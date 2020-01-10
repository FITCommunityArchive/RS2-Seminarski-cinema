using Cinema.Domain.Entities.Identity;
using Cinema.Web.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services.DatabaseSeed
{
    public static class UserRolesCollect
    {
        public static void Collect(ExcelWorksheet rawData, ApplicationDbContext context)
        {
            /*
            var store = new UserStore<ApplicationUser>(context);
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
                    //Role = context.AppRoles.Find(rawData.ReadInteger(row, 7))
                };
                var password = rawData.ReadString(row, 3);

                var result = userManager.CreateAsync(appUser, password).Result;

                SeedUtilities.UsersDictionary.Add(oldId, context.Users.Find(appUser.Id).Id);
            }*/
        }
    }
}
