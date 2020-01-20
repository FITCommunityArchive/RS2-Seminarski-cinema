using Cinema.BLL;
using Cinema.Services.DatabaseSeed;
using Cinema.DAL.Data;

using Microsoft.AspNetCore.Identity;
using System;
using System.IO;
using System.Linq;

namespace Cinema.Seed
{
    class Program
    {

        static void Main(string[] args)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=CinemaReservations;Trusted_Connection=True;MultipleActiveResultSets=true";

            string path = "\\LegacyDatabase\\CinemaDatabase.xlsx";
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            string fullPath = projectDirectory + path;
            FileInfo file = new FileInfo(fullPath);

            ApplicationDbContext context = new ApplicationDbContext(connectionString);
            UnitOfWork unit = new UnitOfWork(context);

            //Uncomment to run database seed            
            unit.SeedDatabase(file);
        }
    }
}
