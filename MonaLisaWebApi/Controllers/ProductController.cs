using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using SharedKernelData.Context;
using SharedKernelData.Entity;
using Mona.Webapi.Models;
using DisconnectedGenericRepository;

namespace MonaLisaWebApi.Controllers
{
    [RoutePrefix("api/Product")]
    public class ProductController : ApiController
    {
        private GenericRepository<Product> _repo;

        public ProductController(GenericRepository<Product> repo)
        {
            _repo = repo;
        }

        [HttpDelete]
        public void Delete(int id)
        {

        }
        [HttpGet]
        public IHttpActionResult Get()
        {
          
            List<Product> test = new List<Product>();
            foreach (var prod in _repo.All())
            {
                test.Add(new Product
                {
                    ProductName = prod.ProductName,
                    ProductDescription = prod.ProductDescription,
                    ProductId = prod.ProductId
                });
            }

            return Ok(test);
           
        }
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var productEntity = _repo.FindBy(x => x.ProductId == id).FirstOrDefault();
            var product = new Product
            {
                ProductName = productEntity.ProductName,
                ProductDescription = productEntity.ProductDescription,
                ProductId = productEntity.ProductId
            };
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
      
        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody]Product product)
        {
            try
            {
                if (product.ProductId == 0)
                {
                    // db.Products.Add(product);
                    _repo.Update(product);


                }
                else
                {
                    
                    //   db.Products.Attach(product);
                    //db.Entry(product).State = EntityState.Modified;
                    //db.SaveChanges();

                }
                return Ok();
            }
            catch (Exception e)
            {

                return InternalServerError(e);
            }



        }

        [HttpPost]
        public IHttpActionResult Post([FromBody]Product product)
        {
            try
            {
                

                if (product.ProductId == 0)
                {
                     _repo.Update(product);
                 


                }
                else
                {

                    //db.Products.Attach(productEntity);
                    //db.Entry(product).State = EntityState.Modified;
                    //db.SaveChanges();

                }
                //return to 201 code (resource created) and the location of the added item
                return this.Created<Product>( new Uri(Request.RequestUri, product.ProductId.ToString()), product);
            }
            catch (Exception e)
            {

                return InternalServerError(e);
            }



        }

       
    }
}