using System;
using MyFirstClassLibrary;

    internal class Program
    {
        static void Main(string[] args)
        {

        
        Console.WriteLine("Hi");
       
        clsMyMath MyMath1= new clsMyMath();
        Console.WriteLine(MyMath1.Sum(10, 20));
        Console.WriteLine(MyMath1.Sum(10, 20,30));

        Console.ReadKey();




    }
    }
