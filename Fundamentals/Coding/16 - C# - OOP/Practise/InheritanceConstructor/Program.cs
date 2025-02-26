using System;

public  class clsPerson
{

    public clsPerson(int ID, string FirstName, string LastName, string Title)
    {
        this.ID = ID;
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Title = Title;
    }

    //properties
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }

    //read only property
    public string FullName
    {
        //Get is use for Reading field
        get
        {
            return FirstName + ' ' + LastName;
        }
    }

}

public class clsEmployee : clsPerson
    {

    public clsEmployee (int ID, string FirstName, string LastName, string Title,
                float Salary,string DepartmentName) : base(ID,FirstName,LastName,Title) 

    {
        this.Salary= Salary;
        this.DepartmentName = DepartmentName;

    }

    public float Salary { get; set; }
    public string DepartmentName { get; set; }


    public void IncreaseSalaryBy(float Amount)
    {
        Salary += Amount;
    }

}
    internal class Program
    {
        static void Main(string[] args)
        {
       
        //Create an object of Empoyee
        clsEmployee Employee1 = new clsEmployee(10,"Mohammed","Abu-Hadhoud","Mr",5000, "IT");
        
        Console.WriteLine("Accessing Object 1 (Employee1):\n");
        Console.WriteLine("ID := {0}", Employee1.ID);
        Console.WriteLine("Title := {0}", Employee1.Title);
        Console.WriteLine("Full Name := {0}" , Employee1.FullName);
        Console.WriteLine("Department Name := {0}", Employee1.DepartmentName);
        Console.WriteLine("Salary := {0}", Employee1.Salary);

        Employee1.IncreaseSalaryBy(100);
        Console.WriteLine("Salary after increase := {0}", Employee1.Salary);

            // Upcasting
        Employee employee = new Employee { Name = "John", Age = 30, Company = "Acme Inc.", Salary = 50000 };
        Person person = employee;
        person.Greet(); // Output: "Hi, my name is John and I am 30 years old."

        // Downcasting
        Person person2 = new Employee { Name = "Jane", Age = 25, Company = "XYZ Corp.", Salary = 60000 };
        Employee employee2 = (Employee)person2;
        employee2.Work(); // Output: "I work at XYZ Corp. and earn $60,000.00 per year."

        // Invalid downcasting - throws InvalidCastException at runtime
      //  Person person3 = new Person { Name = "Bob", Age = 40 };
       // Employee employee3 = (Employee)person3; // Runtime exception: InvalidCastException

    }
    }

