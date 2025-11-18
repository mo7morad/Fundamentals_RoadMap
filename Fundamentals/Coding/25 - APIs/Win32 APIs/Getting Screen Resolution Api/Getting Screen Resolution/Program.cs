using System;
using System.Runtime.InteropServices;

class Program
{
    // Import GetSystemMetrics from user32.dll
    [DllImport("user32.dll")]
    static extern int GetSystemMetrics(int nIndex);

    static void Main()
    {
        int screenWidth = GetSystemMetrics(0);  // SM_CXSCREEN = 0
        int screenHeight = GetSystemMetrics(1); // SM_CYSCREEN = 1

        Console.WriteLine("Screen Width: {0}, Screen Height: {1}", screenWidth, screenHeight);

        Console.ReadKey();

        }
}
