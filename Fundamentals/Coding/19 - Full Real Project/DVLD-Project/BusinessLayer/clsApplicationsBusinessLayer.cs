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

            if (clsApplicationsDataAccess.IsPendingApplication(e.ApplicationID))
                throw new InvalidOperationException("There is a pending application for this person.");

            return clsApplicationsDataAccess.AddNewApplication(e);
        }

    }
}
