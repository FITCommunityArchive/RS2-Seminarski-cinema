using Cinema.Models.Dtos;
using Cinema.Models.Requests.News;
using Cinema.Utilities.Interfaces.Services;

namespace Cinema.Web.Api.Controllers
{
    public class NewsController : BaseCRUDController<NewsDto, NewsSearchRequest, NewsUpsertRequest, NewsUpsertRequest>
    {
        private readonly INewsService _newsService;

        public NewsController(INewsService service) : base(service)
        {
            _newsService = service;
        }
    }
}
