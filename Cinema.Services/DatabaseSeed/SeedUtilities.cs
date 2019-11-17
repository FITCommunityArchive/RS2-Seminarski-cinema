using Cinema.Services.DatabaseSeed;
using Cinema.Web.Data;
using OfficeOpenXml;
using System;
using System.IO;

namespace Cinema.Services.DatabaseSeed
{
    public static class SeedUtilities
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

        public static string ReadString(this ExcelWorksheet sht, int row, int col) => sht.Cells[row, col].Value.ToString().Trim();

        public static int ReadInteger(this ExcelWorksheet sht, int row, int col) => int.Parse(sht.ReadString(row, col));

        public static DateTime ReadDate(this ExcelWorksheet sht, int row, int col)
        {
            var data = sht.Cells[row, col].Value;
            if (data == null) return DateTime.MinValue;
            return DateTime.Parse(data.ToString());
        }
        public static DateTime ReadDateValue(this ExcelWorksheet sht, int row, int col)
        {
            var data = sht.Cells[row, col].Value;
            if (data == null) return DateTime.MinValue;
            return DateTime.FromOADate(double.Parse(data.ToString()));
        }

        public static bool ReadBool(this ExcelWorksheet sht, int row, int col) => sht.ReadString(row, col) == "-1";

        public static decimal ReadDecimal(this ExcelWorksheet sht, int row, int col) => decimal.Parse(sht.ReadString(row, col));

    }
}
