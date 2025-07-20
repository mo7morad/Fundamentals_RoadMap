using System;
using System.Collections;


class Program
{
    static void Main(string[] args)
    {
        ArrayList list = new ArrayList(); // Creating an ArrayList
        list.Add(10); // Adding elements
        list.Add("Hello");
        list.Add(true);


        Console.WriteLine("Total elements in ArrayList: " + list.Count);


        Console.WriteLine("Content of ArrayList using index:");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine("Index " + i + ": " + list[i]);
        }


        Console.ReadKey();
    }
}