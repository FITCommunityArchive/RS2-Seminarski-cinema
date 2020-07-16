using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cinema.Models;
using Cinema.Services;
using Cinema.Models.Requests;

namespace Cinema.Web.Api.Controllers
{
    public class MoviesController : BaseCRUDController<MovieDto, object, MovieUpsertRequest, MovieUpsertRequest>
    {
        public MoviesController(ICRUDService<MovieDto, object, MovieUpsertRequest, MovieUpsertRequest> service) : base(service)
        {
        }
    }
}
