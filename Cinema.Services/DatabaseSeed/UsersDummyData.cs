using Cinema.Web.Data;
using Cinema.Web.IdentityEntities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Services.DatabaseSeed
{
    public class UsersDummyData
    {
        public static async Task Initialize(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            //initialize some role here
            ApplicationRole role = new ApplicationRole();
            await roleManager.CreateAsync(role);

            //initialize some users here
            ApplicationUser user = new ApplicationUser();
            await userManager.CreateAsync(user);
        }
        
        
    }
}
