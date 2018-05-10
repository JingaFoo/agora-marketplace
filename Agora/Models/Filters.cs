using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Agora.Models
{
    [Table("Filters")]
    public class Filters
    {
        [Key]
        public int FilterId { get; set; }
        public string FilterName { get; set; }
        public string FilterDescription { get; set; }
    }
}