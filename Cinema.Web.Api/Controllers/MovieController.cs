using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cinema.Models;
using Cinema.Services;

namespace Cinema.Web.Api.Controllers
{
    public class MovieController : BaseController<DtoMovie, object>
    {
        public MovieController(IService<DtoMovie, object> service) : base(service)
        {
        }
    }
}
