using System.Threading.Tasks;
using BuisnessLogicLevel.Interfaces;
using DataAccessLevel.EntityFramework;
using DataAccessLevel.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using DataAccessLevel.Entities;
using System.Security.Claims;
using BuisnessLogicLevel.BuisnessLogicEntities;


namespace BuisnessLogicLevel.Servicies
{
    public class UserService : IUserService
    {
        private ApplicationContext db;
        private ApplicationUserManager userManager;
        private ApplicationRoleManager roleManager;
        public UserService(string connectionString)
        {
            db = new ApplicationContext(connectionString);
            userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(db));
            roleManager = new ApplicationRoleManager(new RoleStore<ApplicationRole>(db));
        }
        public async Task<ClaimsIdentity> Authenticate(UserTransferModel userBle)
        {
            ClaimsIdentity claim = null;
            ApplicationUser user = await userManager.FindAsync(userBle.Email, userBle.Password);
            if (user != null)
            {
                claim = await userManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
            }

            return claim;
        }
    }
}
