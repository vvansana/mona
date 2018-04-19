using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administration
{
    public partial class ProductDetailUserControl : UserControl
    {
        public TextBox TxtbxProductName { get { return txtbxProductName; } }
        public TextBox TxtbxPrice { get { return txtbxProductPrice; } }
        public TextBox TxtbxProductId { get { return txtbxProductId; } }
        public TextBox TxtbxProductDescription { get { return txtbxProductDescription; } }

        public PictureBox PbxImage1 { get { return pbxImage1; } }
        public PictureBox PbxImage2 { get { return pbxImage2; } }
        public PictureBox PbxImage3 { get { return pbxImage3; } }

        public ProductDetailUserControl()
        {
            InitializeComponent();
        }

        private void pbxImage1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            PictureBox pbx = (PictureBox)sender;
            pbx.Image = Image.FromFile(files[0]);
        }

        private void ProductDetailUserControl_Load(object sender, EventArgs e)
        {
            ((Control)pbxImage1).AllowDrop = true;
            ((Control)pbxImage2).AllowDrop = true;
            ((Control)pbxImage3).AllowDrop = true;
        }

        private void pbxImage1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void pbxImage2_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            PictureBox pbx = (PictureBox)sender;
            pbx.Image = Image.FromFile(files[0]);
        }

        private void pbxImage2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void pbxImage3_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            PictureBox pbx = (PictureBox)sender;
            pbx.Image = Image.FromFile(files[0]);
        }

        private void pbxImage3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
    }
}
