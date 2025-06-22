using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using DVLD_DataAccess;

namespace DVLD_Buisness
{
    public class clsDetainedLicense
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int DetainID { set; get; }
        public int LicenseID { set; get; }
        public DateTime DetainDate { set; get; }

        public float  FineFees { set; get; }
        public int CreatedByUserID { set; get; }
        public clsUser CreatedByUserInfo { set; get; }
        public bool IsReleased { set; get; }
        public DateTime ReleaseDate { set; get; }
        public int ReleasedByUserID { set; get; }
        public clsUser ReleasedByUserInfo { set; get; }
        public int ReleaseApplicationID { set; get; }
       
        public clsDetainedLicense()

        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = 0;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = DateTime.MaxValue;
            this.ReleasedByUserID = 0;
            this.ReleaseApplicationID = -1;



            Mode = enMode.AddNew;

        }

        public clsDetainedLicense(int DetainID,
            int LicenseID,  DateTime DetainDate,
            float FineFees,  int CreatedByUserID,
            bool IsReleased,  DateTime ReleaseDate,
            int ReleasedByUserID,  int ReleaseApplicationID)

        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUser.FindByUserID(this.CreatedByUserID);
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;
            this.ReleasedByUserInfo= clsUser.FindByPersonID(this.ReleasedByUserID);
            Mode = enMode.Update;
        }

        private bool _AddNewDetainedLicense()
        {
            //call DataAccess Layer 

            this.DetainID = clsDetainedLicenseData.AddNewDetainedLicense( 
                this.LicenseID,this.DetainDate,this.FineFees,this.CreatedByUserID);
            
            return (this.DetainID != -1);
        }

        private bool _UpdateDetainedLicense()
        {
            //call DataAccess Layer 

            return clsDetainedLicenseData.UpdateDetainedLicense(
                this.DetainID,this.LicenseID,this.DetainDate,this.FineFees,this.CreatedByUserID);
        }

        public static clsDetainedLicense Find(int DetainID)
        {
            int LicenseID = -1; DateTime DetainDate = DateTime.Now;
            float FineFees= 0; int CreatedByUserID = -1;
            bool IsReleased = false; DateTime ReleaseDate = DateTime.MaxValue;
            int ReleasedByUserID = -1; int ReleaseApplicationID = -1;

            if (clsDetainedLicenseData.GetDetainedLicenseInfoByID(DetainID,
            ref LicenseID, ref DetainDate,
            ref FineFees, ref CreatedByUserID,
            ref IsReleased, ref ReleaseDate,
            ref ReleasedByUserID, ref ReleaseApplicationID))

                return new clsDetainedLicense(DetainID,
                     LicenseID,  DetainDate,
                     FineFees,  CreatedByUserID,
                     IsReleased,  ReleaseDate,
                     ReleasedByUserID,  ReleaseApplicationID);
            else
                return null;

        }

        public static DataTable GetAllDetainedLicenses()
        {
            return clsDetainedLicenseData.GetAllDetainedLicenses();

        }

        public static clsDetainedLicense FindByLicenseID(int LicenseID)
        {
            int DetainID = -1; DateTime DetainDate = DateTime.Now;
            float FineFees = 0; int CreatedByUserID = -1;
            bool IsReleased = false; DateTime ReleaseDate = DateTime.MaxValue;
            int ReleasedByUserID = -1; int ReleaseApplicationID = -1;

            if (clsDetainedLicenseData.GetDetainedLicenseInfoByLicenseID(LicenseID,
            ref DetainID, ref DetainDate,
            ref FineFees, ref CreatedByUserID,
            ref IsReleased, ref ReleaseDate,
            ref ReleasedByUserID, ref ReleaseApplicationID))

                return new clsDetainedLicense(DetainID,
                     LicenseID, DetainDate,
                     FineFees, CreatedByUserID,
                     IsReleased, ReleaseDate,
                     ReleasedByUserID, ReleaseApplicationID);
            else
                return null;

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDetainedLicense())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateDetainedLicense();

            }

            return false;
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            return clsDetainedLicenseData.IsLicenseDetained(LicenseID);
        }

        public bool ReleaseDetainedLicense(int ReleasedByUserID, int ReleaseApplicationID)
        {
            return clsDetainedLicenseData.ReleaseDetainedLicense(this.DetainID,
                   ReleasedByUserID, ReleaseApplicationID);
        }
    }
}
