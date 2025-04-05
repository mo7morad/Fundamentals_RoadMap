using System;
using System.Data;
using System.Data.Common;
using System.Linq;

public class Example
{
    public static void Main()
    {
        DataTable EmployeesDataTable = new DataTable();
        //EmployeesDataTable.Columns.Add("ID", typeof(int));
        //EmployeesDataTable.Columns.Add("Name", typeof(string));
        //EmployeesDataTable.Columns.Add("Country", typeof(string));
        //EmployeesDataTable.Columns.Add("Salary", typeof(Double));
        //EmployeesDataTable.Columns.Add("Date", typeof(DateTime));

        DataColumn[5] dtColumn = new DataColumn[5];
        
        dtColumn.DataType = typeof(int);
        dtColumn.ColumnName = "ID";
        dtColumn.AutoIncrement = true;
        dtColumn.AutoIncrementSeed = 1;
        dtColumn.AutoIncrementStep = 1;

        dtColumn.Caption = "Employee ID";
        dtColumn.ReadOnly = true;
        dtColumn.Unique = true;
        EmployeesDataTable.Columns.Add(dtColumn);

        dtColumn = new DataColumn();
        dtColumn.DataType = typeof(string);
        dtColumn.ColumnName = "Name";
        dtColumn.AutoIncrement = false;
        dtColumn.Caption = "Name";
        dtColumn.ReadOnly = false;
        dtColumn.Unique = false;
        EmployeesDataTable.Columns.Add(dtColumn);


        dtColumn = new DataColumn();
        dtColumn.DataType = typeof(string);
        dtColumn.ColumnName = "Country";
        dtColumn.AutoIncrement = false;
        dtColumn.Caption = "Country";
        dtColumn.ReadOnly = false;
        dtColumn.Unique = false;
        EmployeesDataTable.Columns.Add(dtColumn);

        dtColumn = new DataColumn();
        dtColumn.DataType = typeof(Double);
        dtColumn.ColumnName = "Salary";
        dtColumn.AutoIncrement = false;
        dtColumn.Caption = "Salary";
        dtColumn.ReadOnly = false;
        dtColumn.Unique = false;
        EmployeesDataTable.Columns.Add(dtColumn);

        dtColumn = new DataColumn();
        dtColumn.DataType = typeof(DateTime);
        dtColumn.ColumnName = "Date";
        dtColumn.AutoIncrement = false;
        dtColumn.Caption = "Date";
        dtColumn.ReadOnly = false;
        dtColumn.Unique = false;
        EmployeesDataTable.Columns.Add(dtColumn);


        // Make ID column the primary key column.
        DataColumn[] PrimaryKeyColumns = new DataColumn[1];
        PrimaryKeyColumns[0] = EmployeesDataTable.Columns["ID"];
        EmployeesDataTable.PrimaryKey = PrimaryKeyColumns;

        //Add rows 
        EmployeesDataTable.Rows.Add(null, "Mohammed Abu-Hadhoud", "Jordan",5000, DateTime.Now);
        EmployeesDataTable.Rows.Add(null, "Ali Maher", "KSA",525.5, DateTime.Now);
        EmployeesDataTable.Rows.Add(null, "Lina Kamal", "Jordan",730.5, DateTime.Now);
        EmployeesDataTable.Rows.Add(null, "Fadi JAmeel", "Egypt",800, DateTime.Now);
        EmployeesDataTable.Rows.Add(null, "Omar Mahmoud", "Lebanon",7000, DateTime.Now);

       
        Console.WriteLine("\nEmployees List:\n");
    
        foreach (DataRow RecordRow in EmployeesDataTable.Rows)
        {    
           
            //Using Field Name
            Console.WriteLine("ID: {0}\t Name : {1} \t Country: {2} \t Salary: {3} Date: {4} \t ", 
                RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], 
                RecordRow["Date"]);
       
        }

       

        Console.ReadKey();

    }
}