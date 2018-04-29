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
using SharedKernelData.Context;
using SharedKernelData.Entity;
using System.Diagnostics;
using Mona.SharedTestLib;

namespace MonaLisaWebApi.Tests
{

    [TestFixture]
    public class GenericRepositoryTest
    {
        GenericRepository<ProductEntity> _productRepository = null;
        [SetUp]

        public void Setup()
        {
           
        }

        [Test]
        public void GetProductsWithProductAsTheDescription()
        {
            using (DatabaseContext context = new DatabaseContext(TestingConstants.ConnectionString))
            {
               
                context.Database.Log = EFCommandLogging.Log;
                _productRepository = new GenericRepository<ProductEntity>(context);
                var results2 = _productRepository.FindBy(x => x.ProductName == "Product");
               
            }
            

        }

        public void GetProductAndIncludeCompositeObjects()
        {
            using (DatabaseContext context = new DatabaseContext(TestingConstants.ConnectionString))
            {

                context.Database.Log = EFCommandLogging.Log;
                _productRepository = new GenericRepository<ProductEntity>(context);
                //TODO: I think the findByInclude works with sub components or possible joins, need to spend more time on this.
                var results2 = _productRepository.FindByInclude(x => x.ProductName == "Product");

            }
        }


        private void Write(string message)
        {
            Debug.WriteLine(message);
        }





      
    

    }
}
