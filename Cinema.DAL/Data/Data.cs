using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace Cinema.Dal.Data
{
    public class Data
    {
        public static void Migrate(CinemaDbContext context)
        {
            if (!context.Database.GetService<IRelationalDatabaseCreator>().Exists())
            {
                Console.WriteLine("Performing database migration...");
            }

            context.Database.Migrate();
        }

        public static void Seed(ModelBuilder modelBuilder)
        {
           
        }
    }
}
