using Microsoft.AspNetCore.Mvc; 
using StudentApi.Models;
using StudentApi.DataSimulation;
using System.Collections.Generic; 

namespace StudentApi.Controllers 
{
    [ApiController] // Marks the class as a Web API controller with enhanced features.
   // [Route("[controller]")] // Sets the route for this controller to "students", based on the controller name.
    [Route("api/Students")]

    public class StudentsController : ControllerBase // Declare the controller class inheriting from ControllerBase.
    {
        
        [HttpGet] // Marks this method to respond to HTTP GET requests.
        public ActionResult<IEnumerable<Student>> GetAllStudents() // Define a method to get all students.
        {
            return Ok(StudentDataSimulation.StudentsList); // Returns the list of students.
        }
    }
}
