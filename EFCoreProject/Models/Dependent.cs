using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreProject.Models
{
    public class Dependent
    {
        [Key]
        public int dependentId { get; set; }
        public string dependentName { get; set; }
        public string relationship { get; set; }


        // Dependent 

        [ForeignKey("employee")]
        public int employeeID { get; set; }
        public Employee employee { get; set; }
    }
}
