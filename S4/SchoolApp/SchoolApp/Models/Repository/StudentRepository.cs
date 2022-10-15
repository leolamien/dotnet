using School.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace SchoolApp.Models.Repository
{
    class StudentRepository : IRepository<Student>
    {
        private IList<Student> _students;
        public StudentRepository()
        {
            _students = new List<Student>();

        }
        public void Delete(Student entity)
        {
            _students.Remove(entity);
        }

        public IList<Student> GetAll()
        {
            return _students;
        }

        public Student GetById(int id)
        {
            return this._students.Where(s => s.StudentId == id).SingleOrDefault();
        }

        public void Insert(Student entity)
        {
            _students.Add(entity);
        }

        public bool Save(Student entity, Expression<Func<Student, bool>> predicate)
        {
            Student s = (SearchFor(predicate)).FirstOrDefault();

            if (s == null)
            {
                Insert(entity);
                return true;
            }
            //SaveChanges();

            return false;
        }

        public IList<Student> SearchFor(Expression<Func<Student, bool>> predicate)
        {
            return this._students.AsQueryable().Where(predicate).ToList();

        }
    }
}
