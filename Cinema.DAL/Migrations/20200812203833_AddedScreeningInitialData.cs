using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Cinema.Dal.Migrations
{
    public partial class AddedScreeningInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-1",
                column: "ConcurrencyStamp",
                value: "a1e40b2c-a659-41da-9990-50ba08070a0f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-2",
                column: "ConcurrencyStamp",
                value: "7dde52ba-a686-4510-b934-1019a49986fc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-3",
                column: "ConcurrencyStamp",
                value: "aba15515-ffc2-4304-8649-daef219468f0");

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "CreatedAt", "DateAndTime", "HallId", "IsDeleted", "MovieId", "PricingId" },
                values: new object[,]
                {
                    { -17, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 6, 18, 0, 0, 0, DateTimeKind.Utc), -1, false, -4, -5 },
                    { -16, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 27, 18, 0, 0, 0, DateTimeKind.Utc), -1, false, -4, -1 },
                    { -15, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 22, 22, 0, 0, 0, DateTimeKind.Utc), -1, false, -4, -1 },
                    { -14, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 22, 20, 0, 0, 0, DateTimeKind.Utc), -1, false, -4, -1 },
                    { -12, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 21, 20, 0, 0, 0, DateTimeKind.Unspecified), -2, false, -3, -3 },
                    { -11, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 21, 20, 0, 0, 0, DateTimeKind.Unspecified), -2, false, -3, -3 },
                    { -10, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), -1, false, -3, -3 },
                    { -8, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 10, 21, 0, 0, 0, DateTimeKind.Unspecified), -1, false, -3, -5 },
                    { -7, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 25, 21, 0, 0, 0, DateTimeKind.Unspecified), -2, false, -2, -1 },
                    { -6, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 25, 21, 0, 0, 0, DateTimeKind.Unspecified), -1, false, -2, -1 },
                    { -5, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 20, 20, 15, 0, 0, DateTimeKind.Unspecified), -2, false, -2, -4 },
                    { -4, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 20, 20, 15, 0, 0, DateTimeKind.Unspecified), -2, false, -1, -3 },
                    { -3, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 20, 19, 15, 0, 0, DateTimeKind.Unspecified), -1, false, -1, -3 },
                    { -2, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 8, 13, 19, 15, 0, 0, DateTimeKind.Unspecified), -2, false, -1, -1 },
                    { -9, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), -2, false, -3, -1 },
                    { -1, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 8, 12, 20, 15, 0, 0, DateTimeKind.Unspecified), -1, false, -1, -1 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2dd5950-ec6a-4cb8-bf3d-9027176fa51a", "AQAAAAEAACcQAAAAEH0Pod8GhbEvZLOjMRZCL/llu6q0Efk05+l0qBKU7MDWEp2JNgeXjDyvV2P5kYZwKQ==", "6050b0fa-6aaa-45a0-a3ba-9f27f70643a0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-1",
                column: "ConcurrencyStamp",
                value: "d3d49faf-3c90-4903-8cc3-31a815a4274d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-2",
                column: "ConcurrencyStamp",
                value: "091b3e13-6ca7-45a5-81dd-c4223dafe198");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-3",
                column: "ConcurrencyStamp",
                value: "c376f31d-7efe-484e-8c9b-aa01cf645392");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c30444ae-ad87-4013-ba03-0e62d5efbc19", "AQAAAAEAACcQAAAAEDsrAYSVjNaxe6yiHEP3QaHCt0SD4AXQbUSPXemQSyNLDrFfQhJEkhD6Tl+VDRoZPw==", "6904ab63-2fe6-413c-b93e-067a17ceae65" });
        }
    }
}
