using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Seed.CollectMethods
{
    public class GenreMoviesCollect
    {
        public static async Task Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                GenreMovie genreMovie = new GenreMovie
                {
                    Movie = await unit.Movies.GetAsync(rawData.ReadInteger(row, 2)),
                    Genre = await unit.Genres.GetAsync(rawData.ReadInteger(row, 3))
                };

                await unit.GenreMovies.InsertAsync(genreMovie);                
            }
            await unit.SaveAsync();
        }
    }
}
