using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Dal.Migrations
{
    public partial class RolesAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Deleted", "Name", "NormalizedName" },
                values: new object[] { "41d25f29-26ea-4355-b285-8b050bd9a050", "cb86f8af-3efc-4436-8b40-2832a87ad30d", false, "Administrator", null });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Deleted", "Name", "NormalizedName" },
                values: new object[] { "8f86d991-726c-4b85-bd32-03e7741df43c", "8ec69a76-b825-4f34-b597-8190c462e1ef", false, "Content Editor", null });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Deleted", "Name", "NormalizedName" },
                values: new object[] { "2a00ecb1-0c2d-4a60-a6b2-cf33c2622e7a", "2fd930ab-07e6-415a-aa22-ffa04fb87969", false, "Customer", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2a00ecb1-0c2d-4a60-a6b2-cf33c2622e7a");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "41d25f29-26ea-4355-b285-8b050bd9a050");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8f86d991-726c-4b85-bd32-03e7741df43c");
        }
    }
}
