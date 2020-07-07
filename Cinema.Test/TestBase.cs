using Cinema.Dal.Data;
using NUnit.Framework;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Cinema.Test
{
    [TestFixture]
    public class TestBase
    {
        protected CinemaDbContext context;
        protected UnitOfWork unit;

        [OneTimeSetUp]
        public virtual async Task SetUp()
        {
            string path = "\\TestDatabase\\TestCinemaDatabase.xlsx";
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            string fullPath = projectDirectory + path;

            FileInfo file = new FileInfo(fullPath);
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=TestCinemaReservations;Trusted_Connection=True;MultipleActiveResultSets=true";


            context = new CinemaDbContext(connectionString);
            unit = new UnitOfWork(context);
            await unit.SeedTestDatabase(file);
        }
    }
}