using System;
using System.Collections.Generic;

public class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    //Implementing the CompareTo method for Person class
    public int CompareTo(Person other)
    {
        // If other is not a valid object reference, this instance is greater.
        if (other == null) return 1;

        // Use the Age property to determine the order of Person instances.
        return this.Age.CompareTo(other.Age);
    }

    // Constructor for easier initialization
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Override ToString to make output easier to read
    public override string ToString()
    {
        return $"{Name}, {Age} years old";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating a list of Person instances
        List<Person> people = new List<Person>
        {
            new Person("John", 30),
            new Person("Jane", 25),
            new Person("Doe", 28),
        };

        // Sorting the list using IComparable implementation
        people.Sort();

        // Printing the sorted list
        Console.WriteLine("People sorted by age:");
        foreach (Person person in people)
        {
            Console.WriteLine(person.ToString());
        }
        Console.ReadKey();

    }
}