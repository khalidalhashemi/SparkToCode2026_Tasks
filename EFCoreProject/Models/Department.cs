using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreProject.Models
{
    public class Department
    {
        [Key]
        public int departmentID { get; set; }
        public int departmentNumber { get; set; }
        public string departmentName { get; set; }

        // Works for
        [InverseProperty("depart")]
        public List<Employee> employees { get; set; }


        // Manage
        [ForeignKey("manager")]
        public int employeeID { get; set; }
        public Employee manager { get; set; }
    }
}
