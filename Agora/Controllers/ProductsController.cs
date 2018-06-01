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
        public ActionResult Save(Products products)
        {
            if(products.ProductId == 0) 
                _context.Products.Add(products);
            else
            {
                var productInDb = _context.Products.Single(p => p.ProductId == products.ProductId);
                productInDb.Brand = products.Brand;
                productInDb.Product = products.Product;
                productInDb.Image = products.Image;
                productInDb.Price = products.Price;
                productInDb.Cents = products.Cents;
                productInDb.CategoryName = products.CategoryName;
                productInDb.SubCategoryName = products.SubCategoryName;
                productInDb.Condition = products.Condition;
                productInDb.Availability = products.Availability;
            }
            _context.SaveChanges();

            return RedirectToAction("Manage", "Manage");
        }

    }
}