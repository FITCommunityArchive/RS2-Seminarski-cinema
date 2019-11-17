using Cinema.Domain.Entities;
using Cinema.Web.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services.DatabaseSeed
{
    public class GenreMoviesCollect
    {
        public static void Collect(ExcelWorksheet rawData, ApplicationDbContext context)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                GenreMovie genreMovie = new GenreMovie
                {
                    Movie = context.Movies.Find(rawData.ReadInteger(row, 2)),
                    Genre = context.Genres.Find(rawData.ReadInteger(row, 3))
                };

                context.Add(genreMovie);
                context.SaveChanges();
            }
        }
    }
}
