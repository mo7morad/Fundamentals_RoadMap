using System;
using System.Transactions;

public class LoggingService
{
    public enum enLoggingType { ToFile, ToEventLog, ToDatabase }

    public void Log(string message, enLoggingType LoggingType)
    {

        if (LoggingType == enLoggingType.ToFile)
        {
           FileLoggingService.Log (message);
        }
        else if (LoggingType == enLoggingType.ToEventLog)
        {
            EventLogService.Log  ( message);
        }
        else if (LoggingType == enLoggingType.ToDatabase)
        {
            DatabaseLoggingService.Log ( message);
        }
    }

}

public class FileLoggingService
{
    // Method to log to file
    public static void Log(string message)
    {
        Console.WriteLine($"\nLog to file: {message}");
    }
}

public class EventLogService
{
    // Method to log to EventLog
    public static void Log(string message)
    {
        Console.WriteLine($"\nLog to Event Log: {message}");
    }
}

public class DatabaseLoggingService
{

    // Method to log to file
    public static void Log(string message)
    {
        Console.WriteLine($"\nLog to Database: {message}");
    }
}


class Program
{
    static void Main()
    {
        // Create an instance of the LoggingService
        LoggingService LoggingService = new LoggingService();

        // Log to File
        LoggingService.Log("Error Occured line xxx.", LoggingService.enLoggingType.ToFile);

        // Log to Event Log
        LoggingService.Log("Error Occured line xxx.", LoggingService.enLoggingType.ToEventLog);

        // Log to Database
        LoggingService.Log("Error Occured line xxx.", LoggingService.enLoggingType.ToDatabase);

        Console.ReadKey();

    }
}
