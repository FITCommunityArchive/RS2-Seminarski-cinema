using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Cinema.Dal.Migrations
{
    public partial class RemovedPostImageByteArrayType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Events");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 8, 17, 33, 24, 520, DateTimeKind.Utc).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 8, 17, 33, 24, 520, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: -1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 8, 17, 33, 24, 520, DateTimeKind.Utc).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -3,
                column: "ConcurrencyStamp",
                value: "06928c34-a6f4-4630-9c6a-e84f62991b9a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "735e447b-c752-4781-88b1-8fa37a2b3762");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "832198a7-f6a6-4cb0-a885-1073dd98f2db");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1075e0ef-92e7-4c4d-8ad2-afba947afd99", "AQAAAAEAACcQAAAAEJ/nmYBYQ7Naa3m1B2f9+/2UpC43UjK+ulct9dbY32z/wlVxK5UXsAwu736qrflW2Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "51d11d22-5d9a-4cd1-8a7c-7cdb24c9392e", "AQAAAAEAACcQAAAAENzrojZOyyJy+KGZcAVJiQ7RjJITgs/5tFZwfux/1hU3b7TVBMAsG/M+44UDWc3EtA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6b68cca4-4d1d-497c-ad25-84e20296f304", "AQAAAAEAACcQAAAAEOAvHPl1mdWRbhDzaGmj/8IonrvJEY/5DXL553/nIIwawi616uXSH7LYjYsjWFjcJg==" });
        }
    }
}
