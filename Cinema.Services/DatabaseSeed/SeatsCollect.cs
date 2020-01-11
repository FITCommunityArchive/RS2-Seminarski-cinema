using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services.DatabaseSeed
{
    public class SeatsCollect
    {
        public static void Collect(ExcelWorksheet rawData, ApplicationDbContext context)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                Seat seat = new Seat
                {
                    Hall = context.Halls.Find(rawData.ReadInteger(row, 2)),
                    SeatNumber = rawData.ReadInteger(row, 3),
                    Label = "A1"
                };

                //This method will have to be implemented for the real seat label to be returned
                //seat.CreateSeatLabel();

                context.Add(seat);
                context.SaveChanges();
            }
        }
    }
}
