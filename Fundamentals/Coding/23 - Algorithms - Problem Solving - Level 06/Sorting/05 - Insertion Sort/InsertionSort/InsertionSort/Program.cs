using System;


class InsertionSortExample
{
    static void Main(string[] args)
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };


        Console.WriteLine("Original array:");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();


        InsertionSort(arr);


        Console.WriteLine("\nSorted array:");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.ReadKey();

    }


    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = arr[i];
            int j = i - 1;


            // Move elements of arr[0..i-1], that are greater than key,
            // to one position ahead of their current position
            while (j >= 0 && arr[j] > key)
            {
                arr[i] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }
}



