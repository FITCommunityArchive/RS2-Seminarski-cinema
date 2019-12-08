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
            /*The UserManager and the RoleManager are passed in the Configure method in Startup in the example*/

            //initialize some role here
            ApplicationRole role = new ApplicationRole();
            await roleManager.CreateAsync(role);

            string adminId1;

            //initialize some users here
            ApplicationUser user = new ApplicationUser();
            string password = "password";
            var result = await userManager.CreateAsync(user);

            if(result.Succeeded)
            {
                await userManager.AddPasswordAsync(user, password);
                await userManager.AddToRoleAsync(user, "role as string");
            }

            adminId1 = user.Id;
        }
        
        
    }
}
