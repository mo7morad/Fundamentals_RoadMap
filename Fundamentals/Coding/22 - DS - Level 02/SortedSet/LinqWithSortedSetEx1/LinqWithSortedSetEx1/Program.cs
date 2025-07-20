using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        SortedSet<int> sortedSet = new SortedSet<int>() { 1, 2, 3, 4, 5 };


        // Filtering elements greater than 2
        var filteredSet = sortedSet.Where(x => x > 2);
        Console.WriteLine("Filtered Set:");
        foreach (var item in filteredSet)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();


        // Sum of all elements
        var sum = sortedSet.Sum();
        Console.WriteLine("Sum of all elements: " + sum);


        // Maximum and minimum elements
        var maxElement = sortedSet.Max();
        var minElement = sortedSet.Min();
        Console.WriteLine("Maximum element: " + maxElement);
        Console.WriteLine("Minimum element: " + minElement);


        // Sorting the set in descending order
        var descendingSet = sortedSet.OrderByDescending(x => x);
        Console.WriteLine("Descending Sorted Set:");
        foreach (var item in descendingSet)
        {
            Console.Write(item + " ");
        }
        Console.ReadKey();
    }
}