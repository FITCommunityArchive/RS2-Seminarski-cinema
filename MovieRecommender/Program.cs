using Cinema.Dal.Data;
using Cinema.Utilities.Interfaces.Dal;
using Cinema.Utilities.Interfaces.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.ML;
using Microsoft.ML.Trainers;
using System;
using System.IO;
using System.Linq;

namespace MovieRecommender
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string workingDirectory = Environment.CurrentDirectory;

            // In this example, "ApplicationDbContext" is my DbContext class
            var options = new DbContextOptionsBuilder<CinemaDbContext>()
                    .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Cinema;Trusted_Connection=True;MultipleActiveResultSets=true")
                    .Options;

            CinemaDbContext context = new CinemaDbContext(options);
            var result = context.Reviews.ToList();

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("userId,movieId,rating");
            foreach (var item in result)
            {
                sb.AppendLine(item.UserId.ToString() + "," + item.MovieId.ToString() + "," + item.Rating.ToString());
            }

            File.WriteAllText(
                Path.Combine(
                Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Data", "movieRecommend-training-data.csv"),
                sb.ToString());

            context.Dispose();


            MLContext mlContext = new MLContext();
            (IDataView trainingDataView, IDataView testDataView) = LoadData(mlContext);

            ITransformer model = BuildAndTrainModel(mlContext, trainingDataView);
            EvaluateModel(mlContext, testDataView, model);

            UseModelForSinglePrediction(mlContext, model);

            SaveModel(mlContext, trainingDataView.Schema, model);

            //Define DataViewSchema for data preparation pipeline and trained model
            DataViewSchema modelSchema;

            // Load trained model
            ITransformer trainedModel = mlContext.Model.Load(Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Data\\MovieRecommenderModel.zip", out modelSchema);

            UseModelForSinglePrediction(mlContext, trainedModel);
        }

        public static (IDataView training, IDataView test) LoadData(MLContext mlContext)
        {
            string workingDirectory = Environment.CurrentDirectory;

            var trainingDataPath = Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.FullName, "Data", "movieRecommend-training-data.csv");
            var testDataPath = Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.FullName, "Data", "movieRecommend-test-data.csv");

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

            Console.WriteLine("=============== Training the model ===============");
            ITransformer model = trainerEstimator.Fit(trainingDataView);

            return model;
        }

        public static void EvaluateModel(MLContext mlContext, IDataView testDataView, ITransformer model)
        {
            Console.WriteLine("=============== Evaluating the model ===============");
            var prediction = model.Transform(testDataView);
            var metrics = mlContext.Regression.Evaluate(prediction, labelColumnName: "Label", scoreColumnName: "Score");
            Console.WriteLine("Root Mean Squared Error : " + metrics.RootMeanSquaredError.ToString());
            Console.WriteLine("RSquared: " + metrics.RSquared.ToString());
        }

        public static void UseModelForSinglePrediction(MLContext mlContext, ITransformer model)
        {
            Console.WriteLine("=============== Making a prediction ===============");
            var predictionEngine = mlContext.Model.CreatePredictionEngine<MovieRating, MovieRatingPrediction>(model);

            var testInput = new MovieRating { userId = -500, movieId = -8 };

            var movieRatingPrediction = predictionEngine.Predict(testInput);

            if (Math.Round(movieRatingPrediction.Score, 1) > 3.5)
            {
                Console.WriteLine("Movie " + testInput.movieId + " is recommended for user " + testInput.userId);
            }
            else
            {
                Console.WriteLine("Movie " + testInput.movieId + " is not recommended for user " + testInput.userId);
            }
        }


        public static void SaveModel(MLContext mlContext, DataViewSchema trainingDataViewSchema, ITransformer model)
        {
            string workingDirectory = Environment.CurrentDirectory;

            var modelPath = Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.FullName, "Data", "MovieRecommenderModel.zip");

            Console.WriteLine("=============== Saving the model to a file ===============");
            mlContext.Model.Save(model, trainingDataViewSchema, modelPath);
        }
    }
}
