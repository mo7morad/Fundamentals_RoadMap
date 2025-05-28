using System;

class Program
{
    // A delegate that represents an operation
    delegate int Operation(int x, int y);

    // A function that takes a delegate with parameters and invokes it
    static void ExecuteOperation(int x,int y, Operation operation)
    {
        int result = operation(x, y); // Invoke the provided delegate
        Console.WriteLine("Result: " + result);
    }

    
    // now we use fun and lambda Expression 

    static void ExecuteOperation(int x, int y, Func<int, int, int> Operation)
    {
        int result = Operation(x, y); // Invoke the provided delegate
        Console.WriteLine("Result: " + result);
    }

    static void Main()
    {
      

        Console.WriteLine("\n\nUsing Func Delegate and lambda expression");

        // now use the way 2 instead of previous way
        // Use a lambda expression for addition
        Func<int, int, int> Add = (x, y) => x + y;
        Func<int, int, int> Sub= (x, y) => x - y;

        ExecuteOperation(10, 20, Add); // Pass the lambda expression as an argument
        ExecuteOperation(10, 20, Sub); // Pass the lambda expression as an argument

        Console.ReadLine();

    }
}
