using System;

public class Person
{
    // Virtual method to pay salary
    public virtual void PaySalary()
    {
        Console.WriteLine("Paying salary to a person...");
    }

    // Virtual method to send an email
    public virtual void SendEmail()
    {
        Console.WriteLine("Sending email to a person...");
    }


}

public class Employee : Person
{
    // Override PaySalary for employees
    public override void PaySalary()
    {
        Console.WriteLine("Paying salary to an employee...");
    }

    // Override SendEmail for employees
    public override void SendEmail()
    {
        Console.WriteLine("Sending email to an employee...");
    }
}

public class Manager : Employee
{
    // Override PaySalary for managers
    public override void PaySalary()
    {
        Console.WriteLine("Paying salary to a manager...");
    }

    // Override SendEmail for managers
    public override void SendEmail()
    {
        Console.WriteLine("Sending email to a manager...");
    }
}

public class Student : Person
{
    // LSP violation remains for PaySalary, students don't receive a salary
    public override void PaySalary()
    {
        throw new InvalidOperationException("Students don't receive a salary.");
    }

    // Override SendEmail for students
    public override void SendEmail()
    {
        Console.WriteLine("Sending email to a student...");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Person person1 = new Employee();
        person1.PaySalary();   // Calls PaySalary method for Employee
        person1.SendEmail();   // Calls SendEmail method for Employee

        Person person2 = new Manager();
        person2.PaySalary();   // Calls PaySalary method for Manager
        person2.SendEmail();   // Calls SendEmail method for Manager

        Person person3 = new Student();
        person3.SendEmail();   // Calls SendEmail method for Student

        // Violates LSP: Throws exception because PaySalary isn't valid for a student
        person3.PaySalary();

        Console.ReadKey();
    }
}
