using DisconnectedGenericRepository;
using Mona.SharedTestLib;
using Mona.Webapi.Models;
using NUnit.Framework;
using SharedKernel.Data;
using SharedKernel.Data.Repository;
using SharedKernelData.Context;
using SharedKernelData.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernal.Data.IntegrationTests
{
    [TestFixture]
    public class ProductRepositoryTests
    {
        private IProductRepository _productRepository = null;
        private ICategoryRepository _categoryRepository = null;
        private DatabaseContext _context = null;
        [SetUp]
        public void Setup()
        {
            _context = new DatabaseContext(TestingConstants.ConnectionString);
            _context.Database.Log = EFCommandLogging.Log;
            AutoMapperInitializer.Initialize();
            _productRepository = new ProductRepository( new GenericRepository<ProductEntity>(_context), AutoMapperInitializer.Mapper);
            _categoryRepository = new CategoryRepository(new GenericRepository<CategoryEntity>(_context), AutoMapperInitializer.Mapper);
        }

        [Test]
        public void InsertShirtCategory()
        {
            Category c = new Category
            {
                Name = "Shirt"
            };

            _categoryRepository.Insert(c);



        }


        [Test]
        public void InsertProductCreateNewProduct()
        {
            string productName = "White T-Shirt";
           
            var category = new Category
            {
                Name = "Shirt"
            };

            
        
            Product p = new Product
            {
                ProductCategory = category,
                ProductName = productName,
                ProductPrice = (decimal)10.0
            };

            _productRepository.Insert(p);

            var product = _productRepository.FindByInclude(x => x.ProductName == productName).FirstOrDefault();
            Assert.IsNotNull(product);
            _productRepository.Delete(product.ProductId);
        }

    }
}
