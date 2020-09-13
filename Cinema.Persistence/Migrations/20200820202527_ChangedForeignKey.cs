using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Cinema.Persistence.Migrations
{
    public partial class ChangedForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Pricing_OfferTypeId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Users_UserId1",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_UserId1",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_OfferTypeId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_ReservationId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "OfferTypeId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "TicketQuantity",
                table: "Invoices");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Reservations",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "Reservations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TicketQuantity",
                table: "Reservations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PricingId",
                table: "Invoices",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -3,
                column: "ConcurrencyStamp",
                value: "7aa458b4-fe83-4543-84ec-2b074b05dc90");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "a70cf922-48c4-4aa1-872c-7b07762b0a2a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "0da3be4c-7c6d-4a31-a613-9e803b464aa0");

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "CreatedAt", "DateAndTime", "HallId", "IsDeleted", "MovieId", "PricingId" },
                values: new object[,]
                {
                    { -17, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 14, 18, 0, 0, 0, DateTimeKind.Utc), -1, false, -4, -5 },
                    { -16, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 4, 18, 0, 0, 0, DateTimeKind.Utc), -1, false, -4, -1 },
                    { -15, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 30, 22, 0, 0, 0, DateTimeKind.Utc), -1, false, -4, -1 },
                    { -14, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 30, 20, 0, 0, 0, DateTimeKind.Utc), -1, false, -4, -1 },
                    { -12, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 21, 20, 0, 0, 0, DateTimeKind.Unspecified), -2, false, -3, -3 },
                    { -11, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 21, 20, 0, 0, 0, DateTimeKind.Unspecified), -2, false, -3, -3 },
                    { -10, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), -1, false, -3, -3 },
                    { -1, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 8, 12, 20, 15, 0, 0, DateTimeKind.Unspecified), -1, false, -1, -1 },
                    { -8, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 10, 21, 0, 0, 0, DateTimeKind.Unspecified), -1, false, -3, -5 },
                    { -2, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 8, 13, 19, 15, 0, 0, DateTimeKind.Unspecified), -2, false, -1, -1 },
                    { -3, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 20, 19, 15, 0, 0, DateTimeKind.Unspecified), -1, false, -1, -3 },
                    { -4, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 20, 20, 15, 0, 0, DateTimeKind.Unspecified), -2, false, -1, -3 },
                    { -9, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), -2, false, -3, -1 },
                    { -6, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 25, 21, 0, 0, 0, DateTimeKind.Unspecified), -1, false, -2, -1 },
                    { -7, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 25, 21, 0, 0, 0, DateTimeKind.Unspecified), -2, false, -2, -1 },
                    { -5, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 20, 20, 15, 0, 0, DateTimeKind.Unspecified), -2, false, -2, -4 }
                });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -479,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 224 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -478,
                column: "SeatNumber",
                value: 208);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -477,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 192 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -476,
                column: "SeatNumber",
                value: 176);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -475,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 160 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -474,
                column: "SeatNumber",
                value: 144);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -473,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 128 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -472,
                column: "SeatNumber",
                value: 112);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -471,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 96 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -470,
                column: "SeatNumber",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -469,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 64 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -468,
                column: "SeatNumber",
                value: 48);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -467,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 32 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -466,
                column: "SeatNumber",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -465,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 225 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -464,
                column: "SeatNumber",
                value: 210);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -463,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 195 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -462,
                column: "SeatNumber",
                value: 180);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -461,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 165 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -460,
                column: "SeatNumber",
                value: 150);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -459,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 135 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -458,
                column: "SeatNumber",
                value: 120);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -457,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 105 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -456,
                column: "SeatNumber",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -455,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 75 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -454,
                column: "SeatNumber",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -453,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 45 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -452,
                column: "SeatNumber",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -451,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 15 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -450,
                column: "SeatNumber",
                value: 210);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -449,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 196 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -448,
                column: "SeatNumber",
                value: 182);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -447,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 168 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -446,
                column: "SeatNumber",
                value: 154);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -445,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 140 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -444,
                column: "SeatNumber",
                value: 126);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -443,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 112 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -442,
                column: "SeatNumber",
                value: 98);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -441,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 84 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -440,
                column: "SeatNumber",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -439,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 56 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -438,
                column: "SeatNumber",
                value: 42);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -437,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 28 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -436,
                column: "SeatNumber",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -435,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 195 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -434,
                column: "SeatNumber",
                value: 182);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -433,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 169 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -432,
                column: "SeatNumber",
                value: 156);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -431,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 143 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -430,
                column: "SeatNumber",
                value: 130);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -429,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 117 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -428,
                column: "SeatNumber",
                value: 104);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -427,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 91 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -426,
                column: "SeatNumber",
                value: 78);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -425,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 65 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -424,
                column: "SeatNumber",
                value: 52);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -423,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 39 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -422,
                column: "SeatNumber",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -421,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 13 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -420,
                column: "SeatNumber",
                value: 180);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -419,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 168 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -418,
                column: "SeatNumber",
                value: 156);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -417,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 144 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -416,
                column: "SeatNumber",
                value: 132);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -415,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 120 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -414,
                column: "SeatNumber",
                value: 108);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -413,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 96 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -412,
                column: "SeatNumber",
                value: 84);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -411,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 72 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -410,
                column: "SeatNumber",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -409,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 48 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -408,
                column: "SeatNumber",
                value: 36);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -407,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 24 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -406,
                column: "SeatNumber",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -405,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 165 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -404,
                column: "SeatNumber",
                value: 154);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -403,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 143 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -402,
                column: "SeatNumber",
                value: 132);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -401,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 121 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -400,
                column: "SeatNumber",
                value: 110);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -399,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 99 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -398,
                column: "SeatNumber",
                value: 88);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -397,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 77 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -396,
                column: "SeatNumber",
                value: 66);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -395,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 55 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -394,
                column: "SeatNumber",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -393,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 33 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -392,
                column: "SeatNumber",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -391,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 11 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -390,
                column: "SeatNumber",
                value: 150);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -389,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 140 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -388,
                column: "SeatNumber",
                value: 130);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -387,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 120 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -386,
                column: "SeatNumber",
                value: 110);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -385,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 100 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -384,
                column: "SeatNumber",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -383,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 80 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -382,
                column: "SeatNumber",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -381,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 60 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -380,
                column: "SeatNumber",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -379,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 40 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -378,
                column: "SeatNumber",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -377,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 20 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -376,
                column: "SeatNumber",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -375,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 135 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -374,
                column: "SeatNumber",
                value: 126);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -373,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 117 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -372,
                column: "SeatNumber",
                value: 108);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -371,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 99 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -370,
                column: "SeatNumber",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -369,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 81 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -368,
                column: "SeatNumber",
                value: 72);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -367,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 63 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -366,
                column: "SeatNumber",
                value: 54);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -365,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 45 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -364,
                column: "SeatNumber",
                value: 36);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -363,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 27 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -362,
                column: "SeatNumber",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -361,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 9 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -360,
                column: "SeatNumber",
                value: 120);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -359,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 112 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -358,
                column: "SeatNumber",
                value: 104);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -357,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 96 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -356,
                column: "SeatNumber",
                value: 88);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -355,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 80 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -354,
                column: "SeatNumber",
                value: 72);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -353,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 64 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -352,
                column: "SeatNumber",
                value: 56);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -351,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 48 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -350,
                column: "SeatNumber",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -349,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 32 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -348,
                column: "SeatNumber",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -347,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 16 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -346,
                column: "SeatNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -345,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 105 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -344,
                column: "SeatNumber",
                value: 98);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -343,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 91 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -342,
                column: "SeatNumber",
                value: 84);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -341,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 77 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -340,
                column: "SeatNumber",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -339,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 63 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -338,
                column: "SeatNumber",
                value: 56);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -337,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 49 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -336,
                column: "SeatNumber",
                value: 42);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -335,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 35 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -334,
                column: "SeatNumber",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -333,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 21 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -332,
                column: "SeatNumber",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -331,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 7 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -330,
                column: "SeatNumber",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -329,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 84 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -328,
                column: "SeatNumber",
                value: 78);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -327,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 72 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -326,
                column: "SeatNumber",
                value: 66);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -325,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 60 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -324,
                column: "SeatNumber",
                value: 54);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -323,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 48 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -322,
                column: "SeatNumber",
                value: 42);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -321,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 36 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -320,
                column: "SeatNumber",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -319,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 24 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -318,
                column: "SeatNumber",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -317,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 12 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -316,
                column: "SeatNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -315,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 75 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -314,
                column: "SeatNumber",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -313,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 65 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -312,
                column: "SeatNumber",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -311,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 55 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -310,
                column: "SeatNumber",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -309,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 45 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -308,
                column: "SeatNumber",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -307,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 35 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -306,
                column: "SeatNumber",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -305,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 25 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -304,
                column: "SeatNumber",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -303,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 15 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -302,
                column: "SeatNumber",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -301,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 5 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -300,
                column: "SeatNumber",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -299,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 56 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -298,
                column: "SeatNumber",
                value: 52);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -297,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 48 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -296,
                column: "SeatNumber",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -295,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 40 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -294,
                column: "SeatNumber",
                value: 36);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -293,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 32 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -292,
                column: "SeatNumber",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -291,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 24 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -290,
                column: "SeatNumber",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -289,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 16 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -288,
                column: "SeatNumber",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -287,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 8 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -286,
                column: "SeatNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -285,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 45 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -284,
                column: "SeatNumber",
                value: 42);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -283,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 39 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -282,
                column: "SeatNumber",
                value: 36);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -281,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 33 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -280,
                column: "SeatNumber",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -279,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 27 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -278,
                column: "SeatNumber",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -277,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 21 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -276,
                column: "SeatNumber",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -275,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 15 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -274,
                column: "SeatNumber",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -273,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 9 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -272,
                column: "SeatNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -271,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 3 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -270,
                column: "SeatNumber",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -269,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 28 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -268,
                column: "SeatNumber",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -267,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 24 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -266,
                column: "SeatNumber",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -265,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 20 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -264,
                column: "SeatNumber",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -263,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 16 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -262,
                column: "SeatNumber",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -261,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 12 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -260,
                column: "SeatNumber",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -259,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 8 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -258,
                column: "SeatNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -257,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 4 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -256,
                column: "SeatNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -255,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 15 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -254,
                column: "SeatNumber",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -253,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 13 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -252,
                column: "SeatNumber",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -251,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 11 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -250,
                column: "SeatNumber",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -249,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 9 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -248,
                column: "SeatNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -247,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 7 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -246,
                column: "SeatNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -245,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 5 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -244,
                column: "SeatNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -243,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 3 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -242,
                column: "SeatNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -241,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 1 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -240,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 240 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -239,
                column: "SeatNumber",
                value: 224);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -238,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 208 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -237,
                column: "SeatNumber",
                value: 192);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -236,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 176 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -235,
                column: "SeatNumber",
                value: 160);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -234,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 144 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -233,
                column: "SeatNumber",
                value: 128);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -232,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 112 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -231,
                column: "SeatNumber",
                value: 96);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -230,
                column: "HallId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -229,
                column: "SeatNumber",
                value: 64);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -228,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 48 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -227,
                column: "SeatNumber",
                value: 32);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -226,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 16 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -225,
                column: "SeatNumber",
                value: 225);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -224,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 210 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -223,
                column: "SeatNumber",
                value: 195);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -222,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 180 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -221,
                column: "SeatNumber",
                value: 165);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -220,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 150 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -219,
                column: "SeatNumber",
                value: 135);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -218,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 120 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -217,
                column: "SeatNumber",
                value: 105);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -216,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 90 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -215,
                column: "SeatNumber",
                value: 75);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -214,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 60 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -213,
                column: "SeatNumber",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -212,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 30 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -211,
                column: "SeatNumber",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -210,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 210 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -209,
                column: "SeatNumber",
                value: 196);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -208,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 182 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -207,
                column: "SeatNumber",
                value: 168);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -206,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 154 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -205,
                column: "SeatNumber",
                value: 140);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -204,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 126 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -203,
                column: "SeatNumber",
                value: 112);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -202,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 98 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -201,
                column: "SeatNumber",
                value: 84);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -200,
                column: "HallId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -199,
                column: "SeatNumber",
                value: 56);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -198,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 42 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -197,
                column: "SeatNumber",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -196,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 14 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -195,
                column: "SeatNumber",
                value: 195);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -194,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 182 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -193,
                column: "SeatNumber",
                value: 169);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -192,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 156 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -191,
                column: "SeatNumber",
                value: 143);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -190,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 130 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -189,
                column: "SeatNumber",
                value: 117);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -188,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 104 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -187,
                column: "SeatNumber",
                value: 91);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -186,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 78 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -185,
                column: "SeatNumber",
                value: 65);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -184,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 52 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -183,
                column: "SeatNumber",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -182,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 26 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -181,
                column: "SeatNumber",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -180,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 180 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -179,
                column: "SeatNumber",
                value: 168);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -178,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 156 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -177,
                column: "SeatNumber",
                value: 144);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -176,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 132 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -175,
                column: "SeatNumber",
                value: 120);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -174,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 108 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -173,
                column: "SeatNumber",
                value: 96);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -172,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 84 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -171,
                column: "SeatNumber",
                value: 72);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -170,
                column: "HallId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -169,
                column: "SeatNumber",
                value: 48);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -168,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 36 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -167,
                column: "SeatNumber",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -166,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 12 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -165,
                column: "SeatNumber",
                value: 165);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -164,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 154 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -163,
                column: "SeatNumber",
                value: 143);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -162,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 132 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -161,
                column: "SeatNumber",
                value: 121);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -160,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 110 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -159,
                column: "SeatNumber",
                value: 99);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -158,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 88 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -157,
                column: "SeatNumber",
                value: 77);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -156,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 66 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -155,
                column: "SeatNumber",
                value: 55);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -154,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 44 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -153,
                column: "SeatNumber",
                value: 33);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -152,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 22 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -151,
                column: "SeatNumber",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -150,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 150 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -149,
                column: "SeatNumber",
                value: 140);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -148,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 130 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -147,
                column: "SeatNumber",
                value: 120);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -146,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 110 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -145,
                column: "SeatNumber",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -144,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 90 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -143,
                column: "SeatNumber",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -142,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 70 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -141,
                column: "SeatNumber",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -140,
                column: "HallId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -139,
                column: "SeatNumber",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -138,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 30 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -137,
                column: "SeatNumber",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -136,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 10 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -135,
                column: "SeatNumber",
                value: 135);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -134,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 126 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -133,
                column: "SeatNumber",
                value: 117);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -132,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 108 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -131,
                column: "SeatNumber",
                value: 99);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -130,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 90 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -129,
                column: "SeatNumber",
                value: 81);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -128,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 72 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -127,
                column: "SeatNumber",
                value: 63);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -126,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 54 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -125,
                column: "SeatNumber",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -124,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 36 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -123,
                column: "SeatNumber",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -122,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 18 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -121,
                column: "SeatNumber",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -120,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 120 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -119,
                column: "SeatNumber",
                value: 112);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -118,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 104 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -117,
                column: "SeatNumber",
                value: 96);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -116,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 88 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -115,
                column: "SeatNumber",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -114,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 72 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -113,
                column: "SeatNumber",
                value: 64);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -112,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 56 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -111,
                column: "SeatNumber",
                value: 48);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -110,
                column: "HallId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -109,
                column: "SeatNumber",
                value: 32);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -108,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 24 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -107,
                column: "SeatNumber",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -106,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 8 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -105,
                column: "SeatNumber",
                value: 105);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -104,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 98 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -103,
                column: "SeatNumber",
                value: 91);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -102,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 84 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -101,
                column: "SeatNumber",
                value: 77);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -100,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 70 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -99,
                column: "SeatNumber",
                value: 63);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -98,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 56 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -97,
                column: "SeatNumber",
                value: 49);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -96,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 42 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -95,
                column: "SeatNumber",
                value: 35);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -94,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 28 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -93,
                column: "SeatNumber",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 14 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -91,
                column: "SeatNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -90,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 90 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -89,
                column: "SeatNumber",
                value: 84);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -88,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 78 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -87,
                column: "SeatNumber",
                value: 72);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -86,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 66 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -85,
                column: "SeatNumber",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -84,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 54 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -83,
                column: "SeatNumber",
                value: 48);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -82,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 42 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -81,
                column: "SeatNumber",
                value: 36);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -80,
                column: "HallId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -79,
                column: "SeatNumber",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 18 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -77,
                column: "SeatNumber",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 6 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -75,
                column: "SeatNumber",
                value: 75);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 70 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -73,
                column: "SeatNumber",
                value: 65);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 60 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -71,
                column: "SeatNumber",
                value: 55);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 50 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -69,
                column: "SeatNumber",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 40 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -67,
                column: "SeatNumber",
                value: 35);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 30 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -65,
                column: "SeatNumber",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 20 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -63,
                column: "SeatNumber",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 10 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -61,
                column: "SeatNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 60 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -59,
                column: "SeatNumber",
                value: 56);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 52 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -57,
                column: "SeatNumber",
                value: 48);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 44 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -55,
                column: "SeatNumber",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 36 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -53,
                column: "SeatNumber",
                value: 32);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 28 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -51,
                column: "SeatNumber",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -50,
                column: "HallId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -49,
                column: "SeatNumber",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 12 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -47,
                column: "SeatNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 4 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -45,
                column: "SeatNumber",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 42 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -43,
                column: "SeatNumber",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 36 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -41,
                column: "SeatNumber",
                value: 33);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 30 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -39,
                column: "SeatNumber",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 24 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -37,
                column: "SeatNumber",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 18 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -35,
                column: "SeatNumber",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 12 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -33,
                column: "SeatNumber",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 6 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -31,
                column: "SeatNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 30 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -29,
                column: "SeatNumber",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 26 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -27,
                column: "SeatNumber",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 22 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -25,
                column: "SeatNumber",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 18 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -23,
                column: "SeatNumber",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 14 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -21,
                column: "SeatNumber",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -20,
                column: "HallId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -19,
                column: "SeatNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 6 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -17,
                column: "SeatNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 2 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -15,
                column: "SeatNumber",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 14 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -13,
                column: "SeatNumber",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 12 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -11,
                column: "SeatNumber",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 10 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -9,
                column: "SeatNumber",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 8 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -7,
                column: "SeatNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 6 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -5,
                column: "SeatNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 4 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -3,
                column: "SeatNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash" },
                values: new object[] { "7c3311c6-7974-429c-9d64-41c2a8ae0599", "Admin", "Test", "AQAAAAEAACcQAAAAEH76sRsp4PSREShtlwdSFW52+ap4y/6PLS4iU3ZVFvzeqDermiJNpOBD1PL4eT2Zgg==" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Deleted", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 3, 0, "7c3c51e9-cc37-43d9-8e37-20e5bf1274fe", false, "test2@test-customer.com", true, "Second", "Customer", false, null, "TEST2@TEST-CUSTOMER.COM", "TEST.CUSTOMER2", "AQAAAAEAACcQAAAAEAi7BhDK6+xom6GbHSKw7HyCghJxWKSpNAQ3v1s04608pyR4hTKYDm29euC7FvE8NQ==", "123456789", false, null, false, "test.customer2" },
                    { 2, 0, "34a53178-3caa-44ac-8c52-209073017f06", false, "test1@test-customer.com", true, "First", "Customer", false, null, "TEST1@TEST-CUSTOMER.COM", "TEST.CUSTOMER1", "AQAAAAEAACcQAAAAEOLZSc4oD3vWyJCko9QTTg/EuXPFk28BWHgDMseTfm7JaFsPrt/jGA1YNDm7hBb/wA==", "123456789", false, null, false, "test.customer1" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId", "Deleted" },
                values: new object[] { 2, -3, false });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId", "Deleted" },
                values: new object[] { 3, -3, false });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_PricingId",
                table: "Invoices",
                column: "PricingId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ReservationId",
                table: "Invoices",
                column: "ReservationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Pricing_PricingId",
                table: "Invoices",
                column: "PricingId",
                principalTable: "Pricing",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Users_UserId",
                table: "Reservations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Pricing_PricingId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Users_UserId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_PricingId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_ReservationId",
                table: "Invoices");

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

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { 2, -3 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { 3, -3 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "TicketQuantity",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "PricingId",
                table: "Invoices");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Reservations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OfferTypeId",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TicketQuantity",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -3,
                column: "ConcurrencyStamp",
                value: "709931a7-608f-4070-8c83-b994ae946fae");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "5e41a3da-0648-48be-adc1-16c39f4b4415");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "f8035ee8-d4a2-45bc-b9d9-954d46075c64");

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -479,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 240 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -478,
                column: "SeatNumber",
                value: 224);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -477,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 224 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -476,
                column: "SeatNumber",
                value: 208);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -475,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 208 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -474,
                column: "SeatNumber",
                value: 192);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -473,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 192 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -472,
                column: "SeatNumber",
                value: 176);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -471,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 176 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -470,
                column: "SeatNumber",
                value: 160);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -469,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 160 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -468,
                column: "SeatNumber",
                value: 144);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -467,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 144 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -466,
                column: "SeatNumber",
                value: 128);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -465,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 128 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -464,
                column: "SeatNumber",
                value: 112);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -463,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 112 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -462,
                column: "SeatNumber",
                value: 96);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -461,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 96 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -460,
                column: "SeatNumber",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -459,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 80 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -458,
                column: "SeatNumber",
                value: 64);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -457,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 64 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -456,
                column: "SeatNumber",
                value: 48);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -455,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 48 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -454,
                column: "SeatNumber",
                value: 32);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -453,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 32 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -452,
                column: "SeatNumber",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -451,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 16 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -450,
                column: "SeatNumber",
                value: 225);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -449,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 225 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -448,
                column: "SeatNumber",
                value: 210);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -447,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 210 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -446,
                column: "SeatNumber",
                value: 195);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -445,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 195 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -444,
                column: "SeatNumber",
                value: 180);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -443,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 180 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -442,
                column: "SeatNumber",
                value: 165);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -441,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 165 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -440,
                column: "SeatNumber",
                value: 150);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -439,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 150 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -438,
                column: "SeatNumber",
                value: 135);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -437,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 135 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -436,
                column: "SeatNumber",
                value: 120);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -435,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 120 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -434,
                column: "SeatNumber",
                value: 105);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -433,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 105 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -432,
                column: "SeatNumber",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -431,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 90 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -430,
                column: "SeatNumber",
                value: 75);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -429,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 75 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -428,
                column: "SeatNumber",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -427,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 60 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -426,
                column: "SeatNumber",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -425,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 45 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -424,
                column: "SeatNumber",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -423,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 30 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -422,
                column: "SeatNumber",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -421,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 15 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -420,
                column: "SeatNumber",
                value: 210);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -419,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 210 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -418,
                column: "SeatNumber",
                value: 196);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -417,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 196 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -416,
                column: "SeatNumber",
                value: 182);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -415,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 182 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -414,
                column: "SeatNumber",
                value: 168);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -413,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 168 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -412,
                column: "SeatNumber",
                value: 154);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -411,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 154 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -410,
                column: "SeatNumber",
                value: 140);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -409,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 140 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -408,
                column: "SeatNumber",
                value: 126);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -407,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 126 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -406,
                column: "SeatNumber",
                value: 112);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -405,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 112 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -404,
                column: "SeatNumber",
                value: 98);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -403,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 98 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -402,
                column: "SeatNumber",
                value: 84);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -401,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 84 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -400,
                column: "SeatNumber",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -399,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 70 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -398,
                column: "SeatNumber",
                value: 56);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -397,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 56 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -396,
                column: "SeatNumber",
                value: 42);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -395,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 42 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -394,
                column: "SeatNumber",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -393,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 28 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -392,
                column: "SeatNumber",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -391,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 14 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -390,
                column: "SeatNumber",
                value: 195);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -389,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 195 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -388,
                column: "SeatNumber",
                value: 182);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -387,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 182 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -386,
                column: "SeatNumber",
                value: 169);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -385,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 169 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -384,
                column: "SeatNumber",
                value: 156);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -383,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 156 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -382,
                column: "SeatNumber",
                value: 143);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -381,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 143 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -380,
                column: "SeatNumber",
                value: 130);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -379,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 130 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -378,
                column: "SeatNumber",
                value: 117);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -377,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 117 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -376,
                column: "SeatNumber",
                value: 104);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -375,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 104 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -374,
                column: "SeatNumber",
                value: 91);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -373,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 91 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -372,
                column: "SeatNumber",
                value: 78);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -371,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 78 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -370,
                column: "SeatNumber",
                value: 65);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -369,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 65 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -368,
                column: "SeatNumber",
                value: 52);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -367,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 52 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -366,
                column: "SeatNumber",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -365,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 39 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -364,
                column: "SeatNumber",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -363,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 26 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -362,
                column: "SeatNumber",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -361,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 13 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -360,
                column: "SeatNumber",
                value: 180);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -359,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 180 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -358,
                column: "SeatNumber",
                value: 168);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -357,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 168 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -356,
                column: "SeatNumber",
                value: 156);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -355,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 156 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -354,
                column: "SeatNumber",
                value: 144);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -353,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 144 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -352,
                column: "SeatNumber",
                value: 132);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -351,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 132 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -350,
                column: "SeatNumber",
                value: 120);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -349,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 120 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -348,
                column: "SeatNumber",
                value: 108);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -347,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 108 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -346,
                column: "SeatNumber",
                value: 96);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -345,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 96 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -344,
                column: "SeatNumber",
                value: 84);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -343,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 84 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -342,
                column: "SeatNumber",
                value: 72);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -341,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 72 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -340,
                column: "SeatNumber",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -339,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 60 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -338,
                column: "SeatNumber",
                value: 48);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -337,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 48 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -336,
                column: "SeatNumber",
                value: 36);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -335,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 36 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -334,
                column: "SeatNumber",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -333,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 24 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -332,
                column: "SeatNumber",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -331,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 12 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -330,
                column: "SeatNumber",
                value: 165);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -329,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 165 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -328,
                column: "SeatNumber",
                value: 154);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -327,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 154 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -326,
                column: "SeatNumber",
                value: 143);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -325,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 143 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -324,
                column: "SeatNumber",
                value: 132);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -323,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 132 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -322,
                column: "SeatNumber",
                value: 121);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -321,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 121 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -320,
                column: "SeatNumber",
                value: 110);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -319,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 110 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -318,
                column: "SeatNumber",
                value: 99);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -317,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 99 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -316,
                column: "SeatNumber",
                value: 88);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -315,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 88 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -314,
                column: "SeatNumber",
                value: 77);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -313,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 77 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -312,
                column: "SeatNumber",
                value: 66);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -311,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 66 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -310,
                column: "SeatNumber",
                value: 55);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -309,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 55 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -308,
                column: "SeatNumber",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -307,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 44 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -306,
                column: "SeatNumber",
                value: 33);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -305,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 33 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -304,
                column: "SeatNumber",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -303,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 22 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -302,
                column: "SeatNumber",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -301,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 11 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -300,
                column: "SeatNumber",
                value: 150);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -299,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 150 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -298,
                column: "SeatNumber",
                value: 140);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -297,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 140 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -296,
                column: "SeatNumber",
                value: 130);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -295,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 130 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -294,
                column: "SeatNumber",
                value: 120);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -293,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 120 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -292,
                column: "SeatNumber",
                value: 110);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -291,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 110 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -290,
                column: "SeatNumber",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -289,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 100 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -288,
                column: "SeatNumber",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -287,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 90 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -286,
                column: "SeatNumber",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -285,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 80 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -284,
                column: "SeatNumber",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -283,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 70 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -282,
                column: "SeatNumber",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -281,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 60 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -280,
                column: "SeatNumber",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -279,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 50 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -278,
                column: "SeatNumber",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -277,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 40 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -276,
                column: "SeatNumber",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -275,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 30 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -274,
                column: "SeatNumber",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -273,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 20 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -272,
                column: "SeatNumber",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -271,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 10 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -270,
                column: "SeatNumber",
                value: 135);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -269,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 135 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -268,
                column: "SeatNumber",
                value: 126);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -267,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 126 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -266,
                column: "SeatNumber",
                value: 117);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -265,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 117 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -264,
                column: "SeatNumber",
                value: 108);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -263,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 108 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -262,
                column: "SeatNumber",
                value: 99);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -261,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 99 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -260,
                column: "SeatNumber",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -259,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 90 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -258,
                column: "SeatNumber",
                value: 81);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -257,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 81 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -256,
                column: "SeatNumber",
                value: 72);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -255,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 72 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -254,
                column: "SeatNumber",
                value: 63);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -253,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 63 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -252,
                column: "SeatNumber",
                value: 54);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -251,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 54 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -250,
                column: "SeatNumber",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -249,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 45 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -248,
                column: "SeatNumber",
                value: 36);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -247,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 36 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -246,
                column: "SeatNumber",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -245,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 27 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -244,
                column: "SeatNumber",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -243,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 18 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -242,
                column: "SeatNumber",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -241,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -1, 9 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -240,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 120 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -239,
                column: "SeatNumber",
                value: 120);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -238,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 112 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -237,
                column: "SeatNumber",
                value: 112);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -236,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 104 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -235,
                column: "SeatNumber",
                value: 104);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -234,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 96 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -233,
                column: "SeatNumber",
                value: 96);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -232,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 88 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -231,
                column: "SeatNumber",
                value: 88);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -230,
                column: "HallId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -229,
                column: "SeatNumber",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -228,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 72 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -227,
                column: "SeatNumber",
                value: 72);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -226,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 64 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -225,
                column: "SeatNumber",
                value: 64);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -224,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 56 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -223,
                column: "SeatNumber",
                value: 56);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -222,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 48 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -221,
                column: "SeatNumber",
                value: 48);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -220,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 40 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -219,
                column: "SeatNumber",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -218,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 32 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -217,
                column: "SeatNumber",
                value: 32);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -216,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 24 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -215,
                column: "SeatNumber",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -214,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 16 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -213,
                column: "SeatNumber",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -212,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 8 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -211,
                column: "SeatNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -210,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 105 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -209,
                column: "SeatNumber",
                value: 105);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -208,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 98 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -207,
                column: "SeatNumber",
                value: 98);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -206,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 91 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -205,
                column: "SeatNumber",
                value: 91);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -204,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 84 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -203,
                column: "SeatNumber",
                value: 84);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -202,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 77 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -201,
                column: "SeatNumber",
                value: 77);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -200,
                column: "HallId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -199,
                column: "SeatNumber",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -198,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 63 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -197,
                column: "SeatNumber",
                value: 63);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -196,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 56 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -195,
                column: "SeatNumber",
                value: 56);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -194,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 49 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -193,
                column: "SeatNumber",
                value: 49);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -192,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 42 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -191,
                column: "SeatNumber",
                value: 42);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -190,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 35 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -189,
                column: "SeatNumber",
                value: 35);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -188,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 28 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -187,
                column: "SeatNumber",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -186,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 21 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -185,
                column: "SeatNumber",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -184,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 14 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -183,
                column: "SeatNumber",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -182,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 7 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -181,
                column: "SeatNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -180,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 90 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -179,
                column: "SeatNumber",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -178,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 84 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -177,
                column: "SeatNumber",
                value: 84);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -176,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 78 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -175,
                column: "SeatNumber",
                value: 78);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -174,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 72 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -173,
                column: "SeatNumber",
                value: 72);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -172,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 66 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -171,
                column: "SeatNumber",
                value: 66);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -170,
                column: "HallId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -169,
                column: "SeatNumber",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -168,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 54 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -167,
                column: "SeatNumber",
                value: 54);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -166,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 48 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -165,
                column: "SeatNumber",
                value: 48);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -164,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 42 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -163,
                column: "SeatNumber",
                value: 42);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -162,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 36 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -161,
                column: "SeatNumber",
                value: 36);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -160,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 30 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -159,
                column: "SeatNumber",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -158,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 24 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -157,
                column: "SeatNumber",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -156,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 18 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -155,
                column: "SeatNumber",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -154,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 12 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -153,
                column: "SeatNumber",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -152,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 6 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -151,
                column: "SeatNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -150,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 75 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -149,
                column: "SeatNumber",
                value: 75);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -148,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 70 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -147,
                column: "SeatNumber",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -146,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 65 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -145,
                column: "SeatNumber",
                value: 65);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -144,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 60 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -143,
                column: "SeatNumber",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -142,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 55 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -141,
                column: "SeatNumber",
                value: 55);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -140,
                column: "HallId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -139,
                column: "SeatNumber",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -138,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 45 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -137,
                column: "SeatNumber",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -136,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 40 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -135,
                column: "SeatNumber",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -134,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 35 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -133,
                column: "SeatNumber",
                value: 35);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -132,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 30 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -131,
                column: "SeatNumber",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -130,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 25 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -129,
                column: "SeatNumber",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -128,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 20 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -127,
                column: "SeatNumber",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -126,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 15 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -125,
                column: "SeatNumber",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -124,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 10 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -123,
                column: "SeatNumber",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -122,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 5 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -121,
                column: "SeatNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -120,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 60 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -119,
                column: "SeatNumber",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -118,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 56 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -117,
                column: "SeatNumber",
                value: 56);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -116,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 52 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -115,
                column: "SeatNumber",
                value: 52);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -114,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 48 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -113,
                column: "SeatNumber",
                value: 48);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -112,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 44 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -111,
                column: "SeatNumber",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -110,
                column: "HallId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -109,
                column: "SeatNumber",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -108,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 36 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -107,
                column: "SeatNumber",
                value: 36);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -106,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 32 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -105,
                column: "SeatNumber",
                value: 32);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -104,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 28 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -103,
                column: "SeatNumber",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -102,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 24 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -101,
                column: "SeatNumber",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -100,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 20 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -99,
                column: "SeatNumber",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -98,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 16 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -97,
                column: "SeatNumber",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -96,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 12 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -95,
                column: "SeatNumber",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -94,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 8 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -93,
                column: "SeatNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 4 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -91,
                column: "SeatNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -90,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 45 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -89,
                column: "SeatNumber",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -88,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 42 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -87,
                column: "SeatNumber",
                value: 42);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -86,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 39 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -85,
                column: "SeatNumber",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -84,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 36 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -83,
                column: "SeatNumber",
                value: 36);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -82,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 33 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -81,
                column: "SeatNumber",
                value: 33);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -80,
                column: "HallId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -79,
                column: "SeatNumber",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 27 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -77,
                column: "SeatNumber",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 24 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -75,
                column: "SeatNumber",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 21 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -73,
                column: "SeatNumber",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 18 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -71,
                column: "SeatNumber",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 15 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -69,
                column: "SeatNumber",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 12 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -67,
                column: "SeatNumber",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 9 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -65,
                column: "SeatNumber",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 6 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -63,
                column: "SeatNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 3 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -61,
                column: "SeatNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 30 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -59,
                column: "SeatNumber",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 28 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -57,
                column: "SeatNumber",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 26 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -55,
                column: "SeatNumber",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 24 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -53,
                column: "SeatNumber",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 22 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -51,
                column: "SeatNumber",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -50,
                column: "HallId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -49,
                column: "SeatNumber",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 18 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -47,
                column: "SeatNumber",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 16 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -45,
                column: "SeatNumber",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 14 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -43,
                column: "SeatNumber",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 12 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -41,
                column: "SeatNumber",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 10 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -39,
                column: "SeatNumber",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 8 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -37,
                column: "SeatNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 6 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -35,
                column: "SeatNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 4 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -33,
                column: "SeatNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 2 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -31,
                column: "SeatNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 15 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -29,
                column: "SeatNumber",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 14 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -27,
                column: "SeatNumber",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 13 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -25,
                column: "SeatNumber",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 12 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -23,
                column: "SeatNumber",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 11 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -21,
                column: "SeatNumber",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -20,
                column: "HallId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -19,
                column: "SeatNumber",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 9 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -17,
                column: "SeatNumber",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 8 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -15,
                column: "SeatNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 7 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -13,
                column: "SeatNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 6 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -11,
                column: "SeatNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 5 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -9,
                column: "SeatNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 4 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -7,
                column: "SeatNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 3 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -5,
                column: "SeatNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 2 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -3,
                column: "SeatNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "HallId", "SeatNumber" },
                values: new object[] { -2, 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash" },
                values: new object[] { "7f0754f0-8d5f-493e-9e9a-253d01abe567", null, null, "AQAAAAEAACcQAAAAECk6h9FmfExOIykQz6EkqJzc0B4ur10Oi1dRtHUuiAUn4Hj65rexiOH8IsDOVF7pCQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId1",
                table: "Reservations",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_OfferTypeId",
                table: "Invoices",
                column: "OfferTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ReservationId",
                table: "Invoices",
                column: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Pricing_OfferTypeId",
                table: "Invoices",
                column: "OfferTypeId",
                principalTable: "Pricing",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Users_UserId1",
                table: "Reservations",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
