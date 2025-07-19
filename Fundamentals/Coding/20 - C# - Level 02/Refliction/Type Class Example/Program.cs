using System;


class Program
{
    static void Main()
    {
        Type myType = typeof(string);

        Console.WriteLine("Type Information:");
        Console.WriteLine($"Name: {myType.Name}");
        Console.WriteLine($"Full Name: {myType.FullName}");
        Console.WriteLine($"Is Class: {myType.IsClass}");

        Console.ReadLine();
    }
}