using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Dal.Migrations
{
    public partial class ChangeReviewScoreThreshold : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "Rating" },
                values: new object[] { new DateTime(2020, 9, 1, 6, 34, 21, 599, DateTimeKind.Utc).AddTicks(7317), 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "Rating" },
                values: new object[] { new DateTime(2020, 9, 1, 6, 34, 21, 599, DateTimeKind.Utc).AddTicks(7255), 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "Rating" },
                values: new object[] { new DateTime(2020, 9, 1, 6, 34, 21, 599, DateTimeKind.Utc).AddTicks(5269), 2 });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "30baff6b-c10d-436d-99e1-028bf3d1dd06", "AQAAAAEAACcQAAAAEIQFGi6iCXjkxR1XzmGBXpOPjPbn1vRa7zju3XtvCsuxkMMyHnKTAA/2lVv0L4lqsw==" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "Rating" },
                values: new object[] { new DateTime(2020, 8, 31, 7, 29, 38, 708, DateTimeKind.Utc).AddTicks(8594), 10 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "Rating" },
                values: new object[] { new DateTime(2020, 8, 31, 7, 29, 38, 708, DateTimeKind.Utc).AddTicks(8514), 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "Rating" },
                values: new object[] { new DateTime(2020, 8, 31, 7, 29, 38, 708, DateTimeKind.Utc).AddTicks(4041), 7 });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -3,
                column: "ConcurrencyStamp",
                value: "9ca4140e-776f-4570-95e3-cc327f18dc91");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "cea8823f-7b11-4b08-8573-e63c63d4188d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "e7c8075c-b2ca-4a70-af71-ddcde36d786b");

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateAndTime",
                value: new DateTime(2020, 9, 25, 18, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateAndTime",
                value: new DateTime(2020, 9, 15, 18, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateAndTime",
                value: new DateTime(2020, 9, 10, 22, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateAndTime",
                value: new DateTime(2020, 9, 10, 20, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ddeaf242-368c-4e04-9ff8-f818f1130a07", "AQAAAAEAACcQAAAAEGJtyFJ0NNqSAhAglc5JqF2neykQuDpH2dThrJU2ELf+okJFas3Kse9pvxSP0sdIxw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2334cf95-b556-4173-857a-d55b9658ff6e", "AQAAAAEAACcQAAAAEAm56jOI1JDyuM39K9Ei5ajX102dlO5B0Qlp+8miXb61UrzgsM3rNTTkpWhMj3zWFQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "40341c33-09b1-44e7-b373-d478aad2692a", "AQAAAAEAACcQAAAAEFdOKdFoDlbuB9eyn+gofTEXfPq80IGAmj/SlgP9w6+uxgkoJvhd5qvxXCM+gq6ZtA==" });
        }
    }
}
