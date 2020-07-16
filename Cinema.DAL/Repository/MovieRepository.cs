using Cinema.Domain.Entities;
using Cinema.Utilities.Interfaces;

namespace Cinema.Dal.Repository
{
    public class MovieRepository : Repository<Movie, int>
    {

        public MovieRepository(ICinemaDbContext context) : base(context) { }
    }
}
