using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Web.Api.DataModels
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

    public class MovieRatingPrediction : MovieRating
    {
        [ColumnName("PredictedLabel")]
        public bool Prediction { get; set; }
        public float Probability { get; set; }
        public float Score { get; set; }
    }
}
