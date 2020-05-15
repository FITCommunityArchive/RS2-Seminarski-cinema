﻿using Cinema.Dal.Data;
using Cinema.Domain.Entities;
using OfficeOpenXml;
using System.Threading.Tasks;

namespace Cinema.Seed.CollectMethods
{
    public class EventTypesCollect
    {
        public static async Task Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                EventType eventType = new EventType
                {
                    Name = rawData.ReadString(row, 2)
                };

                await unit.EventTypes.InsertAsync(eventType);
                await unit.SaveAsync();
            }
        }
    }
}
