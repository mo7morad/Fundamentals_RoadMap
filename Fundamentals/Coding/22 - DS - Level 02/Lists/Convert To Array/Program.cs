using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // List initialization
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Converting the list to an array
        int[] numbersArray = numbers.ToArray();

        // Displaying the array elements
        Console.WriteLine("Array elements: " + string.Join(", ", numbersArray));

        // Waiting for a key press
        Console.ReadKey();
    }
}
