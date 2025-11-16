using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };


        // Intersection of set1 and set2
        set1.IntersectWith(set2);


        Console.WriteLine("Intersection of sets:");
        foreach (int item in set1)
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();
    }
}