using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Dal.Migrations
{
    public partial class ChangedColumnNameInvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Pricing_OfferTypeId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_OfferTypeId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "OfferTypeId",
                table: "Invoices");

            migrationBuilder.AddColumn<int>(
                name: "PricingId",
                table: "Invoices",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -300,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -299,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -298,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -297,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -296,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -295,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -294,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -293,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -292,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -291,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -290,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -289,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -288,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -287,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -286,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -285,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -284,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -283,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -282,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -281,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -280,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -279,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -278,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -277,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -276,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -275,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -274,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -273,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -272,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -271,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -270,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -269,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -268,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -267,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -266,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -265,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -264,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -263,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -262,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -261,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -260,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -259,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -258,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -257,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -256,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -255,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -254,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -253,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -252,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -251,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -250,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -249,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -248,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -247,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -246,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -245,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -244,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -243,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -242,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -241,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -240,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -239,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -238,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -237,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -236,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -235,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -234,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -233,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -232,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -231,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -230,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -229,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -228,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -227,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -226,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -225,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -224,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -223,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -222,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -221,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -220,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -219,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -218,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -217,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -216,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -215,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -214,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -213,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -212,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -211,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -210,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -209,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -208,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -207,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -206,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -205,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -204,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -203,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -202,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -201,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -200,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -199,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -198,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -197,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -196,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -195,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -194,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -193,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -192,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -191,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -190,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -189,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -188,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -187,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -186,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -185,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -184,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -183,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -182,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -181,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -180,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -179,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -178,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -177,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -176,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -175,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -174,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -173,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -172,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -171,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -170,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -169,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -168,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -167,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -166,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -165,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -164,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -163,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -162,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -161,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -160,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -159,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -158,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -157,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -156,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -155,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -154,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -153,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -152,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -151,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -150,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -149,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -148,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -147,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -146,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -145,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -144,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -143,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -142,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -141,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -140,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -139,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -138,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -137,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -136,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -135,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -134,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -133,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -132,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -131,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -130,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -129,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -128,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -127,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -126,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -125,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -124,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -123,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -122,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -121,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -120,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -119,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -118,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -117,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -116,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -115,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -114,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -113,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -112,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -111,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -110,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -109,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -108,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -107,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -106,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -105,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -104,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -103,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -102,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -101,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -100,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -99,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -98,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -97,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -96,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -95,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -94,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -93,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -92,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -91,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -90,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -89,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -88,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -87,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -86,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -85,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -84,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -83,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -82,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -81,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -80,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -79,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -78,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -77,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -76,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -75,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -74,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -73,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -72,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -71,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -70,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -69,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -68,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -67,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -66,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -65,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -64,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -63,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -62,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -61,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -60,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -59,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -58,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -57,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -56,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -55,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -54,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -53,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -52,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -51,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -50,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -49,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -48,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -47,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -46,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -45,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -44,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -43,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -42,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -41,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -40,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -39,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -38,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -37,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -36,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -35,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -34,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -33,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -32,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -31,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -30,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -29,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -28,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -27,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -26,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -25,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -24,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -23,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -22,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -21,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -20,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -19,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -18,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -17,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -16,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -15,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -14,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -13,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -12,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -11,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -10,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -9,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -8,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -7,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -6,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -5,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -4,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -3,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -2,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -1,
                column: "PricingId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-1",
                column: "ConcurrencyStamp",
                value: "5a4a10a9-410f-41c8-b7a3-6a35a8de7d96");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-2",
                column: "ConcurrencyStamp",
                value: "2e8a0121-65d4-46d1-b15c-bf1c818e59d6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-3",
                column: "ConcurrencyStamp",
                value: "e93adde7-b5de-42bc-b496-f38df5e5ec3d");

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateAndTime",
                value: new DateTime(2020, 9, 14, 18, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateAndTime",
                value: new DateTime(2020, 9, 4, 18, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateAndTime",
                value: new DateTime(2020, 8, 30, 22, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateAndTime",
                value: new DateTime(2020, 8, 30, 20, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "644aab0a-a364-4cb9-b605-64b306fdcf10", "AQAAAAEAACcQAAAAEJP/5QTbIDiuGOdk3t6t38nhuztKS0RwUI76KBBH1k6xlWl+ud9/kABwptOxIdQxlg==", "e73b48be-057a-4bbb-ad6e-a82c3bca4831" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e600",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56fd4b5a-a392-45cd-bfe6-0281c9c5f77d", "AQAAAAEAACcQAAAAEMxAqCLzpdVg3OuT1HI4G4paI3SVDbWPjn3s0nYvm6TtxQ+/k476QD/xrK/npo1nfQ==", "b8c1cdb5-6fb9-486e-b199-804e328ca0e7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e601",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1046934-34b6-44e8-9fe0-23672107abaf", "AQAAAAEAACcQAAAAEPK0VYzXnDwypDTtr1ZTsLI21v8XcVeIuRbxz7eEpv+sWUq2aD6gBEpBYoAMm7ecfw==", "8ee5f804-d287-4644-9842-8183c49bf236" });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_PricingId",
                table: "Invoices",
                column: "PricingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Pricing_PricingId",
                table: "Invoices",
                column: "PricingId",
                principalTable: "Pricing",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Pricing_PricingId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_PricingId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "PricingId",
                table: "Invoices");

            migrationBuilder.AddColumn<int>(
                name: "OfferTypeId",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -300,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -299,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -298,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -297,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -296,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -295,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -294,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -293,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -292,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -291,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -290,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -289,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -288,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -287,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -286,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -285,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -284,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -283,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -282,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -281,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -280,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -279,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -278,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -277,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -276,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -275,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -274,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -273,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -272,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -271,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -270,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -269,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -268,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -267,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -266,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -265,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -264,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -263,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -262,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -261,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -260,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -259,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -258,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -257,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -256,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -255,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -254,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -253,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -252,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -251,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -250,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -249,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -248,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -247,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -246,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -245,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -244,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -243,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -242,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -241,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -240,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -239,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -238,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -237,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -236,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -235,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -234,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -233,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -232,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -231,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -230,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -229,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -228,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -227,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -226,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -225,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -224,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -223,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -222,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -221,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -220,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -219,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -218,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -217,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -216,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -215,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -214,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -213,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -212,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -211,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -210,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -209,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -208,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -207,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -206,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -205,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -204,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -203,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -202,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -201,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -200,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -199,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -198,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -197,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -196,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -195,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -194,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -193,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -192,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -191,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -190,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -189,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -188,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -187,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -186,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -185,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -184,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -183,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -182,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -181,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -180,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -179,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -178,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -177,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -176,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -175,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -174,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -173,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -172,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -171,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -170,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -169,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -168,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -167,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -166,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -165,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -164,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -163,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -162,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -161,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -160,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -159,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -158,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -157,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -156,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -155,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -154,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -153,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -152,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -151,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -150,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -149,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -148,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -147,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -146,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -145,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -144,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -143,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -142,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -141,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -140,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -139,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -138,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -137,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -136,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -135,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -134,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -133,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -132,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -131,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -130,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -129,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -128,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -127,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -126,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -125,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -124,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -123,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -122,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -121,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -120,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -119,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -118,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -117,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -116,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -115,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -114,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -113,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -112,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -111,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -110,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -109,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -108,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -107,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -106,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -105,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -104,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -103,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -102,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -101,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -100,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -99,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -98,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -97,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -96,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -95,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -94,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -93,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -92,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -91,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -90,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -89,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -88,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -87,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -86,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -85,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -84,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -83,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -82,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -81,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -80,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -79,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -78,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -77,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -76,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -75,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -74,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -73,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -72,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -71,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -70,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -69,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -68,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -67,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -66,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -65,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -64,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -63,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -62,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -61,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -60,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -59,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -58,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -57,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -56,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -55,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -54,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -53,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -52,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -51,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -50,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -49,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -48,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -47,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -46,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -45,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -44,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -43,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -42,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -41,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -40,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -39,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -38,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -37,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -36,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -35,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -34,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -33,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -32,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -31,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -30,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -29,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -28,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -27,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -26,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -25,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -24,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -23,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -22,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -21,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -20,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -19,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -18,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -17,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -16,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -15,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -14,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -13,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -12,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -11,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -10,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -9,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -8,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -7,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -6,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -5,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -4,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -3,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -2,
                column: "OfferTypeId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -1,
                column: "OfferTypeId",
                value: -1);

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

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_OfferTypeId",
                table: "Invoices",
                column: "OfferTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Pricing_OfferTypeId",
                table: "Invoices",
                column: "OfferTypeId",
                principalTable: "Pricing",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
