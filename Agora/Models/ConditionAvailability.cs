using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agora.Models
{
    public class ConditionAvailability
    {
        public IEnumerable<ProductCondition> condition { get; set; }
        public IEnumerable<ProductAvailability> availability { get; set; }
    }
}