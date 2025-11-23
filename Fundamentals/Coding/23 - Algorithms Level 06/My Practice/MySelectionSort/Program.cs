using System;

namespace MySelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 9, 4, 6, 2, 7, 1, 5 };

            Console.WriteLine("Before:");
            PrintArray(ref data);

            SelectionSort(ref data);

            Console.WriteLine("\nAfter:");
            PrintArray(ref data);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // MAIN CONTROLLER FUNCTION
        public static void SelectionSort(ref int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = FindMinIndex(ref array, i);
                Swap(ref array, i, minIndex);
            }
        }

        // Find the index of the smallest element starting from i
        private static int FindMinIndex(ref int[] array, int startIndex)
        {
            int minIndex = startIndex;

            for (int j = startIndex + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            return minIndex;
        }

        // Swap two elements by index
        private static void Swap(ref int[] array, int i, int j)
        {
            if (i == j) return;
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        // 🖨️ Print array contents
        public static void PrintArray(ref int[] array)
        {
            foreach (var item in array)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}
