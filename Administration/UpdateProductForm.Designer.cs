namespace Administration
{
    partial class UpdateProductForm
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.productDetailUserControl = new Administration.ProductDetailUserControl();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(353, 508);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 29);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "Update Product";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(624, 508);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 29);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Delete Product";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // productDetailUserControl
            // 
            this.productDetailUserControl.Location = new System.Drawing.Point(3, -1);
            this.productDetailUserControl.Name = "productDetailUserControl";
            this.productDetailUserControl.Size = new System.Drawing.Size(780, 460);
            this.productDetailUserControl.TabIndex = 42;
            // 
            // UpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.productDetailUserControl);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Name = "UpdateProductForm";
            this.Text = "Update Product Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private ProductDetailUserControl productDetailUserControl;
    }
}