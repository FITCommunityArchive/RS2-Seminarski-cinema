using Cinema.Domain.Entities;
using Cinema.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services.Factory
{
    public static class MasterModelFactory
    {
        public static MasterModel CreateMaster(this Seat seat)
        {
            return new MasterModel
            {
                Id = seat.Id,                
                Name = seat.Label
            };
        }
        public static MasterModel CreateMaster(this Movie movie)
        {
            return new MasterModel
            {
                Id = movie.Id,
                Name = movie.Title
            };
        }
        public static MasterModel CreateMaster(this Screening screening)
        {
            return new MasterModel
            {
                Id = screening.Id,
                Name = screening.Movie.Title + " " + screening.Hall.Name
            };
        }
        public static MasterModel CreateMaster(this Review review)
        {
            return new MasterModel
            {
                Id = review.Id,
                Name = review.User.FullName + ", " + review.Movie.Title
            };
        }
        public static MasterModel CreateMaster(this GenreMovie genreMovie)
        {
            return new MasterModel
            {
                Id = genreMovie.Id,
                Name = genreMovie.Movie.Title + ", " + genreMovie.Genre.Name
            };
        }
        public static MasterModel CreateMaster(this Genre genre)
        {
            return new MasterModel
            {
                Id = genre.Id,
                Name = genre.Name
            };
        }
    }
}
