using PrasadModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeDAL : IEmployee
    {
        EmployeeContext context;
        public EmployeeDAL() 
        {
            context= new EmployeeContext();
        }
        public ICollection<Employee> GetAll()
        {
            ICollection<Employee> prlist = context.Employees.ToList();
            return prlist;
        }

        public Employee Insert(Employee employee)
        {
            Employee pr = context.Employees.Add(employee);
            context.SaveChanges();
            return pr;
        }

        public Employee Remove(string rmemp)
        {
            var emp = (from x in context.Employees
                       where x.EmployeeFirstName == rmemp
                       select x).FirstOrDefault();
            context.Employees.Remove(emp);
            context.SaveChanges();
            return emp;
        }
        public Employee GetByName(string name)
        {
            var emp = (from x in context.Employees
                       where x.EmployeeFirstName == name
                       select x).FirstOrDefault();
            return emp; 
        }
    }
}
