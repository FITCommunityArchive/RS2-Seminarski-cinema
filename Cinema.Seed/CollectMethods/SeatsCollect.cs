using Cinema.BLL;
using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using OfficeOpenXml;
using System;
using System.Threading.Tasks;

namespace Cinema.Seed.CollectMethods
{
    public class SeatsCollect
    {
        public static async Task Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                Seat seat = new Seat
                {
                    Hall = await unit.Halls.GetAsync(rawData.ReadInteger(row, 2)),
                    SeatNumber = rawData.ReadInteger(row, 3)
                };

                seat.CreateSeatLabel();

                await unit.Seats.InsertAsync(seat);
                Console.WriteLine($"Inserted seat nr. ${row}");
                await unit.SaveAsync();
            }
        }
    }
}
