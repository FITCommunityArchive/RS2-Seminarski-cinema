using Cinema.Models.Dtos;
using Cinema.Models.Requests.Reviews;

namespace Cinema.Utilities.Interfaces.Services
{
    public interface IReviewService : ICRUDService<ReviewDto, ReviewSearchRequest, ReviewUpsertRequest, ReviewUpsertRequest>
    {
        bool UserCanVote(int userid, int movieid);
    }
}
