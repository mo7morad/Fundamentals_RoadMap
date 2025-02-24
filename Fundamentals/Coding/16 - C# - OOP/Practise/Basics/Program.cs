using System;

namespace ConsoleApp1
{

    class clsPerson
    {

        //Fileds
        public string FirstName;
        public string LastName;

        //Method
        public string FullName()
        {
            return FirstName + ' ' + LastName;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Create object from class
            clsPerson Person1= new clsPerson();

            Console.WriteLine("Accessing Object 1 (Person1):");
            Person1.FirstName = "Mohammed";
            Person1.LastName = "Abu-Hadhoud";
            Console.WriteLine(Person1.FullName());

            //Create another object from class
            clsPerson Person2 = new clsPerson();
            Console.WriteLine("\nAccessing Object 2 (Person2):");
            Person2.FirstName = "Ali";
            Person2.LastName = "Maher";
            Console.WriteLine(Person2.FullName());
            

        }
    }
}
