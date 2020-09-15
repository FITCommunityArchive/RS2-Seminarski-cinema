using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Cinema.Persistence.Migrations
{
    public partial class ChangedAdminCredentials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "UserName" },
                values: new object[] { "20081aab-1f50-4b63-a400-1bea14523c0a", "AQAAAAEAACcQAAAAEP1vmzYQE98jWTDOIZDor+GePnQarpGRY/5qev2ZMdSwATbE9vJZ5AXLyMnRRQMe1A==", "sa" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 1, 6, 34, 21, 599, DateTimeKind.Utc).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 1, 6, 34, 21, 599, DateTimeKind.Utc).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 1, 6, 34, 21, 599, DateTimeKind.Utc).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -3,
                column: "ConcurrencyStamp",
                value: "a79dfb40-6ec5-4486-a4ae-bb27f63f7a6f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "ef66da18-1b58-45e5-9bb7-b970e82de214");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "c211aef6-799c-4c28-bedb-a7454a6ea49a");

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateAndTime",
                value: new DateTime(2020, 9, 26, 18, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateAndTime",
                value: new DateTime(2020, 9, 16, 18, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateAndTime",
                value: new DateTime(2020, 9, 11, 22, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateAndTime",
                value: new DateTime(2020, 9, 11, 20, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "UserName" },
                values: new object[] { "30baff6b-c10d-436d-99e1-028bf3d1dd06", "AQAAAAEAACcQAAAAEIQFGi6iCXjkxR1XzmGBXpOPjPbn1vRa7zju3XtvCsuxkMMyHnKTAA/2lVv0L4lqsw==", "admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d5231008-b7c0-4055-b391-52c44a7fb992", "AQAAAAEAACcQAAAAENNpHONT66rAEzF4OPvS4ZDoFBSaiWl45A0j2GluoAgThSRL1W5xhvVt3zkw86UyrQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ab1dbb12-8af8-4250-b88e-32d7ec4cfe5a", "AQAAAAEAACcQAAAAELj6FhnsAhoWFhbdmK18jT0MAzqW4KaBL0gNZUDxNU9Hpmz8FatIderc1VJ/BS5gdA==" });
        }
    }
}
