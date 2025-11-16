using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var sortedList = new SortedList<string, int>();

        // Adding elements
      
        sortedList.Add("banana", 2);
        sortedList.Add("Orange", 3);
        sortedList.Add("apple", 3);


        // Accessing elements
        Console.WriteLine("\nQuantity of apples: " + sortedList["apple"]);

        Console.WriteLine("\nIterating SortedList Elements:");
        // Iterating through elements
        foreach (var item in sortedList)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }

        // Removing an element
        sortedList.Remove("apple");


        Console.WriteLine("\nSortedList Elements removing apple:");

        foreach (var item in sortedList)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }

        Console.ReadKey();
    }
}
