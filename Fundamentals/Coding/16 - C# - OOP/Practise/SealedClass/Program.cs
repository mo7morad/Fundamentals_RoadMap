using System;
namespace SealedClass
{
    sealed  class clsA
    {

    }

    // trying to inherit sealed class
    // Error Code
    class clsB : clsA
    {

    }

    class Program
    {
        static void Main(string[] args)
        {

            // create an object of B class
            clsB B1 = new clsB();

            Console.ReadKey();
        }
    }
}