using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2 };
        HashSet<int> set2 = new HashSet<int> { 1, 2, 3, 4, 5 };


        Console.WriteLine("set1 is a subset of set2: " + set1.IsSubsetOf(set2));
        Console.WriteLine("set2 is a subset of set1: " + set2.IsSubsetOf(set1));

        Console.ReadKey();

    }
}
