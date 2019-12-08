using Cinema.Domain.Entities;
using Cinema.Web.Data;
using Cinema.Web.IdentityEntities;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services.DatabaseSeed
{
    public class UsersCollect
    {
        public static void Collect(ExcelWorksheet rawData, ApplicationDbContext context)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                User user = new User
                {
                    Username = rawData.ReadString(row, 2),
                    Password = rawData.ReadString(row, 3),
                    FirstName = rawData.ReadString(row, 4),
                    LastName = rawData.ReadString(row, 5),
                    EmailAddress = rawData.ReadString(row, 6),
                    Role = context.AppRoles.Find(rawData.ReadInteger(row, 7))
                };

                int oldId = rawData.ReadInteger(row, 1);

                ApplicationUser appUser = new ApplicationUser
                {
                    UserName = rawData.ReadString(row, 2),
                    //Hashing needs to be implemented here:
                    PasswordHash = rawData.ReadString(row, 3),
                    FirstName = rawData.ReadString(row, 4),
                    LastName = rawData.ReadString(row, 5),
                    Email = rawData.ReadString(row, 6),
                    //Role = context.AppRoles.Find(rawData.ReadInteger(row, 7))
                };

                context.Add(user);
                context.Add(appUser);               
                context.SaveChanges();
                //SeedUtilities.UsersDictionary.Add(oldId, context.Roles.Find(appUser.Id).Id);
            }
        }
    }
}
