using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Reviews;
using Cinema.Utilities.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.Web.Api.Controllers
{
    public class ReviewsController : BaseCRUDController<ReviewDto, ReviewSearchRequest, ReviewUpsertRequest, ReviewUpsertRequest>
    {

        public ReviewsController(ICRUDService<ReviewDto, ReviewSearchRequest, ReviewUpsertRequest, ReviewUpsertRequest> service) : base(service)
        {

        }
    }
}
