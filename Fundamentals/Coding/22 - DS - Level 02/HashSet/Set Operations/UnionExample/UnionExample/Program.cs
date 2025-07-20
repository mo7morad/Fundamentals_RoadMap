using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

        //Combine the elements of two sets using the UnionWith method in HashSet<T>
        // Union of set1 and set2
        set1.UnionWith(set2);


        Console.WriteLine("Union of sets:");
        foreach (int item in set1)
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();
    }
}