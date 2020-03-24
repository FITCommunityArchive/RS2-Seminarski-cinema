using Cinema.Domain.Entities;
using Cinema.DTO.ViewModels.Movies;
using Cinema.DTO.ViewModels.Reviews;
using Cinema.DTO.ViewModels.Screenings;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema.Services.Factory
{
    public static class ViewModelFactory
    {
        public static MovieIndexVM ToIndexVM(this Movie movie)
        {
            return new MovieIndexVM
            {
                Id = movie.Id,
                Title = movie.Title,
                Duration = movie.Duration,
                Actors = movie.Actors,
                Year = movie.Year,
                Country = movie.Country,
                Image = movie.Image,
                VideoLink = movie.VideoLink
            };
        }

        public static MovieCreateVM ToCreateVM(this Movie movie)
        {
            return new MovieCreateVM
            {
                Title = movie.Title,
                Duration = movie.Duration,
                Actors = movie.Actors,
                Year = movie.Year,
                Country = movie.Country,
                Image = movie.Image,
                VideoLink = movie.VideoLink
            };
        }

        public static ScreeningIndexVM ToIndexVM(this Screening screening)
        {
            return new ScreeningIndexVM
            {
                Id = screening.Id,
                Movie = screening.Movie.Title,
                Hall = screening.Hall.Name,
                DateAndTime = screening.DateAndTime
            };
        }

        public static ScreeningCreateVM ToCreateVM(this Screening screening, SelectList movies, SelectList halls)
        {
            return new ScreeningCreateVM
            {
                Id = screening.Id,
                Movie = screening.Movie.Title,
                Hall = screening.Hall.Name,
                Movies = movies,
                Halls = halls,
                DateAndTime = screening.DateAndTime
            };
        }

        public static NowShowingDetailsVM ToNowShowingIndexVM(this Movie movie, string currentUserId)
        {
            return new NowShowingDetailsVM
            {
                Id = movie.Id,
                Directors = movie.Directors,
                Duration = movie.Duration,
                VideoLink = movie.VideoLink,
                Actors = movie.Actors,
                Country = movie.Country,
                GenreMovies = movie.GenreMovies,
                Screenings = movie.Screenings,
                Title = movie.Title,
                Year = movie.Year,
                NumberOfReviews = movie.Reviews?.Count() > 0 ? movie.Reviews.Count().ToString() : "N/A",
                AverageRating = movie.Reviews?.Count() > 0 ? movie.Reviews?.Average(x => x.Rating).ToString("#.##") : "N/A",
                CurrentUserReview = movie.Reviews?.SingleOrDefault(x => x.UserId == currentUserId)?.ToIndexVM(),
                ScreeningList = movie.Screenings.OrderBy(x => x.DateAndTime).Select(x => new NowShowingDetailsVM.Row
                {
                    HallName = x.Hall.Name,
                    Playing = x.DateAndTime,
                    HallId = x.Hall.Id
                }).ToList()
            };
        }

        public static ReviewIndexVM ToIndexVM(this Review review)
        {
            return new ReviewIndexVM
            {
                ReviewId = review.Id,
                Text = review.Text,
                Rating = review.Rating,
                Movie = review.Movie?.CreateMaster(),
                User = review.User?.CreateMaster()
            };
        }

        public static ReviewUpdateVM ToUpdateVM(this Review review)
        {
            return new ReviewUpdateVM
            {
                Id = review.Id,
                Rating = review.Rating,
                Movie = review.Movie.CreateMaster(),
                UserId = review.User.Id
            };
        }
    }
}
