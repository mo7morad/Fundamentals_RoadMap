
//ProgrammingAdvices.com
//Mohammed Abu-Hadhoud

using System;

namespace Main
    {
        internal class TypeCasting
        {
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
            {
            int myInt = 17;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 17
            Console.WriteLine(myDouble);   // Outputs 17

            Console.WriteLine("----------------------");
            Console.WriteLine("Manual (Explicit) casting");
            Console.WriteLine("----------------------");

            double myDouble2 = 17.58;
            int myInt2 = (int) myDouble2;    // Manual casting: double to int

            Console.WriteLine(myDouble2);   // Outputs 17.58
            Console.WriteLine(myInt2);      // Outputs 17

            Console.WriteLine("----------------------");
            Console.WriteLine("Type Conversion Methods");
            Console.WriteLine("----------------------");

            int myInt3 = 20;
            double myDouble3 = 7.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt3));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt3));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble3));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

            Console.WriteLine("----------------------");
            Console.WriteLine("Enum Conversion");
            Console.WriteLine("----------------------");

            Console.WriteLine(WeekDays.Friday); //output: Friday 
            int day = (int) WeekDays.Friday; // enum to int conversion
            Console.WriteLine(day); //output: 4 

            var wd = (WeekDays) 5; // int to enum conversion
            Console.WriteLine(wd);//output: Saturday 



            }
        }
    }
