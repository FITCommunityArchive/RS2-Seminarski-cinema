using Cinema.Models.Dtos;
using Cinema.Models.Requests.News;

namespace Cinema.Utilities.Interfaces.Services
{
    public interface INewsService : ICRUDService<NewsDto, NewsSearchRequest, NewsUpsertRequest, NewsUpsertRequest>
    {
    }
}
