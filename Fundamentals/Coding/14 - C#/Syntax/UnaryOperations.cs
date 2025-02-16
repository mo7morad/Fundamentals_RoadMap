
//ProgrammingAdvices.com
//Mohammed Abu-Hadhoud

using System;

namespace Main
    {
        internal class UnaryOperations
        {

        static void Main(string[] args)
            {

            int number = 10, result;
            bool flag = true;

            result = +number;
            Console.WriteLine("+number = " + result);

            result = -number;
            Console.WriteLine("-number = " + result);

            result = ++number;
            Console.WriteLine("++number = " + result);

            result = --number;
            Console.WriteLine("--number = " + result);

            Console.WriteLine("!flag = " + (!flag));

            Console.WriteLine((number++));
            Console.WriteLine((number));

            Console.WriteLine((++number));
            Console.WriteLine((number));
            }
        }
    }
