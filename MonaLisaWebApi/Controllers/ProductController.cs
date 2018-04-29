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
using SharedKernel.Data.Repository;

namespace MonaLisaWebApi.Controllers
{
    [RoutePrefix("api/Product")]
    public class ProductController : ApiController
    {
        private IProductRepository _repo = null;;

        public ProductController(IProductRepository repo)
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
            var results = _repo.All();
            if (results.Count() == 0)
            {
                return NotFound();
            }

            return Ok(results);          
        }
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var product = _repo.FindByKey(id);
            
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
                    _repo.Insert(product);
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