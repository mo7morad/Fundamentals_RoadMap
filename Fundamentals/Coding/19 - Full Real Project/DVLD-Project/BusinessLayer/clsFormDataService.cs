using System;
using System.Data;

namespace BusinessLayer
{
    public class clsFormDataService
    {
        // Generic method to populate a form based on data table with error handling
        public static (bool Success, string ErrorMessage) PopulateDataFromTable(DataTable dt, Action<DataRow> populateAction)
        {
            try
            {
                if (dt == null || dt.Rows.Count == 0)
                {
                    return (false, "No data found!");
                }
                
                // Use the provided action to populate the form
                populateAction(dt.Rows[0]);
                return (true, null);
            }
            catch (Exception ex)
            {
                return (false, $"Error loading data: {ex.Message}");
            }
        }
        
        // Generic method to validate form data with custom validation
        public static bool ValidateData<T>(T data, Func<T, bool> validationFunc)
        {
            return validationFunc(data);
        }
        
        // Common method to handle the key press events for numeric inputs
        public static bool IsNumericKey(char keyChar, bool allowDecimal = false)
        {
            // Allow digits and control characters
            bool isValid = char.IsDigit(keyChar) || char.IsControl(keyChar);
            
            // If decimal point is allowed, also check for it
            if (allowDecimal && keyChar == '.')
            {
                isValid = true;
            }
            
            return isValid;
        }
        
        // Common method to handle key press events for alphabetic inputs
        public static bool IsAlphabeticKey(char keyChar)
        {
            // Allow letters, spaces, and control characters
            return char.IsLetter(keyChar) || char.IsWhiteSpace(keyChar) || char.IsControl(keyChar);
        }
        
        // Generic save operation with error handling
        public static (bool Success, string ErrorMessage) SaveData<T>(Func<T, bool> saveOperation, T data)
        {
            try
            {
                if (saveOperation(data))
                {
                    return (true, null);
                }
                else
                {
                    return (false, "Failed to save data.");
                }
            }
            catch (Exception ex)
            {
                return (false, $"Error saving data: {ex.Message}");
            }
        }
    }
} 