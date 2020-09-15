using Cinema.Common.Interfaces.Services;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.News;

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
