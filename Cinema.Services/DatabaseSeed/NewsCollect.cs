using Cinema.Domain.Entities;
using Cinema.Web.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services.DatabaseSeed
{
    public class NewsCollect
    {
        public static void Collect(ExcelWorksheet rawData, ApplicationDbContext context)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                News news = new News
                {
                    Title = rawData.ReadString(row, 2),
                    Description = rawData.ReadString(row, 3),
                    Image = rawData.ReadString(row, 4),
                    Author = context.Users.Find(SeedUtilities.UsersDictionary[rawData.ReadInteger(row, 5)]),
                    Type = context.NewsTypes.Find(rawData.ReadInteger(row, 6))
                };

                context.Add(news);
                context.SaveChanges();
            }
        }
    }
}
