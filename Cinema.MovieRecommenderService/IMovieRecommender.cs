using Cinema.Domain.Entities;
using Cinema.MovieRecommenderService.Models;
using Microsoft.Extensions.ML;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.MovieRecommenderService
{
    public interface IMovieRecommender
    {
        bool TrainModel();
        float PredictScore(int userId, int movieId);
    }
}
