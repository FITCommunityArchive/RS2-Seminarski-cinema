using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Cinema.DTO.ViewModels.Events;
using Cinema.DTO.ViewModels.Movies;
using Cinema.DTO.ViewModels.News;
using Cinema.DTO.ViewModels.Pricings;
using Cinema.DTO.ViewModels.Reviews;
using Cinema.DTO.ViewModels.Screenings;
using Cinema.DTO.ViewModels.Users;

namespace Cinema.Services.Factory
{
    public static class EntityFactory
    {
        public static Movie Create(this MovieCreateVM movie)
        {
            return new Movie
            {
                Id = movie.Id,
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
                Id = screening.Id,
                MovieId = screening.MovieId,
                HallId = screening.HallId,
                PricingId = screening.PricingId,
                DateAndTime = screening.DateAndTime
            };
        }

        public static Review Create(this ReviewCreateVM review)
        {
            return new Review
            {
                MovieId = review.Movie.Id,
                UserId = review.UserId,
                Rating = review.Rating
            };
        }

        public static Review Create(this ReviewUpdateVM review)
        {
            return new Review
            {
                Id = review.Id,
                MovieId = review.Movie.Id,
                UserId = review.UserId,
                Rating = review.Rating
            };
        }

        public static Review Create(this ReviewIndexVM review)
        {
            return new Review
            {
                Id = review.ReviewId,
                MovieId = review.Movie.Id,
                UserId = review.User.Id,
                Rating = review.Rating
            };
        }

        public static ApplicationUser Create(this ApplicationUserCreateVM user)
        {
            return new ApplicationUser
            {
                Email = user.Email,
                UserName = user.Email,
                EmailConfirmed = true,
                PhoneNumber = user.PhoneNumber,
                PhoneNumberConfirmed = true,
                FirstName = user.FirstName,
                LastName = user.LastName,
                NormalizedEmail = user.Email.ToUpper(),
                NormalizedUserName = user.Email.ToUpper()
            };
        }

        public static void Update(this ApplicationUserCreateVM userModel, ApplicationUser user)
        {
            user.UserName = userModel.Email;
            user.EmailConfirmed = true;
            user.PhoneNumber = userModel.PhoneNumber;
            user.PhoneNumberConfirmed = true;
            user.FirstName = userModel.FirstName;
            user.LastName = userModel.LastName;
            user.NormalizedEmail = userModel.Email.ToUpper();
            user.NormalizedUserName = userModel.Email.ToUpper();
        }

        public static Event Create(this EventCreateVM model)
        {
            return new Event
            {
                Id = model.Id,
                AuthorId = model.AuthorId,
                Description = model.Description,
                Title = model.Title,
                DateAndTime = model.DateAndTime,
                Promoter = model.Title,
                TypeId = model.EventTypeId,
                Image = model.Image
            };
        }

        public static News Create(this NewsCreateVM model)
        {
            return new News
            {
                Id = model.Id,
                AuthorId = model.AuthorId,
                Description = model.Description,
                Title = model.Title,
                TypeId = model.NewsTypeId,
                Image = model.Image
            };
        }

        public static Pricing Create(this PricingCreateVM model)
        {
            return new Pricing
            {
                Id = model.Id,
                Name = model.Name,
                Price = (decimal)model.Price
            };
        }
    }
}
