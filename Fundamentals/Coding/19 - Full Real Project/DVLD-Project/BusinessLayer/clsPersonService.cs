using System;
using System.Globalization;
using Entities;

namespace BusinessLayer
{
    public class clsPersonService
    {
        private static string Capitalize(string input)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.Trim().ToLower());
        }

        public static void NormalizePersonData(clsPerson person)
        {
            person.FirstName = Capitalize(person.FirstName);
            person.SecondName = Capitalize(person.SecondName);
            person.ThirdName = Capitalize(person.ThirdName);
            person.LastName = Capitalize(person.LastName);
            person.Address = Capitalize(person.Address);
            person.Email = person.Email.ToLower();
        }
    }

}
