using Cinema.Seed.Collect;
using Cinema.Web.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Cinema.Seed
{
    public static class SeedData
    {
        public static void SeedDatabase(this ApplicationDbContext context, FileInfo fileData)
        {
            /*This methods drops the database, creates a new one, 
             * and performs the defined collect methods upon all tables*/


            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.ChangeTracker.AutoDetectChangesEnabled = false;

            using (ExcelPackage package = new ExcelPackage(fileData))
            {
                //Type entities seed
                GenresCollect.Collect(package.Workbook.Worksheets["Genres"], context);
                AppRolesCollect.Collect(package.Workbook.Worksheets["AppRoles"], context);
                NewsTypesCollect.Collect(package.Workbook.Worksheets["NewsTypes"], context);
                EventTypesCollect.Collect(package.Workbook.Worksheets["EventTypes"], context);
                PricingsCollect.Collect(package.Workbook.Worksheets["Pricings"], context);

                //Other entities seed
                UsersCollect.Collect(package.Workbook.Worksheets["Users"], context);                
                HallsCollect.Collect(package.Workbook.Worksheets["Halls"], context);
                MoviesCollect.Collect(package.Workbook.Worksheets["Movies"], context);
                ReviewsCollect.Collect(package.Workbook.Worksheets["Reviews"], context);
                ScreeningsCollect.Collect(package.Workbook.Worksheets["Screenings"], context);
                ReservationsCollect.Collect(package.Workbook.Worksheets["Reservations"], context);
                InvoicesCollect.Collect(package.Workbook.Worksheets["Invoices"], context);
                SeatsCollect.Collect(package.Workbook.Worksheets["Seat"], context);
                SeatReservationsCollect.Collect(package.Workbook.Worksheets["SeatReservations"], context);
                GenreMoviesCollect.Collect(package.Workbook.Worksheets["GenreMovies"], context);
                EventsCollect.Collect(package.Workbook.Worksheets["Events"], context);
                NewsCollect.Collect(package.Workbook.Worksheets["News"], context);
            }            

            Console.WriteLine("Seed complete!");
        }
    }

}
