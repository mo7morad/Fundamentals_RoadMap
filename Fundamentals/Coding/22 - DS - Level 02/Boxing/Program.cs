using System;


class Program
{
    static void Main()
    {
        int valType = 10;
        object objType = valType; // Boxing: This line demonstrates boxing.
                                  // Boxing is the process of converting a value
                                  //type (in this case, an int) to a reference type
                                  //(in this case, an object).
                                  //Here, valType is boxed to objType.
                                  //During boxing, the value of valType (10)
                                  //is wrapped inside an object instance
                                  //and stored in the heap.

        Console.WriteLine("Value Type: " + valType);
        Console.WriteLine("Object Type: " + objType);
        Console.ReadKey();

    }

    
}