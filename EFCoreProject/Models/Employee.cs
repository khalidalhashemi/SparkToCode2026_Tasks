using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject.Models
{
    public class Employee
    {
        public int employeeID {  get; set; }
        public int employeesSSN { get; set; }
        public string empName { get; set; }
        public int employeeAge { get; set; }
        public double employeeSalary { get; set; }
    }
}
