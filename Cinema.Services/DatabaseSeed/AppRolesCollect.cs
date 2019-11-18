using Cinema.Domain.Entities;
using Cinema.Web.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services.DatabaseSeed
{
    public class AppRolesCollect
    {
        public static void Collect(ExcelWorksheet rawData, ApplicationDbContext context)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                AppRole role = new AppRole
                {
                    Name = rawData.ReadString(row, 2)
                };

                context.Add(role);
                context.SaveChanges();
            }
        }
    }
}
