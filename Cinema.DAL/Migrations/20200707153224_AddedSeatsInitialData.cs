using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Cinema.Dal.Migrations
{
    public partial class AddedSeatsInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "CreatedAt", "HallId", "IsDeleted", "Label", "SeatNumber" },
                values: new object[,]
                {
                    { -1, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 1 },
                    { -328, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 154 },
                    { -327, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 154 },
                    { -326, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 143 },
                    { -325, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 143 },
                    { -324, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 132 },
                    { -323, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 132 },
                    { -322, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 121 },
                    { -321, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 121 },
                    { -320, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 110 },
                    { -319, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 110 },
                    { -318, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 99 },
                    { -317, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 99 },
                    { -329, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 165 },
                    { -316, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 88 },
                    { -314, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 77 },
                    { -313, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 77 },
                    { -312, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 66 },
                    { -311, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 66 },
                    { -310, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 55 },
                    { -309, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 55 },
                    { -308, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 44 },
                    { -307, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 44 },
                    { -306, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 33 },
                    { -305, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 33 },
                    { -304, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 22 },
                    { -303, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 22 },
                    { -315, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 88 },
                    { -302, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 11 },
                    { -330, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 165 },
                    { -332, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 12 },
                    { -358, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 168 },
                    { -357, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 168 },
                    { -356, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 156 },
                    { -355, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 156 },
                    { -354, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 144 },
                    { -353, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 144 },
                    { -352, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 132 },
                    { -351, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 132 },
                    { -350, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 120 },
                    { -349, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 120 },
                    { -348, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 108 },
                    { -347, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 108 },
                    { -331, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 12 },
                    { -346, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 96 },
                    { -344, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 84 },
                    { -343, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 84 },
                    { -342, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 72 },
                    { -341, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 72 },
                    { -340, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 60 },
                    { -339, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 60 },
                    { -338, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 48 },
                    { -337, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 48 },
                    { -336, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 36 },
                    { -335, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 36 },
                    { -334, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 24 },
                    { -333, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 24 },
                    { -345, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 96 },
                    { -359, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 180 },
                    { -301, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 11 },
                    { -299, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 150 },
                    { -268, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 126 },
                    { -267, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 126 },
                    { -266, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 117 },
                    { -265, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 117 },
                    { -264, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 108 },
                    { -263, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 108 },
                    { -262, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 99 },
                    { -261, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 99 },
                    { -260, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 90 },
                    { -259, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 90 },
                    { -258, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 81 },
                    { -257, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 81 },
                    { -269, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 135 },
                    { -256, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 72 },
                    { -254, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 63 },
                    { -253, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 63 },
                    { -252, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 54 },
                    { -251, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 54 },
                    { -250, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 45 },
                    { -249, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 45 },
                    { -248, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 36 },
                    { -247, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 36 },
                    { -246, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 27 },
                    { -245, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 27 },
                    { -244, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 18 },
                    { -243, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 18 },
                    { -255, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 72 },
                    { -300, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 150 },
                    { -270, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 135 },
                    { -272, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 10 },
                    { -298, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 140 },
                    { -297, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 140 },
                    { -296, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 130 },
                    { -295, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 130 },
                    { -294, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 120 },
                    { -293, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 120 },
                    { -292, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 110 },
                    { -291, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 110 },
                    { -290, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 100 },
                    { -289, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 100 },
                    { -288, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 90 },
                    { -287, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 90 },
                    { -271, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 10 },
                    { -286, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 80 },
                    { -284, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 70 },
                    { -283, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 70 },
                    { -282, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 60 },
                    { -281, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 60 },
                    { -280, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 50 },
                    { -279, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 50 },
                    { -278, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 40 },
                    { -277, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 40 },
                    { -276, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 30 },
                    { -275, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 30 },
                    { -274, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 20 },
                    { -273, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 20 },
                    { -285, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 80 },
                    { -242, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 9 },
                    { -360, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 180 },
                    { -362, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 13 },
                    { -448, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 210 },
                    { -447, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 210 },
                    { -446, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 195 },
                    { -445, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 195 },
                    { -444, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 180 },
                    { -443, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 180 },
                    { -442, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 165 },
                    { -441, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 165 },
                    { -440, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 150 },
                    { -439, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 150 },
                    { -438, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 135 },
                    { -437, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 135 },
                    { -449, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 225 },
                    { -436, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 120 },
                    { -434, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 105 },
                    { -433, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 105 },
                    { -432, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 90 },
                    { -431, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 90 },
                    { -430, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 75 },
                    { -429, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 75 },
                    { -428, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 60 },
                    { -427, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 60 },
                    { -426, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 45 },
                    { -425, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 45 },
                    { -424, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 30 },
                    { -423, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 30 },
                    { -435, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 120 },
                    { -422, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 15 },
                    { -450, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 225 },
                    { -452, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 16 },
                    { -478, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 224 },
                    { -477, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 224 },
                    { -476, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 208 },
                    { -475, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 208 },
                    { -474, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 192 },
                    { -473, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 192 },
                    { -472, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 176 },
                    { -471, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 176 },
                    { -470, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 160 },
                    { -469, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 160 },
                    { -468, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 144 },
                    { -467, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 144 },
                    { -451, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 16 },
                    { -466, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 128 },
                    { -464, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 112 },
                    { -463, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 112 },
                    { -462, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 96 },
                    { -461, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 96 },
                    { -460, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 80 },
                    { -459, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 80 },
                    { -458, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 64 },
                    { -457, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 64 },
                    { -456, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 48 },
                    { -455, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 48 },
                    { -454, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 32 },
                    { -453, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 32 },
                    { -465, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 128 },
                    { -361, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 13 },
                    { -421, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 15 },
                    { -419, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 210 },
                    { -388, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 182 },
                    { -387, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 182 },
                    { -386, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 169 },
                    { -385, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 169 },
                    { -384, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 156 },
                    { -383, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 156 },
                    { -382, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 143 },
                    { -381, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 143 },
                    { -380, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 130 },
                    { -379, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 130 },
                    { -378, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 117 },
                    { -377, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 117 },
                    { -389, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 195 },
                    { -376, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 104 },
                    { -374, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 91 },
                    { -373, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 91 },
                    { -372, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 78 },
                    { -371, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 78 },
                    { -370, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 65 },
                    { -369, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 65 },
                    { -368, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 52 },
                    { -367, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 52 },
                    { -366, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 39 },
                    { -365, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 39 },
                    { -364, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 26 },
                    { -363, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 26 },
                    { -375, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 104 },
                    { -420, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 210 },
                    { -390, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 195 },
                    { -392, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 14 },
                    { -418, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 196 },
                    { -417, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 196 },
                    { -416, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 182 },
                    { -415, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 182 },
                    { -414, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 168 },
                    { -413, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 168 },
                    { -412, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 154 },
                    { -411, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 154 },
                    { -410, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 140 },
                    { -409, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 140 },
                    { -408, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 126 },
                    { -407, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 126 },
                    { -391, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 14 },
                    { -406, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 112 },
                    { -404, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 98 },
                    { -403, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 98 },
                    { -402, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 84 },
                    { -401, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 84 },
                    { -400, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 70 },
                    { -399, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 70 },
                    { -398, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 56 },
                    { -397, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 56 },
                    { -396, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 42 },
                    { -395, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 42 },
                    { -394, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 28 },
                    { -393, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 28 },
                    { -405, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 112 },
                    { -241, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 9 },
                    { -240, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 120 },
                    { -239, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 120 },
                    { -87, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 42 },
                    { -86, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 39 },
                    { -85, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 39 },
                    { -84, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 36 },
                    { -83, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 36 },
                    { -82, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 33 },
                    { -81, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 33 },
                    { -80, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 30 },
                    { -79, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 30 },
                    { -78, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 27 },
                    { -77, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 27 },
                    { -76, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 24 },
                    { -88, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 42 },
                    { -75, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 24 },
                    { -73, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 21 },
                    { -72, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 18 },
                    { -71, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 18 },
                    { -70, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 15 },
                    { -69, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 15 },
                    { -68, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 12 },
                    { -67, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 12 },
                    { -66, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 9 },
                    { -65, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 9 },
                    { -64, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 6 },
                    { -63, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 6 },
                    { -62, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 3 },
                    { -74, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 21 },
                    { -61, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 3 },
                    { -89, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 45 },
                    { -91, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 4 },
                    { -117, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 56 },
                    { -116, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 52 },
                    { -115, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 52 },
                    { -114, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 48 },
                    { -113, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 48 },
                    { -112, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 44 },
                    { -111, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 44 },
                    { -110, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 40 },
                    { -109, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 40 },
                    { -108, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 36 },
                    { -107, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 36 },
                    { -106, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 32 },
                    { -90, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 45 },
                    { -105, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 32 },
                    { -103, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 28 },
                    { -102, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 24 },
                    { -101, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 24 },
                    { -100, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 20 },
                    { -99, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 20 },
                    { -98, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 16 },
                    { -97, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 16 },
                    { -96, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 12 },
                    { -95, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 12 },
                    { -94, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 8 },
                    { -93, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 8 },
                    { -92, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 4 },
                    { -104, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 28 },
                    { -118, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 56 },
                    { -60, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 30 },
                    { -58, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 28 },
                    { -27, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 14 },
                    { -26, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 13 },
                    { -25, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 13 },
                    { -24, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 12 },
                    { -23, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 12 },
                    { -22, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 11 },
                    { -21, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 11 },
                    { -20, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 10 },
                    { -19, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 10 },
                    { -18, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 9 },
                    { -17, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 9 },
                    { -16, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 8 },
                    { -28, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 14 },
                    { -15, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 8 },
                    { -13, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 7 },
                    { -12, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 6 },
                    { -11, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 6 },
                    { -10, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 5 },
                    { -9, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 5 },
                    { -8, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 4 },
                    { -7, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 4 },
                    { -6, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 3 },
                    { -5, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 3 },
                    { -4, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 2 },
                    { -3, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 2 },
                    { -2, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 1 },
                    { -14, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 7 },
                    { -59, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 30 },
                    { -29, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 15 },
                    { -31, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 2 },
                    { -57, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 28 },
                    { -56, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 26 },
                    { -55, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 26 },
                    { -54, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 24 },
                    { -53, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 24 },
                    { -52, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 22 },
                    { -51, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 22 },
                    { -50, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 20 },
                    { -49, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 20 },
                    { -48, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 18 },
                    { -47, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 18 },
                    { -46, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 16 },
                    { -30, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 15 },
                    { -45, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 16 },
                    { -43, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 14 },
                    { -42, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 12 },
                    { -41, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 12 },
                    { -40, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 10 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "CreatedAt", "HallId", "IsDeleted", "Label", "SeatNumber" },
                values: new object[,]
                {
                    { -39, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 10 },
                    { -38, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 8 },
                    { -37, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 8 },
                    { -36, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 6 },
                    { -35, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 6 },
                    { -34, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 4 },
                    { -33, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 4 },
                    { -32, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 2 },
                    { -44, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 14 },
                    { -119, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 60 },
                    { -120, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 60 },
                    { -121, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 5 },
                    { -208, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 98 },
                    { -207, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 98 },
                    { -206, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 91 },
                    { -205, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 91 },
                    { -204, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 84 },
                    { -203, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 84 },
                    { -202, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 77 },
                    { -201, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 77 },
                    { -200, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 70 },
                    { -199, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 70 },
                    { -198, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 63 },
                    { -197, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 63 },
                    { -209, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 105 },
                    { -196, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 56 },
                    { -194, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 49 },
                    { -193, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 49 },
                    { -192, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 42 },
                    { -191, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 42 },
                    { -190, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 35 },
                    { -189, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 35 },
                    { -188, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 28 },
                    { -187, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 28 },
                    { -186, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 21 },
                    { -185, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 21 },
                    { -184, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 14 },
                    { -183, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 14 },
                    { -195, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 56 },
                    { -182, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 7 },
                    { -210, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 105 },
                    { -212, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 8 },
                    { -238, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 112 },
                    { -237, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 112 },
                    { -236, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 104 },
                    { -235, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 104 },
                    { -234, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 96 },
                    { -233, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 96 },
                    { -232, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 88 },
                    { -231, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 88 },
                    { -230, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 80 },
                    { -229, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 80 },
                    { -228, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 72 },
                    { -227, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 72 },
                    { -211, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 8 },
                    { -226, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 64 },
                    { -224, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 56 },
                    { -223, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 56 },
                    { -222, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 48 },
                    { -221, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 48 },
                    { -220, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 40 },
                    { -219, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 40 },
                    { -218, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 32 },
                    { -217, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 32 },
                    { -216, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 24 },
                    { -215, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 24 },
                    { -214, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 16 },
                    { -213, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 16 },
                    { -225, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 64 },
                    { -181, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 7 },
                    { -180, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 90 },
                    { -179, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 90 },
                    { -147, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 70 },
                    { -146, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 65 },
                    { -145, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 65 },
                    { -144, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 60 },
                    { -143, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 60 },
                    { -142, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 55 },
                    { -141, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 55 },
                    { -140, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 50 },
                    { -139, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 50 },
                    { -138, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 45 },
                    { -137, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 45 },
                    { -136, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 40 },
                    { -148, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 70 },
                    { -135, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 40 },
                    { -133, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 35 },
                    { -132, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 30 },
                    { -131, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 30 },
                    { -130, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 25 },
                    { -129, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 25 },
                    { -128, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 20 },
                    { -127, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 20 },
                    { -126, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 15 },
                    { -125, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 15 },
                    { -124, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 10 },
                    { -123, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 10 },
                    { -122, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 5 },
                    { -134, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 35 },
                    { -149, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 75 },
                    { -150, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 75 },
                    { -151, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 6 },
                    { -178, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 84 },
                    { -177, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 84 },
                    { -176, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 78 },
                    { -175, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 78 },
                    { -174, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 72 },
                    { -173, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 72 },
                    { -172, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 66 },
                    { -171, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 66 },
                    { -170, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 60 },
                    { -169, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 60 },
                    { -168, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 54 },
                    { -167, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 54 },
                    { -166, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 48 },
                    { -165, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 48 },
                    { -164, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 42 },
                    { -163, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 42 },
                    { -162, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 36 },
                    { -161, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 36 },
                    { -160, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 30 },
                    { -159, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 30 },
                    { -158, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 24 },
                    { -157, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 24 },
                    { -156, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 18 },
                    { -155, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 18 },
                    { -154, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 12 },
                    { -153, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 12 },
                    { -152, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 6 },
                    { -479, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 240 },
                    { -480, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 240 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -480);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -479);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -478);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -477);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -476);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -475);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -474);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -473);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -472);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -471);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -470);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -469);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -468);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -467);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -466);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -465);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -464);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -463);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -462);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -461);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -460);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -459);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -458);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -457);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -456);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -455);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -454);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -453);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -452);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -451);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -450);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -449);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -448);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -447);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -446);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -445);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -444);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -443);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -442);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -441);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -440);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -439);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -438);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -437);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -436);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -435);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -434);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -433);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -432);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -431);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -430);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -429);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -428);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -427);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -426);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -425);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -424);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -423);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -422);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -421);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -420);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -419);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -418);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -417);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -416);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -415);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -414);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -413);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -412);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -411);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -410);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -409);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -408);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -407);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -406);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -405);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -404);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -403);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -402);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -401);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -400);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -399);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -398);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -397);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -396);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -395);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -394);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -393);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -392);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -391);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -390);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -389);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -388);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -387);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -386);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -385);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -384);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -383);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -382);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -381);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -380);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -379);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -378);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -377);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -376);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -375);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -374);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -373);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -372);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -371);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -370);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -369);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -368);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -367);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -366);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -365);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -364);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -363);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -362);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -361);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -360);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -359);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -358);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -357);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -356);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -355);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -354);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -353);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -352);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -351);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -350);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -349);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -348);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -347);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -346);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -345);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -344);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -343);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -342);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -341);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -340);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -339);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -338);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -337);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -336);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -335);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -334);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -333);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -332);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -331);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -330);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -329);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -328);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -327);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -326);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -325);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -324);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -323);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -322);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -321);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -320);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -319);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -318);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -317);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -316);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -315);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -314);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -313);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -312);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -311);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -310);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -309);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -308);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -307);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -306);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -305);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -304);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -303);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -302);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -301);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -300);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -299);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -298);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -297);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -296);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -295);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -294);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -293);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -292);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -291);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -290);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -289);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -288);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -287);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -286);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -285);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -284);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -283);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -282);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -281);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -280);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -279);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -278);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -277);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -276);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -275);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -274);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -273);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -272);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -271);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -270);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -269);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -268);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -267);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -266);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -265);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -264);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -263);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -262);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -261);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -260);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -259);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -258);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -257);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -256);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -255);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -254);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -253);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -252);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -251);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -250);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -249);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -248);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -247);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -246);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -245);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -244);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -243);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -242);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -241);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -240);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -239);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -238);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -237);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -236);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -235);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -234);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -233);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -232);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -231);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -230);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -229);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -228);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -227);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -226);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -225);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -224);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -223);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -222);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -221);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -220);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -219);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -218);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -217);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -216);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -215);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -214);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -213);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -212);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -211);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -210);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -209);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -208);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -207);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -206);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -205);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -204);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -203);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -202);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -201);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -200);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -199);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -198);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -197);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -196);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -195);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -194);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -193);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -192);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -191);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -190);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -189);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -188);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -187);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -186);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -185);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -184);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -183);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -182);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -181);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -180);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -179);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -178);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -177);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -176);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -175);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -174);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -173);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -172);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -171);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -170);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -169);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -168);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -167);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -166);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -165);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -164);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -163);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -162);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -161);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -160);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -159);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -158);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -157);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -156);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -155);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -154);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -153);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -152);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -151);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -150);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -149);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -148);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -147);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -146);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -145);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -144);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -143);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -142);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -141);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -140);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -139);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -138);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -137);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -136);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -135);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -134);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -133);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -132);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -131);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -130);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -129);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -128);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -127);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -126);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -125);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -124);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -123);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -122);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -121);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -120);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -119);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -118);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -117);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -116);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -115);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -114);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -113);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -112);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -111);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -110);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -109);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -108);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -107);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -106);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -105);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -104);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -103);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -102);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -101);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -100);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -99);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -98);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -97);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -96);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -95);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -94);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -93);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -92);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -91);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -90);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -89);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -88);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -87);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -86);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -85);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -84);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -83);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -82);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -81);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -80);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -79);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -78);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -77);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -76);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -75);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -74);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -73);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -72);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -71);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -70);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -69);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -68);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -67);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -66);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -65);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -64);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -63);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -62);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -61);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -60);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -59);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -58);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -57);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -56);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -55);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -54);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -53);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -52);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -51);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -50);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -49);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -48);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -47);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -46);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -45);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -44);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -43);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -42);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -41);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -40);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -39);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -38);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -37);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -36);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -35);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -33);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -31);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
