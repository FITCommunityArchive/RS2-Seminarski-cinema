using AutoMapper;
using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Movies;
using Cinema.Models.Requests.Users;

namespace Cinema.Web.Api.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<BaseClass, BaseDto>().Include<Movie, MovieDto>();
            CreateMap<Movie, MovieDto>();
            CreateMap<Movie, MovieUpsertRequest>().ReverseMap();
            CreateMap<ApplicationUser, ApplicationUserDto>(); 
            CreateMap<ApplicationRole, ApplicationRoleDto>();
            CreateMap<ApplicationUserRole, ApplicationUserRoleDto>();
            CreateMap<ApplicationUser, UserUpsertRequest>().ReverseMap();
            CreateMap<ApplicationUser, UserSearchRequest>().ReverseMap();
            CreateMap<Genre, GenreDto>();
            CreateMap<GenreMovie, GenreMovieDto>();
        }
    }
}
