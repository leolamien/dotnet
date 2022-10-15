using School.Repository;
using SchoolApp.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models.UnitOfWork
{

    class UnitOfWorkMem : UnitOfWorkDB
    {
        private SectionRepository _sectionsRepository;

        private StudentRepository _studentsRepository;

        public UnitOfWorkMem()
        {
            this._sectionsRepository = new SectionRepository();
            this._studentsRepository = new StudentRepository();
        }
      
        public IRepository<Section> repositorySec
        {
            get { return this._sectionsRepository; }
        }

        public IRepository<Student> repositoryStud {
            get { return this._studentsRepository; }
                }
    }
}
