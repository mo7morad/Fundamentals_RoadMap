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

        Console.WriteLine("\nEmployees List:\n");
    
        foreach (DataRow RecordRow in EmployeesDataTable.Rows)
        {    
            //Using Field Name
            Console.WriteLine(" ID: {0}\t Name : {1} \t Country: {2} \t Salary: {3} Date: {4} \t ", RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);
       
        }

        //Delete Employee with ID=4
        Console.WriteLine("\n\nEmployees List After Deleting ID = 4 :\n");
        
        //First You filter for Employee ID=4
        DataRow[] Results = EmployeesDataTable.Select("ID=4"); 
       
        foreach (var RecordRow in Results)
        {
          RecordRow.Delete();
        }
        
        EmployeesDataTable.AcceptChanges();

        foreach (DataRow RecordRow in EmployeesDataTable.Rows)
        {
            //Using Field Name
            Console.WriteLine(" ID: {0}\t Name : {1} \t Country: {2} \t Salary: {3} Date: {4} \t ", RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);
        }

        Console.ReadKey();

    }
}