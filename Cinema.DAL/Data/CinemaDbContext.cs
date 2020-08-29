using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Cinema.Utilities.Interfaces.Dal;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Cinema.Dal.Data
{
    public class CinemaDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int,
                                        ApplicationUserClaim, ApplicationUserRole, ApplicationUserLogin,
                                        ApplicationRoleClaim, ApplicationUserToken>, ICinemaDbContext
    {
        private string _connectionString;
        public CinemaDbContext(DbContextOptions<CinemaDbContext> options)
            : base(options) {
            ChangeTracker.CascadeDeleteTiming = CascadeTiming.OnSaveChanges;
            ChangeTracker.DeleteOrphansTiming = CascadeTiming.OnSaveChanges;
        }

        public CinemaDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public CinemaDbContext()
        {
            _connectionString = "Server=(localdb)\\mssqllocaldb;Database=Cinema;Trusted_Connection=True;MultipleActiveResultSets=true";
        }

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
        public override DbSet<ApplicationUser> Users { get; set; }
        public override DbSet<ApplicationRole> Roles { get; set; }
        public override DbSet<ApplicationUserRole> UserRoles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            //var typesToRegister = Assembly.Load("Cinema.Domain").GetTypes()
            //    .Where(type => !String.IsNullOrEmpty(type.Namespace))
            //    .Where(type => type.BaseType != null && type.BaseType.IsGenericType && type.BaseType.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>));

            //foreach(var type in typesToRegister)
            //{
            //    dynamic configurationInstance = Activator.CreateInstance(type);
            //    builder.ApplyConfiguration(configurationInstance);
            //}

            base.OnModelCreating(builder);

            //This line is in order to prevent Cascade Delete
            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Cascade;
            }

            builder.Entity<Event>().HasQueryFilter(x => !x.IsDeleted);
            builder.Entity<EventType>().HasQueryFilter(x => !x.IsDeleted);
            builder.Entity<Genre>().HasQueryFilter(x => !x.IsDeleted);
            builder.Entity<GenreMovie>().HasQueryFilter(x => !x.IsDeleted);
            builder.Entity<Hall>().HasQueryFilter(x => !x.IsDeleted);
            builder.Entity<Invoice>().HasQueryFilter(x => !x.IsDeleted);
            builder.Entity<Movie>().HasQueryFilter(x => !x.IsDeleted);
            builder.Entity<News>().HasQueryFilter(x => !x.IsDeleted);
            builder.Entity<NewsType>().HasQueryFilter(x => !x.IsDeleted);
            builder.Entity<Pricing>().HasQueryFilter(x => !x.IsDeleted);
            builder.Entity<Reservation>().HasQueryFilter(x => !x.IsDeleted);
            builder.Entity<Review>().HasQueryFilter(x => !x.IsDeleted);
            builder.Entity<Screening>().HasQueryFilter(x => !x.IsDeleted);
            builder.Entity<Seat>().HasQueryFilter(x => !x.IsDeleted);
            builder.Entity<SeatReservation>().HasQueryFilter(x => !x.IsDeleted);
            builder.Entity<ApplicationUser>().HasQueryFilter(x => !x.IsDeleted);
            builder.Entity<ApplicationRole>().HasQueryFilter(x => !x.IsDeleted);
            builder.Entity<ApplicationUserRole>().HasQueryFilter(x => !x.IsDeleted);

            builder.Entity<Reservation>()
                   .HasOne(x => x.Invoice)
                   .WithOne(x => x.Reservation)
                   .HasForeignKey<Invoice>(x => x.ReservationId);

            builder.Entity<ApplicationUser>().Ignore(x => x.FullName);

            //Add Query filters to ApplicationUser and ApplicationRole            
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
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Cascade);
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

            builder.Entity<ApplicationUser>(b =>
            {
                b.ToTable("Users");
            });

            builder.Entity<ApplicationRole>(b =>
            {
                b.ToTable("Roles");
            });

            builder.Entity<ApplicationUserRole>(b =>
            {
                b.ToTable("UserRoles");
            });

            Data.Seed(builder);
        }

        public override int SaveChanges()
        {
            AuditChanges();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            AuditChanges();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void AuditChanges()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified;
                        entry.CurrentValues["IsDeleted"] = true;
                        // iterate over each nav. prop to performe cascade soft delete = true
                        RecursiveChildrenIsDeletedHandler(entry);
                        break;
                }
            }
        }

        public void RecursiveChildrenIsDeletedHandler(EntityEntry entry)
        {
            foreach (var navigationEntry in entry.Navigations
                            .Where(n => !n.Metadata.IsDependentToPrincipal()))
            {
                if (navigationEntry is CollectionEntry collectionEntry)
                {
                    foreach (var dependentEntry in collectionEntry.CurrentValue)
                    {
                        HandleDependent(Entry(dependentEntry));
                    }

                }
                else
                {
                    var dependentEntry = navigationEntry.CurrentValue;
                    if (dependentEntry != null)
                    {
                        HandleDependent(Entry(dependentEntry));
                    }
                }
            }
        }
        private void HandleDependent(EntityEntry entry)
        {
            entry.State = EntityState.Modified;
            entry.CurrentValues["IsDeleted"] = true;

            if (entry.Navigations.Where(n => !n.Metadata.IsDependentToPrincipal()).Count() > 0)
            {
                RecursiveChildrenIsDeletedHandler(entry);
            }
        }
    }
}
