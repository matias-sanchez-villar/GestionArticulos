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
    public partial class AddProduct : Form
    {
        private Product product = null;

        public AddProduct()
        {
            InitializeComponent();
        }

        public AddProduct(Product update)
        {
            InitializeComponent();
            this.btnAceptAdd.Text = "Update";

            product = update;

            Text = "Product - Update Product";

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            // Fills combo box of Brand and Category
            ProductBusiness businessAux = new ProductBusiness();

            try
            {
                cboBrand.DataSource = businessAux.listBrands();
                cboCategory.DataSource = businessAux.listCategory();

                if(product != null)
                {
                    this.txtBoxCode.Text = product.Code.ToString();
                    this.txtBoxName.Text = product.Name.ToString();
                    this.txtBoxDescription.Text = product.Description.ToString();
                    this.cboBrand.SelectedItem = product.Brand.ToString();
                    this.cboCategory.SelectedItem = product.Category.ToString();
                    this.txtBoxUrl.Text = product.URLimage.ToString();
                    this.txtBoxPrice.Text = product.Price.ToString();
                    this.txtBoxStock.Text = product.Quantity.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnAceptAdd_Click(object sender, EventArgs e)
        {
            ProductBusiness toAddOrUpdate = new ProductBusiness();

                try
                {
                if (product == null)
                    product = new Product();

                    product.Code = (string)txtBoxCode.Text;
                    product.Name = (string)txtBoxName.Text;
                    product.Description = (string)txtBoxDescription.Text;
                    product.Brand = (Brand)cboBrand.SelectedItem;
                    product.Category = (Category)cboCategory.SelectedItem;
                    product.URLimage = (string)txtBoxUrl.Text;
                    product.Price = decimal.Parse(txtBoxPrice.Text);
                    product.Quantity = int.Parse(txtBoxStock.Text);

                if(product.ID == 0)
                {
                    toAddOrUpdate.addProduct(product);
                    MessageBox.Show("Product successfully added");
                }
                else
                {
                    toAddOrUpdate.updateProduct(product);
                    MessageBox.Show("Product successfully updated");

                }
                    this.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }

            
        }



    }
}
