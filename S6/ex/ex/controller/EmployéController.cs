using ex.Models;
using ex.Nortwind_API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ex.controller
{

    [ApiController]
    [Route("/api/[controller]")]
    public class EmployéController : ControllerBase
    {
        private readonly NorthwindContext _dbcontext;
        private readonly IUnitOfWorkNorthwind _unitOfWorkNorthwind;


        // public EmployeesController(IRepository<Employee> employeesRepository)
        // add service ? unitofwork
        public EmployéController()
        {
            _dbcontext = new NorthwindContext();
            _unitOfWorkNorthwind = new UnitOfWorkNorthwind(_dbcontext);
        }

        [HttpGet]
        public async Task<IList<EmployeeDTO>> GetEmployeesAsync()
        {
            IList<Employee> lst = await _unitOfWorkNorthwind.EmployeesRepository.GetAllAsync();
            return lst.Select(e => EmployeeToDTO(e)).ToList();
        }

        [HttpPost]
        public async Task InsertEmployeesAsync(EmployeeDTO employeeDTO)
        {
            // assure that id is not set to avoid error with autoincrement in database
            employeeDTO.EmployeeId = 0;
            Employee e = DTOToEmployee(employeeDTO);
            await _unitOfWorkNorthwind.EmployeesRepository.InsertAsync(e);
        }

        [HttpPut]

        public async Task UpdateEmployeeAsync(EmployeeDTO employeeDTO)
        {
            Employee e = DTOToEmployee(employeeDTO);
            await _unitOfWorkNorthwind.EmployeesRepository.SaveAsync(e, emp => emp.EmployeeId == employeeDTO.EmployeeId);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeAsync(int id)
        {
            Employee? emp = await _unitOfWorkNorthwind.EmployeesRepository.GetByIdAsync(id);
            if (emp == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(EmployeeToDTO(emp));
            }

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployeeAsync(int id)
        {
            Employee? emp = await _unitOfWorkNorthwind.EmployeesRepository.GetByIdAsync(id);
            if (emp == null)
            {
                return NotFound();
            }
            else
            {
                await _unitOfWorkNorthwind.EmployeesRepository.DeleteAsync(emp);
                return Ok();
            }

        }


        private static EmployeeDTO EmployeeToDTO(Employee emp) =>
           new EmployeeDTO
           {
               EmployeeId = emp.EmployeeId,
               LastName = emp.LastName,
               FirstName = emp.FirstName,
               BirthDate = emp.BirthDate,
               HireDate = emp.HireDate,
               Title = emp.Title,
               TitleOfCourtesy = emp.TitleOfCourtesy

           };

        private static Employee DTOToEmployee(EmployeeDTO emp) =>
            new Employee
            {
                EmployeeId = emp.EmployeeId,
                LastName = emp.LastName,
                FirstName = emp.FirstName,
                BirthDate = emp.BirthDate,
                HireDate = emp.HireDate,
                Title = emp.Title,
                TitleOfCourtesy = emp.TitleOfCourtesy
            };
    }
}