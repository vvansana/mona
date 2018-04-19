using Mona.Webapi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administration
{
    public partial class MainForm : Form
    {
        private AddProductForm _addProductForm = new AddProductForm();
        private UpdateProductForm _editProductForm = new UpdateProductForm();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        async private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                var client = new MonaWebApiClient();
                var products = await client.GetProducts();
                dgridViewProducts.DataSource = products;

                ((Control)pbxImage1).AllowDrop = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while attempting to access the API.  Make sure that the API is available.");
            }
            

        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _addProductForm.Show();
            
        }

        private void dgridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;

            List<Product> products = (List<Product>)dgridViewProducts.DataSource;
            var selectedProduct = products[rowIndex];
            _editProductForm.LoadProduct(selectedProduct.ProductId);
            _editProductForm.Show();


        }

    }
}
