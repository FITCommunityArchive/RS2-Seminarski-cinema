using Cinema.DAL.Data;
using Cinema.Seed.CollectMethods;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Cinema.Seed
{
    public static class SeedUtilities
    {
        public static Dictionary<int, string> RolesDictionary;
        public static Dictionary<int, string> UsersDictionary;
        public static async Task SeedDatabase(this UnitOfWork unit, FileInfo fileData)
        {
            /*This methods drops the database, creates a new one, 
             * and performs the defined collect methods upon all tables*/
            unit.Context.Database.EnsureDeleted();
            unit.Context.Database.EnsureCreated();
            unit.Context.ChangeTracker.AutoDetectChangesEnabled = false;

            await CollectEntities(unit, fileData);

            Console.WriteLine("Seed complete!");
        }

        public static async Task CollectEntities(this UnitOfWork unit, FileInfo fileData)
        {
            RolesDictionary = new Dictionary<int, string>();
            UsersDictionary = new Dictionary<int, string>();

            using (ExcelPackage package = new ExcelPackage(fileData))
            {
                //Type entities seed
                await GenresCollect.Collect(package.Workbook.Worksheets["Genres"], unit);
                await RolesCollect.Collect(package.Workbook.Worksheets["AppRoles"], unit);
                await NewsTypesCollect.Collect(package.Workbook.Worksheets["NewsTypes"], unit);
                await EventTypesCollect.Collect(package.Workbook.Worksheets["EventTypes"], unit);
                await PricingsCollect.Collect(package.Workbook.Worksheets["Pricings"], unit);

                //Other entities seed
                await UsersCollect.Collect(package.Workbook.Worksheets["Users"], unit);
                await HallsCollect.Collect(package.Workbook.Worksheets["Halls"], unit);
                await MoviesCollect.Collect(package.Workbook.Worksheets["Movies"], unit);
                await ReviewsCollect.Collect(package.Workbook.Worksheets["Reviews"], unit);
                await ScreeningsCollect.Collect(package.Workbook.Worksheets["Screenings"], unit);
                await ReservationsCollect.Collect(package.Workbook.Worksheets["Reservations"], unit);
                await InvoicesCollect.Collect(package.Workbook.Worksheets["Invoices"], unit);
                await SeatsCollect.Collect(package.Workbook.Worksheets["Seat"], unit);
                await SeatReservationsCollect.Collect(package.Workbook.Worksheets["SeatReservations"], unit);
                await GenreMoviesCollect.Collect(package.Workbook.Worksheets["GenreMovies"], unit);
                await EventsCollect.Collect(package.Workbook.Worksheets["Events"], unit);
                await NewsCollect.Collect(package.Workbook.Worksheets["News"], unit);
            }
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

            /*If the date cell in Excel is set to format 'Date' that equals to the set System date format, 
            the package will read it as a DateTime object, and not a OA value*/
            if (data is DateTime)
            {
                DateTime date = DateTime.Parse(data.ToString());
                return date;
            }

            double dateValue = double.Parse(data.ToString());
            return DateTime.FromOADate(dateValue);
        }

        public static bool ReadBool(this ExcelWorksheet sht, int row, int col) => sht.ReadString(row, col) == "-1";

        public static decimal ReadDecimal(this ExcelWorksheet sht, int row, int col) => decimal.Parse(sht.ReadString(row, col));

    }
}
