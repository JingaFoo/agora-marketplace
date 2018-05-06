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
        private ApplicationDbContext _context;

        public FashionController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Fashion
        [Route("fashion")]
        public ActionResult Fashion()
        {
            var products = _context.Products.ToList();

            return View(products);
        }

    }
}