using Microsoft.ML.Data;

namespace Cinema.MovieRecommenderService.Models
{
    public class MovieRating
    {
        [LoadColumn(0)]
        public float userId;
        [LoadColumn(1)]
        public float movieId;
        [ColumnName("Label"), LoadColumn(2)]
        public float rating;

    }
}
