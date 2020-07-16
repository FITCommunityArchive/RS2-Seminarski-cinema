using Cinema.Models;
using Cinema.Models.Requests;
using Cinema.Services;

namespace Cinema.Web.Api.Controllers
{
    public class MoviesController : BaseCRUDController<MovieDto, object, MovieUpsertRequest, MovieUpsertRequest>
    {
        public MoviesController(ICRUDService<MovieDto, object, MovieUpsertRequest, MovieUpsertRequest> service) : base(service)
        {
        }
    }
}
