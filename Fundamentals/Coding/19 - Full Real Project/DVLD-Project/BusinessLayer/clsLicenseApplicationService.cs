using System;
using System.Data;
using Entities;
using Entities.Enums;

namespace BusinessLayer
{
    public class clsLicenseApplicationService
    {
        #region Person Validation

        public static bool IsPersonSelected(int personID)
        {
            return personID > 0;
        }

        public static bool IsPersonFound(int personID)
        {
            if (personID <= 0)
                return false;
                
            return clsPeopleBusinessLayer.GetPersonByID(personID) != null;
        }

        #endregion

        #region License Application Validation

        public static bool IsLicenseClassSelected(int licenseClassID)
        {
            return licenseClassID > 0;
        }

        public static bool AreApplicationFeesValid(decimal fees)
        {
            return fees > 0;
        }

        public static bool ParseApplicationFees(string feesText, out decimal fees)
        {
            fees = 0;
            
            if (string.IsNullOrWhiteSpace(feesText))
                return false;
            
            // Remove currency symbol and trim
            string cleanFeesText = feesText.Replace("$", "").Trim();
            
            if (decimal.TryParse(cleanFeesText, out fees))
                return fees > 0;
                
            return false;
        }

        public static bool IsPersonEligibleForLicense(int personID, int licenseClassID, out string errorMessage)
        {
            errorMessage = string.Empty;
            
            if (personID <= 0)
            {
                errorMessage = "Invalid person ID.";
                return false;
            }
            
            // Check if person exists
            clsPerson person = clsPeopleBusinessLayer.GetPersonByID(personID);
            if (person == null)
            {
                errorMessage = "Person not found.";
                return false;
            }
            
            // Check for pending applications
            if (clsApplicationsBusinessLayer.HasPendingApplication(personID, licenseClassID))
            {
                errorMessage = "This person already has a pending application for this license class.";
                return false;
            }
            
            // Check application status
            enAppStatus status = clsApplicationsBusinessLayer.GetApplicationStatus(personID, licenseClassID);
            
            if (status == enAppStatus.New)
            {
                errorMessage = "This person already has a pending application for this license class.";
                return false;
            }
            
            if (status == enAppStatus.Approved || status == enAppStatus.PassedAllTests || status == enAppStatus.LicenseIssued)
            {
                errorMessage = "This person already has an approved application or license for this class.";
                return false;
            }
            
            // Only NotFound or Canceled statuses are eligible
            return status == enAppStatus.NotFound || status == enAppStatus.Canceled;
        }

        #endregion

        #region License Application Operations

        public static bool LoadLicenseClasses(ref DataTable dtLicenseClasses)
        {
            dtLicenseClasses = clsLicensesBusinessLayer.GetAllLicenseClasses();
            return dtLicenseClasses != null && dtLicenseClasses.Rows.Count > 0;
        }

        public static decimal GetApplicationFeesByID(int applicationTypeID)
        {
            return clsApplicationTypesBusinessLayer.GetApplicationFeesByID(applicationTypeID);
        }
        
        public static int CreateNewLicenseApplication(clsNewApplicationEventArgs applicationEventArgs, out string errorMessage)
        {
            errorMessage = string.Empty;
            
            try
            {
                if (applicationEventArgs == null)
                {
                    errorMessage = "Application data is missing.";
                    return -1;
                }
                
                // Validate person
                if (!IsPersonSelected(applicationEventArgs.ApplicantPersonID))
                {
                    errorMessage = "Please select a person first.";
                    return -1;
                }
                
                // Check eligibility
                if (!IsPersonEligibleForLicense(applicationEventArgs.ApplicantPersonID, applicationEventArgs.ApplicationTypeID, out errorMessage))
                {
                    return -1;
                }
                
                // Create application
                return clsApplicationsBusinessLayer.AddNewApplication(applicationEventArgs);
            }
            catch (InvalidOperationException ex)
            {
                errorMessage = ex.Message;
                return -1;
            }
            catch (Exception ex)
            {
                errorMessage = $"Error creating license application: {ex.Message}";
                return -1;
            }
        }

        #endregion
    }
} 