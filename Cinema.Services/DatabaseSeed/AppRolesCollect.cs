using Cinema.Domain.Entities;
using Cinema.Web.Data;
using Cinema.Domain.Entities.Identity;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Cinema.Services.DatabaseSeed
{
    public class AppRolesCollect
    {
        public static void Collect(ExcelWorksheet rawData, ApplicationDbContext context)
        {
            var store = new RoleStore<ApplicationRole>(context);
            var normalizer = new UpperInvariantLookupNormalizer();
            var roleManager = new RoleManager<ApplicationRole>(store, null, normalizer, null, null);

            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                int oldId = rawData.ReadInteger(row, 1);
                ApplicationRole appRole = new ApplicationRole
                {
                    Name = rawData.ReadString(row, 2)
                };

                var result = roleManager.CreateAsync(appRole).Result;

                //context.Add(role);
                //context.Add(appRole);                
                //context.SaveChanges();
                SeedUtilities.RolesDictionary.Add(oldId, context.Roles.Find(appRole.Id).Id);
            }
        }
    }
}
