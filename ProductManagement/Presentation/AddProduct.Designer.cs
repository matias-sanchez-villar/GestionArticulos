
namespace Presentation
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtBoxCode = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtBoxUrl = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtBoxStock = new System.Windows.Forms.TextBox();
            this.btnAceptAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(121, 31);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxName.MaxLength = 50;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(228, 20);
            this.txtBoxName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(27, 32);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.BackColor = System.Drawing.Color.Transparent;
            this.lblCode.Location = new System.Drawing.Point(27, 67);
            this.lblCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 13);
            this.lblCode.TabIndex = 3;
            this.lblCode.Text = "Code";
            // 
            // txtBoxCode
            // 
            this.txtBoxCode.Location = new System.Drawing.Point(121, 65);
            this.txtBoxCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxCode.MaxLength = 4;
            this.txtBoxCode.Name = "txtBoxCode";
            this.txtBoxCode.Size = new System.Drawing.Size(228, 20);
            this.txtBoxCode.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Location = new System.Drawing.Point(27, 105);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(121, 103);
            this.txtBoxDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxDescription.MaxLength = 150;
            this.txtBoxDescription.Multiline = true;
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(228, 59);
            this.txtBoxDescription.TabIndex = 4;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.BackColor = System.Drawing.Color.Transparent;
            this.lblUrl.Location = new System.Drawing.Point(27, 181);
            this.lblUrl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(61, 13);
            this.lblUrl.TabIndex = 7;
            this.lblUrl.Text = "Image URL";
            // 
            // txtBoxUrl
            // 
            this.txtBoxUrl.Location = new System.Drawing.Point(121, 179);
            this.txtBoxUrl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxUrl.MaxLength = 1000;
            this.txtBoxUrl.Name = "txtBoxUrl";
            this.txtBoxUrl.Size = new System.Drawing.Size(228, 20);
            this.txtBoxUrl.TabIndex = 6;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Location = new System.Drawing.Point(27, 213);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(121, 211);
            this.txtBoxPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(228, 20);
            this.txtBoxPrice.TabIndex = 8;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.Location = new System.Drawing.Point(27, 245);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(35, 13);
            this.lblBrand.TabIndex = 10;
            this.lblBrand.Text = "Brand";
            // 
            // cboBrand
            // 
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Location = new System.Drawing.Point(121, 243);
            this.cboBrand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(228, 21);
            this.cboBrand.TabIndex = 11;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(121, 279);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(228, 21);
            this.cboCategory.TabIndex = 13;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Location = new System.Drawing.Point(27, 281);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 12;
            this.lblCategory.Text = "Category";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.Transparent;
            this.lblStock.Location = new System.Drawing.Point(27, 312);
            this.lblStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 15;
            this.lblStock.Text = "Stock";
            // 
            // txtBoxStock
            // 
            this.txtBoxStock.Location = new System.Drawing.Point(121, 310);
            this.txtBoxStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxStock.Name = "txtBoxStock";
            this.txtBoxStock.Size = new System.Drawing.Size(228, 20);
            this.txtBoxStock.TabIndex = 14;
            // 
            // btnAceptAdd
            // 
            this.btnAceptAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptAdd.Location = new System.Drawing.Point(140, 348);
            this.btnAceptAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptAdd.Name = "btnAceptAdd";
            this.btnAceptAdd.Size = new System.Drawing.Size(115, 30);
            this.btnAceptAdd.TabIndex = 16;
            this.btnAceptAdd.Text = "Add";
            this.btnAceptAdd.UseVisualStyleBackColor = true;
            this.btnAceptAdd.Click += new System.EventHandler(this.btnAceptAdd_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(393, 409);
            this.Controls.Add(this.btnAceptAdd);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtBoxStock);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cboBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtBoxUrl);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtBoxDescription);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtBoxCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBoxName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(409, 448);
            this.MinimumSize = new System.Drawing.Size(409, 448);
            this.Name = "AddProduct";
            this.Text = "Add product";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtBoxCode;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtBoxUrl;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtBoxStock;
        private System.Windows.Forms.Button btnAceptAdd;
    }
}