using Cinema.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Utilities.Interfaces.Dal
{
    public interface IReviewRepository : IRepository<Review, int>
    {
        bool UserCanVote(int userId, int movieId);
    }
}
