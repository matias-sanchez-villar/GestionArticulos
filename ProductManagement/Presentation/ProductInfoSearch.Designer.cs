
namespace Presentation
{
    partial class ProductInfoSearch
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchtProductLbl = new System.Windows.Forms.Label();
            this.productSearchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 26);
            this.textBox1.TabIndex = 0;
            // 
            // searchtProductLbl
            // 
            this.searchtProductLbl.AutoSize = true;
            this.searchtProductLbl.Location = new System.Drawing.Point(46, 97);
            this.searchtProductLbl.Name = "searchtProductLbl";
            this.searchtProductLbl.Size = new System.Drawing.Size(159, 30);
            this.searchtProductLbl.TabIndex = 1;
            this.searchtProductLbl.Text = "Product Code";
            // 
            // productSearchBtn
            // 
            this.productSearchBtn.Location = new System.Drawing.Point(627, 90);
            this.productSearchBtn.Name = "productSearchBtn";
            this.productSearchBtn.Size = new System.Drawing.Size(114, 30);
            this.productSearchBtn.TabIndex = 2;
            this.productSearchBtn.Text = "Search";
            this.productSearchBtn.UseVisualStyleBackColor = true;
            this.productSearchBtn.Click += new System.EventHandler(this.productSearchBtn_Click);
            // 
            // ProductInfoSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 213);
            this.Controls.Add(this.productSearchBtn);
            this.Controls.Add(this.searchtProductLbl);
            this.Controls.Add(this.textBox1);
            this.Name = "ProductInfoSearch";
            this.Text = "ProductInfoSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label searchtProductLbl;
        private System.Windows.Forms.Button productSearchBtn;
    }
}