using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using System.Security.Principal;

class Program
{
    [DllImport("user32.dll", SetLastError = true)]
    public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

    [DllImport("advapi32.dll", SetLastError = true)]
    public static extern bool OpenProcessToken(IntPtr ProcessHandle, uint DesiredAccess, out IntPtr TokenHandle);

    [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Auto)]
    public static extern bool LookupPrivilegeValue(string lpSystemName, string lpName, out LUID lpLuid);

    [DllImport("advapi32.dll", SetLastError = true)]
    public static extern bool AdjustTokenPrivileges(IntPtr TokenHandle, bool DisableAllPrivileges, ref TOKEN_PRIVILEGES NewState, int BufferLength, IntPtr PreviousState, IntPtr ReturnLength);

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct LUID
    {
        public uint LowPart;
        public int HighPart;
    }

    internal struct TOKEN_PRIVILEGES
    {
        public int PrivilegeCount;
        public LUID Luid;
        public int Attributes;
    }

    const int SE_PRIVILEGE_ENABLED = 0x00000002;
    const int TOKEN_QUERY = 0x00000008;
    const int TOKEN_ADJUST_PRIVILEGES = 0x00000020;
    const uint EWX_LOGOFF = 0x00000000;
    const uint EWX_SHUTDOWN = 0x00000001;
    const uint EWX_REBOOT = 0x00000002;
    const uint EWX_FORCE = 0x00000004;

    static void Main()
    {
        EnableShutdownPrivilege();
        // Shutdown the system
        if (!ExitWindowsEx(EWX_SHUTDOWN | EWX_FORCE, 0))
        {
            Console.WriteLine("Shutdown failed!");
        }
    }

    static void EnableShutdownPrivilege()
    {
        if (!OpenProcessToken(System.Diagnostics.Process.GetCurrentProcess().Handle, TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, out IntPtr tokenHandle))
        {
            Console.WriteLine("Failed to open process token.");
            return;
        }

        if (!LookupPrivilegeValue(null, "SeShutdownPrivilege", out LUID luid))
        {
            Console.WriteLine("Failed to look up privilege value.");
            return;
        }

        TOKEN_PRIVILEGES tp = new TOKEN_PRIVILEGES
        {
            PrivilegeCount = 1,
            Luid = luid,
            Attributes = SE_PRIVILEGE_ENABLED
        };

        if (!AdjustTokenPrivileges(tokenHandle, false, ref tp, 0, IntPtr.Zero, IntPtr.Zero))
        {
            Console.WriteLine("Failed to adjust token privileges.");
            return;
        }
    }
}
