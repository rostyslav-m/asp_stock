using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AromaStock.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductCategoryId { get; set; }
        public string ProductInfo { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductCount { get; set; }
    }
}