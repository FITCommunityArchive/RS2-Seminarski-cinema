using Cinema.Domain.Entities;
using Cinema.Web.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services.DatabaseSeed
{
    public class ScreeningsCollect
    {
        public static void Collect(ExcelWorksheet rawData, ApplicationDbContext context)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                Screening screening = new Screening
                {
                    DateAndTime = rawData.ReadDate(row, 6),
                    Hall = context.Halls.Find(rawData.ReadInteger(row, 3)),
                    Movie = context.Movies.Find(rawData.ReadInteger(row, 4))
                };

                context.Add(screening);
                context.SaveChanges();
            }
        }
    }
}
