using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Agora.Models;

namespace Agora.Controllers.Api
{
    [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
    public class CategoriesController : ApiController
    {
        private ApplicationDbContext _context;

        public CategoriesController()
        {
            _context = new ApplicationDbContext();
        }

        public AllCategories GetCategories()
        {
            var categories = _context.Categories;
            var subcategories = _context.Subcategories;

            var AllCategories = new AllCategories()
            {
                categories = categories,
                subcategories = subcategories
            };

            return AllCategories;
        }

    }
}
