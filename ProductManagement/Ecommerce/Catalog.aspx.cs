using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using Domain;

namespace Ecommerce
{
    public partial class Catalog : System.Web.UI.Page
    {
        public List<Product> lista;
        public ProductBusiness prodBuis = new ProductBusiness();
        
        public void setLista()
        {
            lista = prodBuis.listProducts();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            setLista();
            Session.Add("fullList", lista);
        }

    }
}