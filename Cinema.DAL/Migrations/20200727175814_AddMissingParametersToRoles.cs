using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Dal.Migrations
{
    public partial class AddMissingParametersToRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Deleted", "Name", "NormalizedName" },
                values: new object[] { "3eadf352-1e91-48d2-b652-f0c6d06683e5", "f6a85d1d-6d9b-4c35-9347-71916994b7f9", false, "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Deleted", "Name", "NormalizedName" },
                values: new object[] { "4f113b67-63e3-40d4-8b55-4cbe877c787a", "954c97c4-4604-4af2-a247-c12af6c809dc", false, "Content Editor", "CONTENT EDITOR" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Deleted", "Name", "NormalizedName" },
                values: new object[] { "0da60945-6d69-4e12-8c70-ecbf72039a39", "ba1a12ad-1e26-46aa-8995-700c2aa2577e", false, "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0da60945-6d69-4e12-8c70-ecbf72039a39");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3eadf352-1e91-48d2-b652-f0c6d06683e5");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "4f113b67-63e3-40d4-8b55-4cbe877c787a");

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
    }
}
