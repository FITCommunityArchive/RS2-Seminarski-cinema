using Cinema.Domain.Entities;
using Cinema.Web.Data;
using Cinema.Domain.Entities.Identity;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Cinema.Services.DatabaseSeed
{
    public static class UsersCollect
    {        
        public static void Collect(ExcelWorksheet rawData, ApplicationDbContext context)
        {
            var store = new UserStore<ApplicationUser>(context);
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
                    //Role = context.AppRoles.Find(rawData.ReadInteger(row, 7))
                };
                //string normalizedUsername = appUser.UserName.ToUpper();
                //string normalizedEmail = appUser.Email.ToUpper();
                var password = rawData.ReadString(row, 3);

                var result = userManager.CreateAsync(appUser, password).Result;

                //store.SetNormalizedUserNameAsync(appUser, normalizedUsername);
                //store.SetNormalizedEmailAsync(appUser, normalizedEmail);
                //context.Add(user);
                //context.Add(appUser);               
                //context.SaveChanges();
                SeedUtilities.UsersDictionary.Add(oldId, context.Users.Find(appUser.Id).Id);
            }
        }
    }
}
