namespace Administration
{
    partial class ProductDetailUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.txtbxProductId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbxImage3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbxImage2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbxImage1 = new System.Windows.Forms.PictureBox();
            this.txtbxProductDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxProductPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxProductName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "Id";
            // 
            // txtbxProductId
            // 
            this.txtbxProductId.Location = new System.Drawing.Point(356, 48);
            this.txtbxProductId.Name = "txtbxProductId";
            this.txtbxProductId.ReadOnly = true;
            this.txtbxProductId.Size = new System.Drawing.Size(68, 22);
            this.txtbxProductId.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(539, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 52;
            this.label6.Text = "Image 3";
            // 
            // pbxImage3
            // 
            this.pbxImage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImage3.Location = new System.Drawing.Point(537, 291);
            this.pbxImage3.Name = "pbxImage3";
            this.pbxImage3.Size = new System.Drawing.Size(200, 150);
            this.pbxImage3.TabIndex = 51;
            this.pbxImage3.TabStop = false;
            this.pbxImage3.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbxImage3_DragDrop);
            this.pbxImage3.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbxImage3_DragEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "Image 2";
            // 
            // pbxImage2
            // 
            this.pbxImage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImage2.Location = new System.Drawing.Point(285, 291);
            this.pbxImage2.Name = "pbxImage2";
            this.pbxImage2.Size = new System.Drawing.Size(200, 150);
            this.pbxImage2.TabIndex = 49;
            this.pbxImage2.TabStop = false;
            this.pbxImage2.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbxImage2_DragDrop);
            this.pbxImage2.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbxImage2_DragEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Image 1";
            // 
            // pbxImage1
            // 
            this.pbxImage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImage1.Location = new System.Drawing.Point(13, 291);
            this.pbxImage1.Name = "pbxImage1";
            this.pbxImage1.Size = new System.Drawing.Size(200, 150);
            this.pbxImage1.TabIndex = 47;
            this.pbxImage1.TabStop = false;
            this.pbxImage1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbxImage1_DragDrop);
            this.pbxImage1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbxImage1_DragEnter);
            // 
            // txtbxProductDescription
            // 
            this.txtbxProductDescription.Location = new System.Drawing.Point(15, 104);
            this.txtbxProductDescription.Multiline = true;
            this.txtbxProductDescription.Name = "txtbxProductDescription";
            this.txtbxProductDescription.Size = new System.Drawing.Size(398, 131);
            this.txtbxProductDescription.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Product Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Price";
            // 
            // txtbxProductPrice
            // 
            this.txtbxProductPrice.Location = new System.Drawing.Point(234, 48);
            this.txtbxProductPrice.Name = "txtbxProductPrice";
            this.txtbxProductPrice.Size = new System.Drawing.Size(68, 22);
            this.txtbxProductPrice.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Product Name";
            // 
            // txtbxProductName
            // 
            this.txtbxProductName.Location = new System.Drawing.Point(15, 48);
            this.txtbxProductName.Name = "txtbxProductName";
            this.txtbxProductName.Size = new System.Drawing.Size(155, 22);
            this.txtbxProductName.TabIndex = 41;
            // 
            // ProductDetailUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbxProductId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbxImage3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbxImage2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbxImage1);
            this.Controls.Add(this.txtbxProductDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbxProductPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxProductName);
            this.Name = "ProductDetailUserControl";
            this.Size = new System.Drawing.Size(780, 460);
            this.Load += new System.EventHandler(this.ProductDetailUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbxProductId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbxImage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbxImage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbxImage1;
        private System.Windows.Forms.TextBox txtbxProductDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxProductPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxProductName;
    }
}
