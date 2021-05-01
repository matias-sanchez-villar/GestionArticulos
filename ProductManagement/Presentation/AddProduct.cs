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
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            // Fills combo box of Brand and Category
            ProductBusiness businessAux = new ProductBusiness();

            try
            {
                cboBrand.DataSource = businessAux.listBrands();
                cboCategory.DataSource = businessAux.listCategory();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }


        private void btnAceptAdd_Click(object sender, EventArgs e)
        {
            Product prodAux = new Product();
            ProductBusiness toAdd = new ProductBusiness();

            try
            {

                prodAux.Code = (string)txtBoxCode.Text;
                prodAux.Name = (string)txtBoxName.Text;
                prodAux.Description = (string)txtBoxDescription.Text;
                prodAux.Brand = (Brand)cboBrand.SelectedItem;
                prodAux.Category = (Category)cboCategory.SelectedItem;
                prodAux.URLimage = (string)txtBoxUrl.Text;
                prodAux.Price = decimal.Parse(txtBoxPrice.Text);
                prodAux.Quantity = int.Parse(txtBoxStock.Text);

                toAdd.addProduct(prodAux);

                MessageBox.Show("Product successfully added");
                this.Close();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
            }
        }



    }
}
