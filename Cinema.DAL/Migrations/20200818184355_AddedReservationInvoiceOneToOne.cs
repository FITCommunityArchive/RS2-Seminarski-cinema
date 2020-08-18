using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Dal.Migrations
{
    public partial class AddedReservationInvoiceOneToOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Invoices_ReservationId",
                table: "Invoices");

            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "Reservations",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-1",
                column: "ConcurrencyStamp",
                value: "1cab1896-a79b-4faa-88db-d16e1cdf795d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-2",
                column: "ConcurrencyStamp",
                value: "ce2d9dd3-3f33-40b8-8c70-e1e64a481152");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-3",
                column: "ConcurrencyStamp",
                value: "ecb2a62c-8e92-4a84-9344-aedc66056699");

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateAndTime",
                value: new DateTime(2020, 9, 12, 18, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateAndTime",
                value: new DateTime(2020, 9, 2, 18, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateAndTime",
                value: new DateTime(2020, 8, 28, 22, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateAndTime",
                value: new DateTime(2020, 8, 28, 20, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e60daf6-1e94-493d-948a-d5d7b1a99ade", "AQAAAAEAACcQAAAAENLtxgjq7fUL3lGvEHLYGU21kF36Y+xrBhLJ7wuLrUE+8+4WpzR0gGVwEvLrnU3Drw==", "c5bdbfeb-aa4c-48dc-a2c1-abbcdfda1767" });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ReservationId",
                table: "Invoices",
                column: "ReservationId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Invoices_ReservationId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "Reservations");

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

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateAndTime",
                value: new DateTime(2020, 9, 6, 18, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateAndTime",
                value: new DateTime(2020, 8, 27, 18, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateAndTime",
                value: new DateTime(2020, 8, 22, 22, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateAndTime",
                value: new DateTime(2020, 8, 22, 20, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2dd5950-ec6a-4cb8-bf3d-9027176fa51a", "AQAAAAEAACcQAAAAEH0Pod8GhbEvZLOjMRZCL/llu6q0Efk05+l0qBKU7MDWEp2JNgeXjDyvV2P5kYZwKQ==", "6050b0fa-6aaa-45a0-a3ba-9f27f70643a0" });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ReservationId",
                table: "Invoices",
                column: "ReservationId");
        }
    }
}
