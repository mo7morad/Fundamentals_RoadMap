using System;

namespace Entities
{
    public class clsApplicationBasicInfo
    {
        public int ApplicationID { get; set; }
        public short ApplicationStatus { get; set; }
        public decimal ApplicationFees { get; set; }
        public string ApplicationType { get; set; }
        public string ApplicantName { get; set; }
        public DateTime SubmissionDate { get; set; }
        public DateTime? ModificationDate { get; set; } // Nullable in case it hasn't been modified
        public string CreatedBy { get; set; } // Username or ID of the user who created the application
        public clsApplicationBasicInfo(int applicationID, short applicationStatus, decimal applicationFees,
                                        string applicationType, string applicantName, DateTime submissionDate,
                                        DateTime? modificationDate, string createdBy)
        {
            ApplicationID = applicationID;
            ApplicationStatus = applicationStatus;
            ApplicationFees = applicationFees;
            ApplicationType = applicationType;
            ApplicantName = applicantName;
            SubmissionDate = submissionDate;
            ModificationDate = modificationDate;
            CreatedBy = createdBy;
        }
    }
}
