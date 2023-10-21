using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace supermarket.Models
{
    internal class CategoriasModel
    {
        [DisplayName("Categoria Id")]
        public int id { get; set; }
        [DisplayName("Categoria Name")]
        [Required(ErrorMessage = "Categoria name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Categoria name must be between 3 and 50 characters")]
        public string name { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Categoria description is required")]
        public string description { get; set; }
    }
}
