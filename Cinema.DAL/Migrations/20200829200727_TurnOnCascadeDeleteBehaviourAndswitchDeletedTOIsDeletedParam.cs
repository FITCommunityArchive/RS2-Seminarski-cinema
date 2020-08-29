using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Dal.Migrations
{
    public partial class TurnOnCascadeDeleteBehaviourAndswitchDeletedTOIsDeletedParam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_Roles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_Users_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_Users_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_Users_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Users_AuthorId1",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_EventTypes_TypeId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_GenreMovies_Genres_GenreId",
                table: "GenreMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_GenreMovies_Movies_MovieId",
                table: "GenreMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Pricing_PricingId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Reservations_ReservationId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Users_AuthorId1",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_News_NewsTypes_TypeId",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Screenings_ScreeningId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Users_UserId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Movies_MovieId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_UserId1",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Screenings_Halls_HallId",
                table: "Screenings");

            migrationBuilder.DropForeignKey(
                name: "FK_Screenings_Movies_MovieId",
                table: "Screenings");

            migrationBuilder.DropForeignKey(
                name: "FK_Screenings_Pricing_PricingId",
                table: "Screenings");

            migrationBuilder.DropForeignKey(
                name: "FK_SeatReservations_Reservations_ReservationId",
                table: "SeatReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_SeatReservations_Seats_SeatId",
                table: "SeatReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Halls_HallId",
                table: "Seats");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Roles");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "UserRoles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Roles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -3,
                column: "ConcurrencyStamp",
                value: "3587ff5d-51de-4807-b5fe-35aa6295cc97");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "c4457a3d-bdc0-443b-ae98-720e255be69f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "d594ecbb-a48e-4614-82f5-be908e88abf3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "410aa59c-5d86-4c22-8e54-c2e64a460388", "AQAAAAEAACcQAAAAEIHh9BqotHmgpfMcRZRd4Fo+ltAcDD7XjQSZS2w6tmRweMbawjfvSaVAzeNDUQKaog==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2752b0b6-d50c-4b79-9945-5f38a539244d", "AQAAAAEAACcQAAAAEHJH8iz/+oqGd086UiZq6NqshcSVUbfFTsxhjlFN5lUlNy468aKFUuUWQAeRB9UY0g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "714fca13-d02f-45cb-a2e6-5d268f3599fa", "AQAAAAEAACcQAAAAEFnLLrckkWYFZGLyHcfXQV97C9yq8UKc85ExufahUBI7WokqVsFo09ngaMGZ9nPBBA==" });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_Roles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_Users_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_Users_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_Users_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_AuthorId1",
                table: "Events",
                column: "AuthorId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_EventTypes_TypeId",
                table: "Events",
                column: "TypeId",
                principalTable: "EventTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreMovies_Genres_GenreId",
                table: "GenreMovies",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreMovies_Movies_MovieId",
                table: "GenreMovies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Pricing_PricingId",
                table: "Invoices",
                column: "PricingId",
                principalTable: "Pricing",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Reservations_ReservationId",
                table: "Invoices",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_News_Users_AuthorId1",
                table: "News",
                column: "AuthorId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_News_NewsTypes_TypeId",
                table: "News",
                column: "TypeId",
                principalTable: "NewsTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Screenings_ScreeningId",
                table: "Reservations",
                column: "ScreeningId",
                principalTable: "Screenings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Users_UserId",
                table: "Reservations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Movies_MovieId",
                table: "Reviews",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_UserId1",
                table: "Reviews",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Screenings_Halls_HallId",
                table: "Screenings",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Screenings_Movies_MovieId",
                table: "Screenings",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Screenings_Pricing_PricingId",
                table: "Screenings",
                column: "PricingId",
                principalTable: "Pricing",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_SeatReservations_Reservations_ReservationId",
                table: "SeatReservations",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SeatReservations_Seats_SeatId",
                table: "SeatReservations",
                column: "SeatId",
                principalTable: "Seats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Halls_HallId",
                table: "Seats",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_Roles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_Users_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_Users_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_Users_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Users_AuthorId1",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_EventTypes_TypeId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_GenreMovies_Genres_GenreId",
                table: "GenreMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_GenreMovies_Movies_MovieId",
                table: "GenreMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Pricing_PricingId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Reservations_ReservationId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Users_AuthorId1",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_News_NewsTypes_TypeId",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Screenings_ScreeningId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Users_UserId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Movies_MovieId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_UserId1",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Screenings_Halls_HallId",
                table: "Screenings");

            migrationBuilder.DropForeignKey(
                name: "FK_Screenings_Movies_MovieId",
                table: "Screenings");

            migrationBuilder.DropForeignKey(
                name: "FK_Screenings_Pricing_PricingId",
                table: "Screenings");

            migrationBuilder.DropForeignKey(
                name: "FK_SeatReservations_Reservations_ReservationId",
                table: "SeatReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_SeatReservations_Seats_SeatId",
                table: "SeatReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Halls_HallId",
                table: "Seats");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Roles");

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "UserRoles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Roles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -3,
                column: "ConcurrencyStamp",
                value: "4704cefc-4fcb-4da9-b19e-471caa1ed5a7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "51a854b9-6d61-4914-9adb-04c3c7c135f9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "a374ee47-4c9d-42bb-becc-aeaeb9b8d539");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "61c39953-f51a-4d5f-8d01-809688f882ab", "AQAAAAEAACcQAAAAELN8simUuN2ja0G2bw++8p9U0sEeRqCZT6lxMsnF9kJWdiVaGmWWA1twfjA0trfxEA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bd95c4f8-123c-49a3-833c-c91ccd80af50", "AQAAAAEAACcQAAAAEEndrCNcE3HNH7WbWGzo64/D+g7AusSZmFDAQjPsG1pE19Ltior8qPW6xbRzHFJdog==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b4a15c82-e127-4e10-82dc-d3657ec8ffb4", "AQAAAAEAACcQAAAAEM6OY1wo3XaiXTHQswVUhIvcXOko4//i63xZEBmqZeaJxBjTOtZ3GVdpCRpLcaxRTQ==" });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_Roles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_Users_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_Users_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_Users_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_AuthorId1",
                table: "Events",
                column: "AuthorId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_EventTypes_TypeId",
                table: "Events",
                column: "TypeId",
                principalTable: "EventTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreMovies_Genres_GenreId",
                table: "GenreMovies",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreMovies_Movies_MovieId",
                table: "GenreMovies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Pricing_PricingId",
                table: "Invoices",
                column: "PricingId",
                principalTable: "Pricing",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Reservations_ReservationId",
                table: "Invoices",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_News_Users_AuthorId1",
                table: "News",
                column: "AuthorId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_News_NewsTypes_TypeId",
                table: "News",
                column: "TypeId",
                principalTable: "NewsTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Screenings_ScreeningId",
                table: "Reservations",
                column: "ScreeningId",
                principalTable: "Screenings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Users_UserId",
                table: "Reservations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Movies_MovieId",
                table: "Reviews",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_UserId1",
                table: "Reviews",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Screenings_Halls_HallId",
                table: "Screenings",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Screenings_Movies_MovieId",
                table: "Screenings",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Screenings_Pricing_PricingId",
                table: "Screenings",
                column: "PricingId",
                principalTable: "Pricing",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SeatReservations_Reservations_ReservationId",
                table: "SeatReservations",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SeatReservations_Seats_SeatId",
                table: "SeatReservations",
                column: "SeatId",
                principalTable: "Seats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Halls_HallId",
                table: "Seats",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
