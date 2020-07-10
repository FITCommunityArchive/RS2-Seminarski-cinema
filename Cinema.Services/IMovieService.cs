using Cinema.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services
{
    public interface IMovieService
    {
        //List<DtoMovie> Get(MovieSearchRequest req);
        DtoMovie GetById();
        //IEnumerable<DtoMovie> GetComingSoonMovies(int quantity);

        //DtoMovie Update(int id, MovieInsertRequest req);
        //DtoMovie Insert(KorisniciInsertRequest req);
    }
}
