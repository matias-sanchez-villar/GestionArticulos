using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class Index : System.Web.UI.MasterPage
    {
        public static int CantidadProductos;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Total"] != null)
            {
                CantidadProductos = (int)Session["Total"];
            }
            else
            {
                CantidadProductos = 0;
            }
        }
    }
}