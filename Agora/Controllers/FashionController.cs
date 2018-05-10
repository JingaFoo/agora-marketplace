using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using Agora.Models;

namespace Agora.Controllers
{
    public class FashionController : Controller
    {
        private ApplicationDbContext _context;

        public FashionController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Route("fashion")]
        public ViewResult Fashion()
        {
            var subcategories = _context.Subcategories.Where(x => x.CategoryId == 1);
            return View(subcategories);
        }

        [Route("fashion/shoes")]
        public ActionResult Shoes()
        {
            var products = _context.Products.Where(x => x.SubCategoryName == "Shoes");

            return View(products);
        }

    }
}