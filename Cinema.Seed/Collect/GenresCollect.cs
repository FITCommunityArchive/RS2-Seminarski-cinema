using Cinema.Domain.Entities;
using Cinema.Web.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Seed.Collect
{
    public class GenresCollect
    {
        public static void Collect(ExcelWorksheet rawData, ApplicationDbContext context)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                Genre genre = new Genre
                {
                    Name = rawData.ReadString(row, 2)
                };

                context.Add(genre);
                context.SaveChanges();
            }
        }
    }
}
