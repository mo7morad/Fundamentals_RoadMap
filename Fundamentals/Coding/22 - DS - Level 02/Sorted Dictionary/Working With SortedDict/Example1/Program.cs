using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a SortedDictionary with string keys and integer values
        SortedDictionary<string, int> sortedDict = new SortedDictionary<string, int>();

        // Adding elements to the SortedDictionary
        sortedDict.Add("apple", 10);
        sortedDict.Add("banana", 20);
        sortedDict.Add("orange", 15);

        // Displaying the contents of the SortedDictionary
        Console.WriteLine("Contents of the SortedDictionary:");
        foreach (var kvp in sortedDict)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        // Accessing values by key
        Console.WriteLine("\nAccessing values by key:");
        Console.WriteLine($"Value of 'apple': {sortedDict["apple"]}");
        Console.WriteLine($"Value of 'orange': {sortedDict["orange"]}");

        // Checking if a key exists
        Console.WriteLine("\nChecking if a key exists:");
        Console.WriteLine($"Contains 'banana': {sortedDict.ContainsKey("banana")}");
        Console.WriteLine($"Contains 'grape': {sortedDict.ContainsKey("grape")}");

        // Removing an element
        sortedDict.Remove("banana");

        // Displaying the contents after removal
        Console.WriteLine("\nContents of the SortedDictionary after removal:");
        foreach (var kvp in sortedDict)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        Console.ReadKey();

    }
}
