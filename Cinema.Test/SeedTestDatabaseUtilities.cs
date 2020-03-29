using Cinema.DAL.Data;
using Cinema.Seed;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Test
{
    public static class SeedTestDatabaseUtilities
    {
        public static async Task SeedTestDatabase(this UnitOfWork unit, FileInfo fileData)
        {
            /*This methods drops the database, creates a new one, 
             * and performs the defined collect methods upon all tables*/
            unit.Context.Database.EnsureDeleted();
            unit.Context.Database.EnsureCreated();

            await unit.CollectEntities(fileData);

            Console.WriteLine("Seed complete!");
        }
    }
}
