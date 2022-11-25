using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfEmployee.Models;

namespace WpfEmployee.ViewModels
{
    public class EmployeVM
    {
        private List<EmployeModel> _employeModels;
        private NorthwindContext context = new NorthwindContext();
        public List<EmployeModel> EmployeesList
        {
            get
            {
                //if (_legumesList == null) _legumesList = loadLegumes2();
                //return _legumesList;
                return ConcatName();
            }
        }

        public List<string> ListTitle()
        {
            return liste();
        };
        private List<EmployeModel> ConcatName()
        {
            List<EmployeModel> localCollection = new List<EmployeModel>();
            foreach (var item in context.Employees)
            {
                localCollection.Add(new EmployeModel(item));

            }

            return localCollection;
        }

        private List<string> liste()
        {
            List<string> localCollection = new List<string>();
            foreach (var item in context.Employees)
            {
                foreach (var ti in item.Title)
                {
                    localCollection.Add(ti);
                }

            }

            return localCollection;
        }
    }
}
