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
    public class MovieController : BaseCRUDController<DtoMovie,object,MovieUpsertRequest,MovieUpsertRequest>
    {
        public MovieController(ICRUDService<DtoMovie,object,MovieUpsertRequest,MovieUpsertRequest> service) : base(service)
        {
        }
    }
}
