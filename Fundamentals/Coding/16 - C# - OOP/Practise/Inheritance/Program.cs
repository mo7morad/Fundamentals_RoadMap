using System;

public class clsPerson
{
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
        clsEmployee Employee1 = new clsEmployee();

        Console.WriteLine("Accessing Object 1 (Employee1):\n");

        //the following inherited from base class person
        Employee1.ID = 10;
        Employee1.Title = "Mr.";
        Employee1.FirstName = "Mohammed";
        Employee1.LastName = "Abu-Hadhoud";
       
        //the following are from derived class Employee
        Employee1.DepartmentName = "IT";
        Employee1.Salary = 5000;
       
        Console.WriteLine("ID := {0}", Employee1.ID);
        Console.WriteLine("Title := {0}", Employee1.Title);
        Console.WriteLine("Full Name := {0}" , Employee1.FullName);
        Console.WriteLine("Department Name := {0}", Employee1.DepartmentName);
        Console.WriteLine("Salary := {0}", Employee1.Salary);

        Employee1.IncreaseSalaryBy(100);
        Console.WriteLine("Salary after increase := {0}", Employee1.Salary);

        

    }
    }

