using Cinema.Common.Interfaces.Services;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Movies;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.Web.Api.Controllers
{
    public class MoviesController : BaseCRUDController<MovieDto, MovieSearchRequest, MovieUpsertRequest, MovieUpsertRequest>
    {
        private readonly IMovieService _movieService;
        public MoviesController(IMovieService service) : base(service)
        {
            _movieService = service;
        }

        [HttpGet("now-showing")]
        public async Task<ActionResult<List<MovieDto>>> GetNowShowing()
        {
            var result = await _movieService.GetNowShowingAsync();

            return Ok(result);
        }

        [HttpGet("recommended")]
        public async Task<ActionResult<List<MovieDto>>> GetRecommended([FromQuery] int id)
        {
            var result = await _movieService.GetRecommendedAsync(id);

            return Ok(result);
        }

        [HttpGet("{id}/review-score")]
        public ActionResult<double> GetMovieReviewScore(int id)
        {
            return _movieService.GetMovieReviewScore(id);
        }
    }
}
