using Mona.Webapi.Models;
using SharedKernelData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonaLisaWebApi.Data
{
    //This does the same work as the repository but has complex operations
    internal class WebSiteOrderData
    {
        private readonly DatabaseContext _context;

        public WebSiteOrderData(DatabaseContext context)
        {
            _context = context;
        }

        public List<Product> GetProductsWithCategoryForShopping()
        {
           
        }

        public RevisitedCart StoreCartWithInitialProduct(NewCart newCart)
        {
            return null;
        }

        public RevisitedCart RetrieveCart(int cartId)
        {
            return null;
        }

        public RevisitedCart RetrieveCart(string cartCookie)
        {
            return null;
        }

        public void StoreNewCartItem(CartItem item)
        {

        }

        private void CheckForExistingCustomer(NewCart newCart)
        {

        }
    }
}
