using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services.DatabaseSeed
{
    public class ReservationsCollect
    {
        public static void Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                Reservation reservation = new Reservation
                {
                    User = unit.Users.Get(SeedUtilities.UsersDictionary[rawData.ReadInteger(row, 2)]),
                    Screening = unit.Screenings.Get(rawData.ReadInteger(row, 3)),
                };

                unit.Reservations.Insert(reservation);
                unit.Save();
            }
        }
    }
}
