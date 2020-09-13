using Cinema.Common.Interfaces.Services;
using Cinema.Models.Dtos;
using Cinema.Models.Requests;

namespace Cinema.Web.Api.Controllers
{
    public class GenresController : BaseController<GenreDto, BaseSearchRequest>
    {
        public GenresController(IService<GenreDto, BaseSearchRequest> service) : base(service)
        {
        }
    }
}
