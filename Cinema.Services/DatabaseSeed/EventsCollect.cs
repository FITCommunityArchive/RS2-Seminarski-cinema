using Cinema.Domain.Entities;
using Cinema.Web.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services.DatabaseSeed
{
    public class EventsCollect
    {
        public static void Collect(ExcelWorksheet rawData, ApplicationDbContext context)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                Event cinemaEvent = new Event
                {
                    Title = rawData.ReadString(row, 2),
                    Description = rawData.ReadString(row, 3),
                    Image = rawData.ReadString(row, 4),
                    Author = context.AppUsers.Find(rawData.ReadInteger(row, 5)),
                    DateAndTime = rawData.ReadDateValue(row, 6),
                    Promoter = rawData.ReadString(row, 7),
                    Type = context.EventTypes.Find(rawData.ReadInteger(row, 8))
                };

                context.Add(cinemaEvent);
                context.SaveChanges();
            }
        }
    }
}
