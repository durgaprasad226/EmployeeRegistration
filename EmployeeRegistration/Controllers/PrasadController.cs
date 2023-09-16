using DAL;
using PrasadModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeRegistration.Controllers
{
    public class PrasadController : ApiController
    {
        IEmployee iemp = null;
        EmployeeContext empcon = null;
        public PrasadController()
        {
            iemp = new EmployeeDAL();
            empcon = new EmployeeContext();
        }
        
        
        public HttpResponseMessage GetAllEmployees()
        {
            ICollection<Employee> prlist = iemp.GetAll();
            return Request.CreateResponse(HttpStatusCode.OK,prlist);
        }
        [HttpPost]
        public HttpResponseMessage AddEmployees(Employee emp)
        {
            Employee pr=iemp.Insert(emp);
            return Request.CreateResponse(HttpStatusCode.OK, pr);
        }
        public HttpResponseMessage GetEmployeeByName(string empName)
        {
            Employee gebn=iemp.GetByName(empName);
            return Request.CreateResponse(HttpStatusCode.Found, gebn);
        }
        public HttpResponseMessage DeleteEmployeeByName(string empName)
        {
            Employee del=iemp.Remove(empName);
            return Request.CreateResponse(HttpStatusCode.OK, del);
        }
    }
}
