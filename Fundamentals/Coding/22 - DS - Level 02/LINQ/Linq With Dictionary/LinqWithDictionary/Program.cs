using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Creating and initializing the dictionary
        Dictionary<string, int> fruitBasket = new Dictionary<string, int>
        {
            { "Apple", 5 },
            { "Banana", 2 },
            { "Orange", 7 }
        };

        // Using LINQ to transform items
        var fruitInfo = fruitBasket.Select(kpv => new { kpv.Key, kpv.Value });

        // Displaying the results
        Console.WriteLine("Transformed Items:");
        foreach (var item in fruitInfo)
        {
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
        }


        // Using LINQ to filter items
        var filteredFruit = fruitBasket.Where(kpv => kpv.Value > 3);

        Console.WriteLine("\nFiltered Items >3:");
        foreach (var item in filteredFruit)
        {
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
        }



        // Using LINQ to sort by value
        var sortedByQuantity = fruitBasket.OrderBy(kpv => kpv.Value);

        Console.WriteLine("\nSorted Items:");
        foreach (var item in sortedByQuantity)
        {
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
        }

        // Using LINQ to sort by value
        var sortedByQuantityDesc = fruitBasket.OrderByDescending(kpv => kpv.Value);

        Console.WriteLine("\nSorted Items Desc:");
        foreach (var item in sortedByQuantityDesc)
        {
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
        }


        // Using LINQ to aggregate data
        int totalQuantity = fruitBasket.Sum(kpv => kpv.Value);

        Console.WriteLine($"\nTotal Quantity: {totalQuantity}");

        Console.ReadKey();
    }
}
