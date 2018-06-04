using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agora.Models
{
    public class AllCategories
    {
        public IEnumerable<Categories> categories { get; set; }
        public IEnumerable<Subcategories> subcategories { get; set; }
    }
}