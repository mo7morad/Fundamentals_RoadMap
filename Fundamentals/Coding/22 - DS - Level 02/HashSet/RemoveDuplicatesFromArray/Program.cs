using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Array with duplicate values
        int[] array = new int[] { 1, 2, 2, 3, 4, 4, 5 };

        // Initializing a HashSet with the array
        HashSet<int> uniqueNumbers = new HashSet<int>(array);

        // Displaying the unique elements
        foreach (int number in uniqueNumbers)
        {
            Console.WriteLine(number);
        }
        Console.ReadKey();

    }
}
