using Cinema.Models.Dtos;
using Cinema.Models.Requests;
using Cinema.Common.Interfaces.Services;

namespace Cinema.Web.Api.Controllers
{
    public class GenresController : BaseController<GenreDto, BaseSearchRequest>
    {
        public GenresController(IService<GenreDto, BaseSearchRequest> service) : base(service)
        {
        }
    }
}
