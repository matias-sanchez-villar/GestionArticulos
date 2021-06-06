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
    public partial class Detalle : System.Web.UI.Page
    {
        int id;
        public List<Product> listAux;
        public Product prodAux;

        protected void Page_Load(object sender, EventArgs e)
        {
            id = int.Parse(Request.QueryString["id"]);
            listAux = (List<Product>)Session["fullList"];
            prodAux = listAux.Find(x => x.ID == id);
        }
    }
}