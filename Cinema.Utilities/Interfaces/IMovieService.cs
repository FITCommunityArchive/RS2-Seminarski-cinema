using Cinema.Models;
using Cinema.Shared;

namespace Cinema.Utilities.Interfaces
{
    public interface IMovieService
    {
        PagedList<MovieDto> GetPaged();
        MovieDto GetById();
        //IEnumerable<DtoMovie> GetComingSoonMovies(int quantity);

        //DtoMovie Update(int id, MovieInsertRequest req);
        //DtoMovie Insert(KorisniciInsertRequest req);
    }
}
