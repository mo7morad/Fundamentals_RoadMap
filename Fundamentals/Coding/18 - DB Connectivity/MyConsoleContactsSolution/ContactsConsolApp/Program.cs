
using System;
using System.Data;
using ContactBusinessLayer;
using ContactsBusinessLayer;

namespace ContactsConsolApp
{
    internal class Program
    {
        static void testFindContact(int ID)

        {
            clsContact Contact1 = clsContact.Find(ID);

            if (Contact1 != null)
            {
                Console.WriteLine(Contact1.FirstName+ " " + Contact1.LastName);
                Console.WriteLine(Contact1.Email);
                Console.WriteLine(Contact1.Phone);
                Console.WriteLine(Contact1.Address);
                Console.WriteLine(Contact1.DateOfBirth);
                Console.WriteLine(Contact1.CountryID);
                Console.WriteLine(Contact1.ImagePath);
            }
            else 
            {
                Console.WriteLine("Contact [" + ID + "] Not found!");   
            }
        }



        static void testAddNewContact()


        {
            clsContact Contact1 = new clsContact();
            Contact1.FirstName = "Fadi";
            Contact1.LastName = "Maher";
            Contact1.Email = "A@a.com";
            Contact1.Phone = "010010";
            Contact1.Address = "address1";
            Contact1.DateOfBirth = new DateTime(1977, 11, 6, 10, 30, 0);
            Contact1.CountryID = 1;
            Contact1.ImagePath = "";
          
           if (Contact1.Save())
            {

                Console.WriteLine("Contact Added Successfully with id=" + Contact1.ID);
            }

        }

        static void testUpdateContact(int ID)

        {
            clsContact Contact1 = clsContact.Find(ID);

            if (Contact1 != null)
            {
                //update whatever info you want
                Contact1.FirstName = "Fadi2";
                Contact1.LastName = "Maher2";
                Contact1.Email = "A2@a.com";
                Contact1.Phone = "2222";
                Contact1.Address = "222";
                Contact1.DateOfBirth = new DateTime(1977, 11, 6, 10, 30, 0);
                Contact1.CountryID = 1;
                Contact1.ImagePath = "";

                if (Contact1.Save())
                {

                    Console.WriteLine("Contact updated Successfully ");
                }

            }
            else
            {
                Console.WriteLine("Not found!");
            }
        }

        static void ListContacts()
        {

            DataTable dataTable = clsContact.GetAllContacts();
           
            Console.WriteLine("Contacts Data:");

            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine($"{row["ContactID"]},  {row["FirstName"]} {row["LastName"]}");
            }

        }

        static void testDeleteContact(int ID)
        {
            if (!clsContact.IsContactExists(ID))
            {
                Console.WriteLine("Contact Not found!");
                return;
            }

            if (clsContact.DeleteContact(ID))
            {
                Console.WriteLine("Contact Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Contact Not found!");
            }
        }

        static void TestIsContactExists(int ID)
        {
            if(clsContact.IsContactExists(ID))
            {
                Console.WriteLine("Contact Exists");
            }
            else
            {
                Console.WriteLine("Contact Not found!");
            }
        }

        static void testAddNewCountry(string CountryName)
        {
            int newID = clsCountry.AddNewCountry(CountryName);
            if (newID > 0)
            {
                Console.WriteLine("Country Added Successfully with id=" + newID);
            }
            else
            {
                Console.WriteLine("Failed to add country.");
            }
        }

        static void testUpdateCountry(int CountryID, string CountryName)
        {
            if (clsCountry.UpdateCountry(CountryID, CountryName))
            {
                Console.WriteLine("Country updated successfully!");
            }
            else
            {
                Console.WriteLine("Country wasn't updated.");
            }
        }

        static void testListCountries()
        {
            DataTable dataTable = clsCountry.ListCountries();
            Console.WriteLine("Countries Data:");
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine($"{row["CountryID"]},  {row["CountryName"]}, {row["CountryCode"]}, {row["CountryPhoneCode"]}");
            }
        }

        static void testDeleteCountry(int countryID)
        {
            if (clsCountry.DeleteCountry(countryID))
            {
                Console.WriteLine("Country Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Country Not found!");
            }
        }

        static void testFindCountry(int ID)
        {
            clsCountry country = clsCountry.FindCountryByID(ID);
            if (country != null)
            {
                Console.WriteLine("Country is found!");
                Console.WriteLine($"{country.ID}, {country.CountryName}");
            }
            else
            {
                Console.WriteLine("Country Not found!");
            }
        }

        static void testFindCountry(string Name)
        {
            int countryID = -1;
            clsCountry country = clsCountry.FindCountryByName(Name, ref countryID);
            if (country != null)
            {
                Console.WriteLine("Country is found!");
                Console.WriteLine($"{country.ID}, {country.CountryName}");
            }
            else
            {
                Console.WriteLine("Country Not found!");
            }
        }

        static void testIsCountryExists(int ID)
        {
            if (clsCountry.isCountryExists(ID))
            {
                Console.WriteLine("Country Exists");
            }
            else
            {
                Console.WriteLine("Country Not found!");
            }
        }

        static void testIsCountryExists(string Name)
        {
            if (clsCountry.isCountryExists(Name))
            {
                Console.WriteLine("Country Exists");
            }
            else
            {
                Console.WriteLine("Country Not found!");
            }
        }



        static void Main(string[] args)
        {

            //testFindContact(1);
            //Console.WriteLine("__________________");
            //testFindContact(2);
            //Console.WriteLine("__________________");
            //testFindContact(3);
            //Console.WriteLine("__________________");
            //testFindContact(4);
            //Console.WriteLine("__________________");
            //testFindContact(5);
            //Console.WriteLine("__________________");
            //testFindContact(6);
            //Console.WriteLine("__________________");
            //testFindContact(7);
            //Console.WriteLine("__________________");
            //testFindContact(8);
            //Console.WriteLine("__________________");
            //testFindContact(9);
            //Console.WriteLine("__________________");

            //testAddNewContact();

            //testUpdateContact(1);

            //testDeleteContact(9);

            //ListContacts();

            //TestIsContactExists(1); 

            //testAddNewCountry("Egypt");

            //testUpdateCountry(6, "Egipto");

            //testListCountries();

            //testDeleteCountry(6);

            //testFindCountry(5);

            //testFindCountry("germany");

            //testIsCountryExists(5);

            //testIsCountryExists("canada");

            Console.ReadKey();

        }
    }
}
