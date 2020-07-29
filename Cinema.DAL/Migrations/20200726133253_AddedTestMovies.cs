using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Cinema.Dal.Migrations
{
    public partial class AddedTestMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Actors", "Country", "CreatedAt", "Directors", "Duration", "Image", "IsDeleted", "Title", "VideoLink", "Year" },
                values: new object[,]
                {
                    { -5, "Tadanobu Asano, Minami, Eiko Koike", "Japan", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masanori Tominaga", 97, null, false, "Vengeance Can Wait", "", 2010 },
                    { -23, "Test Actor 1, Test Actor 2", "Test Country", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Director", 97, null, false, "Test Movie 23", "", 2010 },
                    { -22, "Test Actor 1, Test Actor 2", "Test Country", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Director", 97, null, false, "Test Movie 22", "", 2010 },
                    { -21, "Test Actor 1, Test Actor 2", "Test Country", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Director", 97, null, false, "Test Movie 21", "", 2010 },
                    { -20, "Test Actor 1, Test Actor 2", "Test Country", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Director", 97, null, false, "Test Movie 20", "", 2010 },
                    { -19, "Test Actor 1, Test Actor 2", "Test Country", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Director", 97, null, false, "Test Movie 19", "", 2010 },
                    { -18, "Test Actor 1, Test Actor 2", "Test Country", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Director", 97, null, false, "Test Movie 18", "", 2010 },
                    { -17, "Test Actor 1, Test Actor 2", "Test Country", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Director", 97, null, false, "Test Movie 17", "", 2010 },
                    { -16, "Test Actor 1, Test Actor 2", "Test Country", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Director", 97, null, false, "Test Movie 16", "", 2010 },
                    { -24, "Test Actor 1, Test Actor 2", "Test Country", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Director", 97, null, false, "Test Movie 24", "", 2010 },
                    { -15, "Test Actor 1, Test Actor 2", "Test Country", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Director", 97, null, false, "Test Movie 15", "", 2010 },
                    { -13, "Test Actor 1, Test Actor 2", "Test Country", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Director", 97, null, false, "Test Movie 13", "", 2010 },
                    { -12, "Test Actor 1, Test Actor 2", "Test Country", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Director", 97, null, false, "Test Movie 12", "", 2010 },
                    { -11, "Test Actor 1, Test Actor 2", "Test Country", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Director", 97, null, false, "Test Movie 11", "", 2010 },
                    { -10, "Test Actor 1, Test Actor 2", "Test Country", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Director", 97, null, false, "Test Movie 10", "", 2010 },
                    { -9, "Test Actor 1, Test Actor 2", "Test Country", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Director", 97, null, false, "Test Movie 9", "", 2010 },
                    { -8, "Test Actor 1, Test Actor 2", "Test Country", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Director", 97, null, false, "Test Movie 8", "", 2010 },
                    { -7, "Test Actor 1, Test Actor 2", "Test Country", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Director", 97, null, false, "Test Movie 7", "", 2010 },
                    { -6, "Test Actor 1, Test Actor 2", "Test Country", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Director", 97, null, false, "Test Movie 6", "", 2010 },
                    { -14, "Test Actor 1, Test Actor 2", "Test Country", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Director", 97, null, false, "Test Movie 14", "", 2010 },
                    { -25, "Test Actor 1, Test Actor 2", "Test Country", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Director", 97, null, false, "Test Movie 25", "", 2010 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -5);
        }
    }
}
