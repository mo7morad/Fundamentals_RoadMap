using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> set2 = new HashSet<int> { 2, 3 };


        Console.WriteLine("set1 is a superset of set2: " + set1.IsSupersetOf(set2));
        Console.ReadKey();
    }
}