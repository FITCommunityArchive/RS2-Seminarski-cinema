using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using System;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICinemaDbContext Context { get; }

        public IRepository<Event, int> Events { get; }
        public IRepository<EventType, int> EventTypes { get; }
        public IRepository<Genre, int> Genres { get; }
        public IRepository<GenreMovie, int> GenreMovies { get; }
        public IRepository<Hall, int> Halls { get; }
        //public InvoiceRepository Invoices { get; }
        public IRepository<Movie, int> Movies { get; }
        public IRepository<News, int> News { get; }
        public IRepository<NewsType, int> NewsTypes { get; }
        //public PricingRepository Pricings { get; }
        public IRepository<Reservation, int> Reservations { get; }
        public IRepository<Review, int> Reviews { get; }
        //public ScreeningRepository Screenings { get; }
        public IRepository<Seat, int> Seats { get; }
        public IRepository<SeatReservation, int> SeatReservations { get; }
        public IRepository<ApplicationUser, string> Users { get; }
        public IRepository<ApplicationRole, string> Roles { get; }
        public IRepository<ApplicationUserRole, string> UserRoles { get; }


        int Save();
        Task<int> SaveAsync();
    }
}
