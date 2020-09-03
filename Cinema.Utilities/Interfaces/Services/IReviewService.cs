using Cinema.Models.Dtos;
using Cinema.Models.Requests.Reviews;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces.Services
{
    public interface IReviewService : ICRUDService<ReviewDto, ReviewSearchRequest, ReviewUpsertRequest, ReviewUpsertRequest>
    {
        bool UserCanVote(int userid, int movieid);
    }
}
