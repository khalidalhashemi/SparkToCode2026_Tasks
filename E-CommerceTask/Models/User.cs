using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace E_CommerceTask.Models
{
    public class User
    {
        [Key]
        public int userID { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }
        public string userPassword { get; set; }


        // Place Relationships 1 - M

        public List<Order> orderLists { get; set; }
    }
}
