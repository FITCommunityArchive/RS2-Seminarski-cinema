using AutoMapper;
using Cinema.Domain.Entities;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Reviews;
using Cinema.Utilities.Interfaces.Dal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services
{
    public class ReviewService : BaseCRUDService<ReviewDto, ReviewSearchRequest, Review, ReviewUpsertRequest, ReviewUpsertRequest>
    {
        public ReviewService(IUnitOfWork unit, IMapper mapper) : base(unit, mapper)
        {
        }
    }
}
