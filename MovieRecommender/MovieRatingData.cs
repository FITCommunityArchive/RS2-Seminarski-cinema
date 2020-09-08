using Microsoft.ML.Data;

namespace MovieRecommender
{
    public class MovieRating
    {
        [LoadColumn(0)]
        public float userId;
        [LoadColumn(1)]
        public float movieId;
        [ColumnName("Label"),LoadColumn(2)]
        public float rating;

    }

    public class MovieRatingPrediction
    {
        public float Label;
        public float Score;
    }
}
