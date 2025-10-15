using System;

public class Person
{
   
    // Virtual method to send an email
    public virtual void SendEmail()
    {
        Console.WriteLine("Sending email to a person...");
    }

}


public class Employee : Person
{
    // Override PaySalary for employees
    public virtual void PaySalary()
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
    

    // Override SendEmail for students
    public override void SendEmail()
    {
        Console.WriteLine("Sending email to a student...");
    }
}

public class User : Person
{
   

    // Override SendEmail for User
    public override void SendEmail()
    {
        Console.WriteLine("Sending email to a User...");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Employee person1 = new Employee();
        person1.PaySalary();   // Calls PaySalary method for Employee
        person1.SendEmail();   // Calls SendEmail method for Employee

        Manager person2 = new Manager();
        person2.PaySalary();   // Calls PaySalary method for Manager
        person2.SendEmail();   // Calls SendEmail method for Manager

        Person person3 = new Student();
        person3.SendEmail();   // Calls SendEmail method for Student

        Person person4 = new User();
        person4.SendEmail();   // Calls SendEmail method for User

     


        Console.ReadKey();
    }
}
