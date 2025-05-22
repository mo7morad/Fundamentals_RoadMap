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

            enAppStatus status = clsApplicationsDataAccess.GetApplicationStatus(e.ApplicantPersonID, e.ApplicationTypeID);
            if (status == enAppStatus.New || status != enAppStatus.Approved)
                throw new InvalidOperationException("Cannot add a new application when there is already an application for this person.");

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

    }
}
