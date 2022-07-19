using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceApi.Models;

namespace EcommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ProductDBContext db;
        public CategoryController(ProductDBContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return db.Categories;
        }
        [HttpPost]
        public string Post([FromBody] Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return "success";
        }
        [HttpPut]
        public string Put([FromBody] Category category)
        {

            var categoriesObj = db.Categories.Where(x => x.CategoryId == category.CategoryId);
            if (categoriesObj != null)
            {
                db.Categories.Update(category);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

        [HttpDelete]
        public string Delete([FromBody] int Id)
        {

            var categoriesObj = db.Categories.Where(x => x.CategoryId == Id).FirstOrDefault();
            if (categoriesObj != null)
            {
                db.Categories.Update(categoriesObj);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }
    }
}
