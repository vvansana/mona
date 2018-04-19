namespace Administration
{
    partial class MainForm
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
            this.dgridViewProducts = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxImage1 = new System.Windows.Forms.PictureBox();
            this.pbxImage2 = new System.Windows.Forms.PictureBox();
            this.pbxImage3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgridViewProducts)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgridViewProducts
            // 
            this.dgridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridViewProducts.Location = new System.Drawing.Point(494, 31);
            this.dgridViewProducts.Name = "dgridViewProducts";
            this.dgridViewProducts.RowTemplate.Height = 24;
            this.dgridViewProducts.Size = new System.Drawing.Size(276, 512);
            this.dgridViewProducts.TabIndex = 0;
            this.dgridViewProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridViewProducts_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.addProductToolStripMenuItem.Text = "Add Product";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // pbxImage1
            // 
            this.pbxImage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImage1.Location = new System.Drawing.Point(288, 31);
            this.pbxImage1.Name = "pbxImage1";
            this.pbxImage1.Size = new System.Drawing.Size(200, 150);
            this.pbxImage1.TabIndex = 20;
            this.pbxImage1.TabStop = false;
            // 
            // pbxImage2
            // 
            this.pbxImage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImage2.Location = new System.Drawing.Point(288, 212);
            this.pbxImage2.Name = "pbxImage2";
            this.pbxImage2.Size = new System.Drawing.Size(200, 150);
            this.pbxImage2.TabIndex = 22;
            this.pbxImage2.TabStop = false;
            // 
            // pbxImage3
            // 
            this.pbxImage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImage3.Location = new System.Drawing.Point(288, 393);
            this.pbxImage3.Name = "pbxImage3";
            this.pbxImage3.Size = new System.Drawing.Size(200, 150);
            this.pbxImage3.TabIndex = 24;
            this.pbxImage3.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.pbxImage3);
            this.Controls.Add(this.pbxImage2);
            this.Controls.Add(this.pbxImage1);
            this.Controls.Add(this.dgridViewProducts);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridViewProducts)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgridViewProducts;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbxImage1;
        private System.Windows.Forms.PictureBox pbxImage2;
        private System.Windows.Forms.PictureBox pbxImage3;
    }
}

