using Cinema.DAL.Data;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Cinema.Seed
{
    class Program
    {

        static async Task Main(string[] args)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=CinemaReservations;Trusted_Connection=True;MultipleActiveResultSets=true";
            //string connectionString = "Server=app.fit.ba, 1431; Database=CinemaReservations; Trusted_Connection=false; User ID=p1872; Password=C!n3m4R3s; MultipleActiveResultSets=true";

            string path = "\\LegacyDatabase\\CinemaDatabase.xlsx";
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            string fullPath = projectDirectory + path;
            FileInfo file = new FileInfo(fullPath);

            ApplicationDbContext context = new ApplicationDbContext(connectionString);
            UnitOfWork unit = new UnitOfWork(context);

            // Uncomment to run database seed.          
            //await unit.SeedDatabase(file);
        }
    }
}
