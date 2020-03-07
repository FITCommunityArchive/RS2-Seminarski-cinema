using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using OfficeOpenXml;
using System;
using Cinema.Services;
using Cinema.BLL;

namespace Cinema.Seed.CollectMethods
{
    public class SeatsCollect
    {
        public static void Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            SeatingService seatingService = new SeatingService(unit);

            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                Seat seat = new Seat
                {
                    Hall = unit.Halls.Get(rawData.ReadInteger(row, 2)),
                    SeatNumber = rawData.ReadInteger(row, 3)
                };

                seat.CreateSeatLabel();

                unit.Seats.Insert(seat);
                unit.Save();
                Console.WriteLine($"Inserted seat nr. ${row}");
            }
        }
    }
}
