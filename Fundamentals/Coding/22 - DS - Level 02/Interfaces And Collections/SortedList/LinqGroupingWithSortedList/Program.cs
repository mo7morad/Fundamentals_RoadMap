using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Initialize a SortedList of int keys and string values
        SortedList<int, string> sortedList = new SortedList<int, string>()
        {
            { 1, "Apple" },
            { 2, "Banana" },
            { 3, "Cherry" },
            { 4, "Date" },
            { 5, "Grape" },
            { 6, "Fig" },
            { 7, "Elderberry" }
        };

        // Grouping by the length of the value
        Console.WriteLine("Grouping by the length of the value:");
        var groups = sortedList.GroupBy(kvp => kvp.Value.Length);
        foreach (var group in groups)
        {
            Console.WriteLine($"Length {group.Key}: {string.Join(", ", group.Select(kvp => kvp.Value))}");
        }

       

        Console.ReadKey();

    }
}
