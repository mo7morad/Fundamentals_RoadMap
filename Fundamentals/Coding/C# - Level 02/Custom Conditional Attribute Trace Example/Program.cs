#define koko
#define Abas

using System;
using System.Diagnostics;

public class TraceExample
{
    [Conditional("koko")]
    public static void LogTrace(string message)
    {
        Console.WriteLine($"[TRACE] {message}");
    }

    [Conditional("Abas")]
    public static void LogTrace2(string message)
    {
        Console.WriteLine($"[TRACE2] {message}");
    }

    public static void Main()
    {
        LogTrace("This trace message will only be included if koko symbol is defined.");
        LogTrace2("This trace2 message will only be included if Abass symbol is defined.");

        Console.WriteLine("Rest of the program.");

        Console.ReadLine();
    }
}
