using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_CommerceTask.Models
{
    public class Product
    {
        [Key]
        public int productID { get; set; }
        public string productName { get; set; }
        public double price { get; set; }


        // Has Relationships 1 - M
        [ForeignKey("categoryOFproduct")]
        public int categoryID { get; set; }
        public Category categoryOFproduct { get; set; }


        // Contain Relationships M - M
        public List<Order> productsOFOrders { get; set; }


        // M - M Relationships
        public List<OrderProduct> OP { get; set; }
    }
}
