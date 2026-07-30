using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_CommerceTask.Models
{
    public class Order
    {
        [Key]
        public int orderID { get; set; }
        public DateTime orderDate { get; set; }


        // Place Relationships 1 - M
        [ForeignKey("userOrder")]
        public int userID { get; set; }
        public User userOrder { get; set; }


        // Have relationships 1 - 1
        public Review orderOFReview { get; set; }


        // Contain Relationships M - M
        public List<Product> productsOrders { get; set; }


        // M - M Relationship
        public List<OrderProduct> OP { get; set; }
    }
}
