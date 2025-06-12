﻿using System;

public class GenericBox<T>
{
    private T content;

    public GenericBox(T value)
    {
        content = value;
    }

    public T GetContent()
    {
        return content;
    }
}

class Program
{
    static void Main()
    {
        // Usage:
        GenericBox<int> intBox = new GenericBox<int>(42);

        Console.WriteLine("Content of intBox: " + intBox.GetContent()); // Outputs: 42

        GenericBox<string> stringBox = new GenericBox<string>("Hello, World!");
        Console.WriteLine("Content of stringBox: " + stringBox.GetContent()); // Outputs: Hello, World!
   
        Console.ReadKey();

    }
}
