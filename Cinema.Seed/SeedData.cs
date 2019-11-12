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
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.ChangeTracker.AutoDetectChangesEnabled = false;

            using (ExcelPackage package = new ExcelPackage(fileData))
            {
                HallsCollect.Collect(package.Workbook.Worksheets["Halls"], context);
                MoviesCollect.Collect(package.Workbook.Worksheets["Movies"], context);
                ScreeningsCollect.Collect(package.Workbook.Worksheets["Screenings"], context);
            }            

            Console.WriteLine("Seed complete!");
        }
    }

}
