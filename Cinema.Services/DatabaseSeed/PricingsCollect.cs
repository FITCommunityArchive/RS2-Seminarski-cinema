using Cinema.Domain.Entities;
using Cinema.Web.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services.DatabaseSeed
{
    public class PricingsCollect
    {
        public static void Collect(ExcelWorksheet rawData, ApplicationDbContext context)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                Pricing pricing = new Pricing
                {
                    Name = rawData.ReadString(row, 2),
                    Price = rawData.ReadDecimal(row, 3)
                };

                context.Add(pricing);
                context.SaveChanges();
            }
        }
    }
}
