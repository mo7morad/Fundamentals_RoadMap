using System;
using System.Runtime.InteropServices;

class Program
{
    // Define the SYSTEM_POWER_STATUS structure with fields as per the Windows API documentation
    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_POWER_STATUS
    {
        public byte ACLineStatus;
        public byte BatteryFlag;
        public byte BatteryLifePercent;
        public byte Reserved1;
        public int BatteryLifeTime;
        public int BatteryFullLifeTime;
    }

    // Import the GetSystemPowerStatus API from kernel32.dll
    [DllImport("kernel32.dll", SetLastError = true)]
    static extern bool GetSystemPowerStatus(out SYSTEM_POWER_STATUS sps);

    static void Main()
    {
        if (GetSystemPowerStatus(out SYSTEM_POWER_STATUS status))
        {
            Console.WriteLine("Battery Information:");
            Console.WriteLine("AC Line Status: " + (status.ACLineStatus == 0 ? "Offline" : "Online"));
            Console.WriteLine("Battery Charge Status: " + GetBatteryStatus(status.BatteryFlag));
            Console.WriteLine("Battery Life Percent: " + (status.BatteryLifePercent == 255 ? "Unknown" : status.BatteryLifePercent + "%"));
            Console.WriteLine("Battery Life Remaining: " + (status.BatteryLifeTime == -1 ? "Unknown" : status.BatteryLifeTime + " seconds"));
            Console.WriteLine("Full Battery Lifetime: " + (status.BatteryFullLifeTime == -1 ? "Unknown" : status.BatteryFullLifeTime + " seconds"));
        }
        else
        {
            Console.WriteLine("Unable to get battery status.");
        }

        Console.ReadKey();

    }

    // Helper method to decode the BatteryFlag
    static string GetBatteryStatus(byte flag)
    {
        switch (flag)
        {
            case 1:
                return "High, more than 66% charged";
            case 2:
                return "Low, less than 33% charged";
            case 4:
                return "Critical, less than 5% charged";
            case 8:
                return "Charging";
            case 128:
                return "No battery";
            case 255:
                return "Unknown status";
            default:
                return "Battery status not detected";
        }
    }
}
