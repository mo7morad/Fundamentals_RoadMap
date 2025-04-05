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
            Console.WriteLine("ID: {0}\t Name : {1} \t Country: {2} \t Salary: {3} Date: {4} \t ", 
                RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], 
                RecordRow["Date"]);
       
        }


        DataTable DepartmentsDataTable = new DataTable();
        DepartmentsDataTable.Columns.Add("DepartmentID", typeof(int));
        DepartmentsDataTable.Columns.Add("Name", typeof(string));

        //Add rows 
        DepartmentsDataTable.Rows.Add(1, "Marketing");
        DepartmentsDataTable.Rows.Add(2, "IT");
        DepartmentsDataTable.Rows.Add(3, "HR");


        Console.WriteLine("\nDepartments List:\n");

        foreach (DataRow RecordRow in DepartmentsDataTable.Rows)
        {
           
            //Using Field Name
            Console.WriteLine("DepartmentID: {0}\t Name : {1} ",
                RecordRow["DepartmentID"], RecordRow["Name"]);

        }

        //Create Dataset
        DataSet dataSet1 = new DataSet();

        //Adding DataTables into DataSet
        dataSet1.Tables.Add(EmployeesDataTable);
        dataSet1.Tables.Add(DepartmentsDataTable);

        Console.WriteLine("\nPrinting Employees Data form the Dataset\n");
        foreach (DataRow RecordRow in dataSet1.Tables[0].Rows)
        {
            //Using Field Name
            Console.WriteLine("ID: {0}\t Name : {1} \t Country: {2} \t Salary: {3} Date: {4} \t ",
                RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"],
                RecordRow["Date"]);
        }

        Console.WriteLine("\nPrinting Departments Data form the Dataset\n");

        foreach (DataRow RecordRow in dataSet1.Tables[1].Rows)
        {
            //Using Field Name
            Console.WriteLine("DepartmentID: {0}\t Name : {1} ",
                RecordRow["DepartmentID"], RecordRow["Name"]);


        }


        Console.ReadKey();

    }
}