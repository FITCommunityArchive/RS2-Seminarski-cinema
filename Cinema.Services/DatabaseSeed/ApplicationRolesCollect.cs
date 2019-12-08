using Cinema.Web.Data;
using Cinema.Web.IdentityEntities;
using Microsoft.AspNetCore.Identity;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Services.DatabaseSeed
{
    public class ApplicationRolesCollect
    {
        public static async Task Collect(ExcelWorksheet rawData, ApplicationDbContext context, RoleManager<ApplicationRole> roleManager)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                ApplicationRole role = new ApplicationRole
                {
                    Name = rawData.ReadString(row, 2)
                };
                //context.Add(role);
                await roleManager.CreateAsync(role);
                await context.SaveChangesAsync();
            }
        }
    }
}
