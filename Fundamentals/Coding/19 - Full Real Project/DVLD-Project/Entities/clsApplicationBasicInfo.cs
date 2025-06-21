using Entities.Enums;
using System;

namespace Entities
{
    public class clsApplicationBasicInfo
    {
        public int ApplicationID { get; set; }
        public int DrivingLicenseAppID { get; set; }
        public enAppStatus ApplicationStatus { get; set; }
        public decimal ApplicationFees { get; set; }
        public string ApplicationType { get; set; }
        public string ApplicantName { get; set; }
        public string DrivingLicenseClass { get; set; }
        public DateTime SubmissionDate { get; set; }
        public DateTime? ModificationDate { get; set; } // Nullable in case it hasn't been modified
        public string CreatedBy { get; set; } // Username or ID of the user who created the application

        public clsApplicationBasicInfo(int applicationID, int drivingLicenseAppID, enAppStatus applicationStatus, decimal applicationFees,
                                       string applicationType, string applicantName, string drivingLicenseClass,
                                       DateTime submissionDate, DateTime? modificationDate, string createdBy)
        {
            ApplicationID = applicationID;
            DrivingLicenseAppID = drivingLicenseAppID;
            ApplicationStatus = applicationStatus;
            ApplicationFees = applicationFees;
            ApplicationType = applicationType;
            ApplicantName = applicantName;
            DrivingLicenseClass = drivingLicenseClass;
            SubmissionDate = submissionDate;
            ModificationDate = modificationDate;
            CreatedBy = createdBy;
        }
    }
}
