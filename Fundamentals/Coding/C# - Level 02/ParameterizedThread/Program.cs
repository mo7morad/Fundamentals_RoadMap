using System;
using System.Threading;
class Program
{
    static void Main()
    {
        //Note that your program is the main thread.

        // Create a new thread and start it
        Thread t = new Thread(() => Method1("Thread1"));
        t.Start();

        Thread t2 = new Thread(() => Method2("Thread2"));
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


    static void Method1(string ThreadName)
    {
        

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"\t{ThreadName} Method1: " + i);
            Thread.Sleep(500);
        }
    }

    static void Method2(string ThreadName)
    {


        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"\t{ThreadName} Method2: " + i);
            Thread.Sleep(500);
        }
    }



}
