using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace WifiScanner
{
    class Program
    {
        static void Main(string[] args)
        {
            var wifiScanner = new WifiScanner();
            var networks = wifiScanner.GetAvailableNetworks();
            foreach (var network in networks)
            {
                Console.WriteLine($"SSID: {network}");
            }
            Console.ReadKey();

        }
    }

    public class WifiScanner
    {
        [DllImport("Wlanapi.dll")]
        private static extern uint WlanOpenHandle(uint dwClientVersion, IntPtr pReserved, out uint pdwNegotiatedVersion, out IntPtr phClientHandle);

        [DllImport("Wlanapi.dll")]
        private static extern uint WlanEnumInterfaces(IntPtr hClientHandle, IntPtr pReserved, out IntPtr ppInterfaceList);

        [DllImport("Wlanapi.dll")]
        private static extern uint WlanCloseHandle(IntPtr hClientHandle, IntPtr pReserved);

        [DllImport("Wlanapi.dll")]
        private static extern uint WlanFreeMemory(IntPtr pMemory);

        private IntPtr clientHandle = IntPtr.Zero;

        public WifiScanner()
        {
            uint negotiatedVersion;
            WlanOpenHandle(2, IntPtr.Zero, out negotiatedVersion, out clientHandle);
        }

        ~WifiScanner()
        {
            WlanCloseHandle(clientHandle, IntPtr.Zero);
        }

        public List<string> GetAvailableNetworks()
        {
            IntPtr interfaceList = IntPtr.Zero;
            WlanEnumInterfaces(clientHandle, IntPtr.Zero, out interfaceList);
            var listHeader = (WlanInterfaceInfoListHeader)Marshal.PtrToStructure(interfaceList, typeof(WlanInterfaceInfoListHeader));
            var wlanInterfaceInfo = new WlanInterfaceInfo[listHeader.dwNumberOfItems];
            List<string> networkList = new List<string>();

            for (int i = 0; i < listHeader.dwNumberOfItems; i++)
            {
                IntPtr interfaceInfoPtr = new IntPtr(interfaceList.ToInt64() + (i * Marshal.SizeOf(typeof(WlanInterfaceInfo))) + Marshal.SizeOf(typeof(int)));
                wlanInterfaceInfo[i] = (WlanInterfaceInfo)Marshal.PtrToStructure(interfaceInfoPtr, typeof(WlanInterfaceInfo));
                networkList.Add(wlanInterfaceInfo[i].strProfileName);
            }

            WlanFreeMemory(interfaceList);
            return networkList;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct WlanInterfaceInfoListHeader
        {
            public uint dwNumberOfItems;
            public uint dwIndex;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        private struct WlanInterfaceInfo
        {
            public Guid InterfaceGuid;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string strProfileName;
        }
    }
}
