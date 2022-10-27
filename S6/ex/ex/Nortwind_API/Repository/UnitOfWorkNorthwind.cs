using ex.Models;

namespace ex.Nortwind_API.Repository
{
    public class UnitOfWorkNorthwind : IUnitOfWorkNorthwind
    {
        private readonly NorthwindContext _context;

        private BaseRepository<Employee> _employeesRepository;


        public UnitOfWorkNorthwind(NorthwindContext context)
        {

            this._context = context;
            this._employeesRepository = new BaseRepository<Employee>(context);

        }

        public IRepository<Employee> EmployeesRepository
        {
            get { return this._employeesRepository; }
        }
    }
}
