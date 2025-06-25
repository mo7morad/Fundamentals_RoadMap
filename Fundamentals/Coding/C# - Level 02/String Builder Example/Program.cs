using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main()
    {
        int iterations = 200000;

        // Concatenating strings using +
        Stopwatch stopwatch1 = Stopwatch.StartNew();
        ConcatenateStrings(iterations);
        stopwatch1.Stop();
        decimal x = stopwatch1.ElapsedMilliseconds / 1000;
        Console.WriteLine($"String concatenation using + took: {x} ms");

        // Concatenating strings using StringBuilder
        Stopwatch stopwatch2 = Stopwatch.StartNew();
        ConcatenateStringBuilder(iterations);
        stopwatch2.Stop();
        Console.WriteLine($"String concatenation using StringBuilder took: {stopwatch2.Elapsed} ms");
    
        Console.ReadKey();

    }

    static void ConcatenateStrings(int iterations)
    {
        string result = "";
        for (int i = 0; i < iterations; i++)
        {
            result += "a";
        }
    }

    static void ConcatenateStringBuilder(int iterations)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < iterations; i++)
        {
            sb.Append("a");
            
        }
        string result = sb.ToString();
    }
}
