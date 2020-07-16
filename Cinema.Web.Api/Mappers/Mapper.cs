using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Domain;
using Cinema.Domain.Entities;
using Cinema.Models;
using Cinema.Models.Requests;

namespace Cinema.Web.Api.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<BaseClass, BaseDto>().Include<Movie,MovieDto>();
            CreateMap<Movie, MovieDto>();
            CreateMap<Movie, MovieUpsertRequest>().ReverseMap();

            //CreateMap<Database.Korisnici, Model.Korisnici>();
            //CreateMap<Database.Korisnici, Model.Requests.KorisniciInsertRequest>().ReverseMap();
            //CreateMap<Database.JediniceMjere, Model.JediniceMjere>();
            //CreateMap<Database.VrsteProizvoda, Model.VrsteProizvoda>();
            //CreateMap<Database.Proizvodi, Model.Proizvod>();
            //CreateMap<Database.Proizvodi, Model.Requests.ProizvodUpsertRequest>().ReverseMap();
            //CreateMap<Database.Uloge, Model.Uloge>();
        }
    }
}
