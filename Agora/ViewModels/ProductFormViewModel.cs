using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Agora.Models;

namespace Agora.ViewModels
{
    public class ProductFormViewModel
    {
        public IEnumerable<Categories> Categories { get; set; }
        public IEnumerable<Subcategories> Subcategories { get; set; }
        public IEnumerable<ProductCondition> ProductCondition { get; set; }
        public Products Products { get; set; }
    }
}