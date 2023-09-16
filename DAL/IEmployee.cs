using PrasadModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IEmployee
    {
        ICollection<Employee> GetAll();
        Employee Insert(Employee employee);
        Employee Remove(string rmemp);
        Employee GetByName(string name);
    }
}
