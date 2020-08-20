using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Cinema.Models.Dtos;

namespace Cinema.Utilities.Factory
{
    public static class MasterModelFactory
    {
        public static MasterDto CreateMaster(this Seat seat)
        {
            return new MasterDto
            {
                Id = seat.Id,
                Name = seat.Label
            };
        }
        public static MasterDto CreateMaster(this Movie movie)
        {
            return new MasterDto
            {
                Id = movie.Id,
                Name = movie.Title
            };
        }
        public static MasterDto CreateMaster(this Screening screening)
        {
            return new MasterDto
            {
                Id = screening.Id,
                Name = screening.Movie.Title + " " + screening.Hall.Name
            };
        }
        public static MasterDto CreateMaster(this Review review)
        {
            return new MasterDto
            {
                Id = review.Id,
                Name = review.User.FullName + ", " + review.Movie.Title
            };
        }
        public static MasterDto CreateMaster(this GenreMovie genreMovie)
        {
            return new MasterDto
            {
                Id = genreMovie.Id,
                Name = genreMovie.Movie.Title + ", " + genreMovie.Genre.Name
            };
        }
        public static MasterDto CreateMaster(this Genre genre)
        {
            return new MasterDto
            {
                Id = genre.Id,
                Name = genre.Name
            };
        }

        public static MasterDto CreateMaster(this EventType eventType)
        {
            return new MasterDto
            {
                Id = eventType.Id,
                Name = eventType.Name
            };
        }

        public static MasterDto CreateMaster(this NewsType newsType)
        {
            return new MasterDto
            {
                Id = newsType.Id,
                Name = newsType.Name
            };
        }

        public static MasterDto CreateMaster(this ApplicationUser user)
        {
            return new MasterDto
            {
                Id = user.Id,
                Name = user.FullName
            };
        }

        public static MasterDto CreateMaster(this ApplicationRole role)
        {
            return new MasterDto
            {
                Id = role.Id,
                Name = role.Name
            };
        }

        public static MasterDto CreateMaster(this Pricing pricing)
        {
            return new MasterDto
            {
                Id = pricing.Id,
                Name = $"{pricing.Name} | {pricing.Price}"
            };
        }

        public static MasterDto CreateMaster(this Hall hall)
        {
            return new MasterDto
            {
                Id = hall.Id,
                Name = hall.Name
            };
        }
    }
}
