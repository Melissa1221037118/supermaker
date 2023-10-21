using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace supermarket.Models
{
    internal class ProvidersModel
    {
        [DisplayName("Providers Id")]
        public int id { get; set; }
        [DisplayName("Providers Name")]
        [Required(ErrorMessage = "Providers name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Providers name must be between 3 and 50 characters")]
        public string name { get; set; }

        [DisplayName("Providers Name")]
        [Required(ErrorMessage = "Providers description is required")]
        public string description { get; set; }
    }
}
