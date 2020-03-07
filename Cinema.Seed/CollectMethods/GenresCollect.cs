using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Seed.CollectMethods
{
    public class GenresCollect
    {
        public static void Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                Genre genre = new Genre
                {
                    Name = rawData.ReadString(row, 2)
                };

                unit.Genres.Insert(genre);
                unit.Save();
            }
        }
    }
}
