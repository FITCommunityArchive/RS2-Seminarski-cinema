using Cinema.Domain.Entities;
using Cinema.Web.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services.DatabaseSeed
{
    public class ReservationsCollect
    {
        public static void Collect(ExcelWorksheet rawData, ApplicationDbContext context)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                Reservation reservation = new Reservation
                {
                    User = context.Users.Find(SeedUtilities.UsersDictionary[rawData.ReadInteger(row, 2)]),
                    Screening = context.Screenings.Find(rawData.ReadInteger(row, 3)),
                };

                context.Add(reservation);
                context.SaveChanges();
            }
        }
    }
}
