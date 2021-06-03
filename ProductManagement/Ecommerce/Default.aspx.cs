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
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<Product> lista;

        protected void Page_Load(object sender, EventArgs e)
        {
            ProductBusiness business = new ProductBusiness();
            try
            {
                lista = business.listProducts();
            }
            catch (Exception ex)
            {
<<<<<<< HEAD
=======
                Session.Add("Error", ex.ToString());
>>>>>>> e61b175f4c25ecb15e2d3cbab0d5ab14ef299495
                Response.Redirect("Error.aspx"); // Falta crearla
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}