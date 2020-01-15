using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cinema.DAL.Data;
using Cinema.Domain.Entities;


namespace Cinema.DAL
{
    public static class Builder
    {
        public static async Task Build<T>(this T entity, ApplicationDbContext context)
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
            entity.User = await context.Users.FindAsync(entity.User.Id);
            entity.Screening = await context.Screenings.FindAsync(entity.Screening.Id);
        }

        private static async Task BuildRelations(Screening entity, ApplicationDbContext context)
        {
            //if (entity.Image == null) entity.Image = "";
            entity.Hall = await context.Halls.FindAsync(entity.Hall.Id);
            entity.Movie = await context.Movies.FindAsync(entity.Movie.Id);
        }

        private static async Task BuildRelations(Review entity, ApplicationDbContext context)
        {
            //if (entity.Image == null) entity.Image = "";
            entity.User = await context.Users.FindAsync(entity.User.Id);
            entity.Movie = await context.Movies.FindAsync(entity.Movie.Id);
        }

        private static async Task BuildRelations(Seat entity, ApplicationDbContext context)
        {
            entity.Hall = await context.Halls.FindAsync(entity.Hall.Id);
        }

        private static async Task BuildRelations(SeatReservation entity, ApplicationDbContext context)
        {
            //if (entity.Image == null) entity.Image = "";
            entity.Reservation = await context.Reservations.FindAsync(entity.Reservation.Id);
            entity.Seat = await context.Seats.FindAsync(entity.Seat.Id);
        }

        public static void Update<T>(this T oldEnt, T newEnt)
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

        private static void UpdateRelations(SeatReservation oldEnt, SeatReservation newEnt)
        {
            oldEnt.Reservation = newEnt.Reservation;
            oldEnt.Seat = newEnt.Seat;
        }

    }
}
