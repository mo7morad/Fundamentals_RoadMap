using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        SortedSet<int> set1 = new SortedSet<int>() { 1, 2, 3, 4, 5 };
        SortedSet<int> set2 = new SortedSet<int>() { 3, 4, 5, 6, 7 };

        // Union
        SortedSet<int> unionSet = new SortedSet<int>(set1);
        unionSet.UnionWith(set2);
        Console.WriteLine("\nUnion:");
        foreach (int item in unionSet)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // Intersection
        SortedSet<int> intersectSet = new SortedSet<int>(set1);
        intersectSet.IntersectWith(set2);
        Console.WriteLine("\nIntersection:");
        foreach (int item in intersectSet)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // Difference
        SortedSet<int> differenceSet = new SortedSet<int>(set1);
        differenceSet.ExceptWith(set2);
        Console.WriteLine("\nDifference (set1 - set2):");
        foreach (int item in differenceSet)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // Subset and Superset
        Console.WriteLine("\nSubset:");
        if (set1.IsSubsetOf(set2))
            Console.WriteLine("Set1 is a subset of Set2");
        else
            Console.WriteLine("Set1 is not a subset of Set2");

        Console.WriteLine("\nSuperset:");
        if (set1.IsSupersetOf(set2))
            Console.WriteLine("Set1 is a superset of Set2");
        else
            Console.WriteLine("Set1 is not a superset of Set2");

        Console.ReadKey();
    }
}
