using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using MonaLisaWebApi.Context;
using MonaLisaWebApi.Models;

namespace MonaLisaWebApi.Controllers
{
    public class ProductController : ApiController
    {
        private  DatabaseContext db = new DatabaseContext();

        public List<Product> Get()
        {
            int count = db.Products.Count();
            return db.Products.ToList();
            //try
            //{
            //    var result = db.Products.Select(x => x );
            //    return Ok(result);

            //}
            //catch (Exception)
            //{

            //    return InternalServerError();
            //}
        }
       
        public int Count()
        {
            return db.Products.Count();
        }
        [HttpPost]
        public HttpResponseMessage InsertOrUpdate([FromBody]Product product)
        {
            try
            {
                if (product.ProductId == 0)
                {
                    db.Products.Add(product);
                    db.SaveChanges();
                    

                }
                else
                {

                    db.Products.Attach(product);
                    db.Entry(product).State = EntityState.Modified;
                    db.SaveChanges();

                }
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            
            
            
        }
    }
}