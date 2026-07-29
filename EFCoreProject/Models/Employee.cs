using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreProject.Models
{
    public class Employee
    {
        [Key]
        public int employeeID {  get; set; }
        public int employeesSSN { get; set; }
        public string empName { get; set; }
        public int employeeAge { get; set; }
        public double employeeSalary { get; set; }


        // Works for 1 - M

        [ForeignKey("depart")]
        public int departmentID { get; set; }
        public Department depart {  get; set; }


        // Manage
        [InverseProperty("manager")]
        public Department managedDepart { get; set; }




        // Dependent 1 - 1
        public Dependent dependent { get; set; }


        // Works on project M - M
       // public List<Project> projects { get; set; }


        // M - M with relationship attribute
        public List<empProj> empProjs { get; set; }


        // Supervision
        [InverseProperty("supervisor")]
        public List<Employee> supervisee { get; set; }

        [ForeignKey("supervisor")]
        public int superviseID { get; set; }
        public Employee supervisor { get; set; }

    }
}
