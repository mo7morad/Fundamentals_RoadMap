using System;
using System.Collections.Generic;

public class HeapSortVisualizer
{
    // Utility: Print the array
    static void PrintArray(int[] arr)
    {
        foreach (var val in arr)
            Console.Write(val + "\t");
        Console.WriteLine("\n");
    }

    // Swap two elements
    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    // Heapify function with direction flag
    static void Heapify(int[] arr, int heapSize, int rootIndex, bool ascending = true)
    {
        int extreme = rootIndex;
        int lChild = 2 * rootIndex + 1;
        int rChild = 2 * rootIndex + 2;

        if (ascending)
        {
            // Build Max-Heap for ascending sort
            if (lChild < heapSize && arr[lChild] > arr[extreme])
                extreme = lChild;
            if (rChild < heapSize && arr[rChild] > arr[extreme])
                extreme = rChild;
        }
        else
        {
            // Build Min-Heap for descending sort
            if (lChild < heapSize && arr[lChild] < arr[extreme])
                extreme = lChild;
            if (rChild < heapSize && arr[rChild] < arr[extreme])
                extreme = rChild;
        }

        if (extreme != rootIndex)
        {
            Swap(arr, rootIndex, extreme);
            Heapify(arr, heapSize, extreme, ascending);
        }
    }

    // Heap Sort Function
    static void HeapSort(int[] arr, bool ascending = true)
    {
        int arrayLength = arr.Length;

        // Build initial heap
        for (int i = arrayLength / 2 - 1; i >= 0; i--)
            Heapify(arr, arrayLength, i, ascending);

        // Extract elements from heap
        for (int i = arrayLength - 1; i >= 0; i--)
        {
            Swap(arr, 0, i);
            Heapify(arr, i, 0, ascending);
        }
    }

    // Visualize heap as tree levels
    static void PrintHeapAsTree(int[] arr)
    {
        Console.WriteLine("Heap visualization (level by level):");
        int level = 0;
        int itemsInLevel = 1;
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + "\t");
            count++;
            if (count == itemsInLevel)
            {
                Console.WriteLine();
                level++;
                itemsInLevel *= 2;
                count = 0;
            }
        }
        Console.WriteLine();
    }

    // Main function
    //static void Main()
    //{
    //    int[] arr = { 12, 11, 13, 5, 6, 7, 3, 9, 10 };
    //    Console.WriteLine("Original array:");
    //    PrintArray(arr);

    //    Console.WriteLine("Visualizing heap before sorting:");
    //    PrintHeapAsTree(arr);

    //    // Ascending sort
    //    Console.WriteLine("Sorting in ascending order...");
    //    HeapSort(arr, ascending: true);
    //    PrintArray(arr);

    //    // Descending sort
    //    Console.WriteLine("Sorting in descending order...");
    //    int[] arr2 = { 12, 11, 13, 5, 6, 7, 3, 9, 10 };
    //    HeapSort(arr2, ascending: false);
    //    PrintArray(arr2);

    //    Console.WriteLine("Visualization complete ✅");
    //}
}
