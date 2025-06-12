//#define DEBUG

using System;
using System.Diagnostics;

public class MyClass
{
    [Conditional("DEBUG")]
    public void DebugMethod()
    {
        Console.WriteLine("Debug method executed.");
    }

    public void NormalMethod()
    {
        Console.WriteLine("Normal method executed.");
    }
}

class Program
{
    static void Main()
    {
        MyClass myClass = new MyClass();

        // Call the methods
        myClass.DebugMethod();  // This will only be executed in DEBUG builds
        myClass.NormalMethod(); // This will always be executed

        Console.ReadLine();
    }
}
