using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        SortedList<int, Employee> employees = new SortedList<int, Employee>()
        {
            { 1, new Employee("Alice", "HR", 50000) },
            { 2, new Employee("Bob", "IT", 70000) },
            { 3, new Employee("Charlie", "HR", 52000) },
            { 4, new Employee("Daisy", "IT", 80000) },
            { 5, new Employee("Ethan", "Marketing", 45000) }
        };

        var query = employees
            .Where(e => e.Value.Department == "IT")
            .OrderByDescending(e => e.Value.Salary)
            .Select(e => e.Value.Name);

        Console.WriteLine("IT Department Employees sorted by Salary (Descending):");
        foreach (var name in query)
        {
            Console.WriteLine(name);
        }
        Console.ReadKey();

    }
}

public class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, string department, decimal salary)
    {
        Name = name;
        Department = department;
        Salary = salary;
    }
}
