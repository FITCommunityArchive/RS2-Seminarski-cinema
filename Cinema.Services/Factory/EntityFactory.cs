using Cinema.Domain.Entities;
using Cinema.DTO.ViewModels.Movies;
using Cinema.DTO.ViewModels.Screenings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services.Factory
{
    public static class EntityFactory
    {
        public static Movie Create(this MovieCreateVM movie)
        {
            return new Movie
            {
                Title = movie.Title,
                Duration = movie.Duration,
                Actors = movie.Actors,
                Directors = movie.Directors,
                Year = movie.Year,
                Country = movie.Country,
                Image = movie.Image,
                VideoLink = movie.VideoLink
            };
        }

        public static Screening Create(this ScreeningCreateVM screening)
        {
            return new Screening
            {
                MovieId = screening.MovieId,
                HallId = screening.HallId,
                DateAndTime = screening.DateAndTime
            };
        }

    }
}
