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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<IEnumerable<Student>> GetAllStudents() // Define a method to get all students.
        {
            //StudentDataSimulation.StudentsList.Clear();

            if (StudentDataSimulation.StudentsList.Count == 0) 
            {
                return NotFound("No Students Found!");
            }
            return Ok(StudentDataSimulation.StudentsList); // Returns the list of students.
        }

        [HttpGet("Passed",Name = "GetPassedStudents")]

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        // Method to get all students who passed
        public ActionResult<IEnumerable<Student>> GetPassedStudents()

        {
            var passedStudents = StudentDataSimulation.StudentsList.Where(student => student.Grade >= 50).ToList();
            //passedStudents.Clear();

            if (passedStudents.Count == 0)
            {
                return NotFound("No Students Passed");
            }


            return Ok(passedStudents); // Return the list of students who passed.
        }

        [HttpGet("AverageGrade", Name = "GetAverageGrade")]

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

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


        [HttpGet("{id}", Name = "GetStudentById")]
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<Student> GetStudentById(int id)
        {

            if (id < 1)
            {
                return BadRequest($"Not accepted ID {id}");
            }

            var student = StudentDataSimulation.StudentsList.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound($"Student with ID {id} not found.");
            }

            return Ok(student);
        }


    }
}
