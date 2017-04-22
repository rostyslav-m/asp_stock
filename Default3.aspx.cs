using AromaStock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AromaStock
{
    public partial class Default : Page
    {

        private ProductRepository repository = new ProductRepository();

        protected IEnumerable<Product> GetProducts()
        {
            return repository.Products;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}