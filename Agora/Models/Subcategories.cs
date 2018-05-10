using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Agora.Models
{
    [Table("Subcategories")]
    public class Subcategories
    {
        [Key]
        public int SubcategoryId { get; set; }
        public int CategoryId { get; set; }
        public string SubcategoryName { get; set; }
    }
}