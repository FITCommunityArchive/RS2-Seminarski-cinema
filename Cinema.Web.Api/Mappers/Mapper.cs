using AutoMapper;
using Cinema.Domain.Entities;
using Cinema.Models;
using Cinema.Models.Requests.Movies;
using Cinema.Shared;
using System.Collections.Generic;

namespace Cinema.Web.Api.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<BaseClass, BaseDto>().Include<Movie, MovieDto>();
            CreateMap<Movie, MovieDto>();
            CreateMap<Movie, MovieUpsertRequest>().ReverseMap();
        }
    }
}
