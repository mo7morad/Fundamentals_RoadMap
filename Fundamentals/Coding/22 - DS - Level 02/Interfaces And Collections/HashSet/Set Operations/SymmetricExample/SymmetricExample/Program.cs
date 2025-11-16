using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

        //Retaining elements unique to each set using SymmetricExceptWith.
        // Symmetric difference between set1 and set2
        set1.SymmetricExceptWith(set2);


        Console.WriteLine("Symmetric difference of sets:");
        foreach (int item in set1)
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();
    }
}