using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agora.Models;

namespace Agora.Controllers
{
    public class ElectronicsController : Controller
    {
        private ApplicationDbContext _context;

        public ElectronicsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Electronics
        [Route("Electronics")]
        public ViewResult Electronics()
        {
            var subcat = _context.Subcategories.Where(x => x.CategoryId == 2);
            return View(subcat);
        }

        [Route("Electronics/Smartphones")]
        public ViewResult Smartphones()
        {
            var smartphones = _context.Products.Where(x => x.SubCategoryName == "Smartphones");
            return View(smartphones);
        }
    }
}