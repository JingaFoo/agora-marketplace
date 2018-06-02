﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Cors;
using Agora.Models;

namespace Agora.Controllers.Api
{
    [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
    public class ProductsController : ApiController
    {
        private ApplicationDbContext _context;

        public ProductsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/products
        public IEnumerable<Products> GetProducts()
        {
            return _context.Products.ToList();
        }

        // GET /api/products/id
        public Products GetProduct(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.ProductId == id);

            if (product == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return product;
        }

        // POST /api/products
        [HttpPost]
        public Products CreateProduct(Products product)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Products.Add(product);
            _context.SaveChanges();

            return product;
        }

        // PUT /api/products/id
        public void UpdateProduct(int id, Products product)
        {

            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var productInDb = _context.Products.SingleOrDefault(p => p.ProductId == id);

            if (productInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            productInDb.Brand = product.Brand;
            productInDb.Product = product.Product;
            productInDb.Image = product.Image;
            productInDb.Price = product.Price;
            productInDb.Cents = product.Cents;
            productInDb.CategoryName = product.CategoryName;
            productInDb.SubCategoryName = product.SubCategoryName;
            productInDb.Condition = product.Condition;
            productInDb.Availability = product.Availability;

            _context.SaveChanges();
        }
    }
}
