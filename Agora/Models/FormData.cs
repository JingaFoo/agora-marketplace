using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agora.Models
{
    public class FormData
    {
        public IEnumerable<Categories> Categories { get; set; }
        public IEnumerable<Subcategories> Subcategories { get; set; }
        public IEnumerable<ProductCondition> ProductConditions { get; set; }
        public IEnumerable<ProductAvailability> ProductAvailabilities { get; set; }
    }
}