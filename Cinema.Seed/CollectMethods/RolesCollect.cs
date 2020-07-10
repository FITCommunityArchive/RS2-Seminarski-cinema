using Cinema.Dal.Data;
using Cinema.Domain.Entities.Identity;
using Cinema.Utilities.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using OfficeOpenXml;
using System.Threading.Tasks;

namespace Cinema.Seed.CollectMethods
{
    public class RolesCollect
    {
        public static async Task Collect(ExcelWorksheet rawData, IUnitOfWork unit)
        {
            var store = new RoleStore<ApplicationRole>(unit.Context as CinemaDbContext);
            var normalizer = new UpperInvariantLookupNormalizer();
            var roleManager = new RoleManager<ApplicationRole>(store, null, normalizer, null, null);

            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                int oldId = rawData.ReadInteger(row, 1);
                ApplicationRole appRole = new ApplicationRole
                {
                    Name = rawData.ReadString(row, 2)
                };

                await roleManager.CreateAsync(appRole);

                //context.Add(role);
                //context.Add(appRole);                
                //context.SaveChanges();
                SeedUtilities.RolesDictionary.Add(oldId, (await unit.Roles.GetAsync(appRole.Id)).Id);
            }
        }
    }
}
