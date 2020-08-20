using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Dal.Migrations
{
    public partial class AddedUserNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-1",
                column: "ConcurrencyStamp",
                value: "47ff150a-6526-4442-87d5-607750f04535");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-2",
                column: "ConcurrencyStamp",
                value: "a90f1ceb-7cc5-4be6-a075-1b32b55e2e02");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-3",
                column: "ConcurrencyStamp",
                value: "048a60d2-4d3a-46b7-b422-87f4298fad35");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0434005-1b3f-4105-9be0-9f735fff88be", "Admin", "Test", "AQAAAAEAACcQAAAAECGNvtl19/rRBhGJ0XoE1wZ5JVnwvwAvtjCIo1ijQZ+/0f54nPyEkNNqAe7s4pobBA==", "45e49ea3-19bb-440e-adaa-ef281c4bed94" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e600",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1ba2657-9b90-4d16-b894-585ac641314b", "First", "Customer", "AQAAAAEAACcQAAAAEPy+MGiaRCYc2mXEZEgpZnYoiXI1xQhvHWOHaOGsBy5XKRvbwTc6vYCgl5kV3ZTk/g==", "b68f3908-b7cb-4a49-8720-6ca6e681f484" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e601",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7202d6ec-1954-4cbe-ae6b-79e262fbd2c5", "First", "Customer", "AQAAAAEAACcQAAAAEDhR1PPFERa6PmrH6YMLxHAL7q18RFn/DLs2KHrwkUe84DH9hlrObE5cEaRQzNqJkA==", "afc5a335-a4ff-4568-9b1d-6df2c27e4d1d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "644aab0a-a364-4cb9-b605-64b306fdcf10", null, null, "AQAAAAEAACcQAAAAEJP/5QTbIDiuGOdk3t6t38nhuztKS0RwUI76KBBH1k6xlWl+ud9/kABwptOxIdQxlg==", "e73b48be-057a-4bbb-ad6e-a82c3bca4831" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e600",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56fd4b5a-a392-45cd-bfe6-0281c9c5f77d", null, null, "AQAAAAEAACcQAAAAEMxAqCLzpdVg3OuT1HI4G4paI3SVDbWPjn3s0nYvm6TtxQ+/k476QD/xrK/npo1nfQ==", "b8c1cdb5-6fb9-486e-b199-804e328ca0e7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e601",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1046934-34b6-44e8-9fe0-23672107abaf", null, null, "AQAAAAEAACcQAAAAEPK0VYzXnDwypDTtr1ZTsLI21v8XcVeIuRbxz7eEpv+sWUq2aD6gBEpBYoAMm7ecfw==", "8ee5f804-d287-4644-9842-8183c49bf236" });
        }
    }
}
