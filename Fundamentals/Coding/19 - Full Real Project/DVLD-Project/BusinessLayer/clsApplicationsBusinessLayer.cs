using System;
using System.Data;
using System.Net.NetworkInformation;
using DataAccessLayer;
using Entities;
using Entities.Enums;

namespace BusinessLayer
{
    public class clsApplicationsBusinessLayer
    {
        public static DataTable GetAllApplications()
        {
            return clsApplicationsDataAccess.GetAllApplications();
        }

        public static int AddNewApplication(clsNewApplicationEventArgs e)
        {
            if (e == null)
                throw new ArgumentNullException(nameof(e), "Event args cannot be empty.");

            // Check if person already has an application for this license class
            if (HasPendingApplication(e.ApplicantPersonID, e.ApplicationTypeID))
            {
                throw new InvalidOperationException("Cannot add a new application when there is already a pending application for this person.");
            }

            return clsApplicationsDataAccess.AddNewApplication(e);
        }

        public static bool HasPendingApplication(int personID, int appTypeID)
        {
            if (personID <= 0)
                throw new ArgumentOutOfRangeException(nameof(personID), "Person ID must be greater than zero.");

            return clsApplicationsDataAccess.HasPendingApplication(personID, appTypeID);
        }

        public static enAppStatus GetApplicationStatus(int personID, int appTypeID)
        {
            if (personID <= 0)
                throw new ArgumentOutOfRangeException(nameof(personID), "Person ID must be greater than zero.");

            return clsApplicationsDataAccess.GetApplicationStatus(personID, appTypeID);
        }

        public static bool CancelApplication(int applicationID)
        {
            if (applicationID <= 0)
                throw new ArgumentOutOfRangeException(nameof(applicationID), "Application ID must be greater than zero.");
            return clsApplicationsDataAccess.CancelApplication(applicationID);
        }

        public static bool IsPersonEligibleForLicense(int personID, int licenseClassID)
        {
            if (personID <= 0)
                throw new ArgumentOutOfRangeException(nameof(personID), "Person ID must be greater than zero.");
            
            // Check person minimum age
            clsPerson person = clsPeopleBusinessLayer.GetPersonByID(personID);
            if (person == null)
                return false;
                
            // Check if they already have a pending application
            if (HasPendingApplication(personID, licenseClassID))
                return false;
                
            // Check application status
            enAppStatus status = GetApplicationStatus(personID, licenseClassID);
            
            // If there's no application or it was canceled, they can apply
            return status == enAppStatus.NotFound || 
                   status == enAppStatus.Canceled;
        }
    }
}
