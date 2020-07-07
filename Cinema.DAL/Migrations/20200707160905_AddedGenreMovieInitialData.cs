using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Dal.Migrations
{
    public partial class AddedGenreMovieInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GenreMovies",
                columns: new[] { "Id", "CreatedAt", "GenreId", "IsDeleted", "MovieId" },
                values: new object[,]
                {
                    { -1, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, -1 },
                    { -2, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, -1 },
                    { -3, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, -4 },
                    { -4, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, -4 },
                    { -5, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, -2 },
                    { -6, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -3, false, -2 },
                    { -7, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -4, false, -2 },
                    { -8, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -4, false, -3 },
                    { -9, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -5, false, -3 },
                    { -10, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -6, false, -3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreMovies",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "GenreMovies",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "GenreMovies",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "GenreMovies",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "GenreMovies",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "GenreMovies",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "GenreMovies",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "GenreMovies",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "GenreMovies",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "GenreMovies",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
