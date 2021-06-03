using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
<<<<<<< HEAD
using Presentation;
=======
>>>>>>> e61b175f4c25ecb15e2d3cbab0d5ab14ef299495
using Domain;

namespace Ecommerce
{
    public partial class Catalog : System.Web.UI.Page
    {
        public List<Product> lista;
<<<<<<< HEAD

=======
>>>>>>> e61b175f4c25ecb15e2d3cbab0d5ab14ef299495
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductBusiness business = new ProductBusiness();
            try
            {
                lista = business.listProducts();
            }
<<<<<<< HEAD
            catch (Exception)
            {
=======
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
>>>>>>> e61b175f4c25ecb15e2d3cbab0d5ab14ef299495
                Response.Redirect("Error.aspx"); // Falta crearla
            }
        }
    }
}