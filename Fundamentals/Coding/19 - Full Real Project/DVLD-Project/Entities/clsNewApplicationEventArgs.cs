using Entities.Enums;
using System;


namespace Entities
{
    public class clsNewApplicationEventArgs : EventArgs
    {
        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationCreatedDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public enAppStatus ApplicationStatus { get; set; }
        public DateTime ApplicationModifiedDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }

        public clsNewApplicationEventArgs(int applicationID, int applicantPersonID, DateTime applicationTypeCreatedDate,
            int applicationTypeID, enAppStatus applicationStatus, DateTime applicationTypeModifiedDate,
            decimal paidFees, int userIDCreatedBy)
        {
            ApplicationID = applicationID;
            ApplicantPersonID = applicantPersonID;
            ApplicationCreatedDate = applicationTypeCreatedDate;
            ApplicationTypeID = applicationTypeID;
            ApplicationStatus = applicationStatus;
            ApplicationModifiedDate = applicationTypeModifiedDate;
            PaidFees = paidFees;
            CreatedByUserID = userIDCreatedBy;
        }

    }
}
