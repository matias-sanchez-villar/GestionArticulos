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
            loadDgv();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProduct addProductDialog = new AddProduct();
            addProductDialog.ShowDialog();
            loadDgv();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            ProductInfoSearch productInfoSearchDialog = new ProductInfoSearch();
            productInfoSearchDialog.ShowDialog();
        }

       

        private void reloadImg(string img)
        {
            pbxProduct.Load(img);
            pbxProduct.SizeMode = PictureBoxSizeMode.StretchImage ;
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
            reloadImg(product.URLimage);
            reloadName(product.Name);
            reloadDescription(product.Description);
        }

        private void loadDgv()
        {
            ProductBusiness ProductBusiness = new ProductBusiness();
            try
            {
                ProductList = ProductBusiness.listProducts();

                dgvProductList.DataSource = ProductList;

                dgvProductList.Columns["ID"].Visible = false;
                dgvProductList.Columns["URLImage"].Visible = false;
                dgvProductList.Columns["Description"].Visible = false;

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            loadDgv();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            Product Selected = (Product)dgvProductList.CurrentRow.DataBoundItem;
            ProductBusiness ProductBusiness = new ProductBusiness();
            try
            {
                if (MessageBox.Show("esto lo hace doro que sabe ingles " + Selected.Name, "Delet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ProductBusiness.DeleteProduct((int)Selected.ID);
                    loadDgv();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }










        }
    }
}
