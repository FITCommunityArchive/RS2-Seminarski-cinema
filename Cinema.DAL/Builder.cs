using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Cinema.Utilities.Interfaces.Dal;
using System.Threading.Tasks;

namespace Cinema.Dal
{
    public static class Builder
    {
        public static async Task BuildAsync<T>(this T entity, ICinemaDbContext context)
        {
            if (typeof(T) == typeof(Reservation)) await BuildRelations(entity as Reservation, context);
            if (typeof(T) == typeof(Screening)) await BuildRelations(entity as Screening, context);
            if (typeof(T) == typeof(Review)) await BuildRelations(entity as Review, context);
            if (typeof(T) == typeof(Seat)) await BuildRelations(entity as Seat, context);
            if (typeof(T) == typeof(SeatReservation)) await BuildRelations(entity as SeatReservation, context);
            if (typeof(T) == typeof(Event)) await BuildRelations(entity as Event, context);
            if (typeof(T) == typeof(News)) await BuildRelations(entity as News, context);
        }

        private static async Task BuildRelations(Reservation entity, ICinemaDbContext context)
        {
            entity.User = await context.Users.FindAsync(entity.UserId);
            entity.Screening = await context.Screenings.FindAsync(entity.ScreeningId);
        }

        private static async Task BuildRelations(Screening entity, ICinemaDbContext context)
        {
            entity.Hall = await context.Halls.FindAsync(entity.HallId);
            entity.Movie = await context.Movies.FindAsync(entity.MovieId);
            entity.Pricing = await context.Pricing.FindAsync(entity.PricingId);
        }

        private static async Task BuildRelations(Review entity, ICinemaDbContext context)
        {
            entity.User = await context.Users.FindAsync(entity.UserId);
            entity.Movie = await context.Movies.FindAsync(entity.MovieId);
        }

        private static async Task BuildRelations(Seat entity, ICinemaDbContext context)
        {
            entity.Hall = await context.Halls.FindAsync(entity.HallId);
        }

        private static async Task BuildRelations(SeatReservation entity, ICinemaDbContext context)
        {
            entity.Reservation = await context.Reservations.FindAsync(entity.ReservationId);
            entity.Seat = await context.Seats.FindAsync(entity.SeatId);
        }

        private static async Task BuildRelations(Event entity, ICinemaDbContext context)
        {
            entity.Author = await context.Users.FindAsync(entity.AuthorId);
            entity.Type = await context.EventTypes.FindAsync(entity.TypeId);
        }
        private static async Task BuildRelations(News entity, ICinemaDbContext context)
        {
            entity.Author = await context.Users.FindAsync(entity.AuthorId);
            entity.Type = await context.NewsTypes.FindAsync(entity.TypeId);
        }

        public static void Update<T>(this T oldEnt, T newEnt)
        {
            if (typeof(T) == typeof(Reservation)) UpdateRelations(oldEnt as Reservation, newEnt as Reservation);
            if (typeof(T) == typeof(Screening)) UpdateRelations(oldEnt as Screening, newEnt as Screening);
            if (typeof(T) == typeof(Review)) UpdateRelations(oldEnt as Review, newEnt as Review);
            if (typeof(T) == typeof(Seat)) UpdateRelations(oldEnt as Seat, newEnt as Seat);
            if (typeof(T) == typeof(SeatReservation)) UpdateRelations(oldEnt as SeatReservation, newEnt as SeatReservation);
            if (typeof(T) == typeof(Event)) UpdateRelations(oldEnt as Event, newEnt as Event);
            if (typeof(T) == typeof(News)) UpdateRelations(oldEnt as News, newEnt as News);
        }

        private static void UpdateRelations(Reservation oldEnt, Reservation newEnt)
        {
            oldEnt.UserId = newEnt.UserId;
            oldEnt.ScreeningId = newEnt.ScreeningId;
        }

        private static void UpdateRelations(Screening oldEnt, Screening newEnt)
        {
            oldEnt.HallId = newEnt.HallId;
            oldEnt.MovieId = newEnt.MovieId;
            oldEnt.PricingId = newEnt.PricingId;
        }

        private static void UpdateRelations(Review oldEnt, Review newEnt)
        {
            oldEnt.UserId = newEnt.UserId;
            oldEnt.MovieId = newEnt.MovieId;
        }

        private static void UpdateRelations(Seat oldEnt, Seat newEnt)
        {
            oldEnt.HallId = newEnt.HallId;
        }

        private static void UpdateRelations(SeatReservation oldEnt, SeatReservation newEnt)
        {
            oldEnt.ReservationId = newEnt.ReservationId;
            oldEnt.SeatId = newEnt.SeatId;
        }

        private static void UpdateRelations(Event oldEnt, Event newEnt)
        {
            oldEnt.TypeId = newEnt.TypeId;
            oldEnt.AuthorId = newEnt.AuthorId;
        }
        private static void UpdateRelations(News oldEnt, News newEnt)
        {
            oldEnt.TypeId = newEnt.TypeId;
            oldEnt.AuthorId = newEnt.AuthorId;
        }
    }
}
