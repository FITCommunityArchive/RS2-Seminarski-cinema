﻿using Cinema.Models.Dtos;
using Cinema.Models.Requests.Movies;
using Cinema.Utilities.Interfaces.Services;
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
    }
}
