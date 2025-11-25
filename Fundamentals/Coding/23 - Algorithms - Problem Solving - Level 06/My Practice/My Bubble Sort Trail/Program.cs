using System;

namespace Bubble_Sort_Trail
{

    internal class Program
    {
        public static bool BubbleSortAscending(ref int[] arr)
        {
            bool swapped = true;

            do
            {
                swapped = false;

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    ref int current = ref arr[i];
                    ref int next = ref arr[i + 1];

                    if (current > next)
                    {
                        (current, next) = (next, current);
                        swapped = true;
                    }
                }
            } while (swapped);
            return true;
        }


        static void Main()
        {
            int[] numbers = { 2, 8, 5, 3, 9, 4, 1 };

            Console.WriteLine("Before sorting:");
            Console.WriteLine(string.Join("\t", numbers));

            BubbleSortAscending(ref numbers);
            // or: BubbleSortAscendingWhile(ref numbers);

            Console.WriteLine("\nAfter sorting:");
            Console.WriteLine(string.Join("\t", numbers));

            Console.ReadKey();
        }

    }
}
