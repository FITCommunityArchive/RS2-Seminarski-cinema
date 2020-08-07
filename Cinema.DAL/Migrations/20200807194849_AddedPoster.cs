using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Dal.Migrations
{
    public partial class AddedPoster : Migration
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

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Movies");

            migrationBuilder.AddColumn<byte[]>(
                name: "Poster",
                table: "Movies",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Poster",
                table: "Movies");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

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
