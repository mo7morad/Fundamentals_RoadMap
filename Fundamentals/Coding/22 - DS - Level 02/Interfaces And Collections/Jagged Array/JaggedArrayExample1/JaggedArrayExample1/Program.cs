using System;
class JaggedArrayDemo
{
    static void Main()
    {
        // Declare and initialize the jagged array
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
        jaggedArray[1] = new int[] { 0, 2, 4 };
        jaggedArray[2] = new int[] { 11, 22 };


        // Display the array elements
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}