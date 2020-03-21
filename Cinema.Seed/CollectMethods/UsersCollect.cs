﻿using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using Cinema.Domain.Entities.Identity;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Cinema.Seed.CollectMethods
{
    public static class UsersCollect
    {        
        public static void Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            var store = new UserStore<ApplicationUser>(unit.Context);
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

                var result = userManager.CreateAsync(appUser, password).Result;

                //Adding the user role for this user
                /*Even though there is a many to many relationship between user and role in Identity, 
                 * the legacy database has only one role per user*/
                ApplicationUserRole userRole = new ApplicationUserRole
                {
                    User = unit.Users.Get(appUser.Id),
                    Role = unit.Roles.Get(SeedUtilities.RolesDictionary[rawData.ReadInteger(row, 7)])
                };

                unit.UserRoles.Insert(userRole);
                unit.Save();
                SeedUtilities.UsersDictionary.Add(oldId, unit.Users.Get(appUser.Id).Id);
                Console.WriteLine($"Inserted user nr. ${row}");
            }
        }
    }
}