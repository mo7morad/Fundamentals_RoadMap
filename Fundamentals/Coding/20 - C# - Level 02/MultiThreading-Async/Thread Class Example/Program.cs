using System;
using System.Threading;
class Program
{
    static void Main()
    {
        //Note that your program is the main thread.

        // Create a new thread and start it
        Thread t = new Thread(Method1);
        t.Start();

        Thread t2 = new Thread(Method2);
        t2.Start();

     
        t.Join();
        t2.Join();

        // Main thread continues its execution
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine("\tMain: " + i);
            Thread.Sleep(500); // Sleep for 0.5 second
        }
        Console.ReadKey();
    }


    static void Method1()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("\tMethod1: " + i);
            Thread.Sleep(500);
        }
    }

    static void Method2()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("\tMethod2: " + i);
            Thread.Sleep(500);
        }
    }



}
