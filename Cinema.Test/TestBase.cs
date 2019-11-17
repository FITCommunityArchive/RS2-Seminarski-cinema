using Cinema.Services.DatabaseSeed;
using Cinema.Web.Data;
using NUnit.Framework;
using System.IO;

namespace Cinema.Test
{
    [TestFixture]
    public class TestBase
    {
        public ApplicationDbContext context;

        [OneTimeSetUp]
        public void SetUp()
        {
            FileInfo file = new FileInfo(@"E:\Projects\Cinema\Cinema.Test\TestDatabase\TestCinemaDatabase.xlsx");
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=TestCinemaReservations;Trusted_Connection=True;MultipleActiveResultSets=true";

            context = new ApplicationDbContext(connectionString);
            context.SeedDatabase(file);
        }
    }
}