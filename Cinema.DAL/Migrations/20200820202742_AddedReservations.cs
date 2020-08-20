using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Dal.Migrations
{
    public partial class AddedReservations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CreatedAt", "InvoiceId", "IsCancelled", "IsDeleted", "ReservationCode", "ScreeningId", "TicketQuantity", "UserId" },
                values: new object[,]
                {
                    { -1, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -205, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -205, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -204, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -204, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -203, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -203, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -202, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -202, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -201, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -201, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -200, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -200, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -206, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -206, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -199, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -199, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -197, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -197, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -196, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -196, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -195, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -195, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -194, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -194, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -193, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -193, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -192, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -192, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -198, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -198, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -207, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -207, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -208, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -208, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -209, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -209, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -224, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -224, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -223, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -223, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -222, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -222, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -221, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -221, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -220, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -220, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -219, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -219, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -218, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -218, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -217, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -217, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -216, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -216, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -215, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -215, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -214, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -214, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -213, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -213, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -212, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -212, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -211, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -211, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -210, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -210, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -191, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -191, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -190, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -190, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -189, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -189, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -188, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -188, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -168, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -168, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -167, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -167, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -166, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -166, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -165, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -165, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -164, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -164, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -163, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -163, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -162, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -162, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -161, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -161, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -160, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -160, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -159, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -159, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -158, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -158, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -157, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -157, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -156, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -156, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -155, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -155, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -154, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -154, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -169, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -169, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -225, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -225, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -170, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -170, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -172, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -172, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -187, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -187, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -186, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -186, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -185, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -185, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -184, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -184, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -183, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -183, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -182, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -182, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -181, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -181, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -180, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -180, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -179, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -179, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -178, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -178, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -177, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -177, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -176, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -176, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -175, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -175, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -174, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -174, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -173, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -173, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -171, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -171, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -226, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -226, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -227, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -227, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -228, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -228, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -281, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -281, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -280, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -280, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -279, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -279, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -278, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -278, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -277, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -277, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -276, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -276, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -275, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -275, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -274, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -274, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -273, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -273, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -272, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -272, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -271, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -271, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -270, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -270, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -269, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -269, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -268, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -268, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -267, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -267, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -282, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -282, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -266, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -266, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -283, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -283, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -285, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -285, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -300, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -300, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -299, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -299, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -298, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -298, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -297, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -297, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -296, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -296, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -295, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -295, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -294, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -294, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -293, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -293, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -292, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -292, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -291, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -291, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -290, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -290, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -289, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -289, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -288, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -288, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -287, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -287, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -286, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -286, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -284, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -284, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -152, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -152, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -265, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -265, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -263, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -263, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -243, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -243, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -242, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -242, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -241, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -241, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -240, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -240, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -239, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -239, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -238, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -238, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -237, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -237, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -236, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -236, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -235, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -235, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -234, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -234, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -233, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -233, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -232, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -232, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -231, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -231, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -230, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -230, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -229, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -229, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -244, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -244, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -264, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -264, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -245, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -245, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -247, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -247, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -262, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -262, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -261, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -261, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -260, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -260, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -259, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -259, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -258, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -258, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -257, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -257, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -256, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -256, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -255, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -255, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -254, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -254, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -253, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -253, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -252, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -252, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -251, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -251, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -250, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -250, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -249, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -249, false, false, "qr_code_placeholder", -5, 1, 2 },
                    { -248, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -248, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -246, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -246, false, false, "qr_code_placeholder", -5, 0, 3 },
                    { -151, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -151, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -153, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -153, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -149, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -149, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -54, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -54, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -53, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -53, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -52, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -52, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -51, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -51, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -50, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -50, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -49, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -49, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -48, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -48, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -47, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -47, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -46, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -46, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -45, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -45, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -44, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -44, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -43, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -43, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -42, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -42, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -41, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -41, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -40, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -40, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -55, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -55, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -39, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -39, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -56, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -56, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -58, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -58, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -150, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -150, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -72, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -72, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -71, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -71, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -70, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -70, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -69, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -69, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -68, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -68, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -67, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -67, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -66, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -66, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -65, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -65, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -64, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -64, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -63, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -63, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -62, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -62, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -61, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -61, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -60, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -60, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -59, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -59, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -57, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -57, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -74, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -74, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -38, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -38, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -36, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -36, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -16, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -16, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -15, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -15, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -14, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -14, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -13, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -13, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -12, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -12, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -11, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -11, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -10, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -10, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -9, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -9, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -8, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -8, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -7, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -7, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -6, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -6, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -5, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -5, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -4, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -4, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -3, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -3, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -2, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -17, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -17, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -37, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -37, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -18, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -18, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -20, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -20, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -35, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -35, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -34, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -34, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -33, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -33, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -32, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -32, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -31, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -31, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -30, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -30, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -29, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -29, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -28, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -28, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -27, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -27, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -26, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -26, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -25, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -25, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -24, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -24, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -23, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -23, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -22, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -22, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -21, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -21, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -19, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -19, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -75, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -75, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -73, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -73, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -77, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -77, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -129, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -129, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -128, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -128, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -127, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -127, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -126, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -126, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -125, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -125, false, false, "qr_code_placeholder", -1, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CreatedAt", "InvoiceId", "IsCancelled", "IsDeleted", "ReservationCode", "ScreeningId", "TicketQuantity", "UserId" },
                values: new object[,]
                {
                    { -124, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -124, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -130, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -130, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -123, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -123, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -121, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -121, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -120, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -120, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -119, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -119, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -118, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -118, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -117, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -117, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -76, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -76, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -122, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -122, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -131, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -131, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -132, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -132, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -133, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -133, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -148, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -148, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -147, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -147, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -146, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -146, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -145, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -145, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -144, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -144, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -143, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -143, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -142, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -142, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -141, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -141, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -140, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -140, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -139, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -139, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -138, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -138, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -137, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -137, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -136, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -136, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -135, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -135, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -134, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -134, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -115, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -115, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -114, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -114, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -116, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -116, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -112, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -112, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -113, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -113, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -91, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -91, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -90, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -90, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -89, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -89, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -88, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -88, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -87, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -87, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -86, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -86, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -85, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -85, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -84, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -84, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -83, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -83, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -82, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -82, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -81, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -81, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -80, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -80, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -79, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -79, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -78, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -78, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -93, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -93, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -94, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -94, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -92, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -92, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -96, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -96, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -111, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -111, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -110, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -110, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -109, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -109, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -108, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -108, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -95, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -95, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -106, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -106, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -105, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -105, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -107, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -107, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -103, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -103, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -102, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -102, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -101, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -101, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -100, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -100, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -99, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -99, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -98, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -98, false, false, "qr_code_placeholder", -1, 0, 3 },
                    { -97, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -97, false, false, "qr_code_placeholder", -1, 1, 2 },
                    { -104, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), -104, false, false, "qr_code_placeholder", -1, 0, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -3,
                column: "ConcurrencyStamp",
                value: "745ca965-77e9-421e-acbb-d9a39cd09ec1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "d904cbcd-a48e-4395-9544-324a14233ffa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "c3adb3ae-da58-4691-826c-c92f182564fd");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b9a5cad3-19b8-4b22-ab62-c2de0c760080", "AQAAAAEAACcQAAAAEGT/4YJiyjP2AMHGHHm+Uy00aDz5w/RLDLObhMUw4LDMa9QrYSk3w42QvFIpVtXv7g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9f29940c-4bc2-4ff5-b92f-27b2fccc21d2", "AQAAAAEAACcQAAAAEIA21TOXv0Wp7jTuMjSMRRfEa4zWdxKAoevlbyXUDqA9IS6Pl1d2TiS+Nyc7Uriexw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "30596ed1-6b40-4c9d-a3d8-39a5313a4fb7", "AQAAAAEAACcQAAAAENSsitItf5eSW0FJz9JonDWfl5F1qresO0NYfoD9Ne+MsMw/kafhmuzhsP3eLAVgNw==" });
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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7c3311c6-7974-429c-9d64-41c2a8ae0599", "AQAAAAEAACcQAAAAEH76sRsp4PSREShtlwdSFW52+ap4y/6PLS4iU3ZVFvzeqDermiJNpOBD1PL4eT2Zgg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "34a53178-3caa-44ac-8c52-209073017f06", "AQAAAAEAACcQAAAAEOLZSc4oD3vWyJCko9QTTg/EuXPFk28BWHgDMseTfm7JaFsPrt/jGA1YNDm7hBb/wA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7c3c51e9-cc37-43d9-8e37-20e5bf1274fe", "AQAAAAEAACcQAAAAEAi7BhDK6+xom6GbHSKw7HyCghJxWKSpNAQ3v1s04608pyR4hTKYDm29euC7FvE8NQ==" });
        }
    }
}
