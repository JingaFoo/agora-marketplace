using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Agora.Models
{
    public class ProductAvailability
    {
        [Key]
        public int ProductAvailabilityId { get; set; }
        public string ProductAvailabilityType { get; set; }
    }
}