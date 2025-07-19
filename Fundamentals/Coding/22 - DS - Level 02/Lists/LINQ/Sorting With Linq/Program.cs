using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // List initialization
        List<int> numbers = new List<int> { 44, 22, 55, 666, 9, -6, 345, 11, 3, 3 };

        // Default Sorting (Ascending)
        numbers.Sort();
        Console.WriteLine("Sorted in Ascending Order: " + string.Join(", ", numbers));

        // Sorting in Descending Order
        numbers.Reverse();
        Console.WriteLine("Sorted in Descending Order: " + string.Join(", ", numbers));

        // Sorting with LINQ
        Console.WriteLine("Sorted Ascending with LINQ: " + string.Join(", ", numbers.OrderBy(n => n)));
        Console.WriteLine("Sorted Descending with LINQ: " + string.Join(", ", numbers.OrderByDescending(n => n)));

       

        // Waiting for a key press
        Console.ReadKey();
    }
}
