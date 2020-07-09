using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Cinema.Dal.Migrations
{
    public partial class AddedGenreInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { -1, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Action" },
                    { -2, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Drama" },
                    { -3, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adventure" },
                    { -4, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Fantasy" },
                    { -5, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Animation" },
                    { -6, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Comedy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
