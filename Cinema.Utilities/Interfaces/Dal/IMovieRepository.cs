using Cinema.Domain.Entities;
using Cinema.Shared.Pagination;
using Cinema.Shared.Search;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces.Dal
{
    public interface IMovieRepository : IRepository<Movie, int>
    {
        Task<IPagedList<Movie>> GetPagedAsync(ISearchRequest searchRequest, string searchTerm, int? searchYear, int? searchDuration);
        Task<Movie> GetByIdWithGenresAsync(int id);
        double GetMovieReviewScore(int id);
    }
}
