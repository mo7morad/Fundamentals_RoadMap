using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        // Creating and initializing a List of integers
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Displaying the total number of elements in the list
        Console.WriteLine("Number of items in the list: " + numbers.Count);

        // Looping through the list using a for loop
        Console.WriteLine("\nDisplaying list elements using a for loop:");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]); // Accessing each element by its index
        }

        // Looping through the list using a foreach loop
        Console.WriteLine("\nDisplaying list elements using a foreach loop:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number); // Accessing each element directly
        }

        // Looping through the list using the List.ForEach method
        Console.WriteLine("\nDisplaying list elements using List.ForEach:");
        numbers.ForEach(number => Console.WriteLine(number)); // Using a lambda expression

        // Waiting for a key press before closing the console window
        Console.ReadKey();
    }
}
