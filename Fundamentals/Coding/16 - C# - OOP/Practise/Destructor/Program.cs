using System;

    class clsPerson
    {

        public clsPerson()
        {
            Console.WriteLine("Constructor called.");
        }

        // destructor
        ~clsPerson()
        {
            Console.WriteLine("Destructor called.");
        }

        public static void Main(string[] args)
        {

            //creates object of Person
            clsPerson p1 = new clsPerson();
            Console.ReadKey();
        }

    }
