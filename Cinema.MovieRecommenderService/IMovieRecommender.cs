using Cinema.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.MovieRecommenderService
{
    public interface IMovieRecommender
    {
        bool TrainModel();
    }
}
