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
    public partial class UpdateProductForm : Form
    {
        public UpdateProductForm()
        {
            InitializeComponent();
        }

        async public void  LoadProduct(int productId)
        {
          

            var client = new MonaWebApiClient();
            var product = await client.GetProduct(productId);

            productDetailUserControl.TxtbxProductName.Text = product.ProductName.ToString();
            productDetailUserControl.TxtbxPrice.Text = product.ProductPrice.ToString();
            productDetailUserControl.TxtbxProductDescription.Text = product.ProductDescription.ToString();
            productDetailUserControl.TxtbxProductId.Text = product.ProductId.ToString();

        }

        async private void btnUpdate_Click(object sender, EventArgs e)
        {
            var client = new MonaWebApiClient();
            int productId = 0;
            int.TryParse(productDetailUserControl.TxtbxProductId.Text, out productId);
            await client.UpdateProduct(productId, new Product());


        }
    }
}
