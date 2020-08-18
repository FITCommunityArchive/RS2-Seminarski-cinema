using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Dal.Migrations
{
    public partial class AddedInvoicesAndSeatReservations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "OfferTypeId", "Price", "ReservationId", "TaxAmount", "TicketQuantity" },
                values: new object[,]
                {
                    { -1, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -1, 1.7m, 2 },
                    { -205, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -205, 1.7m, 2 },
                    { -204, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -204, 1.36m, 1 },
                    { -203, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -203, 1.7m, 2 },
                    { -202, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -202, 1.36m, 1 },
                    { -201, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -201, 1.7m, 2 },
                    { -200, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -200, 1.36m, 1 },
                    { -206, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -206, 1.36m, 1 },
                    { -199, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -199, 1.7m, 2 },
                    { -197, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -197, 1.7m, 2 },
                    { -196, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -196, 1.36m, 1 },
                    { -195, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -195, 1.7m, 2 },
                    { -194, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -194, 1.36m, 1 },
                    { -193, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -193, 1.7m, 2 },
                    { -192, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -192, 1.36m, 1 },
                    { -198, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -198, 1.36m, 1 },
                    { -207, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -207, 1.7m, 2 },
                    { -208, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -208, 1.36m, 1 },
                    { -209, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -209, 1.7m, 2 },
                    { -224, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -224, 1.36m, 1 },
                    { -223, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -223, 1.7m, 2 },
                    { -222, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -222, 1.36m, 1 },
                    { -221, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -221, 1.7m, 2 },
                    { -220, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -220, 1.36m, 1 },
                    { -219, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -219, 1.7m, 2 },
                    { -218, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -218, 1.36m, 1 },
                    { -217, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -217, 1.7m, 2 },
                    { -216, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -216, 1.36m, 1 },
                    { -215, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -215, 1.7m, 2 },
                    { -214, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -214, 1.36m, 1 },
                    { -213, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -213, 1.7m, 2 },
                    { -212, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -212, 1.36m, 1 },
                    { -211, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -211, 1.7m, 2 },
                    { -210, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -210, 1.36m, 1 },
                    { -191, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -191, 1.7m, 2 },
                    { -190, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -190, 1.36m, 1 },
                    { -189, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -189, 1.7m, 2 },
                    { -188, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -188, 1.36m, 1 },
                    { -168, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -168, 1.36m, 1 },
                    { -167, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -167, 1.7m, 2 },
                    { -166, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -166, 1.36m, 1 },
                    { -165, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -165, 1.7m, 2 },
                    { -164, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -164, 1.36m, 1 },
                    { -163, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -163, 1.7m, 2 },
                    { -162, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -162, 1.36m, 1 },
                    { -161, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -161, 1.7m, 2 },
                    { -160, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -160, 1.36m, 1 },
                    { -159, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -159, 1.7m, 2 },
                    { -158, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -158, 1.36m, 1 },
                    { -157, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -157, 1.7m, 2 },
                    { -156, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -156, 1.36m, 1 },
                    { -155, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -155, 1.7m, 2 },
                    { -154, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -154, 1.36m, 1 },
                    { -169, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -169, 1.7m, 2 },
                    { -225, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -225, 1.7m, 2 },
                    { -170, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -170, 1.36m, 1 },
                    { -172, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -172, 1.36m, 1 },
                    { -187, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -187, 1.7m, 2 },
                    { -186, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -186, 1.36m, 1 },
                    { -185, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -185, 1.7m, 2 },
                    { -184, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -184, 1.36m, 1 },
                    { -183, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -183, 1.7m, 2 },
                    { -182, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -182, 1.36m, 1 },
                    { -181, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -181, 1.7m, 2 },
                    { -180, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -180, 1.36m, 1 },
                    { -179, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -179, 1.7m, 2 },
                    { -178, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -178, 1.36m, 1 },
                    { -177, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -177, 1.7m, 2 },
                    { -176, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -176, 1.36m, 1 },
                    { -175, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -175, 1.7m, 2 },
                    { -174, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -174, 1.36m, 1 },
                    { -173, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -173, 1.7m, 2 },
                    { -171, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -171, 1.7m, 2 },
                    { -226, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -226, 1.36m, 1 },
                    { -227, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -227, 1.7m, 2 },
                    { -228, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -228, 1.36m, 1 },
                    { -281, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -281, 1.7m, 2 },
                    { -280, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -280, 1.36m, 1 },
                    { -279, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -279, 1.7m, 2 },
                    { -278, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -278, 1.36m, 1 },
                    { -277, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -277, 1.7m, 2 },
                    { -276, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -276, 1.36m, 1 },
                    { -275, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -275, 1.7m, 2 },
                    { -274, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -274, 1.36m, 1 },
                    { -273, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -273, 1.7m, 2 },
                    { -272, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -272, 1.36m, 1 },
                    { -271, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -271, 1.7m, 2 },
                    { -270, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -270, 1.36m, 1 },
                    { -269, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -269, 1.7m, 2 },
                    { -268, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -268, 1.36m, 1 },
                    { -267, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -267, 1.7m, 2 },
                    { -282, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -282, 1.36m, 1 },
                    { -266, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -266, 1.36m, 1 },
                    { -283, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -283, 1.7m, 2 },
                    { -285, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -285, 1.7m, 2 },
                    { -300, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -300, 1.36m, 1 },
                    { -299, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -299, 1.7m, 2 },
                    { -298, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -298, 1.36m, 1 },
                    { -297, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -297, 1.7m, 2 },
                    { -296, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -296, 1.36m, 1 },
                    { -295, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -295, 1.7m, 2 },
                    { -294, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -294, 1.36m, 1 },
                    { -293, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -293, 1.7m, 2 },
                    { -292, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -292, 1.36m, 1 },
                    { -291, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -291, 1.7m, 2 },
                    { -290, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -290, 1.36m, 1 },
                    { -289, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -289, 1.7m, 2 },
                    { -288, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -288, 1.36m, 1 },
                    { -287, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -287, 1.7m, 2 },
                    { -286, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -286, 1.36m, 1 },
                    { -284, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -284, 1.36m, 1 },
                    { -153, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -153, 1.7m, 2 },
                    { -265, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -265, 1.7m, 2 },
                    { -263, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -263, 1.7m, 2 },
                    { -243, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -243, 1.7m, 2 },
                    { -242, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -242, 1.36m, 1 },
                    { -241, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -241, 1.7m, 2 },
                    { -240, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -240, 1.36m, 1 },
                    { -239, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -239, 1.7m, 2 },
                    { -238, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -238, 1.36m, 1 },
                    { -237, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -237, 1.7m, 2 },
                    { -236, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -236, 1.36m, 1 },
                    { -235, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -235, 1.7m, 2 },
                    { -234, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -234, 1.36m, 1 },
                    { -233, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -233, 1.7m, 2 },
                    { -232, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -232, 1.36m, 1 },
                    { -231, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -231, 1.7m, 2 },
                    { -230, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -230, 1.36m, 1 },
                    { -229, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -229, 1.7m, 2 },
                    { -244, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -244, 1.36m, 1 },
                    { -264, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -264, 1.36m, 1 },
                    { -245, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -245, 1.7m, 2 },
                    { -247, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -247, 1.7m, 2 },
                    { -262, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -262, 1.36m, 1 },
                    { -261, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -261, 1.7m, 2 },
                    { -260, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -260, 1.36m, 1 },
                    { -259, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -259, 1.7m, 2 },
                    { -258, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -258, 1.36m, 1 },
                    { -257, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -257, 1.7m, 2 },
                    { -256, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -256, 1.36m, 1 },
                    { -255, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -255, 1.7m, 2 },
                    { -254, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -254, 1.36m, 1 },
                    { -253, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -253, 1.7m, 2 },
                    { -252, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -252, 1.36m, 1 },
                    { -251, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -251, 1.7m, 2 },
                    { -250, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -250, 1.36m, 1 },
                    { -249, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -249, 1.7m, 2 },
                    { -248, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -248, 1.36m, 1 },
                    { -246, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -246, 1.36m, 1 },
                    { -152, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -152, 1.36m, 1 },
                    { -151, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -151, 1.7m, 2 },
                    { -150, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -150, 1.36m, 1 },
                    { -53, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -53, 1.7m, 2 },
                    { -52, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -52, 1.36m, 1 },
                    { -51, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -51, 1.7m, 2 },
                    { -50, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -50, 1.36m, 1 },
                    { -49, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -49, 1.7m, 2 },
                    { -48, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -48, 1.36m, 1 },
                    { -54, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -54, 1.36m, 1 },
                    { -47, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -47, 1.7m, 2 },
                    { -45, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -45, 1.7m, 2 },
                    { -44, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -44, 1.36m, 1 },
                    { -43, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -43, 1.7m, 2 },
                    { -42, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -42, 1.36m, 1 },
                    { -41, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -41, 1.7m, 2 },
                    { -40, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -40, 1.36m, 1 },
                    { -46, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -46, 1.36m, 1 },
                    { -55, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -55, 1.7m, 2 },
                    { -56, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -56, 1.36m, 1 },
                    { -57, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -57, 1.7m, 2 },
                    { -72, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -72, 1.36m, 1 },
                    { -71, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -71, 1.7m, 2 },
                    { -70, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -70, 1.36m, 1 },
                    { -69, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -69, 1.7m, 2 },
                    { -68, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -68, 1.36m, 1 },
                    { -67, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -67, 1.7m, 2 },
                    { -66, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -66, 1.36m, 1 },
                    { -65, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -65, 1.7m, 2 },
                    { -64, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -64, 1.36m, 1 },
                    { -63, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -63, 1.7m, 2 },
                    { -62, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -62, 1.36m, 1 },
                    { -61, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -61, 1.7m, 2 },
                    { -60, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -60, 1.36m, 1 },
                    { -59, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -59, 1.7m, 2 },
                    { -58, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -58, 1.36m, 1 },
                    { -39, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -39, 1.7m, 2 },
                    { -38, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -38, 1.36m, 1 },
                    { -37, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -37, 1.7m, 2 },
                    { -36, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -36, 1.36m, 1 },
                    { -16, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -16, 1.36m, 1 },
                    { -15, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -15, 1.7m, 2 },
                    { -14, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -14, 1.36m, 1 },
                    { -13, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -13, 1.7m, 2 },
                    { -12, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -12, 1.36m, 1 },
                    { -11, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -11, 1.7m, 2 },
                    { -10, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -10, 1.36m, 1 },
                    { -9, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -9, 1.7m, 2 },
                    { -8, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -8, 1.36m, 1 },
                    { -7, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -7, 1.7m, 2 },
                    { -6, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -6, 1.36m, 1 },
                    { -5, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -5, 1.7m, 2 },
                    { -4, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -4, 1.36m, 1 },
                    { -3, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -3, 1.7m, 2 },
                    { -2, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -2, 1.36m, 1 },
                    { -17, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -17, 1.7m, 2 },
                    { -73, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -73, 1.7m, 2 },
                    { -18, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -18, 1.36m, 1 },
                    { -20, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -20, 1.36m, 1 },
                    { -35, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -35, 1.7m, 2 },
                    { -34, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -34, 1.36m, 1 },
                    { -33, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -33, 1.7m, 2 },
                    { -32, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -32, 1.36m, 1 },
                    { -31, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -31, 1.7m, 2 },
                    { -30, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -30, 1.36m, 1 },
                    { -29, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -29, 1.7m, 2 },
                    { -28, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -28, 1.36m, 1 },
                    { -27, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -27, 1.7m, 2 },
                    { -26, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -26, 1.36m, 1 },
                    { -25, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -25, 1.7m, 2 },
                    { -24, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -24, 1.36m, 1 },
                    { -23, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -23, 1.7m, 2 },
                    { -22, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -22, 1.36m, 1 },
                    { -21, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -21, 1.7m, 2 },
                    { -19, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -19, 1.7m, 2 },
                    { -74, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -74, 1.36m, 1 },
                    { -75, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -75, 1.7m, 2 },
                    { -113, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -113, 1.7m, 2 },
                    { -128, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -128, 1.36m, 1 },
                    { -127, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -127, 1.7m, 2 },
                    { -126, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -126, 1.36m, 1 },
                    { -125, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -125, 1.7m, 2 },
                    { -124, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -124, 1.36m, 1 },
                    { -123, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -123, 1.7m, 2 },
                    { -129, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -129, 1.7m, 2 },
                    { -122, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -122, 1.36m, 1 },
                    { -120, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -120, 1.36m, 1 },
                    { -119, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -119, 1.7m, 2 },
                    { -118, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -118, 1.36m, 1 },
                    { -117, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -117, 1.7m, 2 },
                    { -116, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -116, 1.36m, 1 },
                    { -115, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -115, 1.7m, 2 },
                    { -121, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -121, 1.7m, 2 },
                    { -130, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -130, 1.36m, 1 },
                    { -131, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -131, 1.7m, 2 },
                    { -132, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -132, 1.36m, 1 },
                    { -147, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -147, 1.7m, 2 },
                    { -146, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -146, 1.36m, 1 },
                    { -145, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -145, 1.7m, 2 },
                    { -144, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -144, 1.36m, 1 },
                    { -143, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -143, 1.7m, 2 },
                    { -142, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -142, 1.36m, 1 },
                    { -141, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -141, 1.7m, 2 },
                    { -140, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -140, 1.36m, 1 },
                    { -139, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -139, 1.7m, 2 },
                    { -138, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -138, 1.36m, 1 },
                    { -137, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -137, 1.7m, 2 },
                    { -136, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -136, 1.36m, 1 },
                    { -135, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -135, 1.7m, 2 },
                    { -134, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -134, 1.36m, 1 },
                    { -133, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -133, 1.7m, 2 },
                    { -114, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -114, 1.36m, 1 },
                    { -76, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -76, 1.36m, 1 }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "OfferTypeId", "Price", "ReservationId", "TaxAmount", "TicketQuantity" },
                values: new object[,]
                {
                    { -112, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -112, 1.36m, 1 },
                    { -111, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -111, 1.7m, 2 },
                    { -91, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -91, 1.7m, 2 },
                    { -90, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -90, 1.36m, 1 },
                    { -89, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -89, 1.7m, 2 },
                    { -88, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -88, 1.36m, 1 },
                    { -87, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -87, 1.7m, 2 },
                    { -86, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -86, 1.36m, 1 },
                    { -85, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -85, 1.7m, 2 },
                    { -84, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -84, 1.36m, 1 },
                    { -83, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -83, 1.7m, 2 },
                    { -82, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -82, 1.36m, 1 },
                    { -81, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -81, 1.7m, 2 },
                    { -80, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -80, 1.36m, 1 },
                    { -79, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -79, 1.7m, 2 },
                    { -78, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -78, 1.36m, 1 },
                    { -77, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -77, 1.7m, 2 },
                    { -92, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -92, 1.36m, 1 },
                    { -148, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -148, 1.36m, 1 },
                    { -93, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -93, 1.7m, 2 },
                    { -95, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -95, 1.7m, 2 },
                    { -110, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -110, 1.36m, 1 },
                    { -109, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -109, 1.7m, 2 },
                    { -108, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -108, 1.36m, 1 },
                    { -107, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -107, 1.7m, 2 },
                    { -106, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -106, 1.36m, 1 },
                    { -105, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -105, 1.7m, 2 },
                    { -104, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -104, 1.36m, 1 },
                    { -103, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -103, 1.7m, 2 },
                    { -102, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -102, 1.36m, 1 },
                    { -101, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -101, 1.7m, 2 },
                    { -100, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -100, 1.36m, 1 },
                    { -99, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -99, 1.7m, 2 },
                    { -98, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -98, 1.36m, 1 },
                    { -97, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -97, 1.7m, 2 },
                    { -96, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -96, 1.36m, 1 },
                    { -94, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 8m, -94, 1.36m, 1 },
                    { -149, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, 10m, -149, 1.7m, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-1",
                column: "ConcurrencyStamp",
                value: "b23dee4a-6af4-40fe-9863-657d5ef02a07");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-2",
                column: "ConcurrencyStamp",
                value: "2891f86c-df3b-486d-a149-69e585e55766");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-3",
                column: "ConcurrencyStamp",
                value: "9b79c306-ac3d-48b4-844a-3b3d7b8439a9");

            migrationBuilder.InsertData(
                table: "SeatReservations",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ReservationId", "SeatId" },
                values: new object[,]
                {
                    { -4, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -4, -4 },
                    { -207, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -207, -207 },
                    { -206, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -206, -206 },
                    { -205, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -205, -205 },
                    { -204, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -204, -204 },
                    { -203, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -203, -203 },
                    { -202, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -202, -202 },
                    { -208, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -208, -208 },
                    { -201, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -201, -201 },
                    { -199, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -199, -199 },
                    { -198, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -198, -198 },
                    { -197, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -197, -197 },
                    { -196, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -196, -196 },
                    { -195, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -195, -195 },
                    { -194, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -194, -194 },
                    { -200, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -200, -200 },
                    { -209, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -209, -209 },
                    { -210, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -210, -210 },
                    { -211, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -211, -211 },
                    { -226, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -226, -226 },
                    { -225, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -225, -225 },
                    { -224, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -224, -224 },
                    { -223, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -223, -223 },
                    { -222, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -222, -222 },
                    { -221, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -221, -221 },
                    { -220, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -220, -220 },
                    { -219, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -219, -219 },
                    { -218, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -218, -218 },
                    { -217, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -217, -217 },
                    { -216, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -216, -216 },
                    { -215, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -215, -215 },
                    { -214, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -214, -214 },
                    { -213, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -213, -213 },
                    { -212, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -212, -212 },
                    { -193, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -193, -193 },
                    { -192, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -192, -192 },
                    { -191, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -191, -191 },
                    { -190, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -190, -190 },
                    { -170, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -170, -170 },
                    { -169, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -169, -169 },
                    { -168, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -168, -168 },
                    { -167, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -167, -167 },
                    { -166, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -166, -166 },
                    { -165, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -165, -165 },
                    { -164, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -164, -164 },
                    { -163, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -163, -163 },
                    { -162, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -162, -162 },
                    { -161, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -161, -161 },
                    { -160, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -160, -160 },
                    { -159, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -159, -159 },
                    { -158, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -158, -158 },
                    { -157, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -157, -157 },
                    { -156, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -156, -156 },
                    { -171, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -171, -171 },
                    { -227, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -227, -227 },
                    { -172, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -172, -172 },
                    { -174, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -174, -174 },
                    { -189, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -189, -189 },
                    { -188, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -188, -188 },
                    { -187, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -187, -187 },
                    { -186, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -186, -186 },
                    { -185, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -185, -185 },
                    { -184, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -184, -184 },
                    { -183, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -183, -183 },
                    { -182, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -182, -182 },
                    { -181, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -181, -181 },
                    { -180, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -180, -180 },
                    { -179, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -179, -179 },
                    { -178, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -178, -178 },
                    { -177, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -177, -177 },
                    { -176, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -176, -176 },
                    { -175, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -175, -175 },
                    { -173, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -173, -173 },
                    { -2, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -2, -2 },
                    { -228, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -228, -228 },
                    { -230, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -230, -230 },
                    { -282, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -282, -282 },
                    { -281, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -281, -281 },
                    { -280, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -280, -280 },
                    { -279, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -279, -279 },
                    { -278, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -278, -278 },
                    { -277, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -277, -277 },
                    { -283, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -283, -283 },
                    { -276, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -276, -276 },
                    { -274, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -274, -274 },
                    { -273, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -273, -273 },
                    { -272, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -272, -272 },
                    { -271, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -271, -271 },
                    { -270, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -270, -270 },
                    { -269, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -269, -269 },
                    { -275, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -275, -275 },
                    { -284, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -284, -284 },
                    { -285, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -285, -285 },
                    { -286, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -286, -286 },
                    { -1, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, -1 },
                    { -300, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -300, -300 },
                    { -299, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -299, -299 },
                    { -298, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -298, -298 },
                    { -297, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -297, -297 },
                    { -296, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -296, -296 },
                    { -295, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -295, -295 },
                    { -294, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -294, -294 },
                    { -293, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -293, -293 },
                    { -292, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -292, -292 },
                    { -291, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -291, -291 },
                    { -290, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -290, -290 },
                    { -289, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -289, -289 },
                    { -288, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -288, -288 },
                    { -287, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -287, -287 },
                    { -268, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -268, -268 },
                    { -267, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -267, -267 },
                    { -266, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -266, -266 },
                    { -265, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -265, -265 },
                    { -245, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -245, -245 },
                    { -244, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -244, -244 },
                    { -243, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -243, -243 },
                    { -242, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -242, -242 },
                    { -241, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -241, -241 },
                    { -240, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -240, -240 },
                    { -239, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -239, -239 },
                    { -238, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -238, -238 },
                    { -237, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -237, -237 },
                    { -236, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -236, -236 },
                    { -235, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -235, -235 },
                    { -234, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -234, -234 },
                    { -233, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -233, -233 },
                    { -232, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -232, -232 },
                    { -231, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -231, -231 },
                    { -246, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -246, -246 },
                    { -229, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -229, -229 },
                    { -247, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -247, -247 },
                    { -249, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -249, -249 },
                    { -264, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -264, -264 },
                    { -263, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -263, -263 },
                    { -262, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -262, -262 },
                    { -261, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -261, -261 },
                    { -260, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -260, -260 },
                    { -259, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -259, -259 },
                    { -258, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -258, -258 },
                    { -257, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -257, -257 },
                    { -256, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -256, -256 },
                    { -255, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -255, -255 },
                    { -254, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -254, -254 },
                    { -253, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -253, -253 },
                    { -252, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -252, -252 },
                    { -251, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -251, -251 },
                    { -250, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -250, -250 },
                    { -248, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -248, -248 },
                    { -154, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -154, -154 },
                    { -155, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -155, -155 },
                    { -152, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -152, -152 },
                    { -56, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -56, -56 },
                    { -55, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -55, -55 },
                    { -54, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -54, -54 },
                    { -53, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -53, -53 },
                    { -52, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -52, -52 },
                    { -51, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -51, -51 },
                    { -57, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -57, -57 },
                    { -50, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -50, -50 },
                    { -48, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -48, -48 },
                    { -47, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -47, -47 },
                    { -46, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -46, -46 },
                    { -45, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -45, -45 },
                    { -44, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -44, -44 },
                    { -43, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -43, -43 },
                    { -49, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -49, -49 },
                    { -58, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -58, -58 },
                    { -59, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -59, -59 },
                    { -60, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -60, -60 },
                    { -75, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -75, -75 },
                    { -74, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -74, -74 },
                    { -73, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -73, -73 },
                    { -72, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -72, -72 },
                    { -71, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -71, -71 },
                    { -70, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -70, -70 },
                    { -69, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -69, -69 },
                    { -68, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -68, -68 },
                    { -67, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -67, -67 },
                    { -66, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -66, -66 },
                    { -65, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -65, -65 },
                    { -64, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -64, -64 },
                    { -63, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -63, -63 },
                    { -62, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -62, -62 },
                    { -61, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -61, -61 },
                    { -42, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -42, -42 },
                    { -41, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -41, -41 },
                    { -40, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -40, -40 },
                    { -39, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -39, -39 },
                    { -19, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -19, -19 },
                    { -18, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -18, -18 },
                    { -17, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -17, -17 },
                    { -16, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -16, -16 },
                    { -15, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -15, -15 },
                    { -14, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -14, -14 },
                    { -13, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -13, -13 },
                    { -12, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -12, -12 },
                    { -11, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -11, -11 },
                    { -10, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -10, -10 },
                    { -9, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -9, -9 },
                    { -8, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -8, -8 },
                    { -7, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -7, -7 },
                    { -6, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -6, -6 },
                    { -5, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -5, -5 },
                    { -20, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -20, -20 },
                    { -153, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -153, -153 },
                    { -21, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -21, -21 },
                    { -23, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -23, -23 },
                    { -38, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -38, -38 },
                    { -37, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -37, -37 },
                    { -36, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -36, -36 },
                    { -35, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -35, -35 },
                    { -34, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -34, -34 },
                    { -33, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -33, -33 },
                    { -32, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -32, -32 },
                    { -31, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -31, -31 },
                    { -30, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -30, -30 },
                    { -29, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -29, -29 },
                    { -28, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -28, -28 },
                    { -27, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -27, -27 },
                    { -26, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -26, -26 },
                    { -25, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -25, -25 },
                    { -24, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -24, -24 },
                    { -22, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -22, -22 },
                    { -77, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -77, -77 },
                    { -76, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -76, -76 },
                    { -79, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -79, -79 },
                    { -132, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -132, -132 },
                    { -131, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -131, -131 },
                    { -130, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -130, -130 },
                    { -129, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -129, -129 },
                    { -128, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -128, -128 },
                    { -127, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -127, -127 },
                    { -126, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -126, -126 },
                    { -125, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -125, -125 },
                    { -124, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -124, -124 },
                    { -123, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -123, -123 },
                    { -122, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -122, -122 },
                    { -121, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -121, -121 },
                    { -120, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -120, -120 },
                    { -119, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -119, -119 },
                    { -118, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -118, -118 },
                    { -133, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -133, -133 },
                    { -78, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -78, -78 },
                    { -134, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -134, -134 },
                    { -136, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -136, -136 },
                    { -151, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -151, -151 },
                    { -150, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -150, -150 },
                    { -149, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -149, -149 },
                    { -148, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -148, -148 },
                    { -147, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -147, -147 },
                    { -146, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -146, -146 },
                    { -145, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -145, -145 },
                    { -144, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -144, -144 },
                    { -143, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -143, -143 },
                    { -142, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -142, -142 },
                    { -141, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -141, -141 },
                    { -140, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -140, -140 },
                    { -139, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -139, -139 },
                    { -138, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -138, -138 },
                    { -137, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -137, -137 },
                    { -135, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -135, -135 },
                    { -116, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -116, -116 },
                    { -117, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -117, -117 },
                    { -114, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -114, -114 },
                    { -94, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -94, -94 },
                    { -93, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -93, -93 },
                    { -92, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -92, -92 },
                    { -91, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -91, -91 },
                    { -90, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -90, -90 },
                    { -89, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -89, -89 },
                    { -88, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -88, -88 },
                    { -87, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -87, -87 },
                    { -86, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -86, -86 },
                    { -85, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -85, -85 },
                    { -84, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -84, -84 },
                    { -83, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -83, -83 },
                    { -82, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -82, -82 },
                    { -81, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -81, -81 },
                    { -80, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -80, -80 },
                    { -115, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -115, -115 },
                    { -96, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -96, -96 },
                    { -95, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -95, -95 },
                    { -98, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -98, -98 },
                    { -113, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -113, -113 },
                    { -112, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -112, -112 },
                    { -111, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -111, -111 },
                    { -110, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -110, -110 },
                    { -109, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -109, -109 },
                    { -97, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -97, -97 },
                    { -107, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -107, -107 },
                    { -108, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -108, -108 },
                    { -105, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -105, -105 },
                    { -104, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -104, -104 },
                    { -103, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -103, -103 },
                    { -102, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -102, -102 },
                    { -101, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -101, -101 },
                    { -100, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -100, -100 },
                    { -99, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -99, -99 },
                    { -106, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -106, -106 },
                    { -3, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -3, -3 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53b853be-01bb-46b2-af5e-358fe4dd44b5", "AQAAAAEAACcQAAAAELwqo0OKyMcvWAkrTIEMq4ISY3RMsxKyQ4q2yaujENHDzx5lUxZmfeA+4ZM8xFhpfQ==", "05317624-e971-4312-aa32-6bfeb0ad6c50" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e600",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fcb043e-fb0e-4958-9e7d-007561ffda30", "AQAAAAEAACcQAAAAEDZbmczN/XAC30nC5KCPmInCFon+WiqHgfyZYkFlrXwXuh770i8/DaEbbfgve/KZLQ==", "98a4692e-bd98-487b-95e1-1f00742dbc1b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e601",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f48421ab-adb9-4559-8ca9-ba3f9d5558be", "AQAAAAEAACcQAAAAEHF6ezgmfa4M1a0vJlqjpV2sReZZqoEjzwIbpOnkIVfPDlVPW2/qfB1hfzZP0HY46Q==", "4f5b8f11-1ecc-4786-8e3d-55d2cc9cf789" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -300);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -299);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -298);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -297);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -296);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -295);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -294);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -293);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -292);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -291);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -290);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -289);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -288);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -287);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -286);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -285);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -284);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -283);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -282);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -281);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -280);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -279);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -278);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -277);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -276);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -275);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -274);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -273);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -272);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -271);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -270);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -269);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -268);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -267);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -266);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -265);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -264);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -263);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -262);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -261);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -260);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -259);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -258);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -257);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -256);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -255);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -254);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -253);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -252);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -251);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -250);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -249);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -248);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -247);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -246);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -245);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -244);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -243);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -242);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -241);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -240);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -239);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -238);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -237);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -236);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -235);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -234);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -233);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -232);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -231);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -230);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -229);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -228);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -227);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -226);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -225);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -224);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -223);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -222);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -221);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -220);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -219);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -218);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -217);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -216);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -215);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -214);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -213);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -212);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -211);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -210);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -209);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -208);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -207);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -206);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -205);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -204);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -203);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -202);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -201);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -200);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -199);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -198);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -197);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -196);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -195);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -194);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -193);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -192);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -191);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -190);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -189);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -188);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -187);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -186);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -185);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -184);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -183);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -182);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -181);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -180);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -179);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -178);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -177);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -176);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -175);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -174);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -173);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -172);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -171);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -170);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -169);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -168);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -167);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -166);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -165);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -164);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -163);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -162);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -161);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -160);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -159);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -158);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -157);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -156);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -155);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -154);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -153);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -152);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -151);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -150);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -149);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -148);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -147);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -146);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -145);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -144);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -143);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -142);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -141);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -140);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -139);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -138);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -137);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -136);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -135);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -134);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -133);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -132);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -131);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -130);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -129);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -128);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -127);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -126);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -125);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -124);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -123);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -122);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -121);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -120);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -119);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -118);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -117);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -116);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -115);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -114);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -113);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -112);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -111);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -110);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -109);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -108);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -107);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -106);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -105);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -104);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -103);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -102);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -101);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -100);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -99);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -98);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -97);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -96);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -95);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -94);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -93);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -92);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -91);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -90);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -89);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -88);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -87);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -86);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -85);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -84);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -83);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -82);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -81);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -80);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -79);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -78);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -77);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -76);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -75);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -74);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -73);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -72);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -71);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -70);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -69);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -68);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -67);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -66);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -65);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -64);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -63);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -62);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -61);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -60);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -59);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -58);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -57);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -56);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -55);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -54);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -53);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -52);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -51);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -50);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -49);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -48);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -47);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -46);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -45);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -44);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -43);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -42);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -41);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -40);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -39);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -38);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -37);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -36);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -35);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -33);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -31);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -300);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -299);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -298);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -297);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -296);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -295);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -294);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -293);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -292);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -291);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -290);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -289);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -288);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -287);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -286);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -285);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -284);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -283);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -282);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -281);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -280);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -279);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -278);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -277);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -276);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -275);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -274);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -273);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -272);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -271);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -270);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -269);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -268);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -267);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -266);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -265);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -264);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -263);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -262);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -261);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -260);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -259);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -258);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -257);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -256);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -255);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -254);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -253);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -252);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -251);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -250);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -249);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -248);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -247);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -246);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -245);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -244);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -243);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -242);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -241);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -240);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -239);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -238);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -237);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -236);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -235);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -234);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -233);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -232);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -231);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -230);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -229);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -228);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -227);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -226);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -225);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -224);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -223);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -222);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -221);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -220);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -219);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -218);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -217);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -216);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -215);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -214);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -213);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -212);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -211);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -210);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -209);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -208);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -207);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -206);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -205);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -204);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -203);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -202);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -201);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -200);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -199);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -198);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -197);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -196);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -195);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -194);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -193);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -192);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -191);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -190);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -189);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -188);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -187);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -186);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -185);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -184);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -183);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -182);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -181);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -180);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -179);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -178);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -177);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -176);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -175);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -174);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -173);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -172);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -171);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -170);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -169);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -168);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -167);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -166);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -165);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -164);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -163);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -162);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -161);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -160);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -159);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -158);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -157);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -156);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -155);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -154);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -153);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -152);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -151);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -150);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -149);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -148);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -147);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -146);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -145);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -144);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -143);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -142);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -141);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -140);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -139);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -138);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -137);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -136);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -135);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -134);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -133);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -132);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -131);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -130);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -129);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -128);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -127);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -126);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -125);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -124);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -123);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -122);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -121);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -120);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -119);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -118);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -117);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -116);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -115);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -114);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -113);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -112);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -111);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -110);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -109);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -108);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -107);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -106);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -105);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -104);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -103);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -102);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -101);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -100);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -99);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -98);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -97);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -96);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -95);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -94);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -93);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -92);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -91);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -90);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -89);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -88);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -87);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -86);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -85);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -84);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -83);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -82);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -81);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -80);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -79);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -78);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -77);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -76);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -75);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -74);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -73);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -72);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -71);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -70);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -69);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -68);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -67);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -66);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -65);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -64);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -63);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -62);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -61);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -60);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -59);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -58);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -57);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -56);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -55);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -54);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -53);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -52);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -51);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -50);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -49);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -48);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -47);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -46);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -45);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -44);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -43);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -42);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -41);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -40);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -39);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -38);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -37);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -36);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -35);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -33);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -31);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: -1);

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
    }
}
