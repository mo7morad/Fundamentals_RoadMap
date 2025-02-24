using System;

class clsEmployee
{


    //ID Property 
    public int ID
    {
        get;
        set;   
    }

    //Name Property Declaration
    public string Name
    {
        get;
        set;
    }

    static void Main(string[] args)
    {

        //Create an object of Employee class.

        clsEmployee Employee1 = new clsEmployee();
       
        Employee1.ID = 7;
        Employee1.Name = "Mohammed Abu-Hadhoud";

        Console.WriteLine("Employee Id:={0}", Employee1.ID);
        Console.WriteLine("Employee Name:={0}", Employee1.Name);
        Console.ReadLine();


    }

}
