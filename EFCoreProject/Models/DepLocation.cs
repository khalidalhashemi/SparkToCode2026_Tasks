using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreProject.Models
{
    [PrimaryKey(nameof(departmentID), nameof(departmentLocation))]
    public class DepLocation
    {
        [ForeignKey("depart")]
        public int departmentID { get; set; }
        public Department depart {  get; set; }

        public string departmentLocation { get; set; }
    }
}
