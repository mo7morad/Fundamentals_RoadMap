using System;
using System.Data;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Xml.Linq;
using DVLD_DataAccess;
using static System.Net.Mime.MediaTypeNames;
using static DVLD_Buisness.clsTestType;


namespace DVLD_Buisness
{
    public   class clsLocalDrivingLicenseApplication : clsApplication

    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int LocalDrivingLicenseApplicationID { set; get; }
        public int LicenseClassID { set; get; }
        public clsLicenseClass LicenseClassInfo;
        public string PersonFullName   
        {
            get { 
                return clsPerson.Find(ApplicantPersonID).FullName; 
            }   
            
        }

        public clsLocalDrivingLicenseApplication()

        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.LicenseClassID = -1;
            
           
            Mode = enMode.AddNew;

        }

        private clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int ApplicantPersonID, 
            DateTime ApplicationDate, int ApplicationTypeID,
             enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
             float PaidFees, int CreatedByUserID, int LicenseClassID)

        {
            this.LocalDrivingLicenseApplicationID= LocalDrivingLicenseApplicationID; ;
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = (int) ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.LicenseClassID = LicenseClassID;
            this.LicenseClassInfo = clsLicenseClass.Find(LicenseClassID);
            Mode = enMode.Update;
        }

        private bool _AddNewLocalDrivingLicenseApplication()
        {
            //call DataAccess Layer 
            
            this.LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationData.AddNewLocalDrivingLicenseApplication
                (
                this.ApplicationID, this.LicenseClassID);

            return (this.LocalDrivingLicenseApplicationID != -1);
        }

        private bool _UpdateLocalDrivingLicenseApplication()
        {
            //call DataAccess Layer 

            return clsLocalDrivingLicenseApplicationData.UpdateLocalDrivingLicenseApplication
                (
                this.LocalDrivingLicenseApplicationID ,this.ApplicationID, this.LicenseClassID);
           
        }

        public static clsLocalDrivingLicenseApplication  FindByLocalDrivingAppLicenseID(int LocalDrivingLicenseApplicationID)
        {
            // 
            int ApplicationID=-1, LicenseClassID=-1;

            bool IsFound = clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationInfoByID
                (LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID);


            if (IsFound)
            { 
               //now we find the base application
                clsApplication Application = clsApplication.FindBaseApplication(ApplicationID);

                //we return new object of that person with the right data
                return new clsLocalDrivingLicenseApplication(
                    LocalDrivingLicenseApplicationID, Application.ApplicationID, 
                    Application.ApplicantPersonID,
                                     Application.ApplicationDate, Application.ApplicationTypeID,
                                    (enApplicationStatus)Application.ApplicationStatus, Application.LastStatusDate,
                                     Application.PaidFees, Application.CreatedByUserID,LicenseClassID);
            }
            else
                return null;
          

        }

        public static clsLocalDrivingLicenseApplication FindByApplicationID(int ApplicationID)
        {
            // 
            int LocalDrivingLicenseApplicationID = -1, LicenseClassID = -1;

            bool IsFound = clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationInfoByApplicationID 
                (ApplicationID, ref LocalDrivingLicenseApplicationID, ref LicenseClassID);


            if (IsFound)
            {
                //now we find the base application
                clsApplication Application = clsApplication.FindBaseApplication(ApplicationID);

                //we return new object of that person with the right data
                return new clsLocalDrivingLicenseApplication(
                    LocalDrivingLicenseApplicationID, Application.ApplicationID,
                    Application.ApplicantPersonID,
                                     Application.ApplicationDate, Application.ApplicationTypeID,
                                    (enApplicationStatus)Application.ApplicationStatus, Application.LastStatusDate,
                                     Application.PaidFees, Application.CreatedByUserID, LicenseClassID);
            }
            else
                return null;


        }

        public bool  Save()
        {
          
           //Because of inheritance first we call the save method in the base class,
           //it will take care of adding all information to the application table.
            base.Mode = (clsApplication.enMode) Mode;
          if (!base.Save()) 
                return false ;


          //After we save the main application now we save the sub application.
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLocalDrivingLicenseApplication())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateLocalDrivingLicenseApplication();

            }

            return false;
        }

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            return clsLocalDrivingLicenseApplicationData.GetAllLocalDrivingLicenseApplications();
        }

        public  bool Delete()
        {
            bool IsLocalDrivingApplicationDeleted = false;
            bool IsBaseApplicationDeleted = false;
            //First we delete the Local Driving License Application
            IsLocalDrivingApplicationDeleted = clsLocalDrivingLicenseApplicationData.DeleteLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID);
           
            if (!IsLocalDrivingApplicationDeleted)
                return false;
            //Then we delete the base Application
            IsBaseApplicationDeleted = base.Delete();
            return IsBaseApplicationDeleted;

        }

        public bool DoesPassTestType(clsTestType.enTestType  TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationData.DoesPassTestType( this.LocalDrivingLicenseApplicationID,(int) TestTypeID);
        }

        public bool DoesPassPreviousTest(clsTestType.enTestType CurrentTestType)
        {

            switch (CurrentTestType)
            {
                case clsTestType.enTestType.VisionTest:
                    //in this case no required prvious test to pass.
                    return true;

                case clsTestType.enTestType.WrittenTest:
                    //Written Test, you cannot sechdule it before person passes the vision test.
                    //we check if pass visiontest 1.

                    return this.DoesPassTestType(clsTestType.enTestType.VisionTest);
                   

                case clsTestType.enTestType.StreetTest:

                    //Street Test, you cannot sechdule it before person passes the written test.
                    //we check if pass Written 2.
                    return this.DoesPassTestType(clsTestType.enTestType.WrittenTest);

                default: 
                    return false;
            }
        }

        public static bool DoesPassTestType(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationData.DoesPassTestType(LocalDrivingLicenseApplicationID,(int) TestTypeID);
        }

        public  bool DoesAttendTestType( clsTestType.enTestType TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationData.DoesAttendTestType(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public  byte TotalTrialsPerTest( clsTestType.enTestType TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.TotalTrialsPerTest(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public static byte TotalTrialsPerTest(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationData.TotalTrialsPerTest(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public static bool AttendedTest(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationData.TotalTrialsPerTest(LocalDrivingLicenseApplicationID, (int)TestTypeID) >0;
        }

        public  bool AttendedTest( clsTestType.enTestType TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationData.TotalTrialsPerTest(this.LocalDrivingLicenseApplicationID, (int)TestTypeID) > 0;
        }

        public static bool IsThereAnActiveScheduledTest(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)

        {
            
            return clsLocalDrivingLicenseApplicationData.IsThereAnActiveScheduledTest(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public  bool IsThereAnActiveScheduledTest( clsTestType.enTestType TestTypeID)

        {

            return clsLocalDrivingLicenseApplicationData.IsThereAnActiveScheduledTest(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public clsTest GetLastTestPerTestType(clsTestType.enTestType TestTypeID)
        {
            return clsTest.FindLastTestPerPersonAndLicenseClass(this.ApplicantPersonID, this.LicenseClassID, TestTypeID);
        }

        public byte GetPassedTestCount()
        {
            return clsTest.GetPassedTestCount(this.LocalDrivingLicenseApplicationID);
        }

        public static byte GetPassedTestCount(int LocalDrivingLicenseApplicationID)
        {
            return clsTest.GetPassedTestCount(LocalDrivingLicenseApplicationID);
        }

        public  bool PassedAllTests()
        {
             return clsTest.PassedAllTests(this.LocalDrivingLicenseApplicationID);
        }

        public static bool PassedAllTests(int LocalDrivingLicenseApplicationID)
        {
            //if total passed test less than 3 it will return false otherwise will return true
            return clsTest.PassedAllTests (LocalDrivingLicenseApplicationID) ;
        }
        
        public int IssueLicenseForTheFirtTime(string Notes, int CreatedByUserID)
        {
            int DriverID = -1;

            clsDriver Driver =clsDriver.FindByPersonID(this.ApplicantPersonID);

            if (Driver == null)
            {
                //we check if the driver already there for this person.
                Driver = new clsDriver();
               
                Driver.PersonID= this.ApplicantPersonID;
                Driver.CreatedByUserID= CreatedByUserID;
                if (Driver.Save())
                {
                    DriverID= Driver.DriverID;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                DriverID= Driver.DriverID;
            }
            //now we diver is there, so we add new licesnse
            
            clsLicense License= new clsLicense();
            License.ApplicationID = this.ApplicationID;
            License.DriverID= DriverID;
            License.LicenseClass = this.LicenseClassID;
            License.IssueDate=DateTime.Now;
            License.ExpirationDate = DateTime.Now.AddYears(this.LicenseClassInfo.DefaultValidityLength);
            License.Notes = Notes;
            License.PaidFees = this.LicenseClassInfo.ClassFees;
            License.IsActive= true;
            License.IssueReason = clsLicense.enIssueReason.FirstTime;
            License.CreatedByUserID= CreatedByUserID;

            if (License.Save())
            {
                //now we should set the application status to complete.
                this.SetComplete();

                return License.LicenseID;
            }
               
            else
                return -1;
        }

        public bool IsLicenseIssued()
        {
            return (GetActiveLicenseID() !=-1);
        }

        public int GetActiveLicenseID()
        {//this will get the license id that belongs to this application
            return  clsLicense.GetActiveLicenseIDByPersonID(this.ApplicantPersonID, this.LicenseClassID);
        }
    }
}
