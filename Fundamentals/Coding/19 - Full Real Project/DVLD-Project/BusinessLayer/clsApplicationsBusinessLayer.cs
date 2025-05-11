using System;
using System.Data;
using DataAccessLayer;
using Entities;

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

            if (clsApplicationsDataAccess.HasPendingApplication(e.ApplicantPersonID, e.ApplicationTypeID))
                throw new InvalidOperationException("There is a pending application for this person.");

            return clsApplicationsDataAccess.AddNewApplication(e);
        }

        public static bool HasPendingApplication(int personID, int appTypeID)
        {
            if (personID <= 0)
                throw new ArgumentOutOfRangeException(nameof(personID), "Person ID must be greater than zero.");

            return clsApplicationsDataAccess.HasPendingApplication(personID, appTypeID);
        }

    }
}
