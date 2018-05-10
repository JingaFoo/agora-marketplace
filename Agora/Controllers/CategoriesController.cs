using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agora.Models;

namespace Agora.Controllers
{
    public class CategoriesController : Controller
    {
        private ApplicationDbContext _context;

        public CategoriesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Categories
        [Route("categories")]
        public ViewResult Categories()
        {
            var categories = _context.Categories.ToList();
            return View(categories);
        }
    }
}