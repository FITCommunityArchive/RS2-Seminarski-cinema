using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Dal.Migrations
{
    public partial class ChangedAuthorIdTypeInPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Users_AuthorId1",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Users_AuthorId1",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_AuthorId1",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_Events_AuthorId1",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "AuthorId1",
                table: "News");

            migrationBuilder.DropColumn(
                name: "AuthorId1",
                table: "Events");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "News",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Events",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 8, 17, 40, 53, 297, DateTimeKind.Utc).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 8, 17, 40, 53, 297, DateTimeKind.Utc).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 8, 17, 40, 53, 297, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -3,
                column: "ConcurrencyStamp",
                value: "9264a266-8dde-4b09-b0fe-f48d840f6260");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "5e7f7605-7cda-41be-8d65-1b2bff00f4e7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "2e346100-6c9b-42d6-b635-cd33d1ebd092");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a8239351-9d03-4a66-bd4e-12ab2bae68cd", "AQAAAAEAACcQAAAAEAoVkIlEmyRh1sEFKkSxPv5efXbwNF+BzABWuJcl07bnq4capRqiduW6Hc8/UfiOAg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "abe1e4cf-6a57-44ad-9abc-b5da623ce3e1", "AQAAAAEAACcQAAAAEH9YvZ0ILYRVLMPcDNXhxPP0xntf/1ii46+66BDXLRnUfXV5AYFkjb7ByNURjgqnBQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "56d360ed-6179-4f96-ad70-5b41f09d7e98", "AQAAAAEAACcQAAAAEDEFxePDem7MS3UjnPCqDlQ12Rise7qNCx7ABBY+vPQPm1eixHYMgQ96KBhYefip8g==" });

            migrationBuilder.CreateIndex(
                name: "IX_News_AuthorId",
                table: "News",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_AuthorId",
                table: "Events",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_AuthorId",
                table: "Events",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_News_Users_AuthorId",
                table: "News",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Users_AuthorId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Users_AuthorId",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_AuthorId",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_Events_AuthorId",
                table: "Events");

            migrationBuilder.AlterColumn<string>(
                name: "AuthorId",
                table: "News",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "AuthorId1",
                table: "News",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AuthorId",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "AuthorId1",
                table: "Events",
                type: "int",
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

            migrationBuilder.CreateIndex(
                name: "IX_News_AuthorId1",
                table: "News",
                column: "AuthorId1");

            migrationBuilder.CreateIndex(
                name: "IX_Events_AuthorId1",
                table: "Events",
                column: "AuthorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_AuthorId1",
                table: "Events",
                column: "AuthorId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_News_Users_AuthorId1",
                table: "News",
                column: "AuthorId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
