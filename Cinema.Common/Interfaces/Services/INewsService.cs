using Cinema.Models.Dtos;
using Cinema.Models.Requests.News;

namespace Cinema.Common.Interfaces.Services
{
    public interface INewsService : ICRUDService<NewsDto, NewsSearchRequest, NewsUpsertRequest, NewsUpsertRequest>
    {
    }
}
