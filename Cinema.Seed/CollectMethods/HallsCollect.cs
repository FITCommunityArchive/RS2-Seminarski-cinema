using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Seed.CollectMethods
{
    public class HallsCollect
    {
        public static async Task Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                Hall hall = new Hall
                {
                    Name = rawData.ReadString(row, 2),
                    NumberOfColumns = rawData.ReadInteger(row, 3),
                    NumberOfRows = rawData.ReadInteger(row, 4)
                };

                await unit.Halls.InsertAsync(hall);                
            }
            await unit.SaveAsync();
        }
    }
}
