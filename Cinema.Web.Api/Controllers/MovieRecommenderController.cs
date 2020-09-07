using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.MovieRecommenderService;
using Cinema.Web.Api.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ML;

namespace Cinema.Web.Api.Controllers
{
    [Route("api/[controller]")]
    public class MovieRecommenderController : ControllerBase
    {
        private readonly PredictionEnginePool<MovieRating, MovieRatingPrediction> _predictionEnginePool;
        private readonly IMovieRecommender _recommenderService;
        public MovieRecommenderController(PredictionEnginePool<MovieRating, MovieRatingPrediction> predictionEnginePool, IMovieRecommender recommenderService)
        {
            _predictionEnginePool = predictionEnginePool;
            _recommenderService = recommenderService;
        }

        [HttpPost("predict")]
        public ActionResult<int> Post([FromBody] MovieRating input)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            MovieRatingPrediction prediction = _predictionEnginePool.Predict(modelName: "MovieRatingAnalysisModel", example: input);

            return Ok(prediction.Score);
        }

        [HttpGet("train-model")]
        public ActionResult<bool> TrainModel()
        {
            var result = _recommenderService.TrainModel();
            if(result)
            {
                return true;
            }
            return false;
        }
    }
}
