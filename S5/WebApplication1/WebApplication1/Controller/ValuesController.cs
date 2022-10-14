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
        public Student Add([FromBody] string Firstname, [FromBody] string Lastname, [FromBody] DateTime BirthDate)
        {
            Student student = new Student { ID = _students.Count+1, Firstname = Firstname, Lastname = Lastname, BirthDate = BirthDate };


            return student;
        }

        [HttpGet("students/{id}")]
        public Student GetOne([FromQuery] int id)
        {
            Student student =_students.Find((s) => s.ID == id);
            if (student == null)
                return null;
            return student;
        }
    }
}
