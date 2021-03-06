﻿using Cinema.Common.Interfaces.Services;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Reviews;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.Web.Api.Controllers
{
    public class ReviewsController : BaseCRUDController<ReviewDto, ReviewSearchRequest, ReviewUpsertRequest, ReviewUpsertRequest>
    {
        private readonly IReviewService _reviewService;
        public ReviewsController(IReviewService service) : base(service)
        {
            _reviewService = service;
        }

        [HttpGet("canVote")]
        public bool UserCanVote(int userid, int movieid)
        {
            return _reviewService.UserCanVote(userid, movieid);
        }
    }
}
