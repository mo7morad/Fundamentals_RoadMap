using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        // Create a SortedSet of integers
        SortedSet<int> sortedSet = new SortedSet<int>();


        // Add elements to the SortedSet
        sortedSet.Add(5);
        sortedSet.Add(2);
        sortedSet.Add(8);
        sortedSet.Add(3);


        // Display the elements of the SortedSet
        Console.WriteLine("SortedSet elements:");
        foreach (int element in sortedSet)
        {
            Console.WriteLine(element);
        }


        // Check if an element exists in the SortedSet
        int target = 3;
        if (sortedSet.Contains(target))
        {
            Console.WriteLine($"\nNumber {target} exists in the SortedSet.");
        }


        // Remove an element from the SortedSet
        sortedSet.Remove(2);


        // Display the elements of the SortedSet after removal
        Console.WriteLine("\nSortedSet elements after removal:");
        foreach (int element in sortedSet)
        {
            Console.WriteLine(element);
        }
        Console.ReadKey();
    }
}