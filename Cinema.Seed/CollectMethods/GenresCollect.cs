using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using OfficeOpenXml;
using System.Threading.Tasks;

namespace Cinema.Seed.CollectMethods
{
    public class GenresCollect
    {
        public static async Task Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                Genre genre = new Genre
                {
                    Name = rawData.ReadString(row, 2)
                };

                await unit.Genres.InsertAsync(genre);
                await unit.SaveAsync();
            }
        }
    }
}
