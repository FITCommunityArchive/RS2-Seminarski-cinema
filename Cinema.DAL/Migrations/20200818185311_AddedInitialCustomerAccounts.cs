using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Dal.Migrations
{
    public partial class AddedInitialCustomerAccounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Deleted", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a18be9c0-aa65-4af8-bd17-00bd9344e600", 0, "0eb114c7-2713-485c-8c49-42d6171caf0e", false, "test1@test-customer.com", true, null, null, false, null, "TEST1@TEST-CUSTOMER.COM", "TEST.CUSTOMER1", "AQAAAAEAACcQAAAAEOUMnvEL8mAJm/LN/HXZgVJgNgb3uIKEFIv614FBKEAZ1Ru4cC41prxu1R03vUCJ1w==", "123456789", false, "dc9ddc21-6065-47d8-b868-5e305324afbd", false, "test.customer1" },
                    { "a18be9c0-aa65-4af8-bd17-00bd9344e601", 0, "3746000b-b1f6-47a2-89e7-1e2f5c44ccf0", false, "test2@test-customer.com", true, null, null, false, null, "TEST2@TEST-CUSTOMER.COM", "TEST.CUSTOMER2", "AQAAAAEAACcQAAAAECbF8RZo7EwtVgvbBd6yLyqKSxwvyVgRAEwRNVR1O4rN8n/HoPJl9tLwCmwTJVVa6A==", "123456789", false, "0ec9e57b-77d2-4123-ba3d-b5d3dae963dd", false, "test.customer2" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId", "Deleted" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e600", "-3", false });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId", "Deleted" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e601", "-3", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e600", "-3" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e601", "-3" });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e600");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e601");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-1",
                column: "ConcurrencyStamp",
                value: "1cab1896-a79b-4faa-88db-d16e1cdf795d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-2",
                column: "ConcurrencyStamp",
                value: "ce2d9dd3-3f33-40b8-8c70-e1e64a481152");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-3",
                column: "ConcurrencyStamp",
                value: "ecb2a62c-8e92-4a84-9344-aedc66056699");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e60daf6-1e94-493d-948a-d5d7b1a99ade", "AQAAAAEAACcQAAAAENLtxgjq7fUL3lGvEHLYGU21kF36Y+xrBhLJ7wuLrUE+8+4WpzR0gGVwEvLrnU3Drw==", "c5bdbfeb-aa4c-48dc-a2c1-abbcdfda1767" });
        }
    }
}
