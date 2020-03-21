using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Seed.CollectMethods
{
    public class ReservationsCollect
    {
        public static async Task Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                Reservation reservation = new Reservation
                {
                    User = await unit.Users.GetAsync(SeedUtilities.UsersDictionary[rawData.ReadInteger(row, 2)]),
                    Screening = await unit.Screenings.GetAsync(rawData.ReadInteger(row, 3)),
                };

                await unit.Reservations.InsertAsync(reservation);                
                Console.WriteLine($"Inserted reservation nr. ${row}");
            }
            await unit.SaveAsync();
        }
    }
}
