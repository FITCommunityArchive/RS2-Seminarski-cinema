using Cinema.Models;
using Cinema.Models.Requests;
using Cinema.Utilities.Interfaces;

namespace Cinema.Web.Api.Controllers
{
    public class MoviesController : BaseCRUDController<MovieDto, MovieSearchRequest, MovieUpsertRequest, MovieUpsertRequest>
    {
        public MoviesController(ICRUDService<MovieDto, MovieSearchRequest, MovieUpsertRequest, MovieUpsertRequest> service) : base(service)
        {
        }
    }
}
