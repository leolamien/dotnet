using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static List<Student> _students = new List<Student>()
{
new Student { ID = 1, Firstname = "Paul", Lastname = "Ochon", BirthDate = new DateTime(1950, 12, 1) },
new Student { ID = 2, Firstname = "Daisy", Lastname = "Drathey", BirthDate = new DateTime(1970, 12, 1) },
new Student { ID = 3, Firstname = "Elie", Lastname = "Coptaire", BirthDate = new DateTime(1980, 12, 1) }
};
        // GET: api/<ValuesController>
        [HttpGet("students")]
        public IEnumerable<Student> GetAll()
        {
            return _students;
        }

        [HttpPost("student")]
        public ActionResult<Student> Add([FromBody] Student student)
        {
            Student stud = new Student { ID = _students.Count+1, Firstname = student.Firstname, Lastname = student.Lastname, BirthDate = student.BirthDate };
            _students.Add(stud);    

            return Ok(stud);
        }

        [HttpGet("students/{id}")]
        public ActionResult<Student> GetOne([FromQuery] int id)
        {
            Student student =_students.Find((s) => s.ID == id);
            if (student == null)
                return NotFound();
            return Ok(student);
        }
    }
}
