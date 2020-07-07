using Cinema.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
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
        {/*
            modelBuilder.Entity<Hall>().HasData(
                new Hall
                {
                    Id = -1,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    Name = "Movie Hall 1",
                    NumberOfColumns = 16,
                    NumberOfRows = 15                
                },
                new Hall
                {
                    Id = -2,
                    CreatedAt = new DateTime(2020, 7, 7),
                    IsDeleted = false,
                    Name = "Movie Hall 2",
                    NumberOfColumns = 16,
                    NumberOfRows = 15
                }
            );*/
        }
    }
}
