using System;
using System.Text.RegularExpressions;

namespace BusinessLayer
{
    public class clsFormValidationService
    {
        public static bool IsStringEmpty(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }
        
        public static bool IsValidNumericValue(string value)
        {
            return !IsStringEmpty(value) && decimal.TryParse(value, out _);
        }
        
        public static bool IsValidPositiveNumber(string value)
        {
            if (IsStringEmpty(value))
                return false;
                
            if (decimal.TryParse(value, out decimal numericValue))
                return numericValue > 0;
                
            return false;
        }
        
        public static bool IsValidEmail(string email)
        {
            if (IsStringEmpty(email))
                return false;
                
            try
            {
                // Simple regex pattern for basic email validation
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                return Regex.IsMatch(email, pattern);
            }
            catch
            {
                return false;
            }
        }
        
        public static bool IsValidPhoneNumber(string phone)
        {
            if (IsStringEmpty(phone))
                return false;
                
            // Remove any non-digit characters
            string digitsOnly = Regex.Replace(phone, @"\D", "");
            
            // Check if we have a reasonable number of digits (7-15)
            return digitsOnly.Length >= 7 && digitsOnly.Length <= 15;
        }
        
        public static bool IsValidNationalID(string nationalID)
        {
            if (IsStringEmpty(nationalID))
                return false;
                
            // National ID validation rules would depend on country-specific requirements
            // This is a generic implementation - adjust according to your requirements
            
            // Ensure it only contains alphanumeric characters
            return Regex.IsMatch(nationalID, @"^[a-zA-Z0-9]+$");
        }
        
        public static bool IsValidDateOfBirth(DateTime dateOfBirth)
        {
            // Check if date is not in the future and person is not too old (e.g., 120 years)
            return dateOfBirth <= DateTime.Now && dateOfBirth >= DateTime.Now.AddYears(-120);
        }
        
        public static bool IsValidAge(DateTime dateOfBirth, int minimumAge)
        {
            if (!IsValidDateOfBirth(dateOfBirth))
                return false;
                
            int age = DateTime.Now.Year - dateOfBirth.Year;
            
            // Adjust age if birthday hasn't occurred yet this year
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age--;
                
            return age >= minimumAge;
        }
        
        public static bool IsValidPassword(string password, out string errorMessage)
        {
            errorMessage = string.Empty;
            
            if (IsStringEmpty(password))
            {
                errorMessage = "Password cannot be empty.";
                return false;
            }
            
            if (password.Length < 6)
            {
                errorMessage = "Password must be at least 6 characters long.";
                return false;
            }
            
            // Additional password rules can be added here
            
            return true;
        }
        
        public static bool DoPasswordsMatch(string password, string confirmPassword)
        {
            return !IsStringEmpty(password) && password == confirmPassword;
        }
    }
} 