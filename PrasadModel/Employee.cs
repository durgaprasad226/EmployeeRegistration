using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrasadModel
{
    public class Employee
    {
        [Required]
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        [Required]
        public string EmployeeGender { get; set; }
        public string EmployeeEmail { get; set; }
        [Required]
        [Key]
        public double EmployeeMobile { get; set; }
    }
}
