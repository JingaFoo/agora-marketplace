using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Agora.Models
{
    public class ProductCondition
    {
        [Key]
        public int ConditionId { get; set; }
        public string ConditionType { get; set; }
    }
}