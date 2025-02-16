
//ProgrammingAdvices.com
//Mohammed Abu-Hadhoud

using System;

namespace Main
    {
        internal class Loops
        {

        static void Main(string[] args)
            {

            Console.WriteLine("\nForward Loop:");
            //forward loop
            for (int i = 1;i <= 10; i++) 
            
            { 
                Console.WriteLine(i);
            }

            Console.WriteLine("\nBackword Loop:");
           //backword loop
            for (int i = 10; i >= 1; i--)

            {
                Console.WriteLine(i);
            }


            Console.WriteLine("\nNested Loops:");
            //forward loop
            for (int i = 1; i <= 10; i++)

            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("i={0} and j={1}",i,j);
                }
            }
            
            //while loop
            Console.WriteLine("\nWhile Loop:");
            int num = 1;
            while (num <= 5)
            {
                Console.WriteLine($"C# while Loop: Iteration {num}");
                num++;
            }
            //do while loop
            Console.WriteLine("\nDo While Loop:");
            int number = 1;
            do
            {
                Console.WriteLine("C# while Loop: Iteration {0}", number);
                number++;
            } while (number <= 5);

            //foreach loop
            Console.WriteLine("\nForeach Loop:");
            int[] age = { 10, 20, 30, 40, 50 };

            foreach (int i in age) 
            { 
              Console.WriteLine(i); 
            }

            
            char[] myArray = { 'H', 'e', 'l', 'l', 'o' };

            foreach (char ch in myArray)
            {
                Console.WriteLine(ch);
            }

            char[] gender = { 'm', 'f', 'm', 'm', 'm', 'f', 'f', 'm', 'm', 'f' };
            int male = 0, female = 0;
            foreach (char g in gender)
            {
                if (g == 'm')
                    male++;
                else if (g == 'f')
                    female++;
            }
            Console.WriteLine("Number of male = {0}", male);
            Console.WriteLine("Number of female = {0}", female);
            }
        }
    }
