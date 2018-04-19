namespace Administration
{
    partial class AddProductForm
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
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.productDetailUserControl = new Administration.ProductDetailUserControl();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(329, 506);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(115, 23);
            this.btnAddProduct.TabIndex = 25;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // productDetailUserControl
            // 
            this.productDetailUserControl.Location = new System.Drawing.Point(2, 2);
            this.productDetailUserControl.Name = "productDetailUserControl";
            this.productDetailUserControl.Size = new System.Drawing.Size(780, 460);
            this.productDetailUserControl.TabIndex = 26;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.productDetailUserControl);
            this.Controls.Add(this.btnAddProduct);
            this.Name = "AddProductForm";
            this.Text = "AddProduct";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddProduct;
        private ProductDetailUserControl productDetailUserControl;
    }
}