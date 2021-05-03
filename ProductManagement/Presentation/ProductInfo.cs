using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Business;

namespace Presentation
{
    public partial class ProductInfo : Form
    {
        Product product = null;

        public ProductInfo()
        {
            InitializeComponent();
            txtDescriptionFill.ReadOnly = true;
        }

        public ProductInfo(Product prodAux)
        {
            InitializeComponent();
            txtDescriptionFill.ReadOnly = true;
            product = prodAux;
            fillInfo(prodAux);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void fillInfo(Product prodAux)
        {

            if (prodAux != null)
            {

                PbxImageFill.Load(prodAux.URLimage);
                lblNameFill.Text = prodAux.Name.ToString();
                lblPriceFill.Text = prodAux.Price.ToString();
                lblBrandFill.Text = prodAux.Brand.ToString();
                lblCategoryfill.Text = prodAux.Category.ToString();
                lblStockFill.Text = prodAux.Quantity.ToString();
                txtDescriptionFill.Text = prodAux.Description.ToString();
            }
            else
            {
                PbxImageFill.Load("https://media0.giphy.com/media/UHAYP0FxJOmFBuOiC2/giphy.gif?cid=ecf05e47ev43uz5eifu0arc2qmmeorc2ulc5yglqwzkt6jag&rid=giphy.gif&ct=g");
                lblNameFill.Text = "Name not found";
                lblPriceFill.Text = "Price not found";
                lblBrandFill.Text ="Brand not found";
                lblCategoryfill.Text = "Category not found";
                lblStockFill.Text = "Stock not found";
                txtDescriptionFill.Text = "Description not found, but the answer is in your heart <3";
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ProductBusiness ProductBusiness = new ProductBusiness();
            try
            {
                if (MessageBox.Show("Are you sure you want to delete" + product.Name + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ProductBusiness.DeleteProduct((int)product.ID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show(product.Name + " was successfully deleted");
                this.Close();
            }
        }
    }
}
