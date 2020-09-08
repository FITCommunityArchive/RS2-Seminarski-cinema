using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Dal.Migrations
{
    public partial class RenamedPostImageByteArrayType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "News");

            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "Events");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Events",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 8, 17, 35, 7, 106, DateTimeKind.Utc).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 8, 17, 35, 7, 106, DateTimeKind.Utc).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 8, 17, 35, 7, 106, DateTimeKind.Utc).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -3,
                column: "ConcurrencyStamp",
                value: "41aa3b2c-857d-4d86-80d4-6f5c03f1ce36");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "09690f28-30bb-459b-bee3-f67d0d0dd0c8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "b16c5568-34d3-4548-bb9e-44ce2649ac7e");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b008fcce-7492-4946-b7c6-b2145890de60", "AQAAAAEAACcQAAAAEBPtQp9UAGmXG0USON1L23d8ZfGwMQsrtdDxLteTwLCFfGi4cYA/O3P3zjnucIuQQA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ec7eb8d8-f906-4db6-b892-c732dcf618f7", "AQAAAAEAACcQAAAAEO5cJG153f3J2EnrwatHzGkN91VKo/zbuObi2Hr6nMNjsuKkuJ7aA7p9NTxS0zQMXg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9dc1645e-b975-497c-9035-4e0614a62b1c", "AQAAAAEAACcQAAAAEL/r+VEKY6b0ZtfkWjD8DurpKznsWsEeGR0n51Yr6CekYawE75G3BeXNXdkPPaHmig==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Events");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "News",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "Events",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 8, 17, 34, 5, 849, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 8, 17, 34, 5, 849, DateTimeKind.Utc).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 8, 17, 34, 5, 849, DateTimeKind.Utc).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -3,
                column: "ConcurrencyStamp",
                value: "f217c31c-435c-4b74-833d-09c8a4e8337c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "a30278ec-813d-4f5f-8805-31378c15dd92");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "8a031b38-ca0c-4f49-9bd1-1a2b7bd8c3a4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1f90b94f-31a8-4ad9-8f95-5627a6b239be", "AQAAAAEAACcQAAAAEFpAktjCJ7jFC51wCIJntqfHLSzEqA2v5Mvyvs5It26OB6BpNjnbhlLopmh5UXhkWA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ab7405ba-2804-4ae9-953c-7e4ada6ebbdc", "AQAAAAEAACcQAAAAEAt068ywvD5DanQIkfO3dsi1xhL9CmcXeWABOu1+eTtVz+dV3s4P63Oiffg6K9MeEQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "86488cd0-997a-4845-ac3e-f244a98c19ce", "AQAAAAEAACcQAAAAEPLrkn8QBgKlVXqzwJdDUalYJoitsDXl2O1Z/2tBa6tOwafAgeqT61zkF8cMJNcWtA==" });
        }
    }
}
