using System;
using System.Threading.Tasks;

// Custom event arguments class
public class CustomEventArgs : EventArgs
{
    public int Parameter1 { get; }
    public string Parameter2 { get; }

    public CustomEventArgs(int param1, string param2)
    {
        Parameter1 = param1;
        Parameter2 = param2;
    }
}

class Program
{
    // Define a delegate for the callback
    public delegate void CallbackEventHandler(object sender, CustomEventArgs e);

    // Define an event based on the delegate
    public static event CallbackEventHandler CallbackEvent;

    static async Task Main()
    {
        // Subscribe to the event
        CallbackEvent += OnCallbackReceived;

        // Create and run a Task for the asynchronous operation, passing CallbackEvent as a parameter
        Task performTask = PerformAsyncOperation(CallbackEvent);

        // Do some other work while waiting for the task to complete
        Console.WriteLine("Doing some other work...");

        // Wait for the task to complete
        await performTask;

        Console.WriteLine("Done!");
        Console.ReadKey();
    }

    static async Task PerformAsyncOperation(CallbackEventHandler callback)
    {
        // Simulate an asynchronous operation
        await Task.Delay(2000);

        // Create event arguments with two parameters
        CustomEventArgs eventArgs = new CustomEventArgs(42, "Hello from event");

        // Check if the callback event is not null before invoking
        callback?.Invoke(null, eventArgs);
    }

    // Event handler for the CallbackEvent
    static void OnCallbackReceived(object sender, CustomEventArgs e)
    {
        Console.WriteLine($"Event received: Parameter 1 - {e.Parameter1}, Parameter 2 - {e.Parameter2}");
    }
}
