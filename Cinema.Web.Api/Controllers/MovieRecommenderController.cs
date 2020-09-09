using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.MovieRecommenderService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ML;

namespace Cinema.Web.Api.Controllers
{
    [Route("api/[controller]")]
    public class MovieRecommenderController : ControllerBase
    {
        private readonly IMovieRecommender _recommenderService;
        public MovieRecommenderController(IMovieRecommender recommenderService)
        {
            _recommenderService = recommenderService;
        }

        [HttpPost("predict/{userId}/{movieId}")]
        public ActionResult<int> Post(int userId,int movieId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = _recommenderService.PredictScore(userId, movieId);
            return Ok(result);
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
