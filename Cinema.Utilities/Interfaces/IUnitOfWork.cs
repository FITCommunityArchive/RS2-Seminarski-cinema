using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using System;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces
{
    public interface IUnitOfWork
    {
        public IRepository<ApplicationUser, string> Users => Repository<ApplicationUser, string>();
        public IRepository<ApplicationRole, string> Roles => Repository<ApplicationRole, string>();
        public IRepository<ApplicationUserRole, string> UserRoles => Repository<ApplicationUserRole, string>();
        public IRepository<Event, int> Events => Repository<Event, int>();
        public IRepository<EventType, int> EventTypes => Repository<EventType, int>();
        public IRepository<Genre, int> Genres => Repository<Genre, int>();
        public IRepository<GenreMovie, int> GenreMovies => Repository<GenreMovie, int>();
        public IRepository<Hall, int> Halls => Repository<Hall, int>();
        public IRepository<Invoice, int> Invoices => Repository<Invoice, int>();
        public IRepository<Movie, int> Movies => Repository<Movie, int>();
        public IRepository<News, int> News => Repository<News, int>();
        public IRepository<NewsType, int> NewsTypes => Repository<NewsType, int>();
        public IRepository<Pricing, int> Pricings => Repository<Pricing, int>();
        public IRepository<Reservation, int> Reservations => Repository<Reservation, int>();
        public IRepository<Review, int> Reviews => Repository<Review, int>();
        public IRepository<Screening, int> Screenings => Repository<Screening, int>();
        public IRepository<Seat, int> Seats => Repository<Seat, int>();
        public IRepository<SeatReservation, int> SeatReservations => Repository<SeatReservation, int>();

        IRepository<Entity, Key> Repository<Entity, Key>() where Entity : class;


        int Save();

        Task<int> SaveAsync();
    }
}
