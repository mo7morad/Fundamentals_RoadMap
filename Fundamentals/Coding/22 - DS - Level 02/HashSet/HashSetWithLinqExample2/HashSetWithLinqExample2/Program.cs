using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        // Creating and populating a HashSet of strings
        HashSet<string> names = new HashSet<string> 
                        { "Alice", "Bob", "Charlie", "Daisy", "Ethan", "Fiona" };


        // Using LINQ to filter names that start with 'C'
        var namesStartingWithC = names.Where(name => name.StartsWith("C"));


        // Displaying the names starting with 'C'
        Console.WriteLine("Names Starting with C:");
        foreach (var name in namesStartingWithC)
        {
            Console.WriteLine(name);
        }


        // Using LINQ to find names with length greater than 4 characters
        var namesLongerThanFour = names.Where(name => name.Length > 4);


        // Displaying the names longer than four characters
        Console.WriteLine("\nNames Longer Than Four Characters:");
        foreach (var name in namesLongerThanFour)
        {
            Console.WriteLine(name);
        }
        Console.ReadKey();

    }
}