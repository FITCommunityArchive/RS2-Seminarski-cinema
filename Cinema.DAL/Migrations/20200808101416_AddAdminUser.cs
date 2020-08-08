using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Dal.Migrations
{
    public partial class AddAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { "-1", "056d7f89-bb60-451d-b75f-5074d625ded2", false, "Administrator", "ADMINISTRATOR" },
                    { "-2", "95b90431-3fdb-4d64-8322-d9f4ce5f3b0a", false, "Content Editor", "CONTENT EDITOR" },
                    { "-3", "40ddfce2-eddc-4533-967d-cf6a4aa0ac8c", false, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Deleted", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, "d83776c5-468d-445e-a1fe-812c5591b1db", false, "admin@admin.com", true, null, null, false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEPIou02GT53bu+KGGM8RARPspNSeWEpctP97Kka1StPRCD+hk5GM/8M9j70xnHHPsg==", "123456789", false, "8363fc80-ae79-4356-b2bd-56a367d3d423", false, "admin" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId", "Deleted" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "-1", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-2");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-3");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "-1" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575");

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
    }
}
