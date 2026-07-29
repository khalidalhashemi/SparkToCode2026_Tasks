using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_CommerceTask.Models
{
    [PrimaryKey(nameof(productID), nameof(orderID))]
    public class OrderProduct
    {


        // M - M Relationship

        [ForeignKey("products")]
        public int productID { get; set; }
        public Product products { get; set; }


        [ForeignKey("orders")]
        public int orderID { get; set; }
        public Order orders { get; set; }


        public int quantity { get; set; }
    }
}
