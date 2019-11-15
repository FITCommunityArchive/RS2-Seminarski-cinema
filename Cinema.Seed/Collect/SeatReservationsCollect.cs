using Cinema.Domain.Entities;
using Cinema.Web.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Seed.Collect
{
    public class SeatReservationsCollect
    {
        public static void Collect(ExcelWorksheet rawData, ApplicationDbContext context)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                SeatReservation seatReservation = new SeatReservation
                {
                    Reservation = context.Reservations.Find(rawData.ReadInteger(row, 2)),
                    Seat = context.Seats.Find(rawData.ReadInteger(row, 3))
                };

                context.Add(seatReservation);
                context.SaveChanges();
            }
        }
    }
}
