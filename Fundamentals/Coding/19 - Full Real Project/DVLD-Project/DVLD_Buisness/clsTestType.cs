using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using DVLD_DataAccess;

namespace DVLD_Buisness
{
    public class clsTestType
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public  enum enTestType { VisionTest = 1, WrittenTest = 2,StreetTest=3 };

        public clsTestType.enTestType ID { set; get; }
        public string Title { set; get; }
        public string Description { set; get; } 
        public float Fees { set; get; }
        public clsTestType()

        {
            this.ID = clsTestType.enTestType.VisionTest;
            this.Title = "";
            this.Description = "";
            this.Fees = 0;
            Mode = enMode.AddNew;

        }

        public clsTestType(clsTestType.enTestType ID, string TestTypeTitel,string Description,float TestTypeFees)

        {
            this.ID = ID;
            this.Title = TestTypeTitel;
            this.Description = Description;

            this.Fees = TestTypeFees;
            Mode = enMode.Update;
        }

        private bool _AddNewTestType()
        {
            //call DataAccess Layer 

            this.ID =(clsTestType.enTestType) clsTestTypeData.AddNewTestType(this.Title,this.Description, this.Fees);
              
            return (this.Title !="");
        }

        private bool _UpdateTestType()
        {
            //call DataAccess Layer 

            return clsTestTypeData.UpdateTestType((int) this.ID,this.Title,this.Description,this.Fees);
        }

        public static clsTestType Find(clsTestType.enTestType TestTypeID)
        {
            string Title = "", Description=""; float Fees=0;

            if (clsTestTypeData.GetTestTypeInfoByID((int) TestTypeID, ref Title,ref Description, ref Fees))

                return new clsTestType(TestTypeID, Title, Description,Fees);
            else
                return null;

        }

        public static DataTable GetAllTestTypes()
        {
            return clsTestTypeData.GetAllTestTypes();

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestType())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateTestType();

            }

            return false;
        }

    }
}
