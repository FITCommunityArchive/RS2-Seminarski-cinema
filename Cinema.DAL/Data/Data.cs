using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
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
            int numberOfHallColumns = 16;
            int numberOfHallRows = 15;

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
                    Actors =  "Mark Webber, Jade Yorker, Jaclyn DeSantis",
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
                    Actors = "André Benjamin, Jennifer Carpenter, Isaach De Bankolé",
                    VideoLink = "https://www.imdb.com/video/vi1761450777?playlistId=tt0850253&ref_=tt_ov_vi"
                }
            );
            
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
    }
}
