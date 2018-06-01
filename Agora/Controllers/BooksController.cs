using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agora.Models;
using Agora.ViewModels;

namespace Agora.Controllers
{
    public class BooksController : Controller
    {
        private ApplicationDbContext _context;

        public BooksController()
        {
            _context = new ApplicationDbContext();
        }

        [Route("Books")]
        public ViewResult Books()
        {
            var subcat = _context.Subcategories.Where(s => s.CategoryId == 3);
            return View(subcat);
        } 


        // GET: Books
        [Route("Books/Web-development")]
        public ActionResult WebDevelopment()
        {
            var books = _context.Products.Where(b => b.SubCategoryName == "Web-development");
            var subcat = _context.Subcategories.SingleOrDefault(s => s.SubcategoryId == 5);

            var viewModel = new ProductViewModel
            {
                Products = books,
                SubCategory = subcat
            };

            return View("~/Views/ProductList/ProductList.cshtml", viewModel);
        }
    }
}