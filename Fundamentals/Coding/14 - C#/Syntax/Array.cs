
//ProgrammingAdvices.com
//Mohammed Abu-Hadhoud

using System;

// provides us various methods to use in an array
using System.Linq;

namespace Main
    {
        internal class Program
        {

        static void Main(string[] args)
            {

            // Note that we used System.Linq above.

            int[] nums = { 51, -1, 2,14,18, 40, 178 };

            // get the minimum element
            Console.WriteLine("Smallest  Element: " + nums.Min());

            // Max() returns the largest number in array
            Console.WriteLine("Largest Element: " + nums.Max());

            int[] numbers = { 20, 22, 19, 18, 1 };


            // compute Count
            Console.WriteLine("Count : " + numbers.Count());

            // compute Sum
            Console.WriteLine("Sum : " + numbers.Sum());

            // compute the average
            Console.WriteLine("Average: " + numbers.Average());

            }
        }
    }
