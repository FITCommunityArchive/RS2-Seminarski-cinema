using Cinema.Domain.Entities;
using Cinema.Web.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Seed.Collect
{
    public class EventTypesCollect
    {
        public static void Collect(ExcelWorksheet rawData, ApplicationDbContext context)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                EventType eventType = new EventType
                {
                    Name = rawData.ReadString(row, 2)
                };

                context.Add(eventType);
                context.SaveChanges();
            }
        }
    }
}
