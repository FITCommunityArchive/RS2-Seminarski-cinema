using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services.DatabaseSeed
{
    public class NewsCollect
    {
        public static void Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                News news = new News
                {
                    Title = rawData.ReadString(row, 2),
                    Description = rawData.ReadString(row, 3),
                    Image = rawData.ReadString(row, 4),
                    Author = unit.Users.Get(SeedUtilities.UsersDictionary[rawData.ReadInteger(row, 5)]),
                    Type = unit.NewsTypes.Get(rawData.ReadInteger(row, 6))
                };

                unit.News.Insert(news);
                unit.Save();
            }
        }
    }
}
