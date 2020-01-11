using Cinema.DAL.Repository;
using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using System;
using System.Threading.Tasks;

namespace Cinema.DAL.Data
{
    public class UnitOfWork : IDisposable
    {
        protected ApplicationDbContext _context;

        private IRepository<Event> _events;
        private IRepository<EventType> _eventTypes;
        private IRepository<Genre> _genres;
        private IRepository<GenreMovie> _genreMovies;
        private IRepository<Hall> _halls;
        private IRepository<Invoice> _invoices;
        private IRepository<Movie> _movies;
        private IRepository<News> _news;
        private IRepository<NewsType> _newsTypes;
        private IRepository<Pricing> _pricings;
        private IRepository<Reservation> _reservations;
        private IRepository<Review> _reviews;
        private IRepository<Screening> _screenings;
        private IRepository<Seat> _seats;
        private IRepository<SeatReservation> _seatReservations;
        private IRepository<ApplicationUser> _users;
        private IRepository<ApplicationRole> _roles;
        private IRepository<ApplicationUserRole> _userRoles;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public ApplicationDbContext Context => _context;

        public IRepository<Event> Events => _events ?? (_events = new Repository<Event>(_context));
        public IRepository<EventType> EventTypes => _eventTypes ?? (_eventTypes = new Repository<EventType>(_context));
        public IRepository<Genre> Genres => _genres ?? (_genres = new Repository<Genre>(_context));
        public IRepository<GenreMovie> GenreMovies => _genreMovies ?? (_genreMovies = new Repository<GenreMovie>(_context));
        public IRepository<Hall> Halls => _halls ?? (_halls = new Repository<Hall>(_context));
        public IRepository<Invoice> Invoices => _invoices ?? (_invoices = new Repository<Invoice>(_context));
        public IRepository<Movie> Movies => _movies ?? (_movies = new Repository<Movie>(_context));
        public IRepository<News> News => _news ?? (_news = new Repository<News>(_context));
        public IRepository<NewsType> NewsTypes => _newsTypes ?? (_newsTypes = new Repository<NewsType>(_context));
        public IRepository<Pricing> Pricings => _pricings ?? (_pricings = new Repository<Pricing>(_context));
        public IRepository<Reservation> Reservations => _reservations ?? (_reservations = new Repository<Reservation>(_context));
        public IRepository<Review> Reviews => _reviews ?? (_reviews = new Repository<Review>(_context));
        public IRepository<Screening> Screenings => _screenings ?? (_screenings = new Repository<Screening>(_context));
        public IRepository<Seat> Seats => _seats ?? (_seats = new Repository<Seat>(_context));
        public IRepository<SeatReservation> SeatReservations => _seatReservations ?? (_seatReservations = new Repository<SeatReservation>(_context));
        public IRepository<ApplicationUser> Users => _users ?? (_users = new Repository<ApplicationUser>(_context));
        public IRepository<ApplicationRole> Roles => _roles ?? (_roles = new Repository<ApplicationRole>(_context));
        public IRepository<ApplicationUserRole> UserRoles => _userRoles ?? (_userRoles = new Repository<ApplicationUserRole>(_context));

        public int Save() => _context.SaveChanges();

        public async Task<int> SaveAsync() { return await _context.SaveChangesAsync(); }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
