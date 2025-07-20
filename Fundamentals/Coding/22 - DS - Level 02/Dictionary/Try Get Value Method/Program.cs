using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating and initializing the dictionary
        Dictionary<string, int> fruitBasket = new Dictionary<string, int>
        {
            { "Apple", 5 },
            { "Banana", 2 }
        };

        // Using TryGetValue
        if (fruitBasket.TryGetValue("Apple", out int appleQuantity))
        {
            Console.WriteLine($"Apple quantity: {appleQuantity}");
        }
        else
        {
            Console.WriteLine("Apple not found in the basket.");
        }

        foreach (var item in fruitBasket)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }

        //the following line will make exception error because orange is not there.
        // Console.WriteLine($"Orange quantity: {fruitBasket["Orange"]}");

        // Using TryGetValue
        if (fruitBasket.TryGetValue("Orange", out int OrangeQuantity))
        {
            Console.WriteLine($"Orange quantity: {OrangeQuantity}");
        }
        else
        {
            Console.WriteLine("Orange not found in the basket.");
        }


        Console.ReadKey();
    }
}
