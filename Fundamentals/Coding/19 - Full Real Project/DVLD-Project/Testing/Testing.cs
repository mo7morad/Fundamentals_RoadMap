using BusinessLayer;
using System;
using System.Data;
using Entities;

namespace ConsoleTesting
{
    internal class Testing
    {
        private static void GetAllPeopleTest()
        {
            DataTable people = PeopleBusinessLayer.GetAllPeople();
            foreach (DataRow person in people.Rows)
            {
                Console.WriteLine($"ID: {person["PersonID"]}, Name: {person["FirstName"]} {person["LastName"]}, Email: {person["Email"]}");
            }
        }

        private static int AddNewPersonTest()
        {
            string nationalNo = "123456789";
            string firstName = "John";
            string secondName = "Doe";
            string thirdName = "Smith";
            string lastName = "Johnson";
            DateTime dateOfBirth = new DateTime(1990, 5, 15);
            bool gender = false;
            string address = "123 Main St";
            string phone = "3125346334";
            string countryID = "45";
            string email = "Johndoe@gmail.com";
            string imagePath = "C:\\Images\\john.jpg";

            clsPerson p = new clsPerson(
                nationalNo,
                firstName,
                secondName,
                thirdName,
                lastName,
                dateOfBirth,
                gender,
                address,
                phone,
                countryID,
                email,
                imagePath
            );
            return PeopleBusinessLayer.AddNewPerson(p);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("List Before Adding a new person (John)");
            GetAllPeopleTest();
            Console.WriteLine("Adding a new person (John)...");
            int newPersonID = AddNewPersonTest();
            if (newPersonID > 0)
            {
                Console.WriteLine($"New person added successfully with ID: {newPersonID}");
            }
            else
            {
                Console.WriteLine("Failed to add new person.");
            }
            Console.WriteLine("List After Adding a new person (John)");
            GetAllPeopleTest();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
