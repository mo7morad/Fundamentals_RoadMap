using System;


class MyInsertionSort
{
    static void InsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; ++i)
        {
            int j = i;

            while (j > 0 && arr[j] < arr[j-1])
            {
                (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                
                //Swap(arr, j, j - 1);
                j--;
            }
        }
    }

    public static void Swap(int[] arr, int first, int second)
    {
        int temp = arr[first];
        arr[first] = arr[second];
        arr[second] = temp;
    }

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
}