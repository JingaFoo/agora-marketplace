using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agora.Models;
using Agora.ViewModels;

namespace Agora.Controllers
{
    public class ManageController : Controller
    {
        private ApplicationDbContext _context;

        public ManageController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Manage
        [Route("manage")]
        public ActionResult Manage()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        [Route("manage/create")]
        public ActionResult New()
        {
            var categories = _context.Categories.ToList();
            var subcat = _context.Subcategories.ToList();
            var condition = _context.ProductCondition.ToList();
            var availability = _context.Availability.ToList();
            var viewModel = new ProductFormViewModel
            {
                Categories = categories,
                Subcategories = subcat,
                ProductCondition = condition,
                Availability = availability
            };

            return View("ProductForm", viewModel);
        }

        public ActionResult Edit(int productId)
        {
            var products = _context.Products.SingleOrDefault(c => c.ProductId == productId);

            if (products == null)
                return HttpNotFound();

            var viewModel = new ProductFormViewModel
            {
                Products = products,
                Categories = _context.Categories.ToList(),
                Subcategories = _context.Subcategories.ToList(),
                ProductCondition = _context.ProductCondition.ToList(),
                Availability = _context.Availability.ToList()
            };
            return View("ProductForm", viewModel);
        }

        [HttpPost]
        public ActionResult Remove(int productId)
        {
            var product = _context.Products.SingleOrDefault(c => c.ProductId == productId);

            if (product == null)
                return HttpNotFound();

            _context.Products.Remove(product);
            _context.SaveChanges();
            return RedirectToAction("Manage", "Manage");
        }

    }
}