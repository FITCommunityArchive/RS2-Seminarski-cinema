using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Dal.Migrations
{
    public partial class AddedWritersToMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "84d62ae6-0855-4837-a382-08a6c8d5bdbf");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ebac04a0-9efa-4921-b745-9fd091f6281a");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f548abfc-a8a5-4a70-98b3-fc949b37344f");

            migrationBuilder.AddColumn<string>(
                name: "Writers",
                table: "Movies",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -4,
                column: "Writers",
                value: "Stuart Townsend");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -3,
                column: "Writers",
                value: "Sean Roche, James Gurney");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2,
                column: "Writers",
                value: "Cheuk-Hon Szeto");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1,
                column: "Writers",
                value: "Adam Bhala Lough");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Deleted", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2690a941-1eaa-47ae-8048-b1a0e2d1bef6", "4d37d86c-5ab3-4e5d-9509-aff3edde8380", false, "Administrator", "ADMINISTRATOR" },
                    { "08eef917-5ab7-4cc9-a98f-de01fb1f850a", "261adc50-6871-4818-ba76-e587441e30cf", false, "Content Editor", "CONTENT EDITOR" },
                    { "01cd822a-3aba-4f7a-9e5c-eb8284e44378", "050d704e-9317-40b4-98a9-da49bded3105", false, "Customer", "CUSTOMER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "01cd822a-3aba-4f7a-9e5c-eb8284e44378");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "08eef917-5ab7-4cc9-a98f-de01fb1f850a");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2690a941-1eaa-47ae-8048-b1a0e2d1bef6");

            migrationBuilder.DropColumn(
                name: "Writers",
                table: "Movies");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Deleted", "Name", "NormalizedName" },
                values: new object[] { "ebac04a0-9efa-4921-b745-9fd091f6281a", "bcf35ac2-b3bc-4fba-9559-bba5b8f606b7", false, "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Deleted", "Name", "NormalizedName" },
                values: new object[] { "84d62ae6-0855-4837-a382-08a6c8d5bdbf", "ac4b193c-2b01-4034-8b7d-bf840cdc1fb5", false, "Content Editor", "CONTENT EDITOR" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Deleted", "Name", "NormalizedName" },
                values: new object[] { "f548abfc-a8a5-4a70-98b3-fc949b37344f", "48484ba5-8d73-4e57-b594-0ee66124e992", false, "Customer", "CUSTOMER" });
        }
    }
}
