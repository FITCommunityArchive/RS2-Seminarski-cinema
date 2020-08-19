using Cinema.Models.Dtos;
using Cinema.Models.Requests.Movies;
using Cinema.Utilities.Interfaces.Services;

namespace Cinema.Web.Api.Controllers
{
    public class MoviesController : BaseCRUDController<MovieDto, MovieSearchRequest, MovieUpsertRequest, MovieUpsertRequest>
    {
        public MoviesController(IMovieService service) : base(service)
        {
        }
    }
}
