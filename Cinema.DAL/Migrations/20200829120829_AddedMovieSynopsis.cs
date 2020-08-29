using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Dal.Migrations
{
    public partial class AddedMovieSynopsis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Synopsis",
                table: "Movies",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -4,
                column: "Synopsis",
                value: "In late November 1999, masses are descending upon Seattle for the World Trade Organization (WTO) Conference, the first ever held on American soil. Beyond the several delegates, career protesters are also coming to Seattle, they who believe the non-elected organization only exists to support corporate interests at the expense of the poor, working class and the environment among other things. Before the conference, the lead known protesters vow that their demonstrations will be peaceful, while Seattle Mayor Jim Tobin promises that if that be the case that no arrests will be made and no aggressive action, such as the use of tear gas, will be issued. On day one of the conference, tensions on both sides escalate the confrontation between police and protesters, with many innocent people caught in the crossfire. As such, what was promised ends up not happening during the remainder of the conference, where many on both sides work not for the greater good of their side, but rather for their own personal interests because of their experience on day one. These battles outside the official conference are not the only ones happening in Seattle, as many of the conference delegates, such as Doctors Without Borders and those from some of the poorer nations, try to get across the point of many of the protesters - albeit in a more diplomatic method - while seemingly ignored by those in the upper echelon of the organization.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -3,
                column: "Synopsis",
                value: "Experience the Magic of Dinotopia in an All-New Animated Movie! 26, the beloved young dinosaur from the hit miniseries, stars in an all-new animated movie set on the island where humans and dinosaurs co-exist. Twelve-year-old orphan Kex stows away in a lifeboat, hoping to see the world, but after being washed overboard he finds himself on Dinotopia, befriended by 26. Soon, the friends face trouble when the evil Ogthar is released from his stone prison and recovers the Ruby Sunstone, whose dark power can endanger all of Dinotopia. Join 26, Kex and the other dinosaurs as they fight to save their magical home!");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2,
                column: "Synopsis",
                value: "A college student (Yuen Biao) at a university in Canada is a fencing champion and when he has an accident one day, he \"dreams\" of being transported to ancient China and enters a conflict on Zu, the Magic Mountain. At the end of the story, he regains consciousness (this is in the longer English international version). The first and shorter version is about a warrior (Yuen Biao) who has become disillusioned with the constant civil wars in China and goes to the Magic Mountain. There he encounters ghosts and devils, and also good masters and their disciples who are out to stop the Blood Monster and his demons from destroying the world.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1,
                column: "Synopsis",
                value: "A tribute to graffiti art and the city where it all began. Blest, a 19-year-old graffiti writer, has just graduated from high school. With no ambition toward mainstream goals of work and family, he spends his time bombing the city with graffiti messages until he and his crew become the most wanted bombers by the corrupt NYPD Vandal Squad. He even attracts major media and gallery attention for his tags. Also part of Blest's crew are Buk 50 and his younger brother Lune, whose arrest and beating by the NYPD causes the crew to wage a full-on graffiti war against the city. As they fight with their spray cans and their tags, Blest meets a political activist, Alexandra. Soon after, Blest's relationship with Buk 50 and the crew fragments as Blest ponders his position in life.");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -3,
                column: "ConcurrencyStamp",
                value: "0d6cabeb-29a5-45b7-b518-aacf840f47e9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "a7a24a80-4592-463c-bd65-3149a78ea686");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "34661455-182e-42ef-9075-b78f91dde3c4");

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateAndTime",
                value: new DateTime(2020, 9, 23, 18, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateAndTime",
                value: new DateTime(2020, 9, 13, 18, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateAndTime",
                value: new DateTime(2020, 9, 8, 22, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateAndTime",
                value: new DateTime(2020, 9, 8, 20, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "95a7c92f-4155-4fc9-92ac-5695015403ad", "AQAAAAEAACcQAAAAEKkctddQxcgwz8jDhghMuy8DFyFXLFSBGffWb2eetQa1lMXMEYTds+11x4y0LDV/oQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f0aa23cf-ba7c-4fdd-94bd-5b3fb89691ea", "AQAAAAEAACcQAAAAEO+atX7tmEAdznGAY7OWnOcHt0plBi6+wJseIEVGPROl/QzWFqSEkPM/meeSht9qjg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b3cc7f5a-3177-44ee-b580-d92a6786db56", "AQAAAAEAACcQAAAAEAc8HSfgOklqgqOLAHu3I9qAvYsBsqfNcxiTFccte9ZpMKWT4y1AZ+PzpoKF6xi7/w==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Synopsis",
                table: "Movies");

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

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateAndTime",
                value: new DateTime(2020, 9, 14, 18, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateAndTime",
                value: new DateTime(2020, 9, 4, 18, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateAndTime",
                value: new DateTime(2020, 8, 30, 22, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateAndTime",
                value: new DateTime(2020, 8, 30, 20, 0, 0, 0, DateTimeKind.Utc));

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
    }
}
