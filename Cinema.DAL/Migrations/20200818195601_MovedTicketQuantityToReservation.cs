using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Dal.Migrations
{
    public partial class MovedTicketQuantityToReservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TicketQuantity",
                table: "Invoices");

            migrationBuilder.AddColumn<int>(
                name: "TicketQuantity",
                table: "Reservations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -299,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -297,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -295,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -293,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -291,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -289,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -287,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -285,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -283,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -281,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -279,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -277,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -275,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -273,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -271,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -269,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -267,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -265,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -263,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -261,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -259,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -257,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -255,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -253,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -251,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -249,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -247,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -245,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -243,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -241,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -239,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -237,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -235,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -233,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -231,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -229,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -227,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -225,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -223,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -221,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -219,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -217,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -215,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -213,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -211,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -209,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -207,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -205,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -203,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -201,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -199,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -197,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -195,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -193,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -191,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -189,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -187,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -185,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -183,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -181,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -179,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -177,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -175,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -173,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -171,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -169,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -167,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -165,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -163,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -161,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -159,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -157,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -155,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -153,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -151,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -149,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -147,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -145,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -143,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -141,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -139,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -137,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -135,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -133,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -131,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -129,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -127,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -125,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -123,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -121,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -119,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -117,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -115,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -113,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -111,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -109,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -107,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -105,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -103,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -101,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -99,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -97,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -95,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -93,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -91,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -89,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -87,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -85,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -83,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -81,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -79,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -77,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -75,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -73,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -71,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -69,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -67,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -65,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -63,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -61,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -59,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -57,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -55,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -53,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -51,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -49,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -47,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -45,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -43,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -41,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -39,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -37,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -35,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -33,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -31,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -29,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -27,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -25,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -23,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -21,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -19,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -17,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -15,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -13,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -11,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -9,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -7,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -5,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -3,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -1,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-1",
                column: "ConcurrencyStamp",
                value: "477428ee-0834-4dff-be31-c27e2b73d1f6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-2",
                column: "ConcurrencyStamp",
                value: "ccad7d38-03bd-4559-8294-cd7a785ab966");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-3",
                column: "ConcurrencyStamp",
                value: "b84cd58e-555b-446b-890c-1015ce6eae5c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4b84acf-dca9-4034-8c62-b0ba03809b49", "AQAAAAEAACcQAAAAENQG31X4XbGUaSoQRQcemFNDSnEi2b15wdanQKYtO+0ZW6s3sCqtwI80qvjoYV+Lwg==", "d9ac63e2-e197-4060-b818-1b3d31d9520b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e600",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ef99dfa-ba82-4ee3-b28d-5ae04cc7f4b1", "AQAAAAEAACcQAAAAECuR1AEkamVdItD+TNXGVloAeWODxoJc1K+5tSQp1m2Pa2KqU6LQkHyQnpJfBlcgWQ==", "9b9d76b4-89cb-4e57-b766-00e714fda6c7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e601",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "596457ad-c431-43fb-9390-7cb985214152", "AQAAAAEAACcQAAAAEEfjZhs3UnNfb19pASYUks92JDvaFgu8PnLWF29sHbkEj3wvnVYhxfuxrOnhVrqhlg==", "61b9d724-e273-4e93-9057-210274690686" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TicketQuantity",
                table: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "TicketQuantity",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -300,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -299,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -298,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -297,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -296,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -295,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -294,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -293,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -292,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -291,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -290,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -289,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -288,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -287,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -286,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -285,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -284,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -283,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -282,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -281,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -280,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -279,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -278,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -277,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -276,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -275,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -274,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -273,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -272,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -271,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -270,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -269,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -268,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -267,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -266,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -265,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -264,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -263,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -262,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -261,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -260,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -259,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -258,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -257,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -256,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -255,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -254,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -253,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -252,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -251,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -250,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -249,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -248,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -247,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -246,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -245,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -244,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -243,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -242,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -241,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -240,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -239,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -238,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -237,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -236,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -235,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -234,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -233,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -232,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -231,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -230,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -229,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -228,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -227,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -226,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -225,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -224,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -223,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -222,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -221,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -220,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -219,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -218,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -217,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -216,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -215,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -214,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -213,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -212,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -211,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -210,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -209,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -208,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -207,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -206,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -205,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -204,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -203,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -202,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -201,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -200,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -199,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -198,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -197,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -196,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -195,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -194,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -193,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -192,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -191,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -190,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -189,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -188,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -187,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -186,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -185,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -184,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -183,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -182,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -181,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -180,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -179,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -178,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -177,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -176,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -175,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -174,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -173,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -172,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -171,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -170,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -169,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -168,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -167,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -166,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -165,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -164,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -163,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -162,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -161,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -160,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -159,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -158,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -157,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -156,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -155,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -154,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -153,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -152,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -151,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -150,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -149,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -148,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -147,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -146,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -145,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -144,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -143,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -142,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -141,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -140,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -139,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -138,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -137,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -136,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -135,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -134,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -133,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -132,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -131,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -130,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -129,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -128,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -127,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -126,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -125,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -124,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -123,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -122,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -121,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -120,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -119,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -118,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -117,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -116,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -115,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -114,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -113,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -112,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -111,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -110,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -109,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -108,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -107,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -106,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -105,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -104,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -103,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -102,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -101,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -100,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -99,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -98,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -97,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -96,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -95,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -94,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -93,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -92,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -91,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -90,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -89,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -88,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -87,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -86,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -85,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -84,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -83,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -82,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -81,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -80,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -79,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -78,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -77,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -76,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -75,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -74,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -73,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -72,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -71,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -70,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -69,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -68,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -67,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -66,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -65,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -64,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -63,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -62,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -61,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -60,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -59,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -58,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -57,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -56,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -55,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -54,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -53,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -52,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -51,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -50,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -49,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -48,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -47,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -46,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -45,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -44,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -43,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -42,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -41,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -40,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -39,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -38,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -37,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -36,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -35,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -34,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -33,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -32,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -31,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -30,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -29,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -28,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -27,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -26,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -25,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -24,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -23,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -22,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -21,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -20,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -19,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -18,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -17,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -16,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -15,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -14,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -13,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -12,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -11,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -10,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -9,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -8,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -7,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -6,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -5,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -4,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -3,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -2,
                column: "TicketQuantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -1,
                column: "TicketQuantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-1",
                column: "ConcurrencyStamp",
                value: "5ceb518c-3e7d-4d73-85fe-9485ead61719");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-2",
                column: "ConcurrencyStamp",
                value: "e3fe020e-c1bd-4fef-aa30-bb75df199583");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-3",
                column: "ConcurrencyStamp",
                value: "64052e95-b694-4267-9a9d-893895ce762f");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5271b00-0fce-471c-9f42-907f4916041b", "AQAAAAEAACcQAAAAEOzbDsTAH9X6Ey1JCfYyqazAnfZRQInMBDh1bBV/HNuCF2nXrDu6/MllkEnsYFIkOg==", "cd68f654-cc8c-4f95-834d-29682fa1b0de" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e600",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f47bd1a4-45ea-4237-a4de-dbe7d88c3af7", "AQAAAAEAACcQAAAAEANKzdQB31RUc+t9iE4i7IeWVjU2wZGzHAi60L8NUXS1oiKHT+DFwjlrxD+1vuBPVQ==", "46ab6b25-7cb1-4418-913e-c64c6be5ac28" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e601",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85a5ef18-8299-4db7-a82c-1defe9c7ee05", "AQAAAAEAACcQAAAAEOwzW9gUn4MsVFZNnF/0Erk7aZjg4YDsDh+Xu8WHFEVyxRQ/FJOgC9fQUVKgFnntTQ==", "e837bb7b-1f9d-49eb-aaa3-eaad311adbf8" });
        }
    }
}
