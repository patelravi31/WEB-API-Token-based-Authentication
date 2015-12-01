using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIAuthentication.Models
{
    public class DatabaseContext  : IdentityDbContext<IdentityUser>
    {
        public DatabaseContext()
            : base("DatabaseContext")
        {
 
        }
    }
   
}