using Cinema.Domain.Entities;

namespace Cinema.Utilities.Interfaces.Dal
{
    public interface IReviewRepository : IRepository<Review, int>
    {
        bool UserCanVote(int userId, int movieId);
    }
}
