using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using MonaLisaWebApi.Context;
using MonaLisaWebApi.Entity;
using Mona.Webapi.Models;

namespace MonaLisaWebApi.Controllers
{
    [RoutePrefix("api/Product")]
    public class ProductController : ApiController
    {
        private  DatabaseContext db = new DatabaseContext();

        [HttpDelete]
        public void Delete(int id)
        {

        }
        [HttpGet]
        public IHttpActionResult Get()
        {
            int count = db.Products.Count();
            List<Product> test = new List<Product>();
            foreach (var prod in db.Products)
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
            var productEntity = db.Products.FirstOrDefault(x => x.ProductId == id);
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
                    db.SaveChanges();


                }
                else
                {

                    //   db.Products.Attach(product);
                    db.Entry(product).State = EntityState.Modified;
                    db.SaveChanges();

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
                var productEntity = new ProductEntity
                {
                    ProductName = product.ProductName,
                    ProductDescription = product.ProductDescription,
                    ProductPrice = product.ProductPrice
                };

                if (product.ProductId == 0)
                {
                     db.Products.Add(productEntity);
                    db.SaveChanges();


                }
                else
                {

                    db.Products.Attach(productEntity);
                    db.Entry(product).State = EntityState.Modified;
                    db.SaveChanges();

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