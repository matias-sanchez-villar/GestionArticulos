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
        public List<Carrito> cartlist;
        public List<Product> list;
        public int total = 0;
        public float precioTotal = 0;
        public int cantidadProductos;

        protected void Page_Load(object sender, EventArgs e)
        {
            list = (List<Product>)Session["fullList"];

            if (Session["Cart"] == null)
            {
                cartlist = new List<Carrito>();
            }
            else
            {
                cartlist = (List<Carrito>)Session["Cart"];
            }

            if (Request.QueryString["id"] != null)
            {

                int id = int.Parse(Request.QueryString["id"]);
                Product prod = list.Find(x => x.ID == id);

                if(Request.QueryString["r"] == null)
                {
                    if (cartlist.Find(x => x.Product.ID == id) == null)
                    {
                        Carrito aux = new Carrito(prod);
                        cartlist.Add(aux);
                        Session.Add("Cart", cartlist);
                    }
                    else
                    {
                        Carrito item = cartlist.Find(x => x.Product.ID == id);
                        item.aumentar();
                        Session.Add("Cart", cartlist);
                    }
                }
                else
                {
                    Carrito item = cartlist.Find(x => x.Product.ID == id);
                    item.restar();
                    if(item.Quantity == 0)
                    {
                        cartlist.Remove(item);
                    }
                    Session.Add("Cart", cartlist);
                }
                foreach (Carrito item in cartlist)
                {
                    total += item.Quantity;
                    precioTotal += (float)(item.Quantity * item.Product.Price);
                }
                Session.Add("Total", total);
                Response.Redirect("Cart.aspx");
                if (Session["Cantidad"] != null)
                {
                    cantidadProductos = (int)Session["Cantidad"];
                }
                else
                {
                    cantidadProductos = 0;
                }
            }
        }
    }
}