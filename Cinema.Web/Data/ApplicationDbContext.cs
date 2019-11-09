using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Cinema.Domain.Entities;
using System.Linq;

namespace Cinema.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AppRole>  AppRoles { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<GenreMovie> GenreMovies { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsType> NewsTypes { get; set; }
        public DbSet<Pricing> Pricing { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<SeatReservation> SeatReservations { get; set; }
        public DbSet<User> AppUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies(true);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AppRole>().HasQueryFilter(x => !x.Deleted);
            builder.Entity<Event>().HasQueryFilter(x => !x.Deleted);
            builder.Entity<EventType>().HasQueryFilter(x => !x.Deleted);
            builder.Entity<Genre>().HasQueryFilter(x => !x.Deleted);
            builder.Entity<GenreMovie>().HasQueryFilter(x => !x.Deleted);
            builder.Entity<Hall>().HasQueryFilter(x => !x.Deleted);
            //Adding this option for Invoice, migration shows an arror - "a filter may only be applied to the root entity type"
            //builder.Entity<Invoice>().HasQueryFilter(x => !x.Deleted);
            builder.Entity<Movie>().HasQueryFilter(x => !x.Deleted);
            builder.Entity<News>().HasQueryFilter(x => !x.Deleted);
            builder.Entity<NewsType>().HasQueryFilter(x => !x.Deleted);
            builder.Entity<Pricing>().HasQueryFilter(x => !x.Deleted);
            builder.Entity<Reservation>().HasQueryFilter(x => !x.Deleted);
            builder.Entity<Review>().HasQueryFilter(x => !x.Deleted);
            builder.Entity<Screening>().HasQueryFilter(x => !x.Deleted);
            builder.Entity<Seat>().HasQueryFilter(x => !x.Deleted);
            builder.Entity<SeatReservation>().HasQueryFilter(x => !x.Deleted);
            builder.Entity<User>().HasQueryFilter(x => !x.Deleted);
            base.OnModelCreating(builder);
        }

        //SaveChangesAsync is used, should that method be overriden instead?
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(x => x.State == EntityState.Deleted && x.Entity is BaseClass))
            {
                entry.State = EntityState.Modified;
                entry.CurrentValues["Deleted"] = true;
            }
            return base.SaveChanges();
        }
    }
}
