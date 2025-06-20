using Microsoft.Win32;
using System;

class Program
{
    static void Main()
    {
        // Specify the registry key path and value name
        string keyPath = @"SOFTWARE\YourSoftware";
        string valueName = "YourValueName";

        try
        {
            // Open the registry key in read/write mode with explicit registry view
            using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
            {
                using (RegistryKey key = baseKey.OpenSubKey(keyPath, true))
                {
                    if (key != null)
                    {
                        // Delete the specified value
                        key.DeleteValue(valueName);

                        Console.WriteLine($"Successfully deleted value '{valueName}' from registry key '{keyPath}'");
                    }
                    else
                    {
                        Console.WriteLine($"Registry key '{keyPath}' not found");
                    }
                }
            }
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("UnauthorizedAccessException: Run the program with administrative privileges.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        Console.ReadKey();
    }
}
