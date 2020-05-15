using Cinema.Dal.Data;
using Cinema.Domain.Entities;
using OfficeOpenXml;
using System;
using System.Threading.Tasks;

namespace Cinema.Seed.CollectMethods
{
    public class SeatReservationsCollect
    {
        public static async Task Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                SeatReservation seatReservation = new SeatReservation
                {
                    Reservation = await unit.Reservations.GetAsync(rawData.ReadInteger(row, 2)),
                    Seat = await unit.Seats.GetAsync(rawData.ReadInteger(row, 3))
                };

                await unit.SeatReservations.InsertAsync(seatReservation);
                Console.WriteLine($"Inserted seat reservation nr. ${row}");
                await unit.SaveAsync();
            }
        }
    }
}
