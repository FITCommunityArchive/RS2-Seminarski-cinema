using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;
using Cinema.Domain.Entities.Identity;

namespace Cinema.Seed.CollectMethods
{
    public class ReviewsCollect
    {
        public static void Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {                
                Review review = new Review
                {
                    Text = rawData.ReadString(row, 2),
                    Rating = rawData.ReadInteger(row, 3),
                    User = unit.Users.Get(SeedUtilities.UsersDictionary[rawData.ReadInteger(row, 4)]),
                    Movie = unit.Movies.Get(rawData.ReadInteger(row, 5))
                };

                unit.Reviews.Insert(review);
                unit.Save();
            }
        }
    }
}
