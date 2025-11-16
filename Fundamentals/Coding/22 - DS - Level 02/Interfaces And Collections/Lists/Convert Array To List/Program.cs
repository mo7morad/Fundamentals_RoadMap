using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Array initialization
        int[] numbersArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Converting the array to a list
        List<int> numbersList = new List<int>(numbersArray);

        // Displaying the list elements
        Console.WriteLine("List elements: " + string.Join(", ", numbersList));

        // Waiting for a key press
        Console.ReadKey();
    }
}
