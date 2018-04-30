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
    }
}