using System;
using System.Transactions;


public class LoggingService
{
    private ILogging _Logging;

    public LoggingService(ILogging Logging )
    {
        _Logging = Logging;

    }

    public void Log(string message)
    {
        _Logging.Log(message);  
    }

}

public interface ILogging
{
    public void Log(string message);
    
}

public class FileLoggingService:ILogging
{
    // Method to log to file
    public  void Log(string message)
    {
        Console.WriteLine($"\nLog to file: {message}");
    }
}

public class EventLogService:ILogging
{
    // Method to log to EventLog
    public  void Log(string message)
    {
        Console.WriteLine($"\nLog to Event Log: {message}");
    }
}

public class DatabaseLoggingService:ILogging
{

    // Method to log to file
    public  void Log(string message)
    {
        Console.WriteLine($"\nLog to Database: {message}");
    }
}



public class ExcelLoggingService : ILogging
{

    // Method to log to file
    public void Log(string message)
    {
        Console.WriteLine($"\nLog to Excel: {message}");
    }
}
class Program
{
    static void Main()
    {
        // Create an instance of the LoggingService
        LoggingService LoggingService = new LoggingService( new FileLoggingService() );

        // Log to File
        LoggingService.Log("Error Occured line xxx.");

        LoggingService = new LoggingService(new EventLogService());

        // Log to Event Log
        LoggingService.Log("Error Occured line xxx.");

        LoggingService = new LoggingService(new DatabaseLoggingService());
        // Log to Database
        LoggingService.Log("Error Occured line xxx.");


        LoggingService = new LoggingService(new ExcelLoggingService());
        // Log to Excel
        LoggingService.Log("Error Occured line xxx.");

        Console.ReadKey();

    }
}
