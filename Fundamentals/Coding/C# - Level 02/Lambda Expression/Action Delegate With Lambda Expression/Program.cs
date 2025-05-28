using System;

class Program
{
    static void Main()
    {
        // Declare and initialize Action delegates

        Action parameterlessAction = () => 
        {
            Console.WriteLine("This is a parameterless action.");
        };

        Action<int> actionWithIntParameter = (x) => 
        {
            Console.WriteLine($"Action with int parameter: {x}");
        };

        Action<string, int> actionWithMultipleParameters = (str, num) => 
        {
            Console.WriteLine($"Action with string and int parameters: {str}, {num}");
        };

        // Invoking the actions

        parameterlessAction();
        actionWithIntParameter(42);
        actionWithMultipleParameters("Hello, World!", 100);

        Console.ReadKey();

    }
}
