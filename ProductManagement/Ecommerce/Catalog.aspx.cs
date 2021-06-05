﻿using System;
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

        protected void Page_Load(object sender, EventArgs e)
        {
            ProductBusiness business = new ProductBusiness();
            try
            {
                if (!IsPostBack)
                {
                    RepeatCatalog.DataSource = business.listProducts();
                    RepeatCatalog.DataBind();
                }
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }

        protected void AddProduct_click(object sender, EventArgs e)
        {

            var argument = ((Button)sender).CommandArgument;

            /*
                Buscamos de la lista de productos,
                El producto con el mismo ID que el argument y
                lo cargamos a un objeto producto 
                para que no sea tan engorroso laburar con listas
             */

            Product Seleccionado = lista.Find(x => x.ID.ToString() == argument);

            /*
                El nombre Producto de la Session es muy generico.
                Ponerle el nombre de a donde va a ir => Ejemplo Modal o MostrarProducto etx
                Para no generar Coches.
             */

            Session.Add("Producto", Seleccionado);

        }
    }
}