using System;

class BinarySearchExample
{
    // Method to perform binary search
    static int BinarySearch(int[] arr, int x)
    {
        int Start = 0, End = arr.Length - 1;
        int Trials =0;

        while (Start <= End)
        {
            int Middle = Start + (End - Start) / 2;
            Trials++;

            Console.WriteLine("Trial = " + Trials);

            // Check if x is present at mid
            if (arr[Middle] == x)
                return Middle;


            // If x greater, ignore left half
            if (x > arr[Middle] )
                Start = Middle + 1;


            // If x is smaller, ignore right half
            else
                End = Middle - 1;
        }


        // If we reach here, then element was not present
        return -1;
    }



    static void Main(string[] args)
    {
       
        int[] arr = { 22, 25, 37, 41, 45,46, 49, 51,55,58,70,80,82,90,95 }; // Sorted array

        int x = 45; // Element to be searched


        Console.WriteLine("Sorted Array:");
        foreach (var item in arr)
            Console.Write(item + " ");
        Console.WriteLine();


        int result = BinarySearch(arr, x);


        if (result == -1)
            Console.WriteLine("Element not found in the array.");
        else
            Console.WriteLine("Element found at index: " + result);

        Console.ReadKey();
    }
}
