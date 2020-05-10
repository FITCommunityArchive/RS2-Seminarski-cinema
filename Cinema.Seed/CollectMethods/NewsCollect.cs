using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using OfficeOpenXml;
using System.Threading.Tasks;

namespace Cinema.Seed.CollectMethods
{
    public class NewsCollect
    {
        public static async Task Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                News news = new News
                {
                    Title = rawData.ReadString(row, 2),
                    Description = rawData.ReadString(row, 3),
                    Image = rawData.ReadString(row, 4),
                    Author = await unit.Users.GetAsync(SeedUtilities.UsersDictionary[rawData.ReadInteger(row, 5)]),
                    Type = await unit.NewsTypes.GetAsync(rawData.ReadInteger(row, 6))
                };

                await unit.News.InsertAsync(news);
                await unit.SaveAsync();
            }
        }
    }
}
