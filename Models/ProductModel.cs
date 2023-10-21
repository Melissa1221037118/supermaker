using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace supermarket.Models
{
    internal class ProductModel
    {
        [DisplayName("Product Id")]
        public int id { get; set; }
        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product name must be between 3 and 50 characters")]
        public string name { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product price is required")]
        public int price { get; set; }
        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product price is required")]
        public int stock { get; set; }
        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product price is required")]
        public int category_id { get; set; }

    }
}
