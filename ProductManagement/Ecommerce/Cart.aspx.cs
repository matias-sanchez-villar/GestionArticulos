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
        public int TotalProductos { get; set; }
        public float PrecioTotal { get; set; }

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
                    TotalProductos += item.Quantity;
                    PrecioTotal += (float)(item.Quantity * item.Product.Price);
                }
                Session.Add("Total", TotalProductos);

                Response.Redirect("Cart.aspx");
            }
        }
    }
}