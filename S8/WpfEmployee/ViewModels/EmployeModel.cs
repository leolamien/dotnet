using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfEmployee.Models;

namespace WpfEmployee.ViewModels
{
    public class EmployeModel
    {
        private readonly Employee _employe;


        public EmployeModel(Employee employe)
        {
            _employe = employe;
        }

        public int EmployeeId { get { return _employe.EmployeeId; } set { } }
        public string LastName { get { return _employe.LastName; } set { } }
        public string FirstName { get { return _employe.FirstName; } set { } }

        public DateTime? DisplayBirthDate { get { return _employe.BirthDate; } set { } }
        public DateTime? BirthDate { get { return _employe.BirthDate; } set { } }

        public DateTime? HireDate { get { return _employe.HireDate; } set { } }


        public string? Title { get { return _employe.Title; } set { } }

        public string? TitleOfCourtesy { get { return _employe.TitleOfCourtesy; } set { } }
        public string[] ListTitle { get { return _employe.TitleOfCourtesy; } set { } }

        public string FullName { get { return String.Concat(_employe.FirstName+" " ,  _employe.LastName); } set { } }




    }
}
