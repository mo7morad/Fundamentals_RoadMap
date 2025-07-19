using System;


class Program
{
    static void Main()
    {
        int valType = 10;
        object objType = valType; // Boxing

        int unboxedValType = (int)objType; // Unboxing

        Console.WriteLine("Unboxed Value: " + unboxedValType);

        Console.ReadKey();

    }


}