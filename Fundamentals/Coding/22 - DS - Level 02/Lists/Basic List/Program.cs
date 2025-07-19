using System;
using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();
            
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

        
            Console.WriteLine("Number of items in the list: " + numbers.Count);

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);

            Console.WriteLine("Chaning the value of item 2 of the list to 500:");
           
            numbers[1] = 500;
            Console.WriteLine(numbers[1]);

            Console.ReadKey();



        }
    }

