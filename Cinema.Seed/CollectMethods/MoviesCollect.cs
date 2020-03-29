using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Seed.CollectMethods
{
    public class MoviesCollect
    {
        public static async Task Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            for(int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                Movie movie = new Movie
                {
                    Title = rawData.ReadString(row, 2),
                    Duration = rawData.ReadInteger(row, 3),
                    Year = rawData.ReadInteger(row, 4),
                    Country = rawData.ReadString(row, 5),
                    Image = rawData.ReadString(row, 6),
                    //VideoLink?
                    Directors = rawData.ReadString(row, 8),
                    Actors = rawData.ReadString(row, 9)
                };

                await unit.Movies.InsertAsync(movie);                
                Console.WriteLine($"Inserted movie nr. ${row}");
                await unit.SaveAsync();
            }  
        }
    }
}
