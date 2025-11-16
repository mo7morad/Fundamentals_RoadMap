using System;
using System.Linq;


class LINQJaggedArrayExample
{
    static void Main()
    {
        // Declare and initialize a jagged array
        int[][] jaggedArray = {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9, 10 }
        };


        // Flatten the jagged array and sum all elements
        int totalSum = jaggedArray.SelectMany(subArray => subArray).Sum();
        Console.WriteLine("Total Sum: " + totalSum);


        // Find the maximum element in the jagged array
        int maxElement = jaggedArray.SelectMany(subArray => subArray).Max();
        Console.WriteLine("Maximum Element: " + maxElement);


        // Filter arrays having more than 3 elements and select their first element
        var firstElements = jaggedArray.Where(subArray => subArray.Length > 3)
                                       .Select(subArray => subArray.First());
        Console.Write("First Elements of Long Rows: ");
        foreach (var element in firstElements)
        {
            Console.Write(element + " ");
        }
        Console.ReadKey();
    }
}
