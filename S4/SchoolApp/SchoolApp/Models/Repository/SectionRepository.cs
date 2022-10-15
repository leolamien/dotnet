using School.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models.Repository
{
    class SectionRepository : IRepository<Section>
    {
        private List<Section> _sections;

        public SectionRepository()
        {
            _sections = new List<Section>();  
        }
        public void Delete(Section entity)
        {
            _sections.Remove(entity);
        }

        public IList<Section> GetAll()
        {
            return _sections;
        }

        public Section? GetById(int id)
        {
           return _sections.Find((sec)=>sec.SectionId==id);
        }

        public void Insert(Section entity)
        {
            _sections.Add(entity);
        }

        public bool Save(Section entity, Expression<Func<Section, bool>> predicate)
        {
            Section s = SearchFor(predicate).SingleOrDefault();

            if (s == null)
            {
                Insert(entity);

            }
            return true;
        }

        public IList<Section> SearchFor(Expression<Func<Section, bool>> predicate)
        {
            return this._sections.AsQueryable().Where(predicate).ToList();

        }
    }
}
