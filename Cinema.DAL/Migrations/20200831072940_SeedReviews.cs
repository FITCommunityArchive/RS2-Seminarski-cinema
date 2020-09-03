using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Dal.Migrations
{
    public partial class SeedReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "MovieId", "Rating", "Text", "UserId" },
                values: new object[,]
                {
                    { -1, new DateTime(2020, 8, 31, 7, 29, 38, 708, DateTimeKind.Utc).AddTicks(4041), false, -4, 7, "Lorem ipsum", 1 },
                    { -2, new DateTime(2020, 8, 31, 7, 29, 38, 708, DateTimeKind.Utc).AddTicks(8514), false, -4, 9, "Lorem ipsum", 2 },
                    { -3, new DateTime(2020, 8, 31, 7, 29, 38, 708, DateTimeKind.Utc).AddTicks(8594), false, -4, 10, "Lorem ipsum", 3 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -3,
                column: "ConcurrencyStamp",
                value: "ce369a0c-90dc-400d-8cb3-6074f00c2033");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "da84bcdf-bb59-4503-aacd-d4160aa022b9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "00a8fe98-10d0-4453-a822-38acd67882c5");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ee27eb11-f702-4f5d-9b7e-496727671372", "AQAAAAEAACcQAAAAEI7fKIdY6sj5OJM4dzKCyAKsCQT4fy9j2kifDgYwriAAaRsJfB0rIHPyuhwFjtCMtg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "53192723-ee2f-41dd-9c9b-ca2e7c511e68", "AQAAAAEAACcQAAAAEIs3Swvp9eEQuU+s69Yr3DlcQXNWRu5UVF3CjMHJfKBirAFwOymzB9Rr4EbjB413Sw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d4e200bb-e9d7-4f8d-afc6-e44c5eac5222", "AQAAAAEAACcQAAAAEIjqdNdQI/FGRtgPXykgSW9jbSOZjfkbPrCZnf+qWczTEG3t4c0oC8KBHyMvF7SyiQ==" });
        }
    }
}
