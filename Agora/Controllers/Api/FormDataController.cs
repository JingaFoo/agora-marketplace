using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Agora.Models;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Agora.Controllers.Api
{
    [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
    public class FormDataController : ApiController
    {
        private ApplicationDbContext _context;
        
        public FormDataController()
        {
            _context = new ApplicationDbContext();
        }

        public FormData GetFormData()
        {
            var categories = _context.Categories;
            var subcategories = _context.Subcategories;
            var productConditions = _context.ProductCondition;
            var productAvailabilities = _context.ProductAvailability;
            var formData = new FormData()
            {
                Categories = categories,
                Subcategories = subcategories,
                ProductConditions = productConditions,
                ProductAvailabilities = productAvailabilities
            };

            return formData;
        }
    }
}
