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
    public partial class Cart : System.Web.UI.Page
    {
        public ListCart cartlist;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            /*
                Aca lo que estoy intentando hacer es recibir un producto casterarlo a Carrito,
                Si el producto que esta dentro del carrito existe, aumentarle la cantidad,
                y sino agregarlo a la lista del carrito.
            */

            if (Session["Cart"] == null)
            {
                cartlist = new ListCart();
            }
            else
            {
                Cart cart = (Cart)Session["Cart"];

                //cartlist.Modificar(cart);
            }

        }
    }
}