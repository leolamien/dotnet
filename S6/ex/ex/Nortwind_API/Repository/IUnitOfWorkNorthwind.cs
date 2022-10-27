using ex.Models;

namespace ex.Nortwind_API.Repository
{
    public interface IUnitOfWorkNorthwind
    {
        IRepository<Employee> EmployeesRepository { get; }
    }
}
