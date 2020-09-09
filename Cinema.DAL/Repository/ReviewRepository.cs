using Cinema.Domain.Entities;
using Cinema.Utilities.Interfaces.Dal;
using System.Linq;

namespace Cinema.Dal.Repository
{
    public class ReviewRepository : Repository<Review, int>, IReviewRepository
    {
        public ReviewRepository(ICinemaDbContext context) : base(context) { }

        public bool UserCanVote(int userId, int movieId)
        {

            var review = _dbSet.Where(x => x.UserId == userId && x.MovieId == movieId).FirstOrDefault();
            if (review != null)
            {
                return false;
            }
            return true;
        }
    }
}
