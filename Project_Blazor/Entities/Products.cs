using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Products
    {
        [Key]
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int ProductPrice { get; set; }
        [Required]
        public string ProductCategory { get; set; }
        [Required]
        public int ProductStock { get; set; }


    }
}
