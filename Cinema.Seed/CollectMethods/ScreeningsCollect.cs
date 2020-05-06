using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cinema.Services.Helpers;

namespace Cinema.Seed.CollectMethods
{
    public class ScreeningsCollect
    {
        public static async Task Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            Random random = new Random();

            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                Screening screening = new Screening
                {
                    Hall = await unit.Halls.GetAsync(rawData.ReadInteger(row, 3)),
                    Movie = await unit.Movies.GetAsync(rawData.ReadInteger(row, 4)),
                    Pricing = await unit.Pricings.GetAsync(random.Next(1, 5))
                };

                screening.DateAndTime = DateTimeHelper.GenerateFutureTime(0, 365, 12, 23);

                await unit.Screenings.InsertAsync(screening);                
                Console.WriteLine($"Inserted screening nr. ${row}");
                await unit.SaveAsync();
            }
        }
    }
}
