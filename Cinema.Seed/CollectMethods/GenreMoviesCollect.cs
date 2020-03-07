using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Seed.CollectMethods
{
    public class GenreMoviesCollect
    {
        public static void Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                GenreMovie genreMovie = new GenreMovie
                {
                    Movie = unit.Movies.Get(rawData.ReadInteger(row, 2)),
                    Genre = unit.Genres.Get(rawData.ReadInteger(row, 3))
                };

                unit.GenreMovies.Insert(genreMovie);
                unit.Save();
            }
        }
    }
}
