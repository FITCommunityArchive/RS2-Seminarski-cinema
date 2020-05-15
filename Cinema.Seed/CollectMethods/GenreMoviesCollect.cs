using Cinema.Dal.Data;
using Cinema.Domain.Entities;
using OfficeOpenXml;
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
                await unit.SaveAsync();
            }
        }
    }
}
