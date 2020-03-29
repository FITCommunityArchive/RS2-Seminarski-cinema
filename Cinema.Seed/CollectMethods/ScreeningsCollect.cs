using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Seed.CollectMethods
{
    public class ScreeningsCollect
    {
        public static async Task Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                Screening screening = new Screening
                {
                    DateAndTime = rawData.ReadDateValue(row, 6),
                    Hall = await unit.Halls.GetAsync(rawData.ReadInteger(row, 3)),
                    Movie = await unit.Movies.GetAsync(rawData.ReadInteger(row, 4))
                };

                await unit.Screenings.InsertAsync(screening);                
                Console.WriteLine($"Inserted screening nr. ${row}");
                await unit.SaveAsync();
            }
        }
    }
}
