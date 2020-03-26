
using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using NUnit.Framework;
using System;
using System.IO;
using Cinema.Seed.CollectMethods;
using System.Threading.Tasks;

namespace Cinema.Test
{
    [TestFixture]
    public class TestBase
    {
        private ApplicationDbContext context;
        protected UnitOfWork unit;

        [OneTimeSetUp]
        public async Task SetUp()
        {
            string path = "\\TestDatabase\\TestCinemaDatabase.xlsx";
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            string fullPath = projectDirectory + path;

            FileInfo file = new FileInfo(fullPath);
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=TestCinemaReservations;Trusted_Connection=True;MultipleActiveResultSets=true";


            context = new ApplicationDbContext(connectionString);
            unit = new UnitOfWork(context);
            await unit.SeedDatabase(file);
        }
    }
}