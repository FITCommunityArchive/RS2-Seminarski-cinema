using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;
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
            }
            await unit.SaveAsync();
        }
    }
}
