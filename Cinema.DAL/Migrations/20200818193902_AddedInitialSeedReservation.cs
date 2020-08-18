using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Dal.Migrations
{
    public partial class AddedInitialSeedReservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CreatedAt", "InvoiceId", "IsCancelled", "IsDeleted", "ReservationCode", "ScreeningId", "UserId" },
                values: new object[,]
                {
                    { -1, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -205, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -205, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -204, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -204, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -203, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -203, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -202, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -202, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -201, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -201, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -200, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -200, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -206, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -206, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -199, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -199, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -197, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -197, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -196, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -196, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -195, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -195, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -194, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -194, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -193, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -193, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -192, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -192, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -198, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -198, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -207, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -207, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -208, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -208, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -209, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -209, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -224, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -224, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -223, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -223, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -222, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -222, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -221, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -221, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -220, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -220, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -219, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -219, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -218, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -218, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -217, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -217, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -216, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -216, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -215, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -215, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -214, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -214, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -213, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -213, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -212, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -212, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -211, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -211, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -210, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -210, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -191, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -191, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -190, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -190, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -189, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -189, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -188, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -188, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -168, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -168, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -167, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -167, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -166, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -166, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -165, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -165, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -164, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -164, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -163, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -163, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -162, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -162, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -161, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -161, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -160, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -160, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -159, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -159, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -158, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -158, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -157, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -157, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -156, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -156, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -155, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -155, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -154, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -154, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -169, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -169, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -225, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -225, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -170, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -170, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -172, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -172, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -187, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -187, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -186, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -186, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -185, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -185, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -184, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -184, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -183, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -183, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -182, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -182, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -181, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -181, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -180, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -180, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -179, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -179, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -178, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -178, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -177, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -177, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -176, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -176, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -175, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -175, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -174, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -174, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -173, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -173, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -171, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -171, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -226, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -226, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -227, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -227, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -228, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -228, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -281, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -281, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -280, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -280, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -279, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -279, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -278, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -278, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -277, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -277, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -276, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -276, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -275, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -275, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -274, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -274, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -273, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -273, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -272, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -272, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -271, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -271, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -270, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -270, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -269, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -269, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -268, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -268, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -267, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -267, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -282, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -282, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -266, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -266, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -283, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -283, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -285, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -285, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -300, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -300, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -299, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -299, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -298, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -298, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -297, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -297, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -296, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -296, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -295, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -295, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -294, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -294, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -293, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -293, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -292, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -292, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -291, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -291, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -290, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -290, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -289, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -289, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -288, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -288, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -287, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -287, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -286, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -286, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -284, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -284, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -152, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -152, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -265, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -265, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -263, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -263, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -243, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -243, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -242, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -242, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -241, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -241, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -240, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -240, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -239, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -239, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -238, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -238, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -237, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -237, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -236, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -236, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -235, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -235, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -234, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -234, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -233, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -233, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -232, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -232, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -231, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -231, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -230, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -230, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -229, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -229, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -244, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -244, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -264, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -264, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -245, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -245, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -247, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -247, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -262, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -262, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -261, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -261, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -260, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -260, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -259, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -259, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -258, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -258, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -257, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -257, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -256, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -256, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -255, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -255, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -254, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -254, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -253, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -253, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -252, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -252, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -251, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -251, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -250, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -250, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -249, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -249, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -248, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -248, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -246, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -246, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -151, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -151, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -153, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -153, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -149, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -149, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -54, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -54, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -53, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -53, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -52, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -52, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -51, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -51, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -50, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -50, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -49, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -49, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -48, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -48, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -47, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -47, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -46, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -46, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -45, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -45, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -44, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -44, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -43, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -43, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -42, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -42, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -41, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -41, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -40, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -40, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -55, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -55, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -39, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -39, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -56, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -56, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -58, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -58, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -150, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -150, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -72, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -72, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -71, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -71, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -70, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -70, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -69, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -69, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -68, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -68, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -67, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -67, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -66, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -66, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -65, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -65, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -64, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -64, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -63, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -63, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -62, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -62, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -61, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -61, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -60, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -60, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -59, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -59, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -57, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -57, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -74, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -74, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -38, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -38, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -36, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -36, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -16, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -16, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -15, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -15, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -14, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -14, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -13, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -13, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -12, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -12, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -11, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -11, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -10, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -10, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -9, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -9, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -8, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -8, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -7, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -7, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -6, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -6, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -5, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -5, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -4, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -4, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -3, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -3, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -2, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -17, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -17, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -37, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -37, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -18, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -18, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -20, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -20, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -35, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -35, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -34, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -34, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -33, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -33, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -32, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -32, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -31, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -31, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -30, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -30, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -29, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -29, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -28, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -28, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -27, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -27, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -26, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -26, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -25, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -25, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -24, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -24, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -23, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -23, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -22, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -22, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -21, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -21, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -19, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -19, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -75, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -75, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -73, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -73, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -77, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -77, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -129, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -129, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -128, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -128, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -127, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -127, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -126, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -126, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -125, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -125, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -124, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -124, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -130, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -130, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -123, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -123, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -121, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -121, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -120, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -120, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -119, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -119, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -118, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -118, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -117, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -117, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -76, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -76, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -122, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -122, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -131, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -131, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -132, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -132, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -133, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -133, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -148, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -148, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -147, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -147, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -146, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -146, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -145, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -145, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -144, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -144, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -143, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -143, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -142, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -142, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -141, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -141, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -140, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -140, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -139, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -139, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -138, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -138, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -137, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -137, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -136, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -136, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -135, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -135, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -134, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -134, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -115, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -115, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CreatedAt", "InvoiceId", "IsCancelled", "IsDeleted", "ReservationCode", "ScreeningId", "UserId" },
                values: new object[,]
                {
                    { -114, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -114, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -116, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -116, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -112, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -112, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -113, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -113, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -91, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -91, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -90, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -90, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -89, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -89, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -88, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -88, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -87, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -87, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -86, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -86, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -85, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -85, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -84, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -84, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -83, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -83, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -82, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -82, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -81, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -81, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -80, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -80, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -79, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -79, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -78, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -78, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -93, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -93, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -94, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -94, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -92, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -92, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -96, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -96, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -111, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -111, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -110, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -110, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -109, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -109, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -108, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -108, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -95, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -95, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -106, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -106, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -105, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -105, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -107, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -107, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -103, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -103, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -102, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -102, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -101, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -101, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -100, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -100, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -99, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -99, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -98, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -98, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" },
                    { -97, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -97, false, false, "qr_code_placeholder", -1, "a18be9c0-aa65-4af8-bd17-00bd9344e600" },
                    { -104, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -104, false, false, "qr_code_placeholder", -3, "a18be9c0-aa65-4af8-bd17-00bd9344e601" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-1",
                column: "ConcurrencyStamp",
                value: "611bd7b1-bd63-4b06-8583-51216bf1f77a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-2",
                column: "ConcurrencyStamp",
                value: "6d4850b8-874e-4174-960e-1b239aa982b9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-3",
                column: "ConcurrencyStamp",
                value: "07150f21-f05b-404c-87bf-46b4043ffbc3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2c8447d-0c47-4d62-b312-cdf830f8d608", "AQAAAAEAACcQAAAAEKZSK1s/AbqPGezBF299j1m+WIk9YrYbp+YQc3ix38aiapNA1PD3uy/Z1+7x2AwvHw==", "adb47d5c-8758-4d69-ad36-2f785ff39e75" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e600",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a03b231e-2cd0-4eaa-ad14-453b077a1fc5", "AQAAAAEAACcQAAAAEGOUqMcFq8Lo1rbjMxI4qJy4rBQf+x/7jCggVS+bRANqnxxOZRdztKYuPEdAWABo2Q==", "2ac2a44a-97c8-4a6b-9c4c-ad5d9f2fb33f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e601",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88bb8aa4-5700-40d5-8da5-1c95326d7d63", "AQAAAAEAACcQAAAAEIHjLyt1Oz63kvlSA/80YtcxnXWXKEN1Teo270y1WU65ZnpPHXQj9c9a3mR38JXsLw==", "35233997-34a8-4f5d-84d2-f71a74c31724" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -300);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -299);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -298);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -297);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -296);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -295);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -294);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -293);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -292);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -291);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -290);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -289);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -288);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -287);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -286);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -285);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -284);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -283);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -282);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -281);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -280);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -279);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -278);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -277);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -276);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -275);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -274);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -273);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -272);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -271);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -270);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -269);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -268);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -267);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -266);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -265);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -264);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -263);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -262);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -261);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -260);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -259);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -258);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -257);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -256);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -255);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -254);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -253);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -252);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -251);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -250);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -249);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -248);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -247);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -246);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -245);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -244);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -243);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -242);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -241);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -240);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -239);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -238);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -237);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -236);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -235);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -234);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -233);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -232);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -231);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -230);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -229);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -228);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -227);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -226);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -225);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -224);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -223);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -222);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -221);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -220);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -219);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -218);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -217);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -216);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -215);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -214);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -213);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -212);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -211);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -210);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -209);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -208);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -207);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -206);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -205);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -204);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -203);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -202);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -201);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -200);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -199);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -198);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -197);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -196);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -195);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -194);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -193);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -192);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -191);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -190);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -189);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -188);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -187);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -186);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -185);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -184);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -183);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -182);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -181);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -180);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -179);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -178);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -177);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -176);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -175);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -174);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -173);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -172);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -171);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -170);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -169);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -168);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -167);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -166);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -165);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -164);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -163);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -162);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -161);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -160);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -159);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -158);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -157);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -156);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -155);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -154);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -153);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -152);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -151);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -150);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -149);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -148);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -147);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -146);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -145);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -144);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -143);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -142);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -141);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -140);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -139);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -138);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -137);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -136);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -135);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -134);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -133);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -132);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -131);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -130);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -129);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -128);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -127);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -126);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -125);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -124);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -123);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -122);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -121);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -120);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -119);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -118);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -117);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -116);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -115);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -114);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -113);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -112);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -111);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -110);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -109);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -108);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -107);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -106);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -105);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -104);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -103);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -102);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -101);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -100);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -99);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -98);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -97);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -96);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -95);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -94);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -93);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -92);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -91);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -90);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -89);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -88);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -87);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -86);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -85);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -84);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -83);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -82);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -81);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -80);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -79);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -78);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -77);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -76);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -75);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -74);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -73);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -72);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -71);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -70);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -69);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -68);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -67);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -66);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -65);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -64);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -63);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -62);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -61);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -60);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -59);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -58);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -57);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -56);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -55);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -54);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -53);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -52);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -51);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -50);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -49);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -48);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -47);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -46);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -45);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -44);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -43);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -42);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -41);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -40);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -39);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -38);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -37);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -36);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -35);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -33);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -31);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-1",
                column: "ConcurrencyStamp",
                value: "8222a8fa-b86c-416e-a2e2-1ff4dd50f930");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-2",
                column: "ConcurrencyStamp",
                value: "836f6575-8828-4283-bbbd-5837eb9f40bc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-3",
                column: "ConcurrencyStamp",
                value: "5653e0c3-8390-43bb-a589-704cf8556f46");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53b8246a-9fd8-4316-93a0-3bc5acf47ce4", "AQAAAAEAACcQAAAAEPAFhfMWVwn4TuT9HOewBCCtzV9UZJbSZR/GBVFv6RFfJEZicMC0XO4CzL6SyFjnog==", "79da685d-314e-4c07-be07-8ef3ec95c334" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e600",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0eb114c7-2713-485c-8c49-42d6171caf0e", "AQAAAAEAACcQAAAAEOUMnvEL8mAJm/LN/HXZgVJgNgb3uIKEFIv614FBKEAZ1Ru4cC41prxu1R03vUCJ1w==", "dc9ddc21-6065-47d8-b868-5e305324afbd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e601",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3746000b-b1f6-47a2-89e7-1e2f5c44ccf0", "AQAAAAEAACcQAAAAECbF8RZo7EwtVgvbBd6yLyqKSxwvyVgRAEwRNVR1O4rN8n/HoPJl9tLwCmwTJVVa6A==", "0ec9e57b-77d2-4123-ba3d-b5d3dae963dd" });
        }
    }
}
