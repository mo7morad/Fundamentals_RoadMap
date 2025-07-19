using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>
        {
            new Person("Alice", 30),
            new Person("Bob", 25),
            new Person("Charlie", 35),
            new Person("David", 40),
            new Person("Eve", 29),
            new Person("Frank", 31),
            new Person("Grace", 24),
            new Person("Helen", 27)
        };



        // Iterating over the list and printing details of each person
        Console.WriteLine("Current state of the people list:");
        foreach (Person person in people)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }


        // Using Find
        Person foundPerson = people.Find(p => p.Name == "David");
        if (foundPerson != null)
        {
            Console.WriteLine($"\nFound Person: Name: {foundPerson.Name}, Age: {foundPerson.Age}");
        }

        // Finding and updating the age of a person named "Alice"
        Person searchResult = people.FirstOrDefault(p => p.Name == "Alice");
        if (searchResult != null)
        {
            searchResult.Age = 31;
            Console.WriteLine($"Updated Alice's age to {searchResult.Age}");
        }

        // Using FindAll
        List<Person> peopleOver30 = people.FindAll(p => p.Age > 30);
        Console.WriteLine("\nPeople over 30:");
        foreach (var person in peopleOver30)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }

        // Using Any to check by name
        bool containsAlice = people.Any(p => p.Name == "Alice");
        Console.WriteLine($"\nList contains a person named 'Alice': {containsAlice}");

        // Using Exists
        bool existsOver40 = people.Exists(p => p.Age > 40);
        Console.WriteLine($"Exists person over 40: {existsOver40}");


        // Removing people under the age of 30
        people.RemoveAll(p => p.Age < 30);
        Console.WriteLine("\nRemoved people under the age of 30.");

        // Iterating over the list and printing details of each person
        Console.WriteLine("Current state of the people list:");
        foreach (Person person in people)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }

        Console.ReadKey();
    }
}
