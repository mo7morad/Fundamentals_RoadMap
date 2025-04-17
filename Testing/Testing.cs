using BusinessLayer;
using System;
using System.Data;

namespace ConsoleTesting
{
    internal class Testing
    {
        static void Main(string[] args)
        {
            DataTable peopleData = DataAccessLayer.clsPeopleDataAccess.GetAllPeople();
            foreach (DataRow person in peopleData.Rows)
            {
                Console.WriteLine($"ID: {person["PersonID"]}," +
                                  $" National ID: {person["NationalNo"]}," +
                                  $" Full Name: {person["FirstName"]} {person["LastName"]}," +
                                  $" Email {person["Email"]}");
            }
                Console.ReadLine();
        }
    }
}
