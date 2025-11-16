using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set3 = new HashSet<int> { 3, 4, 5 };


        Console.WriteLine("set1 equals set2: " + set1.SetEquals(set2));
        Console.WriteLine("set1 equals set3: " + set1.SetEquals(set3));
        Console.ReadKey();


    }
}