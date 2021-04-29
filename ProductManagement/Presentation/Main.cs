using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Domain;

namespace Presentation
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private List<Product> ProductList;

        private void Main_Load(object sender, EventArgs e)
        {
            ProductBusiness ProductBusiness = new ProductBusiness();
            try
            {
                ProductList = ProductBusiness.listProducts();

                dgvProductList.DataSource = ProductList;

                dgvProductList.Columns["ID"].Visible =false;

                /*
                    dgvProductList.Columns["URLImagen"].Visible = false;
                    dgvProductList.Columns["URLImagen"].Visible = false;
                 */

                reloadImg(ProductList[0].URLimage);
                reloadName(ProductList[0].Name);
                reloadDescription(ProductList[0].Description);
                
                txtBoxDescription.ReadOnly = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProduct addProductDialog = new AddProduct();
            addProductDialog.ShowDialog();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            ProductInfo productInfoDialog = new ProductInfo();
            productInfoDialog.ShowDialog();
        }

       

        private void reloadImg(string img)
        {
            pbxProduct.Load(img);
        }

        // Recarga el nombre del Label
        private void reloadName(string name)
        {
            lblProductName.Text = name;
        }

        // Recarga la descripcion del pokemon
        private void reloadDescription(string description)
        {
            txtBoxDescription.Text = description;
        }

        private void dgvProductList_Click(object sender, EventArgs e)
        {
            Product product = (Product) dgvProductList.CurrentRow.DataBoundItem;
            reloadImg(ProductList[0].URLimage);
            reloadName(ProductList[0].Name);
            reloadDescription(ProductList[0].Description);
        }
    }
}
