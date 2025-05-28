using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Drawing;
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
        
        // Validation methods moved from UI layer
        public static bool ValidateName(string firstName, string secondName, string thirdName, string lastName)
        {
            return !string.IsNullOrWhiteSpace(firstName) && 
                   !string.IsNullOrWhiteSpace(secondName) && 
                   !string.IsNullOrWhiteSpace(thirdName) && 
                   !string.IsNullOrWhiteSpace(lastName);
        }
        
        public static bool ValidateNationalNo(string nationalNo, int personId = -1)
        {
            if (string.IsNullOrWhiteSpace(nationalNo))
                return false;
            
            // For new person
            if (personId == -1)
            {
                return !clsPeopleBusinessLayer.IsNationalNoExists(nationalNo);
            }
            // For existing person
            else
            {
                clsPerson currentPerson = clsPeopleBusinessLayer.GetPersonByID(personId);
                
                // If national number has changed, check if the new one exists
                if (currentPerson != null && !string.Equals(currentPerson.NationalNo, nationalNo, StringComparison.OrdinalIgnoreCase))
                {
                    return !clsPeopleBusinessLayer.IsNationalNoExists(nationalNo);
                }
                return true;
            }
        }
        
        public static bool ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return true; // Email can be empty
                
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        
        public static bool ValidatePhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return false;
                
            return phone.Length >= 10;
        }
        
        // Image handling methods
        public static string SavePersonImage(string sourcePath, string nationalNo)
        {
            if (string.IsNullOrWhiteSpace(sourcePath))
                return null;
                
            try
            {
                string extension = System.IO.Path.GetExtension(sourcePath);
                string targetDir = System.IO.Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), 
                    "DVLD", 
                    "peoplepictures");
                    
                System.IO.Directory.CreateDirectory(targetDir);
                string destPath = System.IO.Path.Combine(targetDir, nationalNo + extension);
                
                if (sourcePath == destPath)
                    return destPath;
                    
                System.IO.File.Copy(sourcePath, destPath, true);
                return destPath;
            }
            catch (Exception ex)
            {
                // Log exception or handle it as needed
                return null;
            }
        }
        
        public static Image GetPersonImage(string imagePath, bool isFemale)
        {
            if (string.IsNullOrEmpty(imagePath) || !System.IO.File.Exists(imagePath))
            {
                // Return null to signal that default image should be used
                return null;
            }
            
            try
            {
                return Image.FromFile(imagePath);
            }
            catch
            {
                // If loading fails, return null to signal default image
                return null;
            }
        }
        
        public static Image LoadPersonImage(clsPerson person)
        {
            if (person == null)
                return null;
                
            // Try to load image from file path
            if (!string.IsNullOrEmpty(person.ImagePath) && System.IO.File.Exists(person.ImagePath))
            {
                try
                {
                    return Image.FromFile(person.ImagePath);
                }
                catch
                {
                    // Fall back to default image if file loading fails
                    return null;
                }
            }
            
            // Return null so UI layer can handle default image
            return null;
        }
    }
}
