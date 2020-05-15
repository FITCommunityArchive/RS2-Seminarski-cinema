﻿using Cinema.Dal.Data;
using Cinema.Domain.Entities;
using OfficeOpenXml;
using System.Threading.Tasks;

namespace Cinema.Seed.CollectMethods
{
    public class ReviewsCollect
    {
        public static async Task Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                Review review = new Review
                {
                    Text = rawData.ReadString(row, 2),
                    Rating = rawData.ReadInteger(row, 3),
                    User = await unit.Users.GetAsync(SeedUtilities.UsersDictionary[rawData.ReadInteger(row, 4)]),
                    Movie = await unit.Movies.GetAsync(rawData.ReadInteger(row, 5))
                };

                await unit.Reviews.InsertAsync(review);
                await unit.SaveAsync();
            }
        }
    }
}
