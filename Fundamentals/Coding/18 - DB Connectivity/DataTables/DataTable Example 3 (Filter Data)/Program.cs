using System;
using System.Data;
using System.Linq;

public class Example
{
    public static void Main()
    {
        DataTable EmployeesDataTable = new DataTable();
        EmployeesDataTable.Columns.Add("ID", typeof(int));
        EmployeesDataTable.Columns.Add("Name", typeof(string));
        EmployeesDataTable.Columns.Add("Country", typeof(string));
        EmployeesDataTable.Columns.Add("Salary", typeof(Double));
        EmployeesDataTable.Columns.Add("Date", typeof(DateTime));

        //Add rows 
        EmployeesDataTable.Rows.Add(1, "Mohammed Abu-Hadhoud", "Jordan",5000, DateTime.Now);
        EmployeesDataTable.Rows.Add(2, "Ali Maher", "KSA",525.5, DateTime.Now);
        EmployeesDataTable.Rows.Add(3, "Lina Kamal", "Jordan",730.5, DateTime.Now);
        EmployeesDataTable.Rows.Add(4, "Fadi JAmeel", "Egypt",800, DateTime.Now);
        EmployeesDataTable.Rows.Add(5, "Omar Mahmoud", "Lebanon",7000, DateTime.Now);

        int EmployeesCount = 0;
        double TotalSalaries = 0;
        double AverageSalaries = 0;
        double MinSalary = 0;
        double MaxSalary = 0;


        EmployeesCount = EmployeesDataTable.Rows.Count; 
        TotalSalaries = Convert.ToDouble(EmployeesDataTable.Compute("SUM(Salary)", string.Empty ));
        AverageSalaries = Convert.ToDouble(EmployeesDataTable.Compute("AVG(Salary)", string.Empty));
        MinSalary = Convert.ToDouble(EmployeesDataTable.Compute("Min(Salary)", string.Empty));
        MaxSalary = Convert.ToDouble(EmployeesDataTable.Compute("Max(Salary)", string.Empty));

        Console.WriteLine("\nEmployees List:\n");
    
        foreach (DataRow RecordRow in EmployeesDataTable.Rows)
        {    
            //Using Index
             // Console.WriteLine("ID: {0}\t Name : {1} \t Name: {2} \t Salary: {3} Date: {4} \t ", RecordRow[0], RecordRow[1], RecordRow[2], RecordRow[3], RecordRow[4]);
            //Using Field Name
            Console.WriteLine(" ID: {0}\t Name : {1} \t Name: {2} \t Salary: {3} Date: {4} \t ", RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);
        }

        Console.WriteLine("\nCount of Employees = " + EmployeesCount);
        Console.WriteLine("Total Employee Salaries = " + TotalSalaries);
        Console.WriteLine("Average Employee Salaries = " + AverageSalaries);
        Console.WriteLine("Minimum Salary = " + MinSalary);
        Console.WriteLine("Maximum Salary = " + MaxSalary);


        //Filter By Country Jordan
        int ResultCount = 0;
        DataRow[] ResultRows;

        //filter only Jodran Users.
        ResultRows = EmployeesDataTable.Select("Country='Jordan'");
      
        Console.WriteLine("\n\nFilter \"Jordan\" Employees\n");
        foreach (DataRow RecordRow in ResultRows)
        {
            //Using Index
            // Console.WriteLine("ID: {0}\t Name : {1} \t Country: {2} \t Salary: {3} Date: {4} \t ", RecordRow[0], RecordRow[1], RecordRow[2], RecordRow[3], RecordRow[4]);
            //Using Field Name
            Console.WriteLine(" ID: {0}\t Name : {1} \t Country: {2} \t Salary: {3} Date: {4} \t ", RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);
        }

        ResultCount = ResultRows.Count();
        TotalSalaries = Convert.ToDouble(EmployeesDataTable.Compute("SUM(Salary)", "Country='Jordan'"));
        AverageSalaries = Convert.ToDouble(EmployeesDataTable.Compute("AVG(Salary)", "Country='Jordan'"));
        MinSalary = Convert.ToDouble(EmployeesDataTable.Compute("Min(Salary)", "Country='Jordan'"));
        MaxSalary = Convert.ToDouble(EmployeesDataTable.Compute("Max(Salary)", "Country='Jordan'"));

        Console.WriteLine("\nCount of Employees = " + ResultCount);
        Console.WriteLine("Total Employee Salaries = " + TotalSalaries);
        Console.WriteLine("Average Employee Salaries = " + AverageSalaries);
        Console.WriteLine("Minimum Salary = " + MinSalary);
        Console.WriteLine("Maximum Salary = " + MaxSalary);

        //-----------------------------------------
        //Filter By Country "Jordan or Egypt"
        ResultRows = EmployeesDataTable.Select("Country='Jordan' or Country='Egypt'");
       
        Console.WriteLine("\n\n\"Filter Jordan or Egypt\" Employees\n");

        foreach (DataRow RecordRow in ResultRows)
        {
            //Using Index
            // Console.WriteLine("ID: {0}\t Name : {1} \t Country: {2} \t Salary: {3} Date: {4} \t ", RecordRow[0], RecordRow[1], RecordRow[2], RecordRow[3], RecordRow[4]);

            //Using Field Name
            Console.WriteLine(" ID: {0}\t Name : {1} \t Country: {2} \t Salary: {3} Date: {4} \t ", RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);

        }

        ResultCount = ResultRows.Count();
        TotalSalaries = Convert.ToDouble(EmployeesDataTable.Compute("SUM(Salary)", "Country='Jordan' or Country='Egypt'"));
        AverageSalaries = Convert.ToDouble(EmployeesDataTable.Compute("AVG(Salary)", "Country='Jordan' or Country='Egypt'"));
        MinSalary = Convert.ToDouble(EmployeesDataTable.Compute("Min(Salary)", "Country='Jordan' or Country='Egypt'"));
        MaxSalary = Convert.ToDouble(EmployeesDataTable.Compute("Max(Salary)", "Country='Jordan' or Country='Egypt'"));

        Console.WriteLine("\nCount of Employees = " + ResultCount);
        Console.WriteLine("Total Employee Salaries = " + TotalSalaries);
        Console.WriteLine("Average Employee Salaries = " + AverageSalaries);
        Console.WriteLine("Minimum Salary = " + MinSalary);
        Console.WriteLine("Maximum Salary = " + MaxSalary);

        //-----------------------------------------
        //Filter By ID "1"
        ResultRows = EmployeesDataTable.Select("ID=1");

        Console.WriteLine("\n\nFilter Employee With ID = 1\n");

        foreach (DataRow RecordRow in ResultRows)
        {
            //Using Index
            // Console.WriteLine("ID: {0}\t Name : {1} \t Country: {2} \t Salary: {3} Date: {4} \t ", RecordRow[0], RecordRow[1], RecordRow[2], RecordRow[3], RecordRow[4]);

            //Using Field Name
            Console.WriteLine(" ID: {0}\t Name : {1} \t Country: {2} \t Salary: {3} Date: {4} \t ", RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);

        }

        ResultCount = ResultRows.Count();
        TotalSalaries = Convert.ToDouble(EmployeesDataTable.Compute("SUM(Salary)", "ID=1"));
        AverageSalaries = Convert.ToDouble(EmployeesDataTable.Compute("AVG(Salary)", "ID=1"));
        MinSalary = Convert.ToDouble(EmployeesDataTable.Compute("Min(Salary)", "ID=1"));
        MaxSalary = Convert.ToDouble(EmployeesDataTable.Compute("Max(Salary)", "ID=1"));

        Console.WriteLine("\nCount of Employees = " + ResultCount);
        Console.WriteLine("Total Employee Salaries = " + TotalSalaries);
        Console.WriteLine("Average Employee Salaries = " + AverageSalaries);
        Console.WriteLine("Minimum Salary = " + MinSalary);
        Console.WriteLine("Maximum Salary = " + MaxSalary);

        Console.ReadKey();

    }
}