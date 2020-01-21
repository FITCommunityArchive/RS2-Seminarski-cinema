using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services.DatabaseSeed
{
    public class ScreeningsCollect
    {
        public static void Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                Screening screening = new Screening
                {
                    DateAndTime = rawData.ReadDateValue(row, 6),
                    Hall = unit.Halls.Get(rawData.ReadInteger(row, 3)),
                    Movie = unit.Movies.Get(rawData.ReadInteger(row, 4))
                };

                unit.Screenings.Insert(screening);
                unit.Save();
                Console.WriteLine($"Inserted screening nr. ${row}");
            }
        }
    }
}
