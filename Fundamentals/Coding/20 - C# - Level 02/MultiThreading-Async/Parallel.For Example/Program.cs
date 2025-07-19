using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // Define the number of iterations
        int numberOfIterations = 10;

        // Use Parallel.For to execute the loop in parallel
        Parallel.For(0, numberOfIterations, i =>
        {
            Console.WriteLine($"Executing iteration {i} on thread {Task.CurrentId}");
            // Simulate some work
            Task.Delay(1000).Wait();
        });

        Console.WriteLine("All iterations completed.");
        Console.ReadKey();

    }
}
