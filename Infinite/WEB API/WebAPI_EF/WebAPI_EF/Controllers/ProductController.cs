using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebAPI_EF.Models;

namespace WebAPI_EF.Controllers
{
    public class ProductController : ApiController
    {
        InfiniteDBEntities db = new InfiniteDBEntities();
        //Get
        public IEnumerable<Product>Get()
        {
            return db.Products.ToList();
        }
        public Product Get(int id)
        {
            return db.Products.FirstOrDefault(x => x.ProductId == id);
        }

        //Post
        public IHttpActionResult PostNewProduct([FromBody]Product p)
        {
            if (!ModelState.IsValid)
                return BadRequest("Validations Failed");
            db.Products.Add(new Product()
            {
                ProductId=p.ProductId,
                ProdName=p.ProdName,
                Price=p.Price,
                QtyAvailable=p.QtyAvailable,
            });
            db.SaveChanges();
            return Ok("Success");
        }

        [HttpPut]
        [Route("api/product/Edit")]
        public IHttpActionResult Put([FromBody] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                 db.SaveChanges();
            }
            return Ok("Updated");
        }
    }
}
