﻿using Cinema.Models.Dtos;
using Cinema.Models.Requests;
using Cinema.Common.Interfaces.Services;

namespace Cinema.Web.Api.Controllers
{
    public class NewsTypesController : BaseController<NewsTypeDto, BaseSearchRequest>
    {
        public NewsTypesController(IService<NewsTypeDto, BaseSearchRequest> service) : base(service)
        {
        }
    }
}
