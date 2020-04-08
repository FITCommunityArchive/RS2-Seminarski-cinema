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

        private IRepository<Event, int> _events;
        private IRepository<EventType, int> _eventTypes;
        private IRepository<Genre, int> _genres;
        private IRepository<GenreMovie, int> _genreMovies;
        private IRepository<Hall, int> _halls;
        private IRepository<Invoice, int> _invoices;
        private IRepository<Movie, int> _movies;
        private IRepository<News, int> _news;
        private IRepository<NewsType, int> _newsTypes;
        private IRepository<Pricing, int> _pricings;
        private IRepository<Reservation, int> _reservations;
        private IRepository<Review, int> _reviews;
        private IRepository<Screening, int> _screenings;
        private IRepository<Seat, int> _seats;
        private IRepository<SeatReservation, int> _seatReservations;
        private IRepository<ApplicationUser, string> _users;
        private IRepository<ApplicationRole, string> _roles;
        private IRepository<ApplicationUserRole, string> _userRoles;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public ApplicationDbContext Context => _context;

        public IRepository<Event, int> Events => _events ?? (_events = new Repository<Event, int>(_context));
        public IRepository<EventType, int> EventTypes => _eventTypes ?? (_eventTypes = new Repository<EventType, int>(_context));
        public IRepository<Genre, int> Genres => _genres ?? (_genres = new Repository<Genre, int>(_context));
        public IRepository<GenreMovie, int> GenreMovies => _genreMovies ?? (_genreMovies = new Repository<GenreMovie, int>(_context));
        public IRepository<Hall, int> Halls => _halls ?? (_halls = new Repository<Hall, int>(_context));
        public IRepository<Invoice, int> Invoices => _invoices ?? (_invoices = new Repository<Invoice, int>(_context));
        public IRepository<Movie, int> Movies => _movies ?? (_movies = new Repository<Movie, int>(_context));
        public IRepository<News, int> News => _news ?? (_news = new Repository<News, int>(_context));
        public IRepository<NewsType, int> NewsTypes => _newsTypes ?? (_newsTypes = new Repository<NewsType, int>(_context));
        public IRepository<Pricing, int> Pricings => _pricings ?? (_pricings = new Repository<Pricing, int>(_context));
        public IRepository<Reservation, int> Reservations => _reservations ?? (_reservations = new Repository<Reservation, int>(_context));
        public IRepository<Review, int> Reviews => _reviews ?? (_reviews = new Repository<Review, int>(_context));
        public IRepository<Screening, int> Screenings => _screenings ?? (_screenings = new Repository<Screening, int>(_context));
        public IRepository<Seat, int> Seats => _seats ?? (_seats = new Repository<Seat, int> (_context));
        public IRepository<SeatReservation, int> SeatReservations => _seatReservations ?? (_seatReservations = new Repository<SeatReservation, int>(_context));
        public IRepository<ApplicationUser, string> Users => _users ?? (_users = new ApplicationUsersRepository(_context));
        public IRepository<ApplicationRole, string> Roles => _roles ?? (_roles = new Repository<ApplicationRole, string>(_context));
        public IRepository<ApplicationUserRole, string> UserRoles => _userRoles ?? (_userRoles = new Repository<ApplicationUserRole, string>(_context));

        public int Save() => _context.SaveChanges();

        public async Task<int> SaveAsync() { return await _context.SaveChangesAsync(); }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
