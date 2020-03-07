using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Seed.CollectMethods
{
    public class EventsCollect
    {
        public static void Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                Event cinemaEvent = new Event
                {
                    Title = rawData.ReadString(row, 2),
                    Description = rawData.ReadString(row, 3),
                    Image = rawData.ReadString(row, 4),
                    Author = unit.Users.Get(SeedUtilities.UsersDictionary[rawData.ReadInteger(row, 5)]),
                    DateAndTime = rawData.ReadDate(row, 6),
                    Promoter = rawData.ReadString(row, 7),
                    Type = unit.EventTypes.Get(rawData.ReadInteger(row, 8))
                };

                unit.Events.Insert(cinemaEvent);
                unit.Save();
            }
        }
    }
}
