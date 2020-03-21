using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;

namespace Cinema.DAL
{
    public static class Builder
    {
        public static async Task BuildAsync<T>(this T entity, ApplicationDbContext context)
        {
            if (typeof(T) == typeof(Reservation)) await BuildRelations(entity as Reservation, context);
            if (typeof(T) == typeof(Screening)) await BuildRelations(entity as Screening, context);
            if (typeof(T) == typeof(Review)) await BuildRelations(entity as Review, context);
            if (typeof(T) == typeof(Seat)) await BuildRelations(entity as Seat, context);
            if (typeof(T) == typeof(SeatReservation)) await BuildRelations(entity as SeatReservation, context);
            //if (typeof(T) == typeof(User)) await BuildRelations(entity as User, context);
        }

        private static async Task BuildRelations(Reservation entity, ApplicationDbContext context)
        {
            //if (entity.Image == null) entity.Image = "";
            entity.User = await context.Users.FindAsync(entity.UserId);
            entity.Screening = await context.Screenings.FindAsync(entity.ScreeningId);
        }

        private static async Task BuildRelations(Screening entity, ApplicationDbContext context)
        {
            //if (entity.Image == null) entity.Image = "";
            entity.Hall = await context.Halls.FindAsync(entity.HallId);
            entity.Movie = await context.Movies.FindAsync(entity.MovieId);
        }

        private static async Task BuildRelations(Review entity, ApplicationDbContext context)
        {
            //if (entity.Image == null) entity.Image = "";
            entity.User = await context.Users.FindAsync(entity.UserId);
            entity.Movie = await context.Movies.FindAsync(entity.MovieId);
        }

        private static async Task BuildRelations(Seat entity, ApplicationDbContext context)
        {
            entity.Hall = await context.Halls.FindAsync(entity.HallId);
        }

        private static async Task BuildRelations(SeatReservation entity, ApplicationDbContext context)
        {
            //if (entity.Image == null) entity.Image = "";
            entity.Reservation = await context.Reservations.FindAsync(entity.ReservationId);
            entity.Seat = await context.Seats.FindAsync(entity.SeatId);
        }

        public static void UpdateAsync<T>(this T oldEnt, T newEnt)
        {
            if (typeof(T) == typeof(Reservation)) UpdateRelations(oldEnt as Reservation, newEnt as Reservation);
            if (typeof(T) == typeof(Screening)) UpdateRelations(oldEnt as Screening, newEnt as Screening);
            if (typeof(T) == typeof(Review)) UpdateRelations(oldEnt as Review, newEnt as Review);
            if (typeof(T) == typeof(Seat)) UpdateRelations(oldEnt as Seat, newEnt as Seat);
            if (typeof(T) == typeof(SeatReservation)) UpdateRelations(oldEnt as SeatReservation, newEnt as SeatReservation);
        }

        private static void UpdateRelations(Reservation oldEnt, Reservation newEnt)
        {
            oldEnt.User = newEnt.User;
            oldEnt.Screening = newEnt.Screening;
        }

        private static void UpdateRelations(Screening oldEnt, Screening newEnt)
        {
            oldEnt.Hall = newEnt.Hall;
            oldEnt.Movie = newEnt.Movie;
        }

        private static void UpdateRelations(Review oldEnt, Review newEnt)
        {
            oldEnt.User = newEnt.User;
            oldEnt.Movie = newEnt.Movie;
        }

        private static void UpdateRelations(Seat oldEnt, Seat newEnt)
        {
            oldEnt.Hall = newEnt.Hall;
        }

        private static void Update(SeatReservation oldEnt, SeatReservation newEnt)
        {
            oldEnt.Reservation = newEnt.Reservation;
            oldEnt.Seat = newEnt.Seat;
        }


        public static bool CanDelete<T>(this T entity)
        {
            if (typeof(T) == typeof(Hall)) return HasNoChildren(entity as Hall);
            if (typeof(T) == typeof(Movie)) return HasNoChildren(entity as Movie);
            if (typeof(T) == typeof(Screening)) return HasNoChildren(entity as Screening);
            if (typeof(T) == typeof(Reservation)) return HasNoChildren(entity as Reservation);
            if (typeof(T) == typeof(ApplicationUser)) return HasNoChildren(entity as ApplicationUser);
            if (typeof(T) == typeof(ApplicationRole)) return HasNoChildren(entity as ApplicationRole);

            return true;
        }

        private static bool HasNoChildren(Hall hall)
        {
            return hall.Screenings.Count + hall.Seats.Count == 0;
        }

        private static bool HasNoChildren(Movie movie)
        {
            return movie.Screenings.Count + movie.Reviews.Count == 0;
        }

        private static bool HasNoChildren(Screening screening)
        {
            return screening.Reservations.Count == 0;
        }

        private static bool HasNoChildren(Reservation reservation)
        {
            return reservation.SeatReservations.Count + reservation.Invoices.Count == 0;
        }

        private static bool HasNoChildren(Seat seat)
        {
            return seat.SeatReservations.Count == 0;
        }

        private static bool HasNoChildren(ApplicationUser user)
        {
            return user.Reviews.Count + user.Reservations.Count + user.News.Count + user.Events.Count +
                user.Claims.Count + user.Logins.Count + user.Tokens.Count == 0;
        }

        private static bool HasNoChildren(ApplicationRole role)
        {
            return role.RoleClaims.Count == 0;
        }
    }
}
