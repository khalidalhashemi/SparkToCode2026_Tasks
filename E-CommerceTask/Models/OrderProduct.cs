using System;
using System.Collections.Generic;
using System.Text;

namespace E_CommerceTask.Models
{
    public class OrderProduct
    {
        public int productionID { get; set; }
        public int orderID { get; set; }
        public int quantity { get; set; }
    }
}
