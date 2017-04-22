using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AromaStock.Models
{
    public class ProductRepository
    {
        private ProductContext context = new ProductContext();

        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}