using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Dal.Migrations
{
    public partial class ChangedAdminEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 6, 20, 26, 30, 813, DateTimeKind.Utc).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 6, 20, 26, 30, 813, DateTimeKind.Utc).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 6, 20, 26, 30, 812, DateTimeKind.Utc).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -3,
                column: "ConcurrencyStamp",
                value: "6b643353-fcf7-4206-8dc1-06bbe0365092");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "b6329ef7-9432-4aad-b98e-a70d964927e2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "9fe3a3c8-c4d0-41a2-abeb-f964164eadc3");

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateAndTime",
                value: new DateTime(2020, 10, 1, 18, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateAndTime",
                value: new DateTime(2020, 9, 21, 18, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateAndTime",
                value: new DateTime(2020, 9, 16, 22, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateAndTime",
                value: new DateTime(2020, 9, 16, 20, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "d10538b5-8cf8-493c-a1d4-75af70e9476c", "admin@admin-test-cinema.com", "ADMIN@ADMIN-TEST-CINEMA.COM", "AQAAAAEAACcQAAAAEMjswWsxCiS0D/pSQOhr7sJEe4YXVIpsf3zlCvPRnQDlrGiDhwaq9SyP9ZQBrEbJVg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "abf79043-91cf-45fa-b500-7d58bad60fed", "AQAAAAEAACcQAAAAELCPh4IqDoaFGSX0YjOUeomc3WbMj4IuY+wizldWpXwi11YnO2YHdy8R0aUMKgPhwQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2a13a767-8a62-4773-a475-256eeea4e713", "AQAAAAEAACcQAAAAEOUsJt8xxvBmGkADAjhuC54QqKLbpLH54zLvfH4G+QY1tpWirdEribfFpodkiN9PEQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 4, 11, 19, 43, 563, DateTimeKind.Utc).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 4, 11, 19, 43, 563, DateTimeKind.Utc).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 4, 11, 19, 43, 563, DateTimeKind.Utc).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -3,
                column: "ConcurrencyStamp",
                value: "44170aef-4350-4951-b7ae-1900006f49de");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "0087f83d-09fa-45e8-9050-06383e1f16fa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "6f043655-127a-48df-9cdb-30693fbad222");

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateAndTime",
                value: new DateTime(2020, 9, 29, 18, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateAndTime",
                value: new DateTime(2020, 9, 19, 18, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateAndTime",
                value: new DateTime(2020, 9, 14, 22, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateAndTime",
                value: new DateTime(2020, 9, 14, 20, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "20081aab-1f50-4b63-a400-1bea14523c0a", "admin@admin.com", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEP1vmzYQE98jWTDOIZDor+GePnQarpGRY/5qev2ZMdSwATbE9vJZ5AXLyMnRRQMe1A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d8ac00f7-7031-44a7-8db2-57397a099f70", "AQAAAAEAACcQAAAAEF2LygcIUH26abuqtkuopEdiLkwD9bC31OES1sgL39uaRrlErcKGZHztkywZIyRd9A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2fec174f-8eb6-4e3b-a4a5-fbf2f0159816", "AQAAAAEAACcQAAAAEL2E/1QBJCrP4YAe1BD91pDN9YiFORaLZ92KD9VJLZwQBK/p+TnWF/lvV+/8gJaPgw==" });
        }
    }
}
