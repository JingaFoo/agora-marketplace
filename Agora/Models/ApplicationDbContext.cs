using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Agora.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Products> Products { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Filters> Filters { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Subcategories> Subcategories { get; set; }
        public DbSet<ProductCondition> ProductCondition { get; set; }
        public DbSet<ProductAvailability> ProductAvailability { get; set; }
    }
}