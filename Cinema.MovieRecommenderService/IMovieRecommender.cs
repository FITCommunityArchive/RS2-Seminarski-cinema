namespace Cinema.MovieRecommenderService
{
    public interface IMovieRecommender
    {
        bool TrainModel();
        float PredictScore(int userId, int movieId);
    }
}
