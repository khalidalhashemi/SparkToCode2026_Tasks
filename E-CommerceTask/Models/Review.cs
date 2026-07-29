using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_CommerceTask.Models
{
    public class Review
    {
        [Key]
        public int reviewID { get; set; }
        public string rating { get; set; }
        public string comments { get; set; }


        // Have relationships 1 - 1
        [ForeignKey("orderReview")]
        public int orderID { get; set; }
        public Order orderReview { get; set; }

    }
}
