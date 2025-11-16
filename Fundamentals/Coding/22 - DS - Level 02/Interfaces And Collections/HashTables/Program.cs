using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Initialization
        Hashtable myHashtable = new Hashtable();
        myHashtable.Add("key1", "value1");
        myHashtable.Add("key2", "value2");
        myHashtable.Add("key3", "value3");


        // Accessing an element
        Console.WriteLine($"Accessing key1: {myHashtable["key1"]}");

        // Modifying an element
        myHashtable["key1"] = "newValue1";

        // Removing an element
        myHashtable.Remove("key2");

        // Iterating over elements
        Console.WriteLine("\nCurrent Hashtable contents:");
        foreach (DictionaryEntry entry in myHashtable)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
        Console.ReadKey();

    }
}
