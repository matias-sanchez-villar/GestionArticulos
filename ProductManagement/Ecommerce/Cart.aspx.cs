﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Cart"] == null)
            {
                ///Recibimos un objetos de tipo Producto y le pasmos ese objeto a cart.aspx
            }
        }
    }
}