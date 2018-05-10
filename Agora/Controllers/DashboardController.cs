using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agora.Models;
using Agora.ViewModels;

namespace Agora.Controllers
{
    public class DashboardController : Controller
    {
        private ApplicationDbContext _context;

        public DashboardController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Dashboard
        [Route("dashboard")]
        public ActionResult Dashboard()
        {
            return View();
        }

        [Route("dashboard/create")]
        public ActionResult New()
        {
            var categories = _context.Categories.ToList();
            var subcat = _context.Subcategories.ToList();
            var condition = _context.ProductCondition.ToList();
            var viewModel = new ProductFormViewModel
            {
                Categories = categories,
                Subcategories = subcat,
                ProductCondition = condition
            };

            return View("ProductForm", viewModel);
        }



        [Route("dashboard/manage")]
        public ActionResult Manage()
        {
            var products = _context.Products.ToList();
            return View(products);
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
                ProductCondition = _context.ProductCondition.ToList()
            };
            return View("ProductForm", viewModel);
        }
    }
}