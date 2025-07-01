using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class RangeAttribute : Attribute
{
    public int Min { get; }
    public int Max { get; }

    public string ErrorMessage { get; set; }

    public RangeAttribute(int min, int max)
    {
        Min = min;
        Max = max;
    }
}

public class Person
{
    [Range(18, 99, ErrorMessage = "Age must be between 18 and 99.")]
    public int Age { get; set; }

    [Range(20, 30, ErrorMessage = "Experience must be between 20 and 30.")]
    public int Experience  { get; set; }


    public string Name { get; set; }
}

public class ValidationExample
{
    public static void Main()
    {
        Person person = new Person { Age = 125, Name = "Mohammed Abu-Hadhoud",Experience=15 };

        if (ValidatePerson(person))
        {
            Console.WriteLine("Person is valid.");
        }
        else
        {
            Console.WriteLine("Validation failed.");
        }
        Console.ReadKey();

    }

    static bool ValidatePerson(Person person)
    {
        Type type = typeof(Person);
        
        foreach (var property in type.GetProperties())
        {
            // Check for RangeAttribute on properties
            if (Attribute.IsDefined(property, typeof(RangeAttribute)))
            {
                var rangeAttribute = (RangeAttribute)Attribute.GetCustomAttribute(property, typeof(RangeAttribute));
                int value = (int)property.GetValue(person);

                // Perform validation
                if (value < rangeAttribute.Min || value > rangeAttribute.Max)
                {
                    Console.WriteLine($"Validation failed for property '{property.Name}': {rangeAttribute.ErrorMessage}");
                    return false;
                }
            }
        }

        return true;
    }
}
