/*using EcommApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        EcommerceDbContext db;
        public ProductController(EcommerceDbContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<ProductDetail> Get()
        {
            return db.ProductDetails;
        }
        [HttpPost]
        public string Post([FromBody] ProductDetail product)
        {
            db.ProductDetails.Add(product);
            db.SaveChanges();
            return "success";
        }


        [HttpPut]
        public string Put([FromBody] ProductDetail product)
        {

            var productObj = db.ProductDetails.Where(x => x.ProductId == product.ProductId);
            if (productObj != null)
            {
                db.ProductDetails.Update(product);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

        [HttpDelete]
        public string Delete([FromBody] int Id)
        {

            var productObj = db.ProductDetails.Where(x => x.ProductId == Id).FirstOrDefault();
            if (productObj != null)
            {
                db.ProductDetails.Remove(productObj);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }
    }
}
*/