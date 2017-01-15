using System.Threading.Tasks;
using BuisnessLogicLevel.Interfaces;
using DataAccessLevel.EntityFramework;
using DataAccessLevel.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using Models.Entities;
using BuisnessLogicLevel.Infrastructure;


namespace BuisnessLogicLevel.Servicies
{
    public class UserService : IUserService
    {
        private ApplicationContext db;
        private ApplicationUserManager userManager;
        public UserService(string connectionString)
        {
            db = new ApplicationContext(connectionString);
            userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(db));
        }
        public async Task<ClaimsIdentity> Authenticate(UserModel userModel)
        {
            ClaimsIdentity claim = null;
            ApplicationUser user = await userManager.FindAsync(userModel.Email, userModel.Password);
            if (user != null)
            {
                claim = await userManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
            }

            return claim;
        }
    }
}
