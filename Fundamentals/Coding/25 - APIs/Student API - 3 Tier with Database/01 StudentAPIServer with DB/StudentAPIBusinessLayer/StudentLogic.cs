using System.Data;
using StudentModels;
using StudentDataAccessLayer;
using System.Threading;
using System.Threading.Tasks;

namespace StudentAPIBusinessLayer
{

    public class StudentLogic
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public StudentDTO SDTO 
        {
            get 
            { 
                return (new StudentDTO(this.ID, this.Name, this.Age, this.Grade)); 
            }
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

        public StudentLogic(StudentDTO SDTO, enMode cMode = enMode.AddNew)
        {
            this.ID = SDTO.Id;
            this.Name = SDTO.Name; 
            this.Age = SDTO.Age;
            this.Grade = SDTO.Grade;
         
            Mode = cMode;
        }

        private bool _AddNewStudent()
        {
            //call DataAccess Layer 

            this.ID = StudentData.AddStudent(SDTO);

            return (this.ID != -1);
        }

        private async Task<bool> _AddNewStudentAsync(CancellationToken ct = default)
        {
            //call DataAccess Layer 

            this.ID = await StudentData.AddStudentAsync(SDTO, ct);

            return (this.ID != -1);
        }

        private bool _UpdateStudent()
        {
            return StudentData.UpdateStudent(SDTO);
        }

        private Task<bool> _UpdateStudentAsync(CancellationToken ct = default)
        {
            return StudentData.UpdateStudentAsync(SDTO, ct);
        }

        public static List<StudentDTO> GetAllStudents()
        {
            return StudentData.GetAllStudents();
        }

        public static async Task<List<StudentDTO>> GetAllStudentsAsync(CancellationToken ct = default)
        {
            return await StudentData.GetAllStudentsAsync(ct);
        }

        public static List<StudentDTO> GetPassedStudents()
        {
            return StudentData.GetPassedStudents();
        }

        public static Task<List<StudentDTO>> GetPassedStudentsAsync(CancellationToken ct = default)
        {
            return StudentData.GetPassedStudentsAsync(ct);
        }

        public static double GetAverageGrade()
        {
            return StudentData.GetAverageGrade();
        }

        public static Task<double> GetAverageGradeAsync(CancellationToken ct = default)
        {
            return StudentData.GetAverageGradeAsync(ct);
        }

        public static StudentLogic Find(int ID)
        {
            StudentDTO SDTO = StudentData.GetStudentById(ID);

            if (SDTO != null)
            {
                //we return new object of that student with the right data
                return new StudentLogic(SDTO, enMode.Update);
            }
            else
                return null;
        }

        public static async Task<StudentLogic> FindAsync(int ID, CancellationToken ct = default)
        {
            StudentDTO SDTO = await StudentData.GetStudentByIdAsync(ID, ct);

            if (SDTO != null)
            {
                //we return new object of that student with the right data
                return new StudentLogic(SDTO, enMode.Update);
            }
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewStudent())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateStudent();
            }

            return false;
        }

        public async Task<bool> SaveAsync(CancellationToken ct = default)
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (await _AddNewStudentAsync(ct))
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return await _UpdateStudentAsync(ct);
            }

            return false;
        }

        public static bool DeleteStudent(int ID)
        {
            return StudentData.DeleteStudent(ID);
        }

        public static Task<bool> DeleteStudentAsync(int ID, CancellationToken ct = default)
        {
            return StudentData.DeleteStudentAsync(ID, ct);
        }
    }
}

