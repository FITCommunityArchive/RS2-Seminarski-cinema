using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services.DatabaseSeed
{
    public class HallsCollect
    {
        public static void Collect(ExcelWorksheet rawData, ApplicationDbContext context)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                Hall hall = new Hall
                {
                    Name = rawData.ReadString(row, 2),
                    NumberOfColumns = rawData.ReadInteger(row, 3),
                    NumberOfRows = rawData.ReadInteger(row, 4)
                };

                context.Add(hall);
                context.SaveChanges();
            }
        }
    }
}
