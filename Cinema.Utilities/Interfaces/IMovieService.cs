using Cinema.Models;
using System.Collections.Generic;

namespace Cinema.Utilities.Interfaces
{
    public interface IMovieService
    {
        List<MovieDto> Get();
        MovieDto GetById();
        //IEnumerable<DtoMovie> GetComingSoonMovies(int quantity);

        //DtoMovie Update(int id, MovieInsertRequest req);
        //DtoMovie Insert(KorisniciInsertRequest req);
    }
}
