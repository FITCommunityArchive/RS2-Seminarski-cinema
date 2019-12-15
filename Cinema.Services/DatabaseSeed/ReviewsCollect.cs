using Cinema.Domain.Entities;
using Cinema.Web.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services.DatabaseSeed
{
    public class ReviewsCollect
    {
        public static void Collect(ExcelWorksheet rawData, ApplicationDbContext context)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                Review review = new Review
                {
                    Text = rawData.ReadString(row, 2),
                    Rating = rawData.ReadInteger(row, 3),
                    User = context.Users.Find(SeedUtilities.UsersDictionary[rawData.ReadInteger(row, 4)]),
                    Movie = context.Movies.Find(rawData.ReadInteger(row, 5))
                };

                context.Add(review);
                context.SaveChanges();
            }
        }
    }
}
