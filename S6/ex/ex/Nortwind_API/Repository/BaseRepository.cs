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
            await context.SaveChangesAsync();
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
            context.Set<TEntity>().AddAsync(entity);
            await context.SaveChangesAsync();

        }

       async public Task SaveChangesAsync()
        {
            try
            {
                await context.SaveChangesAsync();
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

        public async Task<bool?> SaveAsync(TEntity entity, Expression<Func<TEntity, bool>> predicate)
        {
            TEntity? ent = SearchForAsync(predicate).Result.FirstOrDefault();

            if (ent == null)
            {
                await InsertAsync(entity);
                return true;
            }
            else
            {
               context.Set<TEntity>().Update(entity);
                await SaveChangesAsync();
            }

            return true;
        }
    }
}
