using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agora.Models;
using Agora.ViewModels;

namespace Agora.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext _context;

        public ProductsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpPost]
        public ActionResult Create(Products products)
        {
            _context.Products.Add(products);
            _context.SaveChanges();

            return RedirectToAction("Manage", "Dashboard");
        }

    }
}