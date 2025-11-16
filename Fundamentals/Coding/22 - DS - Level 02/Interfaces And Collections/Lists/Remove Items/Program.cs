using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // List initialization
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Removing an item by value
        numbers.Remove(5);
        Console.WriteLine("After removing 5: " + string.Join(", ", numbers));

        // Removing an item by index
        numbers.RemoveAt(0);
        Console.WriteLine("After removing first element: " + string.Join(", ", numbers));

        // Removing multiple items
        numbers.RemoveAll(n => n % 2 == 0);
        Console.WriteLine("After removing all even numbers: " + string.Join(", ", numbers));

        // Clearing the list
        numbers.ForEach(number => Console.WriteLine("Printing Elements using built-in for-each " + number)); // Using a lambda expression


        numbers.Clear();
        Console.WriteLine("After clearing the list, count: " + numbers.Count);

        // Waiting for a key press
        Console.ReadKey();
    }
}
