using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebAPIAuthentication.Models
{
    public class UserRepository : IDisposable
    {
        private DatabaseContext  db;

        private UserManager<IdentityUser> userManager;

        public UserRepository()
        {
            db = new DatabaseContext();
            userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(db));
        }

        public async Task<IdentityResult> RegisterNewUser(RegisterUser  obj)
        {
            IdentityUser user = new IdentityUser
            {
                UserName = obj.Username
            };

            var result = await userManager.CreateAsync(user, obj.Password);

            return result;
        }

        public async Task<IdentityUser> SearchUser(string email, string password)
        {
            IdentityUser user = await userManager.FindAsync(email, password);

            return user;
        }

        public void Dispose()
        {
            db.Dispose();
            userManager.Dispose();

        }
    }
}