using System;

class MyMergeSort
{
    public static void MergeSort(ref int[] array)
    {
        if (array.Length <= 1)
            return;

        int middle = array.Length / 2;

        // Split array into left and right halves
        int[] left = new int[middle];
        int[] right = new int[array.Length - middle];

        Array.Copy(array, 0, left, 0, middle);
        Array.Copy(array, middle, right, 0, array.Length - middle);

        // Recursively sort both halves
        MergeSort(ref left);
        MergeSort(ref right);

        // Merge the sorted halves
        Merge(ref array, ref left, ref right);
    }

    private static void Merge(ref int[] array, ref int[] left, ref int[] right)
    {
        int i = 0; // left index
        int j = 0; // right index
        int k = 0; // main array index

        // Compare and merge elements
        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                array[k++] = left[i++];
            }
            else
            {
                array[k++] = right[j++];
            }
        }

        // Copy any remaining elements
        while (i < left.Length)
        {
            array[k++] = left[i++];
        }

        while (j < right.Length)
        {
            array[k++] = right[j++];
        }
    }

    static void Main()
    {
        int[] numbers = { 38, 27, 43, 3, 9, 82, 10 };

        Console.WriteLine("Before sorting: " + string.Join(", ", numbers));
        MergeSort(ref numbers);
        Console.WriteLine("After sorting:  " + string.Join(", ", numbers));
    }
}
