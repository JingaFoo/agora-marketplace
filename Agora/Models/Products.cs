using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Agora.Models
{
    [Table("Products")]
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(255)]
        public string Product { get; set; }
        public string Brand { get; set; }
        public string Image { get; set; }
        public int  Price { get; set; }
        public byte Cents { get; set; }
        public string Condition { get; set; }
        public string Availability { get; set; }
        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }
    }
}