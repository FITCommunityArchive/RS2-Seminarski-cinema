using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Dal.Migrations
{
    public partial class AddedPosterAndWriters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Movies");

            migrationBuilder.AddColumn<byte[]>(
                name: "Poster",
                table: "Movies",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-1",
                column: "ConcurrencyStamp",
                value: "d3d49faf-3c90-4903-8cc3-31a815a4274d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-2",
                column: "ConcurrencyStamp",
                value: "091b3e13-6ca7-45a5-81dd-c4223dafe198");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-3",
                column: "ConcurrencyStamp",
                value: "c376f31d-7efe-484e-8c9b-aa01cf645392");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c30444ae-ad87-4013-ba03-0e62d5efbc19", "AQAAAAEAACcQAAAAEDsrAYSVjNaxe6yiHEP3QaHCt0SD4AXQbUSPXemQSyNLDrFfQhJEkhD6Tl+VDRoZPw==", "6904ab63-2fe6-413c-b93e-067a17ceae65" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Poster",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Writers",
                table: "Movies");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-1",
                column: "ConcurrencyStamp",
                value: "056d7f89-bb60-451d-b75f-5074d625ded2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-2",
                column: "ConcurrencyStamp",
                value: "95b90431-3fdb-4d64-8322-d9f4ce5f3b0a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "-3",
                column: "ConcurrencyStamp",
                value: "40ddfce2-eddc-4533-967d-cf6a4aa0ac8c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d83776c5-468d-445e-a1fe-812c5591b1db", "AQAAAAEAACcQAAAAEPIou02GT53bu+KGGM8RARPspNSeWEpctP97Kka1StPRCD+hk5GM/8M9j70xnHHPsg==", "8363fc80-ae79-4356-b2bd-56a367d3d423" });
        }
    }
}
