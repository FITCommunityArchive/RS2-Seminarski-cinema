using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Dal.Migrations
{
    public partial class AddedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EventTypes",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { -1, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Event Type 1" },
                    { -2, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Event Type 2" }
                });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "NumberOfColumns", "NumberOfRows" },
                values: new object[,]
                {
                    { -1, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Movie Hall 1", 16, 15 },
                    { -2, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Movie Hall 2", 16, 15 }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Actors", "Country", "CreatedAt", "Directors", "Duration", "Image", "IsDeleted", "Title", "VideoLink", "Year" },
                values: new object[,]
                {
                    { -1, "Mark Webber, Jade Yorker, Jaclyn DeSantis", "USA", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adam Bhala Lough", 91, null, false, "Bomb the System", "https://www.imdb.com/video/vi1706754329?playlistId=tt0337585&ref_=tt_ov_vi", 2002 },
                    { -2, "Biao Yuen, Hoi Mang, Adam Cheng", "Hong Kong", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hark Tsui", 102, null, false, "Zu: Warriors from the Magic Mountain", "https://www.imdb.com/video/vi645768729?playlistId=tt0086308&ref_=tt_ov_vi", 1983 },
                    { -3, "Alyssa Milano, Jamie Kennedy, Kathy Griffin", "USA", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Davis Doi", 75, null, false, "Dinotopia: Quest for the Ruby Sunstone", "https://www.imdb.com/video/vi1889665305?playlistId=tt0372238&ref_=tt_ov_vi", 2005 },
                    { -4, "André Benjamin, Jennifer Carpenter, Isaach De Bankolé", "Canada, USA, Germany", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stuart Townsend", 98, null, false, "Battle in Seattle", "https://www.imdb.com/video/vi1761450777?playlistId=tt0850253&ref_=tt_ov_vi", 2007 }
                });

            migrationBuilder.InsertData(
                table: "NewsTypes",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { -1, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "News Type 1" },
                    { -2, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "News Type 2" }
                });

            migrationBuilder.InsertData(
                table: "Pricing",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { -1, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Regular", 7m },
                    { -2, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Weekend", 8m },
                    { -3, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "3D", 10m },
                    { -4, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Students", 6m },
                    { -5, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Premiere", 12m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "NewsTypes",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "NewsTypes",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
