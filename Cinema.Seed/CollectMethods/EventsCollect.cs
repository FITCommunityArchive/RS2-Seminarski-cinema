using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Seed.CollectMethods
{
    public class EventsCollect
    {
        public static async Task Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                Event cinemaEvent = new Event
                {
                    Title = rawData.ReadString(row, 2),
                    Description = rawData.ReadString(row, 3),
                    Image = rawData.ReadString(row, 4),
                    Author = await unit.Users.GetAsync(SeedUtilities.UsersDictionary[rawData.ReadInteger(row, 5)]),
                    DateAndTime = rawData.ReadDate(row, 6),
                    Promoter = rawData.ReadString(row, 7),
                    Type = await unit.EventTypes.GetAsync(rawData.ReadInteger(row, 8))
                };

                await unit.Events.InsertAsync(cinemaEvent);
                await unit.SaveAsync();
            }
        }
    }
}
