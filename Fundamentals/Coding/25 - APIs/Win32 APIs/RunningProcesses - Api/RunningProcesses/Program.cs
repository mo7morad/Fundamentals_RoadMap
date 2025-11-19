using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

class Program
{
    [DllImport("psapi.dll", SetLastError = true)]
    public static extern bool EnumProcesses([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4)][In][Out] uint[] processIds, uint arraySizeBytes, out uint bytesReturned);

    [DllImport("psapi.dll", SetLastError = true)]
    public static extern bool GetProcessMemoryInfo(IntPtr hProcess, out PROCESS_MEMORY_COUNTERS counters, uint size);

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern IntPtr OpenProcess(uint processAccess, bool bInheritHandle, uint processId);

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern bool CloseHandle(IntPtr hObject);

    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESS_MEMORY_COUNTERS
    {
        public uint cb;
        public uint PageFaultCount;
        public uint PeakWorkingSetSize;
        public uint WorkingSetSize;
        public uint QuotaPeakPagedPoolUsage;
        public uint QuotaPagedPoolUsage;
        public uint QuotaPeakNonPagedPoolUsage;
        public uint QuotaNonPagedPoolUsage;
        public uint PagefileUsage;
        public uint PeakPagefileUsage;
    }

    const int PROCESS_QUERY_INFORMATION = 0x0400;
    const int PROCESS_VM_READ = 0x0010;

    static void Main()
    {
        uint[] processIds = new uint[1024];
        uint bytesReturned;

        if (EnumProcesses(processIds, (uint)processIds.Length * sizeof(uint), out bytesReturned))
        {
            Console.WriteLine("Number of processes: {0}", bytesReturned / sizeof(uint));

            for (int i = 0; i < bytesReturned / sizeof(uint); i++)
            {
                uint pid = processIds[i];
                IntPtr processHandle = OpenProcess(PROCESS_QUERY_INFORMATION | PROCESS_VM_READ, false, pid);

                if (processHandle != IntPtr.Zero)
                {
                    PROCESS_MEMORY_COUNTERS memCounters;
                    if (GetProcessMemoryInfo(processHandle, out memCounters, (uint)Marshal.SizeOf(typeof(PROCESS_MEMORY_COUNTERS))))
                    {
                        string processName = "Unknown";
                        try
                        {
                            Process proc = Process.GetProcessById((int)pid);
                            processName = proc.ProcessName;
                        }
                        catch (Exception)
                        {
                            // Process might have exited or access denied
                        }

                        Console.WriteLine($"Process ID: {pid}, Name: {processName} - Memory Usage: {memCounters.WorkingSetSize / 1024} KB");
                    }

                    CloseHandle(processHandle);
                }
            }
        }
        else
        {
            Console.WriteLine("Failed to enumerate processes.");
        }
        Console.ReadKey();
    }
}
