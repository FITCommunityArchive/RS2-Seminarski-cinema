using Cinema.Dal.Data;
using Cinema.Domain.Entities.Identity;
using Cinema.Utilities.Interfaces;
using Cinema.Utilities.Interfaces.Dal;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using OfficeOpenXml;
using System;
using System.Threading.Tasks;

namespace Cinema.Seed.CollectMethods
{
    public static class UsersCollect
    {
        public static async Task Collect(ExcelWorksheet rawData, IUnitOfWork unit, ICinemaDbContext context)
        {
            var store = new UserStore<ApplicationUser>(context as CinemaDbContext);
            var passwordHasher = new PasswordHasher<ApplicationUser>();
            var normalizer = new UpperInvariantLookupNormalizer();
            var userManager = new UserManager<ApplicationUser>(store, null, passwordHasher, null, null, normalizer, null, null, null);

            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                int oldId = rawData.ReadInteger(row, 1);

                ApplicationUser appUser = new ApplicationUser
                {
                    UserName = rawData.ReadString(row, 2),
                    EmailConfirmed = true,
                    FirstName = rawData.ReadString(row, 4),
                    LastName = rawData.ReadString(row, 5),
                    Email = rawData.ReadString(row, 6),
                    PhoneNumber = "0038761000000"
                };
                var password = rawData.ReadString(row, 3);

                await userManager.CreateAsync(appUser, password);

                //Adding the user role for this user
                /*Even though there is a many to many relationship between user and role in Identity, 
                 * the legacy database has only one role per user*/
                ApplicationUserRole userRole = new ApplicationUserRole
                {
                    User = await unit.Users.GetAsync(appUser.Id),
                    Role = await unit.Roles.GetAsync(SeedUtilities.RolesDictionary[rawData.ReadInteger(row, 7)])
                };

                await unit.UserRoles.InsertAsync(userRole);
                await unit.SaveAsync();
                SeedUtilities.UsersDictionary.Add(oldId, (await unit.Users.GetAsync(appUser.Id)).Id);
                Console.WriteLine($"Inserted user nr. ${row}");
            }
        }
    }
}
