using System;
using System.Threading;
using System.Threading.Tasks;

class RunMultipleTasks
{
    static async Task Main(string[] args)
    {
        // Define long-running tasks
        Task task1 = Task.Run(() => DownloadFile("Download File 1"));

        Task task2 = Task.Run(() => DownloadFile("Dowload File 2"));
            
        // Wait for both tasks to finish
        await Task.WhenAll(task1, task2);

        // Display execution time for each task
        Console.WriteLine($"Task 1 and 2 completed");
        Console.ReadKey();  

    }

    static void DownloadFile(string TaskName)
    {
        Console.WriteLine($"{TaskName}: Started!");
        Thread.Sleep(5000); // Simulate long-running operation
        Console.WriteLine($"{TaskName}: Completed!");
    }
}
