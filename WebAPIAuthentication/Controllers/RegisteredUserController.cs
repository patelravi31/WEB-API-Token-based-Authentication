using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIAuthentication.Models;

namespace WebAPIAuthentication.Controllers
{
    [RoutePrefix("api/RegisteredUser")]
    public class RegisteredUserController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult GetRegisterdUser()
        {

            DatabaseContext db = new DatabaseContext();

            var result = db.Users.ToList();
            if(result==null)
            {
                return Ok("No user found in database");
            }
            return Ok(result);
        }

    }

}
