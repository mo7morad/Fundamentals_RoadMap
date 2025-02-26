using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {Name} and I'm {Age} years old.");
    }
}

public class Employee : Person
{
    public int EmployeeId { get; set; }
    public decimal Salary { get; set; }

    public void Work()
    {
        Console.WriteLine($"Employee with ID {EmployeeId} and salary {Salary:C} is working.");
    }
}

public class Doctor : Employee
{
    public string Specialty { get; set; }

    public void Heal()
    {
        Console.WriteLine($"Doctor {Name} with ID {EmployeeId}, salary {Salary:C}, and specialty {Specialty} is healing a patient.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Doctor doctor = new Doctor();
        doctor.Name = "John";
        doctor.Age = 35;
        doctor.EmployeeId = 123;
        doctor.Salary = 100000.00M;
        doctor.Specialty = "Cardiology";
        doctor.Introduce(); // Output: "Hi, my name is John and I'm 35 years old."
        doctor.Work(); // Output: "Employee with ID 123 and salary $100,000.00 is working."
        doctor.Heal(); // Output: "Doctor John with ID 123, salary $100,000.00, and specialty Cardiology is healing a patient."

        Console.ReadKey();
    }
}