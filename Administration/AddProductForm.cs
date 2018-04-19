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
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        async private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                
                string name = productDetailUserControl.TxtbxProductName.Text;
                string description = productDetailUserControl.TxtbxProductDescription.Text;
                decimal price = 0; 
                if (!string.IsNullOrWhiteSpace(productDetailUserControl.TxtbxPrice.Text))
                {
                    price = Convert.ToDecimal(productDetailUserControl.TxtbxPrice.Text);
                }

                var product = new Product
                {
                    ProductName = name,
                    ProductDescription = description,
                    ProductPrice = price
                };

                var client = new MonaWebApiClient();
                await client.AddProduct(product);

                MessageBox.Show("Product was saved successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error occurred during save");
            }               

        }
    }
}
