using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agora.Models
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }
        public byte  Price { get; set; }
    }
}