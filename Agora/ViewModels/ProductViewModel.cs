using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Agora.Models;

namespace Agora.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<Products> Products { get; set; }
        public Subcategories SubCategory { get; set; }
    }
}