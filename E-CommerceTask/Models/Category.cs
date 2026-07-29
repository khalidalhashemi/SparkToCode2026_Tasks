using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace E_CommerceTask.Models
{
    public class Category
    {
        [Key]
        public int categoryID { get; set; }
        public int productID { get; set; }


        // Has Relationships 1 - M

        public List<Product> productCategories { get; set; }
    }
}
