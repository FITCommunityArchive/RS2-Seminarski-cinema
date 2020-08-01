using Microsoft.Extensions.Configuration;
using Cinema.Models;
using Cinema.Models.Requests.Movies;
using Cinema.Utilities.Interfaces.Services;

namespace Cinema.Web.Api.Controllers
{
    public class MoviesController : BaseCRUDController<MovieDto, MovieSearchRequest, MovieUpsertRequest, MovieUpsertRequest>
    {
        public MoviesController(ICRUDService<MovieDto, MovieSearchRequest, MovieUpsertRequest, MovieUpsertRequest> service) : base(service)
        {
        }
    }
}
