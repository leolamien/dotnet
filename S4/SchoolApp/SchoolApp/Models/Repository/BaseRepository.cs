using Microsoft.EntityFrameworkCore;
using School.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models.Repository
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly SchoolContext _dbContext;
        public BaseRepository(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            SaveChanges();
        }

        private void SaveChanges()
        {
            try
            {
                _dbContext.SaveChanges();
            }
            catch (DbUpdateException ex)
            {

                throw new DbUpdateException(ex.InnerException.Message);
            }
        }

        public bool Save(TEntity entity, Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
