using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Cinema.Domain.Entities;
using System.Linq;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Cinema.Web.IdentityEntities;
using Microsoft.AspNetCore.Identity;

namespace Cinema.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string,
                                        ApplicationUserClaim, ApplicationUserRole, ApplicationUserLogin,
                                        ApplicationRoleClaim, ApplicationUserToken>
    {
        private string _connectionString;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
      
        public ApplicationDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ApplicationDbContext()
        {
            _connectionString = "Server=(localdb)\\mssqllocaldb;Database=CinemaReservations;Trusted_Connection=True;MultipleActiveResultSets=true";
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
        /*public override DbSet<ApplicationUser> Users { get; set; }
        public override DbSet<ApplicationRole> Roles { get; set; }
        public override DbSet<ApplicationUserRole> UserRoles { get; set; }*/


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(_connectionString != null)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
            
            optionsBuilder.UseLazyLoadingProxies(true);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //This line is in order to prevent Cascade Delete
            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

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
            
            builder.Entity<ApplicationUser>(b =>
            {
                // Each User can have many UserClaims
                b.HasMany(e => e.Claims)
                    .WithOne(e => e.User)
                    .HasForeignKey(uc => uc.UserId)
                    .IsRequired();

                // Each User can have many UserLogins
                b.HasMany(e => e.Logins)
                    .WithOne(e => e.User)
                    .HasForeignKey(ul => ul.UserId)
                    .IsRequired();

                // Each User can have many UserTokens
                b.HasMany(e => e.Tokens)
                    .WithOne(e => e.User)
                    .HasForeignKey(ut => ut.UserId)
                    .IsRequired();

                // Each User can have many entries in the UserRole join table
                b.HasMany(e => e.UserRoles)
                    .WithOne(e => e.User)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });

            
            builder.Entity<ApplicationRole>(b =>
            {
                // Each Role can have many entries in the UserRole join table
                b.HasMany(e => e.UserRoles)
                    .WithOne(e => e.Role)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                // Each Role can have many associated RoleClaims
                b.HasMany(e => e.RoleClaims)
                    .WithOne(e => e.Role)
                    .HasForeignKey(rc => rc.RoleId)
                    .IsRequired();
            });

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

        //SaveChangesAsync is used, should that method be overriden instead?
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries().Where(x => x.State == EntityState.Deleted && x.Entity is BaseClass))
            {
                entry.State = EntityState.Modified;
                entry.CurrentValues["Deleted"] = true;
            }
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}
