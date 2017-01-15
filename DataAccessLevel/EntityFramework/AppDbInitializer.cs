using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using DataAccessLevel.Identity;
using Models.Entities;

namespace DataAccessLevel.EntityFramework
{
    public class AppDbInitializer : DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));

            var zver = new ApplicationUser { Email = "belysasha@tut.by", UserName = "belysasha@tut.by" };
            string password = "zver123";

            var result = userManager.Create(zver, password);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
