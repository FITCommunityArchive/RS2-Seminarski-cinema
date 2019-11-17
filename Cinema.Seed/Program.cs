using Cinema.Services.DatabaseSeed;
using Cinema.Web.Data;
using System;
using System.IO;

namespace Cinema.Seed
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo file = new FileInfo(@"E:\Projects\Cinema\CinemaSeed\LegacyDatabase\CinemaDatabase.xlsx");
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=CinemaReservations;Trusted_Connection=True;MultipleActiveResultSets=true";

            ApplicationDbContext context = new ApplicationDbContext(connectionString);

            //Uncomment to run database seed
            //context.SeedDatabase(file);            
        }
    }
}
