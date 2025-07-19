using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // List initialization
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // LINQ Filtering
        Console.WriteLine("Even Numbers: " + string.Join(", ", numbers.Where(n => n % 2 == 0)));
        Console.WriteLine("Odd Numbers: " + string.Join(", ", numbers.Where(n => n % 2 != 0)));
        Console.WriteLine("Numbers Greater Than 5: " + string.Join(", ", numbers.Where(n => n > 5)));
        Console.WriteLine("Every Second Number: " + string.Join(", ", numbers.Where((n, index) => index % 2 == 1)));
        Console.WriteLine("Numbers Between 3 and 8: " + string.Join(", ", numbers.Where(n => n > 3 && n < 8)));

        // Waiting for a key press
        Console.ReadKey();
    }
}
