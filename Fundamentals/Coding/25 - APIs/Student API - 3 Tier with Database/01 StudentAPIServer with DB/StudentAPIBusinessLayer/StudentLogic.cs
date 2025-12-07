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
                return new StudentDTO(this.ID, this.Name, this.Age, this.Grade); 
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

        private async Task<bool> _AddNewStudentAsync(CancellationToken ct = default)
        {
            this.ID = await StudentData.AddStudentAsync(SDTO, ct);
            return (this.ID != -1);
        }

        private Task<bool> _UpdateStudentAsync(CancellationToken ct = default)
        {
            return StudentData.UpdateStudentAsync(SDTO, ct);
        }

        public static Task<List<StudentDTO>> GetAllStudentsAsync(CancellationToken ct = default)
        {
            return StudentData.GetAllStudentsAsync(ct);
        }

        public static Task<List<StudentDTO>> GetPassedStudentsAsync(CancellationToken ct = default)
        {
            return StudentData.GetPassedStudentsAsync(ct);
        }

        public static Task<double> GetAverageGradeAsync(CancellationToken ct = default)
        {
            return StudentData.GetAverageGradeAsync(ct);
        }

        public static async Task<StudentLogic?> FindAsync(int ID, CancellationToken ct = default)
        {
            StudentDTO? SDTO = await StudentData.GetStudentByIdAsync(ID, ct);
            if (SDTO != null)
            {
                return new StudentLogic(SDTO, enMode.Update);
            }
            return null;
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
                    return false;

                case enMode.Update:
                    return await _UpdateStudentAsync(ct);
            }

            return false;
        }

        public static Task<bool> DeleteStudentAsync(int ID, CancellationToken ct = default)
        {
            return StudentData.DeleteStudentAsync(ID, ct);
        }
    }
}

