
// File: Program.cs
using System;

class Program
{
    static void Main()
    {
        //the code of Person Class is seperated in 2 files Person1.cs and PersonPrinting.cs
        Person person1 = new Person();
        person1.Age = 25;
        person1.Birthday(); // Output: "Current age: 26"

       
        Console.ReadKey();
        
    }
}