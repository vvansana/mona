using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DisconnectedGenericRepository;
using Mona.Webapi.Models;
using System.Data.Entity;
using System.Data.Common;

namespace MonaLisaWebApi.Tests
{

    [TestFixture]
    public class GenericRepositoryTest
    {
        GenericRepository<Product> _productRepository = null;
        [SetUp]

        public void Setup()
        {
           
        }

        [Test]
        public void GetAllProductsWithDescriptionSample()
        {
            string connectionString = "Data Source = LR90FBH91; Initial Catalog = WebsiteDb; Integrated Security = false; User ID = mnadmin; Password=MonaLisa1";
            using (DbContext context = new DbContext(connectionString))
            {
                _productRepository = new GenericRepository<Product>(context);
                var results2 =  _productRepository.All();
                var results = _productRepository.AllInclude(x => x.ProductName, x => x.ProductPrice);
            }
            

        }





      
    

    }
}
