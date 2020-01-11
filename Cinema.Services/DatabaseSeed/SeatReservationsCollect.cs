using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services.DatabaseSeed
{
    public class SeatReservationsCollect
    {
        public static void Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                SeatReservation seatReservation = new SeatReservation
                {
                    Reservation = unit.Reservations.Get(rawData.ReadInteger(row, 2)),
                    Seat = unit.Seats.Get(rawData.ReadInteger(row, 3))
                };

                unit.SeatReservations.Insert(seatReservation);
                unit.Save();
            }
        }
    }
}
