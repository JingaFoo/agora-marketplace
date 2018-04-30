using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agora.Models;

namespace Agora.Controllers
{
    public class FashionController : Controller
    {
        // GET: Fashion
        [Route("fashion")]
        public ActionResult Fashion()
        {
            var products = new Products
            {
                Name = "adidas",
                Price = 10,
                Image = "https://www.adidas.com/dis/dw/image/v2/aaqx_prd/on/demandware.static/-/Sites-adidas-products/en_US/dw7be84d16/zoom/C77153_01_standard.jpg"
            };
            return View(products);
        }
    }
}