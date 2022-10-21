using ex.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ex.Nortwind_API.Repository
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        NorthwindContext context = new NorthwindContext();

        public BaseRepository(NorthwindContext dbContext)
        {
            context = dbContext;
        }

       async public Task DeleteAsync(TEntity entity)
        {
             context.Set<TEntity>().Remove(entity);
        }

         async public Task<IList<TEntity>> GetAllAsync()
        {
            IList<TEntity> lst = await context.Set<TEntity>().ToListAsync();
            return lst;
        }

        async public  Task<TEntity?> GetByIdAsync(int id)
        {
            return await context.Set<TEntity>().FindAsync(id);
        }

       async  public Task InsertAsync(TEntity entity)
        {
           await context.Set<TEntity>().AddAsync(entity);

        }

       async public Task<bool?> SaveAsync(TEntity entity, Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                await context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateException ex)
            {

                throw new DbUpdateException(ex.InnerException.Message);
            }
        }

       async public Task<IList<TEntity>> SearchForAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await context.Set<TEntity>().Where(predicate).ToListAsync();
        }
    }
}
