using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Initialize a SortedList with integer keys and string values
        SortedList<int, string> sortedList = new SortedList<int, string>()
        {
            { 1, "One" },
            { 3, "Three" },
            { 2, "Two" },
            { 4, "Four" } // Enhanced dataset for comprehensive output
        };


        // Query using Query Expression Syntax
        var queryExpressionSyntax = from kvp in sortedList
                                    where kvp.Key > 1 // Filter keys greater than 1
                                    select kvp;

        Console.WriteLine("Query Expression Syntax Results:");
        foreach (var item in queryExpressionSyntax)
        {
            Console.WriteLine($"{item.Key}: {item.Value}"); // Expected: 2, 3, 4
        }


        // Query using Method Syntax
        var methodSyntax = sortedList.Where(kvp => kvp.Key > 1); // Filter keys greater than 1
        Console.WriteLine("\nMethod Syntax Results:");
        foreach (var item in methodSyntax)
        {
            Console.WriteLine($"{item.Key}: {item.Value}"); // Expected: 2, 3, 4
        }


        // Filter key-value pairs with keys greater than a specific value
        int specificValue = 2;
        var filteredByKey = sortedList.Where(kvp => kvp.Key > specificValue); // Filter keys greater than 2
        Console.WriteLine($"\nEntries with keys greater than {specificValue}:");
        foreach (var item in filteredByKey)
        {
            Console.WriteLine($"{item.Key}: {item.Value}"); // Expected: 3, 4
        }
        Console.ReadKey();

    }
}
