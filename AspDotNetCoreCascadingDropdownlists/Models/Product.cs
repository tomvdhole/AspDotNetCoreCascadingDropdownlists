using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetCoreCascadingDropdownlists.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }  

        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}
