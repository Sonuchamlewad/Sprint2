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
    public class AdminController : ControllerBase
    {
        ProductDBContext db;
        public AdminController(ProductDBContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<AdminDetail> Get()
        {
            return db.AdminDetails;
        }
        [HttpPost]
        public string Post([FromBody] AdminDetail admin)
        {
            db.AdminDetails.Add(admin);
            db.SaveChanges();
            return "success";
        }
        [HttpPut]
        public string Put([FromBody] AdminDetail admin)
        {

            var userObj = db.AdminDetails.Where(x => x.UserId == admin.UserId);
            if (userObj != null)
            {
                db.AdminDetails.Update(admin);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

        [HttpDelete]
        public string Delete([FromBody] int Id)
        {

            var adminObj = db.AdminDetails.Where(x => x.UserId == Id).FirstOrDefault();
            if (adminObj != null)
            {
                db.AdminDetails.Remove(adminObj);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }
    }
}
