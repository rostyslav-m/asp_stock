using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AromaStock.Models
{
    public class ProductContext:DbContext
    {
        public ProductContext() : base("DefaultConnection") { }

        public DbSet<Product> Products { get; set; }
    }
}