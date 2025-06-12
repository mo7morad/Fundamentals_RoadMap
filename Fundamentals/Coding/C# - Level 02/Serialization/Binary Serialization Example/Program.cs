<<<<<<< HEAD
<<<<<<< HEAD
﻿using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


[Serializable]
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}


class Program
{
    static void Main()
    {
        // Create an instance of the Person class
        Person person = new Person { Name = "Mohammed Abu-Hadhoud", Age = 46 };


        // Binary serialization
        BinaryFormatter formatter = new BinaryFormatter();
        using (FileStream stream = new FileStream("person.bin", FileMode.Create))
        {
            formatter.Serialize(stream, person);
        }


        // Deserialize the object back
        using (FileStream stream = new FileStream("person.bin", FileMode.Open))
        {
            Person deserializedPerson = (Person)formatter.Deserialize(stream);
            Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
            Console.ReadKey();
        }
    }
}
=======
﻿using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


[Serializable]
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}


class Program
{
    static void Main()
    {
        // Create an instance of the Person class
        Person person = new Person { Name = "Mohammed Abu-Hadhoud", Age = 46 };


        // Binary serialization
        BinaryFormatter formatter = new BinaryFormatter();
        using (FileStream stream = new FileStream("person.bin", FileMode.Create))
        {
            formatter.Serialize(stream, person);
        }


        // Deserialize the object back
        using (FileStream stream = new FileStream("person.bin", FileMode.Open))
        {
            Person deserializedPerson = (Person)formatter.Deserialize(stream);
            Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
            Console.ReadKey();
        }
    }
}
>>>>>>> d9393c5e0564d28d3f69e74801c6f938d0dbce0e
=======
﻿using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


[Serializable]
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}


class Program
{
    static void Main()
    {
        // Create an instance of the Person class
        Person person = new Person { Name = "Mohammed Abu-Hadhoud", Age = 46 };


        // Binary serialization
        BinaryFormatter formatter = new BinaryFormatter();
        using (FileStream stream = new FileStream("person.bin", FileMode.Create))
        {
            formatter.Serialize(stream, person);
        }


        // Deserialize the object back
        using (FileStream stream = new FileStream("person.bin", FileMode.Open))
        {
            Person deserializedPerson = (Person)formatter.Deserialize(stream);
            Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
            Console.ReadKey();
        }
    }
}
>>>>>>> d9393c5e0564d28d3f69e74801c6f938d0dbce0e
