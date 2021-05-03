
namespace Presentation
{
    partial class ProductInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfo));
            this.PbxImageFill = new System.Windows.Forms.PictureBox();
            this.lblNameFill = new System.Windows.Forms.Label();
            this.lblPriceFill = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblCategori = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtDescriptionFill = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblBrandFill = new System.Windows.Forms.Label();
            this.lblCategoryfill = new System.Windows.Forms.Label();
            this.lblStockFill = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImageFill)).BeginInit();
            this.SuspendLayout();
            // 
            // PbxImageFill
            // 
            this.PbxImageFill.Image = ((System.Drawing.Image)(resources.GetObject("PbxImageFill.Image")));
            this.PbxImageFill.Location = new System.Drawing.Point(87, 55);
            this.PbxImageFill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PbxImageFill.Name = "PbxImageFill";
            this.PbxImageFill.Size = new System.Drawing.Size(247, 178);
            this.PbxImageFill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxImageFill.TabIndex = 0;
            this.PbxImageFill.TabStop = false;
            // 
            // lblNameFill
            // 
            this.lblNameFill.AutoSize = true;
            this.lblNameFill.BackColor = System.Drawing.Color.Transparent;
            this.lblNameFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblNameFill.Location = new System.Drawing.Point(83, 261);
            this.lblNameFill.Name = "lblNameFill";
            this.lblNameFill.Size = new System.Drawing.Size(128, 20);
            this.lblNameFill.TabIndex = 1;
            this.lblNameFill.Text = "Product Name";
            // 
            // lblPriceFill
            // 
            this.lblPriceFill.AutoSize = true;
            this.lblPriceFill.BackColor = System.Drawing.Color.Transparent;
            this.lblPriceFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPriceFill.Location = new System.Drawing.Point(311, 261);
            this.lblPriceFill.Name = "lblPriceFill";
            this.lblPriceFill.Size = new System.Drawing.Size(49, 20);
            this.lblPriceFill.TabIndex = 2;
            this.lblPriceFill.Text = "$420";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblBrand.Location = new System.Drawing.Point(83, 300);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(65, 20);
            this.lblBrand.TabIndex = 3;
            this.lblBrand.Text = "Brand:";
            // 
            // lblCategori
            // 
            this.lblCategori.AutoSize = true;
            this.lblCategori.BackColor = System.Drawing.Color.Transparent;
            this.lblCategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategori.Location = new System.Drawing.Point(83, 338);
            this.lblCategori.Name = "lblCategori";
            this.lblCategori.Size = new System.Drawing.Size(90, 20);
            this.lblCategori.TabIndex = 4;
            this.lblCategori.Text = "Category:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.Location = new System.Drawing.Point(83, 377);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(81, 20);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "In stock:";
            // 
            // txtDescriptionFill
            // 
            this.txtDescriptionFill.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDescriptionFill.Enabled = false;
            this.txtDescriptionFill.Location = new System.Drawing.Point(73, 425);
            this.txtDescriptionFill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescriptionFill.Multiline = true;
            this.txtDescriptionFill.Name = "txtDescriptionFill";
            this.txtDescriptionFill.Size = new System.Drawing.Size(260, 187);
            this.txtDescriptionFill.TabIndex = 7;
            // 
            // btnOk
            // 
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Location = new System.Drawing.Point(73, 638);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(92, 36);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(242, 638);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 36);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblBrandFill
            // 
            this.lblBrandFill.AutoSize = true;
            this.lblBrandFill.BackColor = System.Drawing.Color.Transparent;
            this.lblBrandFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblBrandFill.Location = new System.Drawing.Point(247, 300);
            this.lblBrandFill.Name = "lblBrandFill";
            this.lblBrandFill.Size = new System.Drawing.Size(128, 20);
            this.lblBrandFill.TabIndex = 11;
            this.lblBrandFill.Text = "Product Name";
            // 
            // lblCategoryfill
            // 
            this.lblCategoryfill.AutoSize = true;
            this.lblCategoryfill.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoryfill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategoryfill.Location = new System.Drawing.Point(247, 338);
            this.lblCategoryfill.Name = "lblCategoryfill";
            this.lblCategoryfill.Size = new System.Drawing.Size(128, 20);
            this.lblCategoryfill.TabIndex = 12;
            this.lblCategoryfill.Text = "Product Name";
            // 
            // lblStockFill
            // 
            this.lblStockFill.AutoSize = true;
            this.lblStockFill.BackColor = System.Drawing.Color.Transparent;
            this.lblStockFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblStockFill.Location = new System.Drawing.Point(247, 377);
            this.lblStockFill.Name = "lblStockFill";
            this.lblStockFill.Size = new System.Drawing.Size(128, 20);
            this.lblStockFill.TabIndex = 13;
            this.lblStockFill.Text = "Product Name";
            // 
            // ProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(412, 692);
            this.Controls.Add(this.lblStockFill);
            this.Controls.Add(this.lblCategoryfill);
            this.Controls.Add(this.lblBrandFill);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtDescriptionFill);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblCategori);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblPriceFill);
            this.Controls.Add(this.lblNameFill);
            this.Controls.Add(this.PbxImageFill);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(430, 751);
            this.MinimumSize = new System.Drawing.Size(430, 584);
            this.Name = "ProductInfo";
            this.Text = "Product Information";
            ((System.ComponentModel.ISupportInitialize)(this.PbxImageFill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbxImageFill;
        private System.Windows.Forms.Label lblNameFill;
        private System.Windows.Forms.Label lblPriceFill;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblCategori;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtDescriptionFill;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblBrandFill;
        private System.Windows.Forms.Label lblCategoryfill;
        private System.Windows.Forms.Label lblStockFill;
    }
}