using Microsoft.AspNetCore.Mvc;
using StudentModels;
using System.Threading;
using System.Threading.Tasks;

namespace StudentApi.Controllers
{
    [ApiController] // Marks the class as a Web API controller with enhanced features.
    [Route("api/Students")]

    public class StudentsController : ControllerBase // Declare the controller class inheriting from ControllerBase.
    {

        [HttpGet("All", Name = "GetAllStudents")] // Marks this method to respond to HTTP GET requests.
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        //here we used StudentDTO
        public async Task<ActionResult<IEnumerable<StudentDTO>>> GetAllStudents(CancellationToken ct) // Define a method to get all students.
        {
            var studentsList = await StudentAPIBusinessLayer.StudentLogic.GetAllStudentsAsync(ct);
            if (studentsList.Count == 0)
            {
                return NotFound("No Students Found!");
            }
            return Ok(studentsList); // Returns the list of students.

        }

        [HttpGet("Passed", Name = "GetPassedStudents")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        // Method to get all students who passed
        public async Task<ActionResult<IEnumerable<StudentDTO>>> GetPassedStudents(CancellationToken ct)

        {
            var passedStudentsList = await StudentAPIBusinessLayer.StudentLogic.GetPassedStudentsAsync(ct);
            if (passedStudentsList.Count == 0)
            {
                return NotFound("No Students Found!");
            }

            return Ok(passedStudentsList); // Return the list of students who passed.
        }

        [HttpGet("AverageGrade", Name = "GetAverageGrade")]

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<double>> GetAverageGrade(CancellationToken ct)
        {
            double averageGrade = await StudentAPIBusinessLayer.StudentLogic.GetAverageGradeAsync(ct);
            return Ok(averageGrade);
        }


        [HttpGet("{id}", Name = "GetStudentById")]

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<StudentDTO>> GetStudentById(int id, CancellationToken ct)
        {

            if (id < 1)
            {
                return BadRequest($"Not accepted ID {id}");
            }

            var student = await StudentAPIBusinessLayer.StudentLogic.FindAsync(id, ct);

            if (student == null)
            {
                return NotFound($"Student with ID {id} not found.");
            }

            //here we get only the DTO object to send it back.
            var SDTO = student.SDTO;

            //we return the DTO not the student object.
            return Ok(SDTO);

        }

        //for add new we use Http Post

        [HttpPost(Name = "AddStudent")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<StudentDTO>> AddStudent(StudentDTO newStudentDTO, CancellationToken ct)
        {
            //we validate the data here
            if (newStudentDTO == null || string.IsNullOrEmpty(newStudentDTO.Name) || newStudentDTO.Age < 0 || newStudentDTO.Grade < 0)
            {
                return BadRequest("Invalid student data.");
            }

            var student = new StudentAPIBusinessLayer.StudentLogic(new StudentDTO(newStudentDTO.Id, newStudentDTO.Name, newStudentDTO.Age, newStudentDTO.Grade));
            await student.SaveAsync(ct);

            newStudentDTO.Id = student.ID;

            //we return the DTO only not the full student object
            //we dont return Ok here,we return createdAtRoute: this will be status code 201 created.
            return CreatedAtRoute("GetStudentById", new { id = newStudentDTO.Id }, newStudentDTO);

        }



        //here we use http put method for update
        [HttpPut("{id}", Name = "UpdateStudent")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<StudentDTO>> UpdateStudent(int id, StudentDTO updatedStudent, CancellationToken ct)
        {
            if (id < 1 || updatedStudent == null || string.IsNullOrEmpty(updatedStudent.Name) || updatedStudent.Age < 0 || updatedStudent.Grade < 0)
            {
                return BadRequest("Invalid student data.");
            }

            var student = await StudentAPIBusinessLayer.StudentLogic.FindAsync(id, ct);


            if (student == null)
            {
                return NotFound($"Student with ID {id} not found.");
            }


            student.Name = updatedStudent.Name;
            student.Age = updatedStudent.Age;
            student.Grade = updatedStudent.Grade;
            await student.SaveAsync(ct);

            //we return the DTO not the full student object.
            return Ok(student.SDTO);

        }


        //here we use HttpDelete method
        [HttpDelete("{id}", Name = "DeleteStudent")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> DeleteStudent(int id, CancellationToken ct)
        {
            if (id < 1)
            {
                return BadRequest($"Not accepted ID {id}");
            }

            if (await StudentAPIBusinessLayer.StudentLogic.DeleteStudentAsync(id, ct))

                return Ok($"Student with ID {id} has been deleted.");
            else
                return NotFound($"Student with ID {id} not found. no rows deleted!");
        }

    }
}
