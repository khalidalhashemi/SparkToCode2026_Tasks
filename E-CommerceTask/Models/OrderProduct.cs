using System;
using System.Collections.Generic;
using System.Text;

namespace E_CommerceTask.Models
{
    public class OrderProduct
    {
        public int OrderProductID { get; set; }
        public int productID { get; set; }
        public int orderID { get; set; }
        public int quantity { get; set; }
    }
}
