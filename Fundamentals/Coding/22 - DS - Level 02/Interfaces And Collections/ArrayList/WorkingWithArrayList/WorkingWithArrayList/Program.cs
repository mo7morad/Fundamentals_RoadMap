using System;
using System.Collections;


class Program
{
    static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        list.Add(10);
        list.Add(20);
        list.Add(30);


        Console.WriteLine("Elements in ArrayList:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }


        list.Remove(20); // Removing an element

        Console.WriteLine("\nAfter removing an element:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();
    }
}