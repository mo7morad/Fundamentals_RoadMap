
//ProgrammingAdvices.com
//Mohammed Abu-Hadhoud

using System;

namespace Main
    {
        internal class Program
        {

        static void Main(string[] args)
            {


            //if statement
            Console.WriteLine("if statements");
            Console.WriteLine("----------------------");
            int x=10; int y=20;
            //if then statement
            if (x == 10 && y<=20)
            {
                Console.WriteLine("yes x = 10 and y<=20");
            }



            //if then else statement
            if (x == 11 )
            {
                Console.WriteLine("yes x = 11 ");
            }
            else
            {
                Console.WriteLine("yes x != 11 ");
            }


            //if else if statement
            int number = 12;

            if (number < 5)
            {
                Console.WriteLine("{0} is less than 5", number);
            }
            else if (number > 5)
            {
                Console.WriteLine("{0} is greater than 5", number);
            }
            else
            {
                Console.WriteLine("{0} is equal to 5");
            }

            //switch statement
            Console.WriteLine("----------------------");
            Console.WriteLine("switch statements");
            Console.WriteLine("----------------------");

            char ch;
            Console.WriteLine("Enter a letter?");
            ch = Convert.ToChar(Console.ReadLine());

            switch (Char.ToLower(ch))
            {
                case 'a':
                    Console.WriteLine("Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Not a vowel");
                    break;
            }

            //switch statement with grouped cases

            // char ch;
            // Console.WriteLine("Enter a letter");
            // ch = Convert.ToChar(Console.ReadLine());

            // switch (Char.ToLower(ch))
            // {
            //     case 'a':
            //     case 'e':
            //     case 'i':
            //     case 'o':
            //     case 'u':
            //         Console.WriteLine("Vowel");
            //         break;
            //     default:
            //         Console.WriteLine("Not a vowel");
            //         break;
            // }
            
            //Simple Calculator
            Console.WriteLine("----------------------");
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("----------------------");

            char op;
            double first, second, result;

            Console.Write("Enter first number: ");
            first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            second = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operator (+, -, *, /): ");
            op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    result = first + second;
                    Console.WriteLine("{0} + {1} = {2}", first, second, result);
                    break;

                case '-':
                    result = first - second;
                    Console.WriteLine("{0} - {1} = {2}", first, second, result);
                    break;

                case '*':
                    result = first * second;
                    Console.WriteLine("{0} * {1} = {2}", first, second, result);
                    break;

                case '/':
                    result = first / second;
                    Console.WriteLine("{0} / {1} = {2}", first, second, result);
                    break;

                default:
                    Console.WriteLine("Invalid Operator");
                    break;

            }
        }
    }
}
