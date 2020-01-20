using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services.DatabaseSeed
{
    public class EventTypesCollect
    {
        public static void Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                EventType eventType = new EventType
                {
                    Name = rawData.ReadString(row, 2)
                };

                unit.EventTypes.Insert(eventType);
                unit.Save();
            }
        }
    }
}
