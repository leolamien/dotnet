using System.Linq.Expressions;

namespace ex.Nortwind_API.Repository
{
    public class EmployeeRepository : IRepository<EmployeeDTO>
    {
        public Task DeleteAsync(EmployeeDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<IList<EmployeeDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeDTO?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(EmployeeDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool?> SaveAsync(EmployeeDTO entity, Expression<Func<EmployeeDTO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IList<EmployeeDTO>> SearchForAsync(Expression<Func<EmployeeDTO, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
