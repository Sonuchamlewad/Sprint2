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
    public class UserController : ControllerBase
    {

        //EcommerceDbContext db;
      //  public UserController(EcommerceDbContext _db)
        {
      //      db = _db;
        }
        [HttpGet]
     //   public IEnumerable<UserDetail> Get()
        {
      //      return db.UserDetails;
        }
        [HttpPost]
        public string Post([FromBody] UserDetail user)
        {
            db.UserDetails.Add(user);
            db.SaveChanges();
            return "success";
        }
        [HttpPut]
        public string Put([FromBody] UserDetail user)
        {

            var userObj = db.UserDetails.Where(x => x.UserId == user.UserId);
            if (userObj != null)
            {
                db.UserDetails.Update(user);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

        [HttpDelete]
        public string Delete([FromBody] int Id)
        {

            var userObj = db.UserDetails.Where(x => x.UserId == Id).FirstOrDefault();
            if (userObj != null)
            {
                db.UserDetails.Remove(userObj);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }
    }
}
*/