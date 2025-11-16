using System;

class AdvancedJaggedArrayExample
{
    static void Main()
    {
        // Initialize the jagged array with 3 rows
        int[][] matrix = new int[3][];

        // Populate each row with arrays of varying sizes
        matrix[0] = new int[] { 1, 2, 3 };
        matrix[1] = new int[] { 4, 5 };
        matrix[2] = new int[] { 6, 7, 8, 9 };

        // Display the matrix
        for (int row = 0; row < matrix.Length; row++)
        {
            Console.Write("Row " + row + ": ");
            for (int col = 0; col < matrix[row].Length; col++)
            {
                Console.Write(matrix[row][col] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}