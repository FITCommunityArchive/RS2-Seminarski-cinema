using Cinema.Services.DatabaseSeed;
using Cinema.Web.Data;
using System;
using System.IO;

namespace Cinema.Seed
{
    class Program
    {

        public static string path = "\\LegacyDatabase\\CinemaDatabase.xlsx";
        public static string workingDirectory = Environment.CurrentDirectory;
        public static string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        public static string fullPath = projectDirectory + path;

        static void Main(string[] args)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=CinemaReservations;Trusted_Connection=True;MultipleActiveResultSets=true";

            string path = "\\LegacyDatabase\\CinemaDatabase.xlsx";
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            string fullPath = projectDirectory + path;
            FileInfo file = new FileInfo(fullPath);

            ApplicationDbContext context = new ApplicationDbContext(connectionString);

            //Uncomment to run database seed            
            //context.SeedDatabase(file);            
        }
    }
}
