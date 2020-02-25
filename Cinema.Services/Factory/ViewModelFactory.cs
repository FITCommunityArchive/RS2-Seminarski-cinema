using Cinema.Domain.Entities;
using Cinema.DTO.ViewModels.Movies;
using System;
using System.Collections.Generic;
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
    }
}
