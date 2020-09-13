using Cinema.Common.Helpers;
using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cinema.Persistence.Data
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
            int adminId = 1;
            int contentEditorId = 2;
            int firstUserId = 3;
            int secondUserId = 4;

            int numberOfTickets = 150;

            SeedHalls(modelBuilder);
            SeedPricings(modelBuilder);
            SeedNewsTypes(modelBuilder);
            SeedEventTypes(modelBuilder);
            SeedGenres(modelBuilder);
            SeedMovies(modelBuilder);
            SeedGenreMovies(modelBuilder);
            SeedRoles(modelBuilder);
            SeedUsers(modelBuilder, adminId, contentEditorId);
            SeedNews(modelBuilder, contentEditorId);
            SeedEvents(modelBuilder, contentEditorId);
            SeedCustomers(modelBuilder, firstUserId, secondUserId);
            SeedScreenings(modelBuilder);
            SeedReservations(modelBuilder, numberOfTickets, firstUserId, secondUserId);
            SeedInvoices(modelBuilder, numberOfTickets);
            SeedSeatReservations(modelBuilder, numberOfTickets);
            SeedReviews(modelBuilder);
        }

        private static void SeedEvents(ModelBuilder modelBuilder, int contentEditorId)
        {
            int id = 0;

            DateTime dateTime = new DateTime(2020, 9, 20).AddHours(20).AddDays(-8);

            for (int j = 0; j < 10; j++)
            {
                Event eventFirstType = new Event
                {
                    Id = --id,
                    Title = $"Event {Math.Abs(id)}",
                    AuthorId = contentEditorId,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    CreatedAt = new DateTime(2020, 9, 9),
                    TypeId = -1,
                    DateAndTime = dateTime,
                    IsDeleted = false
                };

                dateTime = dateTime.AddDays(1);

                Event eventSecondType = new Event
                {
                    Id = --id,
                    Title = $"Event {Math.Abs(id)}",
                    AuthorId = contentEditorId,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    CreatedAt = new DateTime(2020, 9, 9),
                    TypeId = -2,
                    DateAndTime = dateTime,
                    IsDeleted = false
                };

                dateTime = dateTime.AddDays(1);

                modelBuilder.Entity<Event>().HasData(eventFirstType, eventSecondType);
            }
        }

        private static void SeedNews(ModelBuilder modelBuilder, int contentEditorId)
        {
            int id = 0;

            for (int j = 0; j < 10; j++)
            {
                News newsFirstType = new News
                {
                    Id = --id,
                    Title = $"News {Math.Abs(id)}",
                    AuthorId = contentEditorId,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    CreatedAt = new DateTime(2020, 9, 9),
                    TypeId = -1,
                    IsDeleted = false
                };

                News newsSecondType = new News
                {
                    Id = --id,
                    Title = $"News {Math.Abs(id)}",
                    AuthorId = contentEditorId,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    CreatedAt = new DateTime(2020, 9, 9),
                    TypeId = -2,
                    IsDeleted = false
                };

                modelBuilder.Entity<News>().HasData(newsFirstType, newsSecondType);
            }
        }

        private static void SeedInvoices(ModelBuilder modelBuilder, int numberOfTickets)
        {
            int id = -1;

            for (int i = 0; i < numberOfTickets; i++)
            {
                //first tier
                modelBuilder.Entity<Invoice>().HasData(
                     new Invoice
                     {
                         Id = id,
                         CreatedAt = new DateTime(2020, 8, 18),
                         IsDeleted = false,
                         Price = 10,
                         PricingId = -1,
                         TaxAmount = (decimal)1.7,
                         ReservationId = id
                     });

                id--;

                modelBuilder.Entity<Invoice>().HasData(
                     new Invoice
                     {
                         Id = id,
                         CreatedAt = new DateTime(2020, 8, 18),
                         IsDeleted = false,
                         Price = 8,
                         PricingId = -1,
                         TaxAmount = (decimal)1.36,
                         ReservationId = id
                     });

                id--;
            }
        }

        private static void SeedReviews(ModelBuilder modelBuilder)
        {            
            Random rnd = new Random();
            int reviewId = -999999;
            for (int i = -650; i < -51; i++)
            {
                for (int j = -10; j < 0; j++)
                {
                    modelBuilder.Entity<Review>().HasData(
                        new Review
                        {
                            Id = reviewId++,
                            MovieId = j,
                            Rating = rnd.Next(1, 6),
                            Text = "Lorem ipsum",
                            UserId = i,
                            CreatedAt = new DateTime(2020, 9, 10)
                        }
                    );
                }
            }
        }

        private static void SeedSeatReservations(ModelBuilder modelBuilder, int numberOfTickets)
        {
            int id = -1;

            for (int i = 0; i < numberOfTickets; i++)
            {
                //first tier            
                modelBuilder.Entity<SeatReservation>().HasData(
                     new SeatReservation
                     {
                         Id = id,
                         ReservationId = id,
                         IsDeleted = false,
                         CreatedAt = new DateTime(2020, 8, 18),
                         SeatId = id
                     });

                id--;

                //second tier          
                modelBuilder.Entity<SeatReservation>().HasData(
                     new SeatReservation
                     {
                         Id = id,
                         ReservationId = id,
                         IsDeleted = false,
                         CreatedAt = new DateTime(2020, 8, 18),
                         SeatId = id
                     });

                id--;
            }
        }

        private static void SeedReservations(ModelBuilder modelBuilder, int numberOfTickets, int firstUserId, int secondUserId)
        {
            int id = -1;

            for (int i = 0; i < numberOfTickets; i++)
            {
                int screeningId = id >= -240 ? -1 : -5;

                //first tier
                modelBuilder.Entity<Reservation>().HasData(
                    new Reservation
                    {
                        Id = id,
                        CreatedAt = new DateTime(2020, 8, 18),
                        IsDeleted = false,
                        IsCancelled = false,
                        TicketQuantity = 1,
                        ReservationCode = "qr_code_placeholder",
                        ScreeningId = screeningId, //depending on the hall and available seat for seat reservation
                        UserId = firstUserId,
                        InvoiceId = id
                    }
                );

                id--;

                //second tier
                modelBuilder.Entity<Reservation>().HasData(
                    new Reservation
                    {
                        Id = id,
                        CreatedAt = new DateTime(2020, 8, 18),
                        IsDeleted = false,
                        IsCancelled = false,
                        ReservationCode = "qr_code_placeholder",
                        ScreeningId = screeningId,
                        UserId = secondUserId,
                        InvoiceId = id
                    }
                );

                id--;
            }
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
                    Synopsis = "A tribute to graffiti art and the city where it all began. Blest, a 19-year-old graffiti writer, has just graduated from high school. With no ambition toward mainstream goals of work and family, he spends his time bombing the city with graffiti messages until he and his crew become the most wanted bombers by the corrupt NYPD Vandal Squad. He even attracts major media and gallery attention for his tags. Also part of Blest's crew are Buk 50 and his younger brother Lune, whose arrest and beating by the NYPD causes the crew to wage a full-on graffiti war against the city. As they fight with their spray cans and their tags, Blest meets a political activist, Alexandra. Soon after, Blest's relationship with Buk 50 and the crew fragments as Blest ponders his position in life.",
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
                    Synopsis = "A college student (Yuen Biao) at a university in Canada is a fencing champion and when he has an accident one day, he \"dreams\" of being transported to ancient China and enters a conflict on Zu, the Magic Mountain. At the end of the story, he regains consciousness (this is in the longer English international version). The first and shorter version is about a warrior (Yuen Biao) who has become disillusioned with the constant civil wars in China and goes to the Magic Mountain. There he encounters ghosts and devils, and also good masters and their disciples who are out to stop the Blood Monster and his demons from destroying the world.",
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
                    Synopsis = "Experience the Magic of Dinotopia in an All-New Animated Movie! 26, the beloved young dinosaur from the hit miniseries, stars in an all-new animated movie set on the island where humans and dinosaurs co-exist. Twelve-year-old orphan Kex stows away in a lifeboat, hoping to see the world, but after being washed overboard he finds himself on Dinotopia, befriended by 26. Soon, the friends face trouble when the evil Ogthar is released from his stone prison and recovers the Ruby Sunstone, whose dark power can endanger all of Dinotopia. Join 26, Kex and the other dinosaurs as they fight to save their magical home!",
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
                    Synopsis = "In late November 1999, masses are descending upon Seattle for the World Trade Organization (WTO) Conference, the first ever held on American soil. Beyond the several delegates, career protesters are also coming to Seattle, they who believe the non-elected organization only exists to support corporate interests at the expense of the poor, working class and the environment among other things. Before the conference, the lead known protesters vow that their demonstrations will be peaceful, while Seattle Mayor Jim Tobin promises that if that be the case that no arrests will be made and no aggressive action, such as the use of tear gas, will be issued. On day one of the conference, tensions on both sides escalate the confrontation between police and protesters, with many innocent people caught in the crossfire. As such, what was promised ends up not happening during the remainder of the conference, where many on both sides work not for the greater good of their side, but rather for their own personal interests because of their experience on day one. These battles outside the official conference are not the only ones happening in Seattle, as many of the conference delegates, such as Doctors Without Borders and those from some of the poorer nations, try to get across the point of many of the protesters - albeit in a more diplomatic method - while seemingly ignored by those in the upper echelon of the organization.",
                    Directors = "Stuart Townsend",
                    Writers = "Stuart Townsend",
                    Actors = "André Benjamin, Jennifer Carpenter, Isaach De Bankolé",
                    VideoLink = "https://www.imdb.com/video/vi1761450777?playlistId=tt0850253&ref_=tt_ov_vi"
                },
                new Movie
                {
                    Id = -5,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    Title = "Vengeance Can Wait",
                    Duration = 160,
                    Year = 1971,
                    Country = "China",
                    Synopsis = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Directors = "Clare Bretland",
                    Writers = "Clare Bretland",
                    Actors = "Sheelagh Lathleiffure",
                    VideoLink = "https://www.imdb.com/video/vi1761450777?playlistId=tt0850253&ref_=tt_ov_vi"
                },
                new Movie
                {
                    Id = -6,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    Title = "Sharknado",
                    Duration = 93,
                    Year = 1986,
                    Country = "Indonesia",
                    Synopsis = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Directors = "Rebe Wynett",
                    Writers = "Rebe Wynett",
                    Actors = "Jerome Gourdon",
                    VideoLink = "https://www.imdb.com/video/vi1761450777?playlistId=tt0850253&ref_=tt_ov_vi"
                },
                new Movie
                {
                    Id = -7,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    Title = "Snow Creature, The",
                    Duration = 68,
                    Year = 1980,
                    Country = "Greece",
                    Synopsis = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Directors = "Anita Hancorn",
                    Writers = "Anita Hancorn",
                    Actors = "Kelsey Beig",
                    VideoLink = "https://www.imdb.com/video/vi1761450777?playlistId=tt0850253&ref_=tt_ov_vi"
                },
                new Movie
                {
                    Id = -8,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    Title = "Brothers Bloom, The",
                    Duration = 61,
                    Year = 2002,
                    Country = "Russia",
                    Synopsis = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Directors = "Constantine Ivatt",
                    Writers = "Constantine Ivatt",
                    Actors = "Farrand Jakubovicz",
                    VideoLink = "https://www.imdb.com/video/vi1761450777?playlistId=tt0850253&ref_=tt_ov_vi"
                },
                new Movie
                {
                    Id = -9,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    Title = "Police Academy 4: Citizens on Patrol",
                    Duration = 96,
                    Year = 1992,
                    Country = "Japan",
                    Synopsis = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Directors = "Katti Assard",
                    Writers = "Katti Assard",
                    Actors = "Christin Kernermann",
                    VideoLink = "https://www.imdb.com/video/vi1761450777?playlistId=tt0850253&ref_=tt_ov_vi"
                },
                new Movie
                {
                    Id = -10,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    Title = "Spy Kids",
                    Duration = 2002,
                    Year = 1992,
                    Country = "Azerbaijan",
                    Synopsis = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Directors = "Tades Bass",
                    Writers = "Tades Bass",
                    Actors = "Xerxes Slevin",
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
            Hall hall1 = new Hall
            {
                Id = -1,
                CreatedAt = new DateTime(2020, 7, 7),
                IsDeleted = false,
                Name = "Movie Hall 1",
                NumberOfColumns = 16,
                NumberOfRows = 15
            };

            Hall hall2 = new Hall
            {
                Id = -2,
                CreatedAt = new DateTime(2020, 7, 7),
                IsDeleted = false,
                Name = "Movie Hall 2",
                NumberOfColumns = 16,
                NumberOfRows = 15
            };

            modelBuilder.Entity<Hall>().HasData(hall1, hall2);

            SeedSeats(modelBuilder, hall1, hall2);
        }

        private static void SeedSeats(ModelBuilder modelBuilder, Hall hall1, Hall hall2)
        {
            int numberOfHallColumns = 16;
            int numberOfHallRows = 15;

            List<Seat> seats = new List<Seat>();
            int seatId = -1;

            seats.AddRange(GenerateSeatsForHall(hall1, seatId, numberOfHallColumns, numberOfHallRows));
            seatId = seats.Min(x => x.Id);
            seatId--;
            seats.AddRange(GenerateSeatsForHall(hall2, seatId, numberOfHallColumns, numberOfHallRows));

            modelBuilder.Entity<Seat>().HasData(seats);
        }

        private static List<Seat> GenerateSeatsForHall(Hall hall, int firstSeatId, int numberOfHallColumns, int numberOfHallRows)
        {
            List<Seat> seats = new List<Seat>();

            int seatNumber = 0;

            for (int i = 1; i <= numberOfHallRows; i++)
            {
                for (int j = 1; j <= numberOfHallColumns; j++)
                {
                    Seat seat = new Seat
                    {
                        Id = firstSeatId--,
                        CreatedAt = new DateTime(2020, 7, 7),
                        IsDeleted = false,
                        HallId = hall.Id,
                        SeatNumber = ++seatNumber
                    };

                    seat.Label = seat.CreateSeatLabel(hall);

                    seats.Add(seat);
                }
            }

            return seats;
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
                    Id = -1,
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                new ApplicationRole
                {
                    Id = -2,
                    Name = "Content Editor",
                    NormalizedName = "CONTENT EDITOR"
                },
                new ApplicationRole
                {
                    Id = -3,
                    Name = "Customer",
                    NormalizedName = "CUSTOMER"
                }
            );
        }

        private static void SeedUsers(ModelBuilder modelBuilder, int adminId, int contentEditorId)
        {
            ApplicationUser admin = new ApplicationUser
            {
                Id = adminId,
                UserName = "desktop",
                Email = "admin@admin-test-cinema.com",
                NormalizedEmail = "admin@admin-test-cinema.com".ToUpper(),
                NormalizedUserName = "desktop".ToUpper(),
                FirstName = "Admin",
                LastName = "Test",
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                PhoneNumber = "123456789",
                PhoneNumberConfirmed = false
            };

            PasswordHasher<ApplicationUser> ph = new PasswordHasher<ApplicationUser>();
            admin.PasswordHash = ph.HashPassword(admin, "test");

            ApplicationUser contentEditor = new ApplicationUser
            {
                Id = contentEditorId,
                UserName = "content.editor",
                Email = "content.editor@admin-test-cinema.com",
                NormalizedEmail = "content.editor@admin-test-cinema.com".ToUpper(),
                NormalizedUserName = "content.editor".ToUpper(),
                FirstName = "Content",
                LastName = "Editor",
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                PhoneNumber = "123456789",
                PhoneNumberConfirmed = false
            };

            contentEditor.PasswordHash = ph.HashPassword(contentEditor, "test");

            modelBuilder.Entity<ApplicationUser>().HasData(
                admin, contentEditor
            );

            modelBuilder.Entity<ApplicationUserRole>().HasData(
            new ApplicationUserRole
            {
                UserId = adminId,
                RoleId = -1
            },
            new ApplicationUserRole
            {
                UserId = contentEditorId,
                RoleId = -2
            });
        }

        private static void SeedCustomers(ModelBuilder modelBuilder, int firstUserId, int secondUserId)
        {
            PasswordHasher<ApplicationUser> ph = new PasswordHasher<ApplicationUser>();

            ApplicationUser fistTestCustomer = new ApplicationUser
            {
                Id = firstUserId,
                UserName = "mobile",
                Email = "test1@test-customer.com",
                NormalizedEmail = "test1@test-customer.com".ToUpper(),
                NormalizedUserName = "mobile".ToUpper(),
                FirstName = "First",
                LastName = "Customer",
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                PhoneNumber = "123456789",
                PhoneNumberConfirmed = false
            };

            ApplicationUser secondTestCustomer = new ApplicationUser
            {
                Id = secondUserId,
                UserName = "test.customer2",
                Email = "test2@test-customer.com",
                NormalizedEmail = "test2@test-customer.com".ToUpper(),
                NormalizedUserName = "test.customer2".ToUpper(),
                FirstName = "Second",
                LastName = "Customer",
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                PhoneNumber = "123456789",
                PhoneNumberConfirmed = false
            };

            fistTestCustomer.PasswordHash = ph.HashPassword(fistTestCustomer, "test");
            secondTestCustomer.PasswordHash = ph.HashPassword(secondTestCustomer, "test");

            modelBuilder.Entity<ApplicationUser>().HasData(fistTestCustomer, secondTestCustomer);

            modelBuilder.Entity<ApplicationUserRole>().HasData(
                new ApplicationUserRole
                {
                    UserId = firstUserId,
                    RoleId = -3
                },
                new ApplicationUserRole
                {
                    UserId = secondUserId,
                    RoleId = -3
                }
            );



            for (int i = 0; i < 600; i++)
            {
                ApplicationUser customer = new ApplicationUser
                {
                    Id = -650 + i,
                    UserName = "customer" + i + "t",
                    Email = "customer" + i + "@test-customer" + i + ".com",
                    NormalizedEmail = "CUSTOMER" + i + "@TEST-CUSTOMER" + i + ".COM",
                    NormalizedUserName = "CUSTOMER" + i + "T",
                    FirstName = "Decko" + i,
                    LastName = "Deckic" + i,
                    TwoFactorEnabled = false,
                    EmailConfirmed = true,
                    PhoneNumber = RandomDigits(10),
                    PhoneNumberConfirmed = false
                };

                ApplicationUserRole customerRole = new ApplicationUserRole
                {
                    UserId = customer.Id,
                    RoleId = -3
                };

                customer.PasswordHash = ph.HashPassword(customer, "test");

                modelBuilder.Entity<ApplicationUser>().HasData(customer);
                modelBuilder.Entity<ApplicationUserRole>().HasData(customerRole);
            }
        }

        public static string RandomDigits(int length)
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < length; i++)
                s = String.Concat(s, random.Next(9).ToString());
            return s;
        }
    }
}
