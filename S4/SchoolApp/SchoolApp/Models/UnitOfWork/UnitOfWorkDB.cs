using School.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models.UnitOfWork
{
    interface  UnitOfWorkDB
    {
        IRepository<Section> repositorySec { get; }
        IRepository<Student> repositoryStud { get; }


    }
}
