using System;

public class MyHeapSort
{
    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + "\t");
        Console.WriteLine();
    }

    static void Swap(int[] arr, int first, int second)
    {
        int temp = arr[first];
        arr[first] = arr[second];
        arr[second] = temp;
    }


static void Heapify(int[] arr, int heapSize, int rootIndex)
    {
        int maxIndex = rootIndex;
        int rChild = rootIndex * 2 + 1;
        int lChild = rootIndex * 2 + 2;

        if (rChild < heapSize && arr[rChild] > arr[maxIndex])
            maxIndex = rChild;
        if (lChild < heapSize && arr[lChild] > arr[maxIndex])
            maxIndex = lChild;

        if(rootIndex != maxIndex)
        {
            Swap(arr, rootIndex, maxIndex);
            Heapify(arr, heapSize, maxIndex);
        }
    }

    static void HeapSort(int[] arr)
    {

        // Build max heap
        for (int i = arr.Length / 2 - 1; i >= 0; i--)
            Heapify(arr, arr.Length, i);

        // Extract elements one by one
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Swap(arr, 0, i);
            Heapify(arr, i, 0);
        }
    }

    static void Main()
    {
        int[] arr = { 12, 11, 3, 25, 1, 30, 13, 20, 6, 15, 7, 18, 5, 32, 9 };
        Console.WriteLine("Original array:");
        PrintArray(arr);

        HeapSort(arr);
        Console.WriteLine("Sorted array (descending):");
        PrintArray(arr);
    }
}
