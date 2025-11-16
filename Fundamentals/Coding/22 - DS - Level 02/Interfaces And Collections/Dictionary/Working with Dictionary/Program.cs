using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating the dictionary
        Dictionary<string, int> fruitBasket = new Dictionary<string, int>();

        // Adding elements
        fruitBasket.Add("Apple", 5);
        fruitBasket.Add("Banana", 2);
        //the following commented line will casue an error because they key is repeated.
        //fruitBasket.Add("Banana", 5);
        fruitBasket.Add("Orange", 12);

        // Accessing and updating elements
        fruitBasket["Apple"] = 10;

        Console.WriteLine("\nDictionary Content:");
        // Iterating through the dictionary
        foreach (KeyValuePair<string, int> item in fruitBasket)
        {
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
        }

        // Removing an element
        fruitBasket.Remove("Banana");

        Console.WriteLine("\nDictionary Content after removing Banana:");
        // Iterating through the dictionary after removing Banana
        foreach (KeyValuePair<string, int> item in fruitBasket)
        {
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
        }

        Console.ReadKey();
    }
}
