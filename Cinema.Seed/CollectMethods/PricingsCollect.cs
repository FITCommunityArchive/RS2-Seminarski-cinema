using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Seed.CollectMethods
{
    public class PricingsCollect
    {
        public static async Task Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                Pricing pricing = new Pricing
                {
                    Name = rawData.ReadString(row, 2),
                    Price = rawData.ReadDecimal(row, 3)
                };

                await unit.Pricings.InsertAsync(pricing);                
            }
            await unit.SaveAsync();
        }
    }
}
