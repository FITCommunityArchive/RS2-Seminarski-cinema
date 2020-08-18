using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;

namespace Cinema.Dal.Data
{
    public class Data
    {
        public static void Migrate(CinemaDbContext context)
        {
            if (!context.Database.GetService<IRelationalDatabaseCreator>().Exists())
            {
                Console.WriteLine("Performing database migration...");
            }

            context.Database.Migrate();
        }

        public static void Seed(ModelBuilder modelBuilder)
        {
            SeedHalls(modelBuilder);
            SeedSeats(modelBuilder);
            SeedPricings(modelBuilder);
            SeedNewsTypes(modelBuilder);
            SeedEventTypes(modelBuilder);
            SeedGenres(modelBuilder);
            SeedMovies(modelBuilder);
            SeedGenreMovies(modelBuilder);
            SeedRoles(modelBuilder);
            SeedUsers(modelBuilder);
            SeedScreenings(modelBuilder);
        }

        private static void SeedScreenings(ModelBuilder modelBuilder)
        {
            DateTime today = DateTime.UtcNow.Date;

            modelBuilder.Entity<Screening>().HasData(
                new Screening
                {
                    Id = -1,
                    MovieId = -1,
                    HallId = -1,
                    PricingId = -1,
                    CreatedAt = new DateTime(2020, 8, 12),
                    IsDeleted = false,
                    DateAndTime = new DateTime(2019, 8, 12, 20, 15, 0)
                },
                new Screening
                {
                    Id = -2,
                    MovieId = -1,
                    HallId = -2,
                    PricingId = -1,
                    CreatedAt = new DateTime(2020, 8, 12),
                    IsDeleted = false,
                    DateAndTime = new DateTime(2019, 8, 13, 19, 15, 0)
                },
                new Screening
                {
                    Id = -3,
                    MovieId = -1,
                    HallId = -1,
                    PricingId = -3,
                    CreatedAt = new DateTime(2020, 8, 12),
                    IsDeleted = false,
                    DateAndTime = new DateTime(2019, 9, 20, 19, 15, 0)
                },
                new Screening
                {
                    Id = -4,
                    MovieId = -1,
                    HallId = -2,
                    PricingId = -3,
                    CreatedAt = new DateTime(2020, 8, 12),
                    IsDeleted = false,
                    DateAndTime = new DateTime(2019, 11, 20, 20, 15, 0)
                },
                new Screening
                {
                    Id = -5,
                    MovieId = -2,
                    HallId = -2,
                    PricingId = -4,
                    CreatedAt = new DateTime(2020, 8, 12),
                    IsDeleted = false,
                    DateAndTime = new DateTime(2020, 5, 20, 20, 15, 0)
                },
                new Screening
                {
                    Id = -6,
                    MovieId = -2,
                    HallId = -1,
                    PricingId = -1,
                    CreatedAt = new DateTime(2020, 8, 12),
                    IsDeleted = false,
                    DateAndTime = new DateTime(2020, 5, 25, 21, 0, 0)
                },
                new Screening
                {
                    Id = -7,
                    MovieId = -2,
                    HallId = -2,
                    PricingId = -1,
                    CreatedAt = new DateTime(2020, 8, 12),
                    IsDeleted = false,
                    DateAndTime = new DateTime(2020, 6, 25, 21, 0, 0)
                },
                new Screening
                {
                    Id = -8,
                    MovieId = -3,
                    HallId = -1,
                    PricingId = -5,
                    CreatedAt = new DateTime(2020, 8, 12),
                    IsDeleted = false,
                    DateAndTime = new DateTime(2020, 7, 10, 21, 0, 0)
                },
                new Screening
                {
                    Id = -9,
                    MovieId = -3,
                    HallId = -2,
                    PricingId = -1,
                    CreatedAt = new DateTime(2020, 8, 12),
                    IsDeleted = false,
                    DateAndTime = new DateTime(2020, 7, 10, 23, 0, 0)
                },
                new Screening
                {
                    Id = -10,
                    MovieId = -3,
                    HallId = -1,
                    PricingId = -3,
                    CreatedAt = new DateTime(2020, 8, 12),
                    IsDeleted = false,
                    DateAndTime = new DateTime(2020, 7, 20, 20, 0, 0)
                },
                new Screening
                {
                    Id = -11,
                    MovieId = -3,
                    HallId = -2,
                    PricingId = -3,
                    CreatedAt = new DateTime(2020, 8, 12),
                    IsDeleted = false,
                    DateAndTime = new DateTime(2020, 7, 21, 20, 0, 0)
                },
                new Screening
                {
                    Id = -12,
                    MovieId = -3,
                    HallId = -2,
                    PricingId = -3,
                    CreatedAt = new DateTime(2020, 8, 12),
                    IsDeleted = false,
                    DateAndTime = new DateTime(2020, 8, 21, 20, 0, 0)
                },
                new Screening
                {
                    Id = -14,
                    MovieId = -4,
                    HallId = -1,
                    PricingId = -1,
                    CreatedAt = new DateTime(2020, 8, 12),
                    IsDeleted = false,
                    DateAndTime = today.AddHours(20).AddDays(10)
                },
                new Screening
                {
                    Id = -15,
                    MovieId = -4,
                    HallId = -1,
                    PricingId = -1,
                    CreatedAt = new DateTime(2020, 8, 12),
                    IsDeleted = false,
                    DateAndTime = today.AddHours(22).AddDays(10)
                },
                new Screening
                {
                    Id = -16,
                    MovieId = -4,
                    HallId = -1,
                    PricingId = -1,
                    CreatedAt = new DateTime(2020, 8, 12),
                    IsDeleted = false,
                    DateAndTime = today.AddHours(18).AddDays(15)
                },
                new Screening
                {
                    Id = -17,
                    MovieId = -4,
                    HallId = -1,
                    PricingId = -5,
                    CreatedAt = new DateTime(2020, 8, 12),
                    IsDeleted = false,
                    DateAndTime = today.AddHours(18).AddDays(25)
                }
            );
        }

        private static void SeedGenreMovies(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GenreMovie>().HasData(
                new GenreMovie
                {
                    Id = -1,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    MovieId = -1,
                    GenreId = -1
                },
                new GenreMovie
                {
                    Id = -2,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    MovieId = -1,
                    GenreId = -2
                },
                new GenreMovie
                {
                    Id = -3,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    MovieId = -4,
                    GenreId = -1
                },
                new GenreMovie
                {
                    Id = -4,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    MovieId = -4,
                    GenreId = -2
                },
                new GenreMovie
                {
                    Id = -5,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    MovieId = -2,
                    GenreId = -1
                },
                new GenreMovie
                {
                    Id = -6,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    MovieId = -2,
                    GenreId = -3
                },
                new GenreMovie
                {
                    Id = -7,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    MovieId = -2,
                    GenreId = -4
                },
                new GenreMovie
                {
                    Id = -8,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    MovieId = -3,
                    GenreId = -4
                },
                new GenreMovie
                {
                    Id = -9,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    MovieId = -3,
                    GenreId = -5
                },
                new GenreMovie
                {
                    Id = -10,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    MovieId = -3,
                    GenreId = -6
                });
        }

        private static void SeedMovies(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = -1,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    Title = "Bomb the System",
                    Duration = 91,
                    Year = 2002,
                    Country = "USA",
                    Directors = "Adam Bhala Lough",
                    Writers = "Adam Bhala Lough",
                    Actors = "Mark Webber, Jade Yorker, Jaclyn DeSantis",
                    VideoLink = "https://www.imdb.com/video/vi1706754329?playlistId=tt0337585&ref_=tt_ov_vi"
                },
                new Movie
                {
                    Id = -2,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    Title = "Zu: Warriors from the Magic Mountain",
                    Duration = 102,
                    Year = 1983,
                    Country = "Hong Kong",
                    Directors = "Hark Tsui",
                    Writers = "Cheuk-Hon Szeto",
                    Actors = "Biao Yuen, Hoi Mang, Adam Cheng",
                    VideoLink = "https://www.imdb.com/video/vi645768729?playlistId=tt0086308&ref_=tt_ov_vi"
                },
                new Movie
                {
                    Id = -3,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    Title = "Dinotopia: Quest for the Ruby Sunstone",
                    Duration = 75,
                    Year = 2005,
                    Country = "USA",
                    Directors = "Davis Doi",
                    Writers = "Sean Roche, James Gurney",
                    Actors = "Alyssa Milano, Jamie Kennedy, Kathy Griffin",
                    VideoLink = "https://www.imdb.com/video/vi1889665305?playlistId=tt0372238&ref_=tt_ov_vi"
                },
                new Movie
                {
                    Id = -4,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    Title = "Battle in Seattle",
                    Duration = 98,
                    Year = 2007,
                    Country = "Canada, USA, Germany",
                    Directors = "Stuart Townsend",
                    Writers = "Stuart Townsend",
                    Actors = "André Benjamin, Jennifer Carpenter, Isaach De Bankolé",
                    VideoLink = "https://www.imdb.com/video/vi1761450777?playlistId=tt0850253&ref_=tt_ov_vi"
                }
            );
        }

        private static void SeedGenres(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                            new Genre
                            {
                                Id = -1,
                                CreatedAt = new DateTime(2020, 7, 7),
                                IsDeleted = false,
                                Name = "Action"
                            },
                            new Genre
                            {
                                Id = -2,
                                CreatedAt = new DateTime(2020, 7, 7),
                                IsDeleted = false,
                                Name = "Drama"
                            },
                            new Genre
                            {
                                Id = -3,
                                CreatedAt = new DateTime(2020, 7, 7),
                                IsDeleted = false,
                                Name = "Adventure"
                            },
                            new Genre
                            {
                                Id = -4,
                                CreatedAt = new DateTime(2020, 7, 7),
                                IsDeleted = false,
                                Name = "Fantasy"
                            },
                            new Genre
                            {
                                Id = -5,
                                CreatedAt = new DateTime(2020, 7, 7),
                                IsDeleted = false,
                                Name = "Animation"
                            },
                            new Genre
                            {
                                Id = -6,
                                CreatedAt = new DateTime(2020, 7, 7),
                                IsDeleted = false,
                                Name = "Comedy"
                            });
        }

        private static void SeedEventTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventType>().HasData(
                            new EventType
                            {
                                Id = -1,
                                CreatedAt = new DateTime(2020, 7, 7),
                                IsDeleted = false,
                                Name = "Event Type 1"
                            },
                            new EventType
                            {
                                Id = -2,
                                CreatedAt = new DateTime(2020, 7, 7),
                                IsDeleted = false,
                                Name = "Event Type 2"
                            }
                        );
        }

        private static void SeedNewsTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewsType>().HasData(
                new NewsType
                {
                    Id = -1,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    Name = "News Type 1"
                },
                new NewsType
                {
                    Id = -2,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    Name = "News Type 2"
                }
            );
        }

        private static void SeedHalls(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hall>().HasData(
                new Hall
                {
                    Id = -1,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    Name = "Movie Hall 1",
                    NumberOfColumns = 16,
                    NumberOfRows = 15
                },
                new Hall
                {
                    Id = -2,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    Name = "Movie Hall 2",
                    NumberOfColumns = 16,
                    NumberOfRows = 15
                }
            );
        }

        private static void SeedSeats(ModelBuilder modelBuilder)
        {
            int numberOfHallColumns = 16;
            int numberOfHallRows = 15;

            List<Seat> seats = new List<Seat>();
            int seatId = -1;

            for (int i = 1; i <= numberOfHallColumns; i++)
            {
                for (int j = 1; j <= numberOfHallRows; j++)
                {
                    Seat seatFirstHall = new Seat
                    {
                        Id = seatId--,
                        CreatedAt = new DateTime(2020, 7, 7),
                        IsDeleted = false,
                        HallId = -1,
                        SeatNumber = i * j
                    };

                    Seat seatSecondHall = new Seat
                    {
                        Id = seatId--,
                        CreatedAt = new DateTime(2020, 7, 7),
                        IsDeleted = false,
                        HallId = -2,
                        SeatNumber = i * j
                    };

                    seats.Add(seatFirstHall);
                    seats.Add(seatSecondHall);
                }
            }

            modelBuilder.Entity<Seat>().HasData(seats);
        }

        private static void SeedPricings(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pricing>().HasData(
                new Pricing
                {
                    Id = -1,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    Name = "Regular",
                    Price = 7
                },
                new Pricing
                {
                    Id = -2,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    Name = "Weekend",
                    Price = 8
                },
                new Pricing
                {
                    Id = -3,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    Name = "3D",
                    Price = 10
                },
                new Pricing
                {
                    Id = -4,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    Name = "Students",
                    Price = 6
                },
                new Pricing
                {
                    Id = -5,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    Name = "Premiere",
                    Price = 12
                }
            );
        }

        private static void SeedRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationRole>().HasData(
                new ApplicationRole
                {
                    Id = "-1",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                new ApplicationRole
                {
                    Id = "-2",
                    Name = "Content Editor",
                    NormalizedName = "CONTENT EDITOR"
                },
                new ApplicationRole
                {
                    Id = "-3",
                    Name = "Customer",
                    NormalizedName = "CUSTOMER"
                }
            );
        }

        private static void SeedUsers(ModelBuilder modelBuilder)
        {

            const string ADMIN_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e575";
            ApplicationUser appUser = new ApplicationUser
            {
                Id = ADMIN_ID,
                UserName = "admin",
                Email = "admin@admin.com",
                NormalizedEmail = "admin@admin.com".ToUpper(),
                NormalizedUserName = "admin".ToUpper(),
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                PhoneNumber = "123456789",
                PhoneNumberConfirmed = false
            };

            PasswordHasher<ApplicationUser> ph = new PasswordHasher<ApplicationUser>();
            appUser.PasswordHash = ph.HashPassword(appUser, "test1234");

            modelBuilder.Entity<ApplicationUser>().HasData(
                appUser
            );

            modelBuilder.Entity<ApplicationUserRole>().HasData(new ApplicationUserRole
            {
                UserId = ADMIN_ID,
                RoleId = "-1"
            });
        }
    }
}
