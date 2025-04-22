using BusinessLayer;
using System;
using System.Data;
using Entities;

namespace ConsoleTesting
{
    internal class Testing
    {

        private static bool UpdatePersonTest(int personID)
        {
            string errorMessage = string.Empty;
            clsPerson p = clsPeopleBusinessLayer.GetPersonByID(personID);
            p.Address = "456 New Address St";
            p.NationalNo = "N7";
            return clsPeopleBusinessLayer.UpdatePerson(p, ref errorMessage);
        }   


        static void Main(string[] args)
        {
            if(UpdatePersonTest(1030))
            {
                Console.WriteLine("Person updated successfully.");
            }
            else
            {
                Console.WriteLine("Failed to update person.");
            }
            Console.ReadKey();
        }
    }
}
