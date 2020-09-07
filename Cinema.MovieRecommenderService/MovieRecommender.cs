using Cinema.Dal.Data;
using Cinema.Domain.Entities;
using Cinema.MovieRecommenderService.Models;
using Cinema.Utilities.Interfaces.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML;
using Microsoft.ML.Trainers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.MovieRecommenderService
{
    public class MovieRecommender : IMovieRecommender
    {
        public static string workingDirectory = Directory.GetParent(Environment.CurrentDirectory).FullName + "\\Cinema.MovieRecommenderService\\Data";

        private readonly IUnitOfWork _unit;
        private readonly IReviewRepository _reviewRepo;
        
        public MovieRecommender(IUnitOfWork unit)
        {
            _unit = unit;
            _reviewRepo = unit.Reviews;
        }

        public bool TrainModel()
        {
            var data = _reviewRepo.Get().ToList();
            BuildDataSpreadsheet(data);

            MLContext mlContext = new MLContext();
            (IDataView trainingDataView, IDataView testDataView) = LoadData(mlContext);

            ITransformer model = BuildAndTrainModel(mlContext, trainingDataView);
            SaveModel(mlContext, trainingDataView.Schema, model);
            return true;
        }

        private void BuildDataSpreadsheet(IEnumerable<Review> data)
        {
            System.Text.StringBuilder spreadsheet = new System.Text.StringBuilder();
            spreadsheet.AppendLine("userId,movieId,rating");
            foreach (var item in data)
            {
                spreadsheet.AppendLine(item.UserId.ToString() + "," + item.MovieId.ToString() + "," + item.Rating.ToString());
            }

            File.WriteAllText(
                Path.Combine(
                workingDirectory, "movieRecommend-training-data.csv"),
                spreadsheet.ToString());
        }


        public static (IDataView training, IDataView test) LoadData(MLContext mlContext)
        {
            var trainingDataPath = Path.Combine(workingDirectory, "movieRecommend-training-data.csv");
            var testDataPath = Path.Combine(workingDirectory, "movieRecommend-test-data.csv");

            IDataView trainingDataView = mlContext.Data.LoadFromTextFile<MovieRating>(trainingDataPath, hasHeader: true, separatorChar: ',');
            IDataView testDataView = mlContext.Data.LoadFromTextFile<MovieRating>(testDataPath, hasHeader: true, separatorChar: ',');

            return (trainingDataView, testDataView);
        }


        public static ITransformer BuildAndTrainModel(MLContext mlContext, IDataView trainingDataView)
        {
            IEstimator<ITransformer> estimator = mlContext.Transforms.Conversion.MapValueToKey(outputColumnName: "userIdEncoded", inputColumnName: "userId")
                .Append(mlContext.Transforms.Conversion.MapValueToKey(outputColumnName: "movieIdEncoded", inputColumnName: "movieId"));

            var options = new MatrixFactorizationTrainer.Options
            {
                MatrixColumnIndexColumnName = "userIdEncoded",
                MatrixRowIndexColumnName = "movieIdEncoded",
                LabelColumnName = "Label",
                NumberOfIterations = 20,
                ApproximationRank = 100
            };

            var trainerEstimator = estimator.Append(mlContext.Recommendation().Trainers.MatrixFactorization(options));

            ITransformer model = trainerEstimator.Fit(trainingDataView);

            return model;
        }

        public static void EvaluateModel(MLContext mlContext, IDataView testDataView, ITransformer model)
        {
            //Console.WriteLine("=============== Evaluating the model ===============");
            var prediction = model.Transform(testDataView);
            var metrics = mlContext.Regression.Evaluate(prediction, labelColumnName: "Label", scoreColumnName: "Score");
            //Console.WriteLine("Root Mean Squared Error : " + metrics.RootMeanSquaredError.ToString());
            //Console.WriteLine("RSquared: " + metrics.RSquared.ToString());
        }

        public static void UseModelForSinglePrediction(MLContext mlContext, ITransformer model)
        {
            //Console.WriteLine("=============== Making a prediction ===============");
            var predictionEngine = mlContext.Model.CreatePredictionEngine<MovieRating, MovieRatingPrediction>(model);

            var testInput = new MovieRating { userId = -500, movieId = -8 };

            var movieRatingPrediction = predictionEngine.Predict(testInput);

            if (Math.Round(movieRatingPrediction.Score, 1) > 3.5)
            {
                //Console.WriteLine("Movie " + testInput.movieId + " is recommended for user " + testInput.userId);
            }
            else
            {
                //Console.WriteLine("Movie " + testInput.movieId + " is not recommended for user " + testInput.userId);
            }
        }


        public static void SaveModel(MLContext mlContext, DataViewSchema trainingDataViewSchema, ITransformer model)
        {
            var modelPath = Path.Combine(Environment.CurrentDirectory, "MLModels", "MovieRecommenderModel.zip");
            mlContext.Model.Save(model, trainingDataViewSchema, modelPath);
        }
    }
}
