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

            Product selected = (Product)dgvProductList.CurrentRow.DataBoundItem;
            ProductInfo formInfo = new ProductInfo(selected);
            formInfo.ShowDialog();
            loadDgv();
        }


        private void reloadImg(string img)
        {
            try
            {
                pbxProduct.Load(img);
            }
            catch (Exception)
            {
                pbxProduct.Load("https://media0.giphy.com/media/UHAYP0FxJOmFBuOiC2/giphy.gif?cid=ecf05e47ev43uz5eifu0arc2qmmeorc2ulc5yglqwzkt6jag&rid=giphy.gif&ct=g");
            }
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

        // Carga la información del data grid view
        private void loadDgv()
        {
            ProductBusiness ProductBusiness = new ProductBusiness();
            try
            {
                ProductList = ProductBusiness.listProducts();

                dgvProductList.DataSource = ProductList;

                hideColumns();
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

        // Actualiza un producto seleccionado
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product selected = (Product)dgvProductList.CurrentRow.DataBoundItem;
            AddProduct UpdateProduct = new AddProduct(selected);
            UpdateProduct.ShowDialog();
            loadDgv();
        }

        // Borra un producto seleccionado
        private void btnDelete_Click(object sender, EventArgs e)
        {

            Product Selected = (Product)dgvProductList.CurrentRow.DataBoundItem;
            ProductBusiness ProductBusiness = new ProductBusiness();
            try
            {
                if (MessageBox.Show("Are you sure you want to delete" + Selected.Name + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void hideColumns()
        {
            dgvProductList.Columns["ID"].Visible = false;
            dgvProductList.Columns["URLImage"].Visible = false;
            dgvProductList.Columns["Description"].Visible = false;
        }

        private void search()
        {
            //txtFiltro
            List<Product> filteredList;
            if (txtSearchBar.Text != "")
            {
                filteredList = this.ProductList.FindAll(toSearch => toSearch.Name.ToUpper().Contains(txtSearchBar.Text.ToUpper()) || toSearch.Brand.Name.ToUpper().Contains(txtSearchBar.Text.ToUpper()) || toSearch.Category.Name.ToUpper().Contains(txtSearchBar.Text.ToUpper()));
                dgvProductList.DataSource = null;
                dgvProductList.DataSource = filteredList;
            }
            else
            {
                dgvProductList.DataSource = null;
                dgvProductList.DataSource = ProductList;
            }

            hideColumns();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            search();
        }
    }
}
