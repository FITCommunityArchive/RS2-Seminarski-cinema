using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Cinema.Persistence.Migrations
{
    public partial class AddedInvoicesAndSeatReservationsInitialSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Price", "PricingId", "ReservationId", "TaxAmount" },
                values: new object[,]
                {
                    { -1, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -1, 1.7m },
                    { -204, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -204, 1.36m },
                    { -203, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -203, 1.7m },
                    { -202, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -202, 1.36m },
                    { -201, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -201, 1.7m },
                    { -200, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -200, 1.36m },
                    { -199, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -199, 1.7m },
                    { -205, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -205, 1.7m },
                    { -198, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -198, 1.36m },
                    { -196, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -196, 1.36m },
                    { -195, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -195, 1.7m },
                    { -194, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -194, 1.36m },
                    { -193, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -193, 1.7m },
                    { -192, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -192, 1.36m },
                    { -191, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -191, 1.7m },
                    { -197, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -197, 1.7m },
                    { -206, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -206, 1.36m },
                    { -207, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -207, 1.7m },
                    { -208, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -208, 1.36m },
                    { -223, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -223, 1.7m },
                    { -222, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -222, 1.36m },
                    { -221, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -221, 1.7m },
                    { -220, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -220, 1.36m },
                    { -219, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -219, 1.7m },
                    { -218, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -218, 1.36m },
                    { -217, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -217, 1.7m },
                    { -216, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -216, 1.36m },
                    { -215, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -215, 1.7m },
                    { -214, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -214, 1.36m },
                    { -213, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -213, 1.7m },
                    { -212, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -212, 1.36m },
                    { -211, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -211, 1.7m },
                    { -210, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -210, 1.36m },
                    { -209, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -209, 1.7m },
                    { -190, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -190, 1.36m },
                    { -189, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -189, 1.7m },
                    { -188, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -188, 1.36m },
                    { -187, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -187, 1.7m },
                    { -167, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -167, 1.7m },
                    { -166, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -166, 1.36m },
                    { -165, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -165, 1.7m },
                    { -164, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -164, 1.36m },
                    { -163, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -163, 1.7m },
                    { -162, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -162, 1.36m },
                    { -161, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -161, 1.7m },
                    { -160, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -160, 1.36m },
                    { -159, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -159, 1.7m },
                    { -158, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -158, 1.36m },
                    { -157, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -157, 1.7m },
                    { -156, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -156, 1.36m },
                    { -155, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -155, 1.7m },
                    { -154, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -154, 1.36m },
                    { -153, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -153, 1.7m },
                    { -168, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -168, 1.36m },
                    { -224, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -224, 1.36m },
                    { -169, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -169, 1.7m },
                    { -171, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -171, 1.7m },
                    { -186, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -186, 1.36m },
                    { -185, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -185, 1.7m },
                    { -184, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -184, 1.36m },
                    { -183, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -183, 1.7m },
                    { -182, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -182, 1.36m },
                    { -181, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -181, 1.7m },
                    { -180, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -180, 1.36m },
                    { -179, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -179, 1.7m },
                    { -178, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -178, 1.36m },
                    { -177, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -177, 1.7m },
                    { -176, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -176, 1.36m },
                    { -175, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -175, 1.7m },
                    { -174, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -174, 1.36m },
                    { -173, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -173, 1.7m },
                    { -172, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -172, 1.36m },
                    { -170, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -170, 1.36m },
                    { -152, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -152, 1.36m },
                    { -225, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -225, 1.7m },
                    { -227, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -227, 1.7m },
                    { -279, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -279, 1.7m },
                    { -278, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -278, 1.36m },
                    { -277, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -277, 1.7m },
                    { -276, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -276, 1.36m },
                    { -275, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -275, 1.7m },
                    { -274, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -274, 1.36m },
                    { -280, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -280, 1.36m },
                    { -273, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -273, 1.7m },
                    { -271, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -271, 1.7m },
                    { -270, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -270, 1.36m },
                    { -269, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -269, 1.7m },
                    { -268, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -268, 1.36m },
                    { -267, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -267, 1.7m },
                    { -266, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -266, 1.36m },
                    { -272, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -272, 1.36m },
                    { -281, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -281, 1.7m },
                    { -282, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -282, 1.36m },
                    { -283, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -283, 1.7m },
                    { -298, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -298, 1.36m },
                    { -297, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -297, 1.7m },
                    { -296, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -296, 1.36m },
                    { -295, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -295, 1.7m },
                    { -294, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -294, 1.36m },
                    { -293, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -293, 1.7m },
                    { -292, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -292, 1.36m },
                    { -291, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -291, 1.7m },
                    { -290, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -290, 1.36m },
                    { -289, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -289, 1.7m },
                    { -288, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -288, 1.36m },
                    { -287, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -287, 1.7m },
                    { -286, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -286, 1.36m },
                    { -285, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -285, 1.7m },
                    { -284, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -284, 1.36m },
                    { -265, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -265, 1.7m },
                    { -264, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -264, 1.36m },
                    { -263, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -263, 1.7m },
                    { -262, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -262, 1.36m },
                    { -242, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -242, 1.36m },
                    { -241, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -241, 1.7m },
                    { -240, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -240, 1.36m },
                    { -239, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -239, 1.7m },
                    { -238, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -238, 1.36m },
                    { -237, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -237, 1.7m },
                    { -236, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -236, 1.36m },
                    { -235, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -235, 1.7m },
                    { -234, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -234, 1.36m },
                    { -233, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -233, 1.7m },
                    { -232, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -232, 1.36m },
                    { -231, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -231, 1.7m },
                    { -230, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -230, 1.36m },
                    { -229, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -229, 1.7m },
                    { -228, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -228, 1.36m },
                    { -243, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -243, 1.7m },
                    { -226, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -226, 1.36m },
                    { -244, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -244, 1.36m },
                    { -246, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -246, 1.36m },
                    { -261, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -261, 1.7m },
                    { -260, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -260, 1.36m },
                    { -259, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -259, 1.7m },
                    { -258, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -258, 1.36m },
                    { -257, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -257, 1.7m },
                    { -256, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -256, 1.36m },
                    { -255, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -255, 1.7m },
                    { -254, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -254, 1.36m },
                    { -253, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -253, 1.7m },
                    { -252, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -252, 1.36m },
                    { -251, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -251, 1.7m },
                    { -250, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -250, 1.36m },
                    { -249, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -249, 1.7m },
                    { -248, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -248, 1.36m },
                    { -247, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -247, 1.7m },
                    { -245, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -245, 1.7m },
                    { -151, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -151, 1.7m },
                    { -150, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -150, 1.36m },
                    { -149, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -149, 1.7m },
                    { -53, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -53, 1.7m },
                    { -52, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -52, 1.36m },
                    { -51, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -51, 1.7m },
                    { -50, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -50, 1.36m },
                    { -49, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -49, 1.7m },
                    { -48, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -48, 1.36m },
                    { -54, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -54, 1.36m },
                    { -47, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -47, 1.7m },
                    { -45, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -45, 1.7m },
                    { -44, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -44, 1.36m },
                    { -43, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -43, 1.7m },
                    { -42, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -42, 1.36m },
                    { -41, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -41, 1.7m },
                    { -40, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -40, 1.36m },
                    { -46, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -46, 1.36m },
                    { -55, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -55, 1.7m },
                    { -56, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -56, 1.36m },
                    { -57, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -57, 1.7m },
                    { -72, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -72, 1.36m },
                    { -71, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -71, 1.7m },
                    { -70, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -70, 1.36m },
                    { -69, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -69, 1.7m },
                    { -68, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -68, 1.36m },
                    { -67, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -67, 1.7m },
                    { -66, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -66, 1.36m },
                    { -65, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -65, 1.7m },
                    { -64, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -64, 1.36m },
                    { -63, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -63, 1.7m },
                    { -62, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -62, 1.36m },
                    { -61, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -61, 1.7m },
                    { -60, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -60, 1.36m },
                    { -59, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -59, 1.7m },
                    { -58, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -58, 1.36m },
                    { -39, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -39, 1.7m },
                    { -38, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -38, 1.36m },
                    { -37, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -37, 1.7m },
                    { -36, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -36, 1.36m },
                    { -16, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -16, 1.36m },
                    { -15, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -15, 1.7m },
                    { -14, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -14, 1.36m },
                    { -13, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -13, 1.7m },
                    { -12, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -12, 1.36m },
                    { -11, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -11, 1.7m },
                    { -10, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -10, 1.36m },
                    { -9, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -9, 1.7m },
                    { -8, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -8, 1.36m },
                    { -7, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -7, 1.7m },
                    { -6, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -6, 1.36m },
                    { -5, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -5, 1.7m },
                    { -4, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -4, 1.36m },
                    { -3, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -3, 1.7m },
                    { -2, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -2, 1.36m },
                    { -17, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -17, 1.7m },
                    { -73, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -73, 1.7m },
                    { -18, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -18, 1.36m },
                    { -20, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -20, 1.36m },
                    { -35, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -35, 1.7m },
                    { -34, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -34, 1.36m },
                    { -33, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -33, 1.7m },
                    { -32, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -32, 1.36m },
                    { -31, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -31, 1.7m },
                    { -30, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -30, 1.36m },
                    { -29, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -29, 1.7m },
                    { -28, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -28, 1.36m },
                    { -27, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -27, 1.7m },
                    { -26, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -26, 1.36m },
                    { -25, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -25, 1.7m },
                    { -24, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -24, 1.36m },
                    { -23, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -23, 1.7m },
                    { -22, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -22, 1.36m },
                    { -21, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -21, 1.7m },
                    { -19, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -19, 1.7m },
                    { -74, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -74, 1.36m },
                    { -75, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -75, 1.7m },
                    { -76, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -76, 1.36m },
                    { -129, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -129, 1.7m },
                    { -128, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -128, 1.36m },
                    { -127, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -127, 1.7m },
                    { -126, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -126, 1.36m },
                    { -125, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -125, 1.7m },
                    { -124, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -124, 1.36m },
                    { -123, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -123, 1.7m },
                    { -122, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -122, 1.36m },
                    { -121, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -121, 1.7m },
                    { -120, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -120, 1.36m },
                    { -119, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -119, 1.7m },
                    { -118, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -118, 1.36m },
                    { -117, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -117, 1.7m },
                    { -116, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -116, 1.36m },
                    { -115, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -115, 1.7m },
                    { -130, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -130, 1.36m },
                    { -114, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -114, 1.36m },
                    { -131, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -131, 1.7m },
                    { -133, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -133, 1.7m },
                    { -148, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -148, 1.36m },
                    { -147, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -147, 1.7m },
                    { -146, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -146, 1.36m },
                    { -145, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -145, 1.7m },
                    { -144, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -144, 1.36m },
                    { -143, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -143, 1.7m },
                    { -142, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -142, 1.36m },
                    { -141, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -141, 1.7m },
                    { -140, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -140, 1.36m },
                    { -139, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -139, 1.7m },
                    { -138, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -138, 1.36m },
                    { -137, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -137, 1.7m },
                    { -136, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -136, 1.36m },
                    { -135, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -135, 1.7m },
                    { -134, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -134, 1.36m },
                    { -132, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -132, 1.36m },
                    { -299, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -299, 1.7m },
                    { -113, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -113, 1.7m },
                    { -111, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -111, 1.7m },
                    { -91, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -91, 1.7m },
                    { -90, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -90, 1.36m },
                    { -89, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -89, 1.7m },
                    { -88, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -88, 1.36m },
                    { -87, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -87, 1.7m },
                    { -86, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -86, 1.36m },
                    { -85, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -85, 1.7m },
                    { -84, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -84, 1.36m },
                    { -83, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -83, 1.7m },
                    { -82, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -82, 1.36m },
                    { -81, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -81, 1.7m },
                    { -80, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -80, 1.36m },
                    { -79, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -79, 1.7m },
                    { -78, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -78, 1.36m },
                    { -77, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -77, 1.7m },
                    { -92, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -92, 1.36m },
                    { -112, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -112, 1.36m },
                    { -93, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -93, 1.7m },
                    { -95, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -95, 1.7m },
                    { -110, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -110, 1.36m },
                    { -109, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -109, 1.7m },
                    { -108, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -108, 1.36m },
                    { -107, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -107, 1.7m },
                    { -106, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -106, 1.36m },
                    { -105, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -105, 1.7m },
                    { -104, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -104, 1.36m },
                    { -103, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -103, 1.7m },
                    { -102, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -102, 1.36m },
                    { -101, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -101, 1.7m },
                    { -100, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -100, 1.36m },
                    { -99, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -99, 1.7m },
                    { -98, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -98, 1.36m },
                    { -97, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10m, -1, -97, 1.7m },
                    { -96, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -96, 1.36m },
                    { -94, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -94, 1.36m }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Price", "PricingId", "ReservationId", "TaxAmount" },
                values: new object[] { -300, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8m, -1, -300, 1.36m });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -3,
                column: "ConcurrencyStamp",
                value: "fc7f25a8-01ac-4674-99f8-2b9fe07eaf9a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "740ab7b1-f35c-480b-b2ff-77f7fc5ca03d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "67768d9e-5926-4d8b-9ad0-d049e9c1322f");

            migrationBuilder.InsertData(
                table: "SeatReservations",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ReservationId", "SeatId" },
                values: new object[,]
                {
                    { -2, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -2, -2 },
                    { -206, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -206, -206 },
                    { -205, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -205, -205 },
                    { -204, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -204, -204 },
                    { -203, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -203, -203 },
                    { -202, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -202, -202 },
                    { -201, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -201, -201 },
                    { -200, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -200, -200 },
                    { -199, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -199, -199 },
                    { -198, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -198, -198 },
                    { -197, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -197, -197 },
                    { -196, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -196, -196 },
                    { -195, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -195, -195 },
                    { -194, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -194, -194 },
                    { -193, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -193, -193 },
                    { -207, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -207, -207 },
                    { -208, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -208, -208 },
                    { -210, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -210, -210 },
                    { -192, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -192, -192 },
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
                    { -211, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -211, -211 },
                    { -209, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -209, -209 },
                    { -191, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -191, -191 },
                    { -189, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -189, -189 },
                    { -226, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -226, -226 },
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
                    { -155, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -155, -155 },
                    { -170, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -170, -170 },
                    { -190, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -190, -190 },
                    { -171, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -171, -171 },
                    { -173, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -173, -173 },
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
                    { -174, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -174, -174 },
                    { -172, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -172, -172 },
                    { -227, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -227, -227 },
                    { -228, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -228, -228 },
                    { -229, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -229, -229 },
                    { -281, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -281, -281 },
                    { -280, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -280, -280 },
                    { -279, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -279, -279 },
                    { -278, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -278, -278 },
                    { -277, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -277, -277 },
                    { -276, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -276, -276 },
                    { -282, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -282, -282 },
                    { -275, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -275, -275 },
                    { -273, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -273, -273 },
                    { -272, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -272, -272 },
                    { -271, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -271, -271 },
                    { -270, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -270, -270 },
                    { -269, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -269, -269 },
                    { -268, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -268, -268 },
                    { -274, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -274, -274 },
                    { -283, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -283, -283 },
                    { -284, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -284, -284 },
                    { -285, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -285, -285 },
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
                    { -286, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -286, -286 },
                    { -267, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -267, -267 },
                    { -266, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -266, -266 },
                    { -265, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -265, -265 },
                    { -264, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -264, -264 },
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
                    { -230, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -230, -230 },
                    { -245, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -245, -245 },
                    { -1, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -1, -1 },
                    { -246, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -246, -246 },
                    { -248, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -248, -248 },
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
                    { -249, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -249, -249 },
                    { -247, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -247, -247 },
                    { -153, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -153, -153 },
                    { -154, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -154, -154 },
                    { -151, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -151, -151 },
                    { -55, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -55, -55 },
                    { -54, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -54, -54 },
                    { -53, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -53, -53 },
                    { -52, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -52, -52 },
                    { -51, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -51, -51 },
                    { -50, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -50, -50 },
                    { -56, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -56, -56 },
                    { -49, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -49, -49 },
                    { -47, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -47, -47 },
                    { -46, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -46, -46 },
                    { -45, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -45, -45 },
                    { -44, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -44, -44 },
                    { -43, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -43, -43 },
                    { -42, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -42, -42 },
                    { -48, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -48, -48 },
                    { -57, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -57, -57 },
                    { -58, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -58, -58 },
                    { -59, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -59, -59 },
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
                    { -60, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -60, -60 },
                    { -41, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -41, -41 },
                    { -40, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -40, -40 },
                    { -39, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -39, -39 },
                    { -38, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -38, -38 },
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
                    { -4, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -4, -4 },
                    { -19, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -19, -19 },
                    { -152, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -152, -152 },
                    { -20, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -20, -20 },
                    { -22, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -22, -22 },
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
                    { -23, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -23, -23 },
                    { -21, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -21, -21 },
                    { -76, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -76, -76 },
                    { -75, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -75, -75 },
                    { -78, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -78, -78 },
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
                    { -117, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -117, -117 },
                    { -132, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -132, -132 },
                    { -77, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -77, -77 },
                    { -133, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -133, -133 },
                    { -135, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -135, -135 },
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
                    { -136, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -136, -136 },
                    { -134, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -134, -134 },
                    { -115, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -115, -115 },
                    { -116, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -116, -116 },
                    { -113, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -113, -113 },
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
                    { -79, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -79, -79 },
                    { -114, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -114, -114 },
                    { -95, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -95, -95 },
                    { -94, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -94, -94 },
                    { -97, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -97, -97 },
                    { -112, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -112, -112 },
                    { -111, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -111, -111 },
                    { -110, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -110, -110 },
                    { -109, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -109, -109 },
                    { -108, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -108, -108 },
                    { -96, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -96, -96 },
                    { -106, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -106, -106 },
                    { -107, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -107, -107 },
                    { -104, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -104, -104 },
                    { -103, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -103, -103 },
                    { -102, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -102, -102 },
                    { -101, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -101, -101 },
                    { -100, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -100, -100 },
                    { -99, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -99, -99 },
                    { -98, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -98, -98 },
                    { -105, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -105, -105 },
                    { -3, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, -3, -3 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0c91d39c-e4fc-47a0-9970-3616b98081cf", "AQAAAAEAACcQAAAAEBfdViydAx8Z/cka4vIpGCPN2nhIzhTUyQDb86w+lsXs1kJj+o+xlgkrLjy+TRrrcw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1fbbf698-7852-4312-93b2-43bfb7a94ca6", "AQAAAAEAACcQAAAAEBHoFL1bBhbZB6oVuMegD4BO9CezJX46qQyImtZNAyA0Ilka76O5mr+OZJUVawK5yQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f4ef353-1895-4d0c-a292-13a2e0b78405", "AQAAAAEAACcQAAAAELRDmvFK9iW7gxUj9aIDG7R+Qb1GW0aukRgWqOBdBfkRgPTqqPJczKJ/wwrn/PcRVg==" });
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
    }
}
