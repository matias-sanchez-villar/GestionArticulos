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
        public int Cantidad;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Total"] != null)
            {
                Cantidad = (int)Session["Total"];
                Session.Add("Cantidad", Cantidad);
            }
            else
            {
                Cantidad = 0;
            }
        }
    }
}