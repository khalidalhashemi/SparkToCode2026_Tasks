using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreProject.Models
{
    public class Project
    {
        [Key]
        public int projectID { get; set; }
        public string projName { get; set; }
        public string projectLocation { get; set; }


        // Works on project M - M
        // public List<Employee> employees { get; set; }


        // M - M with relationship attribute
        public List<empProj> empProjs { get; set; }
    }
}
