using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // List initialization
        List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry", "fig", "grape", "honeydew" };

        // Using Contains
        Console.WriteLine("List contains 'apple': " + words.Contains("apple"));

        // Using Exists
        Console.WriteLine("List contains a word of length 5: " + words.Exists(word => word.Length == 5));

        // Using Find
        Console.WriteLine("First word longer than 5 characters: " + words.Find(word => word.Length > 5));

        // Using FindAll
        Console.WriteLine("Words longer than 5 characters: " + string.Join(", ", words.FindAll(word => word.Length > 5)));

        // Using Any
        Console.WriteLine("Any words starting with 'a': " + words.Any(word => word.StartsWith("a")));

        // Using Any
        Console.WriteLine("Any words Ends with 'a': " + words.Any(word => word.EndsWith("a")));



        // Waiting for a key press
        Console.ReadKey();
    }
}
