using Microsoft.AspNetCore.Mvc; 
using StudentApi.Models;
using StudentApi.DataSimulation;
using System.Collections.Generic; 

namespace StudentApi.Controllers 
{
    [ApiController] // Marks the class as a Web API controller with enhanced features.
  //  [Route("[controller]")] // Sets the route for this controller to "students", based on the controller name.
    [Route("api/Students")]

    public class StudentsController : ControllerBase // Declare the controller class inheriting from ControllerBase.
    {


        [HttpGet("All", Name ="GetAllStudents")] // Marks this method to respond to HTTP GET requests.
        public ActionResult<IEnumerable<Student>> GetAllStudents() // Define a method to get all students.
        {
            return Ok(StudentDataSimulation.StudentsList); // Returns the list of students.
        }

        [HttpGet("Passed",Name = "GetPassedStudents")]
        // Method to get all students who passed
        public ActionResult<IEnumerable<Student>> GetPassedStudents()

        {
            var passedStudents = StudentDataSimulation.StudentsList.Where(student => student.Grade >= 50).ToList();
            return Ok(passedStudents); // Return the list of students who passed.
        }


        [HttpGet("AverageGrade", Name = "GetAverageGrade")]
        public ActionResult<double> GetAverageGrade()
        {

         //   StudentDataSimulation.StudentsList.Clear();

            if (StudentDataSimulation.StudentsList.Count == 0)
            {
                return NotFound("No students found.");
            }

            var averageGrade = StudentDataSimulation.StudentsList.Average(student => student.Grade);
            return Ok(averageGrade);
        }

    }
}
