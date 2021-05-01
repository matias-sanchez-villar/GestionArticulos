using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class ProductInfoSearch : Form
    {
        public ProductInfoSearch()
        {
            InitializeComponent();
        }

        private void productSearchBtn_Click(object sender, EventArgs e)
        {
            ProductInfo productInfoDialog = new ProductInfo();
            productInfoDialog.ShowDialog();
        }
    }
}
