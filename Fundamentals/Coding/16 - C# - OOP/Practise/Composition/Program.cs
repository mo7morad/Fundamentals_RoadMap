using System;

    class clsA
    {
        public int x;
        public int y;

        public void Method1()
        {
            Console.WriteLine("Method1 of class A is called");
        }

        public void Method2()
        {
       
            Console.WriteLine("Method2 of class A is called");
            Console.WriteLine("Now i will call method1 of class B...");

            //defining an object of another class inside this class is called composition.
            clsB ObjectB1= new clsB();
            ObjectB1.Method1();
        }

}

class clsB

{ 
    public void Method1()
    {
        Console.WriteLine("Method1 of class B is called");
    }
}


internal class Program
    {
        static void Main(string[] args)
        {
        //Create object from class
        clsA ObjectA1 = new clsA();

        ObjectA1.Method1();
        ObjectA1.Method2();

        Console.ReadKey();

        }
    }
