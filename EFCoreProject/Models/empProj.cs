using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreProject.Models
{
    [PrimaryKey(nameof(employeeID), nameof(projectID))]
    public class empProj
    {
        [ForeignKey("emp")]
        public int employeeID { get; set; }
        public Employee emp {  get; set; }



        [ForeignKey("proj")]
        public int projectID { get; set; }
        public Project proj { get; set; }


        public int Hours { get; set; } // relationship attribute
    }
}
