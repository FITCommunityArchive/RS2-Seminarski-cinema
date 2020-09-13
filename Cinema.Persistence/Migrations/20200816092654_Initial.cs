using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Cinema.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Halls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NumberOfRows = table.Column<int>(nullable: false),
                    NumberOfColumns = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Halls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Duration = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Country = table.Column<string>(nullable: true),
                    Poster = table.Column<byte[]>(nullable: true),
                    VideoLink = table.Column<string>(nullable: true),
                    Directors = table.Column<string>(nullable: true),
                    Writers = table.Column<string>(nullable: true),
                    Actors = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NewsTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pricing",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pricing", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    SeatNumber = table.Column<int>(nullable: false),
                    Label = table.Column<string>(nullable: true),
                    HallId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seats_Halls_HallId",
                        column: x => x.HallId,
                        principalTable: "Halls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GenreMovies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    MovieId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreMovies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenreMovies_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GenreMovies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Screenings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DateAndTime = table.Column<DateTime>(nullable: false),
                    HallId = table.Column<int>(nullable: false),
                    MovieId = table.Column<int>(nullable: false),
                    PricingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screenings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Screenings_Halls_HallId",
                        column: x => x.HallId,
                        principalTable: "Halls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Screenings_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Screenings_Pricing_PricingId",
                        column: x => x.PricingId,
                        principalTable: "Pricing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    AuthorId = table.Column<string>(nullable: true),
                    AuthorId1 = table.Column<int>(nullable: true),
                    DateAndTime = table.Column<DateTime>(nullable: false),
                    Promoter = table.Column<string>(nullable: true),
                    TypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Users_AuthorId1",
                        column: x => x.AuthorId1,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_EventTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "EventTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    AuthorId = table.Column<string>(nullable: true),
                    AuthorId1 = table.Column<int>(nullable: true),
                    TypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Users_AuthorId1",
                        column: x => x.AuthorId1,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_News_NewsTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "NewsTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    UserId1 = table.Column<int>(nullable: true),
                    MovieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    UserId1 = table.Column<int>(nullable: true),
                    ScreeningId = table.Column<int>(nullable: false),
                    IsCancelled = table.Column<bool>(nullable: false),
                    ReservationCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Screenings_ScreeningId",
                        column: x => x.ScreeningId,
                        principalTable: "Screenings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ReservationId = table.Column<int>(nullable: false),
                    TicketQuantity = table.Column<int>(nullable: false),
                    OfferTypeId = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    TaxAmount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_Pricing_OfferTypeId",
                        column: x => x.OfferTypeId,
                        principalTable: "Pricing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoices_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SeatReservations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ReservationId = table.Column<int>(nullable: false),
                    SeatId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeatReservations_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SeatReservations_Seats_SeatId",
                        column: x => x.SeatId,
                        principalTable: "Seats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "EventTypes",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { -1, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Event Type 1" },
                    { -2, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Event Type 2" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { -1, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Action" },
                    { -2, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Drama" },
                    { -3, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adventure" },
                    { -4, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Fantasy" },
                    { -5, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Animation" },
                    { -6, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Comedy" }
                });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "NumberOfColumns", "NumberOfRows" },
                values: new object[,]
                {
                    { -2, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Movie Hall 2", 16, 15 },
                    { -1, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Movie Hall 1", 16, 15 }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Actors", "Country", "CreatedAt", "Directors", "Duration", "IsDeleted", "Poster", "Title", "VideoLink", "Writers", "Year" },
                values: new object[,]
                {
                    { -4, "André Benjamin, Jennifer Carpenter, Isaach De Bankolé", "Canada, USA, Germany", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stuart Townsend", 98, false, null, "Battle in Seattle", "https://www.imdb.com/video/vi1761450777?playlistId=tt0850253&ref_=tt_ov_vi", "Stuart Townsend", 2007 },
                    { -1, "Mark Webber, Jade Yorker, Jaclyn DeSantis", "USA", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adam Bhala Lough", 91, false, null, "Bomb the System", "https://www.imdb.com/video/vi1706754329?playlistId=tt0337585&ref_=tt_ov_vi", "Adam Bhala Lough", 2002 },
                    { -2, "Biao Yuen, Hoi Mang, Adam Cheng", "Hong Kong", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hark Tsui", 102, false, null, "Zu: Warriors from the Magic Mountain", "https://www.imdb.com/video/vi645768729?playlistId=tt0086308&ref_=tt_ov_vi", "Cheuk-Hon Szeto", 1983 },
                    { -3, "Alyssa Milano, Jamie Kennedy, Kathy Griffin", "USA", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Davis Doi", 75, false, null, "Dinotopia: Quest for the Ruby Sunstone", "https://www.imdb.com/video/vi1889665305?playlistId=tt0372238&ref_=tt_ov_vi", "Sean Roche, James Gurney", 2005 }
                });

            migrationBuilder.InsertData(
                table: "NewsTypes",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { -2, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "News Type 2" },
                    { -1, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "News Type 1" }
                });

            migrationBuilder.InsertData(
                table: "Pricing",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { -3, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "3D", 10m },
                    { -2, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Weekend", 8m },
                    { -1, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Regular", 7m },
                    { -5, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Premiere", 12m },
                    { -4, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Students", 6m }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Deleted", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { -2, "5e41a3da-0648-48be-adc1-16c39f4b4415", false, "Content Editor", "CONTENT EDITOR" },
                    { -1, "f8035ee8-d4a2-45bc-b9d9-954d46075c64", false, "Administrator", "ADMINISTRATOR" },
                    { -3, "709931a7-608f-4070-8c83-b994ae946fae", false, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Deleted", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, "7f0754f0-8d5f-493e-9e9a-253d01abe567", false, "admin@admin.com", true, null, null, false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAECk6h9FmfExOIykQz6EkqJzc0B4ur10Oi1dRtHUuiAUn4Hj65rexiOH8IsDOVF7pCQ==", "123456789", false, null, false, "admin" });

            migrationBuilder.InsertData(
                table: "GenreMovies",
                columns: new[] { "Id", "CreatedAt", "GenreId", "IsDeleted", "MovieId" },
                values: new object[,]
                {
                    { -4, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, -4 },
                    { -1, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, -1 },
                    { -2, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, -1 },
                    { -5, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, -2 },
                    { -6, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -3, false, -2 },
                    { -3, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, -4 },
                    { -8, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -4, false, -3 },
                    { -10, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -6, false, -3 },
                    { -7, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -4, false, -2 },
                    { -9, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -5, false, -3 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "CreatedAt", "HallId", "IsDeleted", "Label", "SeatNumber" },
                values: new object[,]
                {
                    { -134, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 35 },
                    { -184, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 14 },
                    { -182, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 7 },
                    { -180, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 90 },
                    { -178, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 84 },
                    { -176, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 78 },
                    { -174, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 72 },
                    { -172, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 66 },
                    { -170, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 60 },
                    { -168, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 54 },
                    { -166, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 48 },
                    { -164, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 42 },
                    { -162, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 36 },
                    { -160, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 30 },
                    { -156, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 18 },
                    { -154, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 12 },
                    { -152, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 6 },
                    { -150, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 75 },
                    { -148, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 70 },
                    { -146, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 65 },
                    { -144, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 60 },
                    { -142, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 55 },
                    { -140, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 50 },
                    { -138, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 45 },
                    { -136, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 40 },
                    { -186, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 21 },
                    { -158, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 24 },
                    { -190, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 35 },
                    { -192, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 42 },
                    { -244, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 18 },
                    { -242, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 9 },
                    { -240, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 120 },
                    { -238, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 112 },
                    { -236, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 104 },
                    { -234, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 96 },
                    { -232, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 88 },
                    { -230, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 80 },
                    { -228, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 72 },
                    { -226, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 64 },
                    { -224, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 56 },
                    { -222, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 48 },
                    { -188, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 28 },
                    { -220, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 40 },
                    { -216, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 24 },
                    { -214, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 16 },
                    { -212, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 8 },
                    { -210, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 105 },
                    { -208, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 98 },
                    { -206, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 91 },
                    { -204, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 84 },
                    { -202, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 77 },
                    { -200, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 70 },
                    { -198, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 63 },
                    { -196, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 56 },
                    { -194, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 49 },
                    { -218, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 32 },
                    { -132, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 30 },
                    { -128, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 20 },
                    { -126, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 15 },
                    { -64, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 6 },
                    { -62, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 3 },
                    { -60, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 30 },
                    { -58, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 28 },
                    { -56, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 26 },
                    { -54, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 24 },
                    { -52, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 22 },
                    { -50, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 20 },
                    { -48, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 18 },
                    { -46, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 16 },
                    { -44, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 14 },
                    { -42, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 12 },
                    { -40, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 10 },
                    { -38, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 8 },
                    { -36, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 6 },
                    { -34, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 4 },
                    { -32, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 2 },
                    { -30, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 15 },
                    { -28, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 14 },
                    { -26, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 13 },
                    { -24, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 12 },
                    { -22, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 11 },
                    { -20, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 10 },
                    { -18, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 9 },
                    { -16, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 8 },
                    { -66, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 9 },
                    { -68, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 12 },
                    { -70, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 15 },
                    { -72, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 18 },
                    { -124, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 10 },
                    { -122, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 5 },
                    { -120, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 60 },
                    { -118, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 56 },
                    { -116, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 52 },
                    { -114, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 48 },
                    { -112, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 44 },
                    { -110, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 40 },
                    { -108, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 36 },
                    { -106, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 32 },
                    { -104, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 28 },
                    { -102, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 24 },
                    { -130, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 25 },
                    { -100, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 20 },
                    { -96, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 12 },
                    { -94, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 8 },
                    { -92, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 4 },
                    { -90, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 45 },
                    { -88, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 42 },
                    { -86, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 39 },
                    { -84, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 36 },
                    { -82, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 33 },
                    { -80, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 30 },
                    { -78, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 27 },
                    { -76, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 24 },
                    { -74, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 21 },
                    { -98, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 16 },
                    { -246, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 27 },
                    { -250, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 45 },
                    { -252, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 54 },
                    { -420, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 210 },
                    { -418, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 196 },
                    { -416, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 182 },
                    { -414, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 168 },
                    { -412, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 154 },
                    { -410, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 140 },
                    { -408, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 126 },
                    { -406, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 112 },
                    { -404, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 98 },
                    { -402, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 84 },
                    { -400, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 70 },
                    { -398, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 56 },
                    { -396, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 42 },
                    { -394, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 28 },
                    { -392, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 14 },
                    { -390, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 195 },
                    { -388, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 182 },
                    { -386, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 169 },
                    { -384, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 156 },
                    { -382, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 143 },
                    { -380, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 130 },
                    { -378, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 117 },
                    { -376, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 104 },
                    { -374, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 91 },
                    { -372, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 78 },
                    { -422, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 15 },
                    { -424, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 30 },
                    { -426, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 45 },
                    { -428, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 60 },
                    { -480, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 240 },
                    { -478, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 224 },
                    { -476, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 208 },
                    { -474, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 192 },
                    { -472, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 176 },
                    { -470, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 160 },
                    { -468, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 144 },
                    { -466, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 128 },
                    { -464, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 112 },
                    { -462, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 96 },
                    { -460, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 80 },
                    { -458, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 64 },
                    { -370, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 65 },
                    { -456, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 48 },
                    { -452, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 16 },
                    { -450, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 225 },
                    { -448, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 210 },
                    { -446, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 195 },
                    { -444, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 180 },
                    { -442, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 165 },
                    { -440, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 150 },
                    { -438, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 135 },
                    { -436, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 120 },
                    { -434, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 105 },
                    { -432, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 90 },
                    { -430, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 75 },
                    { -454, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 32 },
                    { -248, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 36 },
                    { -368, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 52 },
                    { -364, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 26 },
                    { -302, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 11 },
                    { -300, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 150 },
                    { -298, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 140 },
                    { -296, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 130 },
                    { -294, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 120 },
                    { -292, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 110 },
                    { -290, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 100 },
                    { -288, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 90 },
                    { -286, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 80 },
                    { -284, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 70 },
                    { -282, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 60 },
                    { -280, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 50 },
                    { -278, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 40 },
                    { -276, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 30 },
                    { -274, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 20 },
                    { -272, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 10 },
                    { -270, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 135 },
                    { -268, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 126 },
                    { -266, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 117 },
                    { -264, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 108 },
                    { -262, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 99 },
                    { -260, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 90 },
                    { -258, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 81 },
                    { -14, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 7 },
                    { -254, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 63 },
                    { -304, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 22 },
                    { -306, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 33 },
                    { -308, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 44 },
                    { -310, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 55 },
                    { -362, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 13 },
                    { -360, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 180 },
                    { -358, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 168 },
                    { -356, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 156 },
                    { -354, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 144 },
                    { -352, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 132 },
                    { -350, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 120 },
                    { -348, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 108 },
                    { -346, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 96 },
                    { -344, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 84 },
                    { -342, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 72 },
                    { -340, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 60 },
                    { -366, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 39 },
                    { -338, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 48 },
                    { -334, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 24 },
                    { -332, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 12 },
                    { -330, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 165 },
                    { -328, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 154 },
                    { -326, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 143 },
                    { -324, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 132 },
                    { -322, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 121 },
                    { -320, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 110 },
                    { -318, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 99 },
                    { -316, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 88 },
                    { -314, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 77 },
                    { -312, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 66 },
                    { -336, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 36 },
                    { -256, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 72 },
                    { -12, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 6 },
                    { -8, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 4 },
                    { -177, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 84 },
                    { -175, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 78 },
                    { -173, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 72 },
                    { -171, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 66 },
                    { -169, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 60 },
                    { -167, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 54 },
                    { -165, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 48 },
                    { -163, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 42 },
                    { -161, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 36 },
                    { -159, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 30 },
                    { -157, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 24 },
                    { -155, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 18 },
                    { -179, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 90 },
                    { -153, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 12 },
                    { -149, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 75 },
                    { -147, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 70 },
                    { -145, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 65 },
                    { -143, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 60 },
                    { -141, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 55 },
                    { -139, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 50 },
                    { -137, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 45 },
                    { -135, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 40 },
                    { -133, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 35 },
                    { -131, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 30 },
                    { -129, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 25 },
                    { -127, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 20 },
                    { -151, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 6 },
                    { -181, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 7 },
                    { -183, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 14 },
                    { -185, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 21 },
                    { -239, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 120 },
                    { -237, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 112 },
                    { -235, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 104 },
                    { -233, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 96 },
                    { -231, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 88 },
                    { -229, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 80 },
                    { -227, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 72 },
                    { -225, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 64 },
                    { -223, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 56 },
                    { -221, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 48 },
                    { -219, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 40 },
                    { -217, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 32 },
                    { -215, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 24 },
                    { -213, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 16 },
                    { -211, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 8 },
                    { -209, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 105 },
                    { -207, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 98 },
                    { -205, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 91 },
                    { -203, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 84 },
                    { -201, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 77 },
                    { -199, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 70 },
                    { -197, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 63 },
                    { -195, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 56 },
                    { -193, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 49 },
                    { -191, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 42 },
                    { -189, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 35 },
                    { -187, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 28 },
                    { -125, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 15 },
                    { -123, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 10 },
                    { -121, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 5 },
                    { -119, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 60 },
                    { -55, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 26 },
                    { -53, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 24 },
                    { -51, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 22 },
                    { -49, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 20 },
                    { -47, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 18 },
                    { -45, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 16 },
                    { -43, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 14 },
                    { -41, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 12 },
                    { -39, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 10 },
                    { -37, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 8 },
                    { -35, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 6 },
                    { -33, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 4 },
                    { -31, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 2 },
                    { -29, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 15 },
                    { -27, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 14 },
                    { -25, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 13 },
                    { -23, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 12 },
                    { -21, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 11 },
                    { -19, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 10 },
                    { -17, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 9 },
                    { -15, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 8 },
                    { -13, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 7 },
                    { -11, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 6 },
                    { -9, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 5 },
                    { -7, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 4 },
                    { -5, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 3 },
                    { -3, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 2 },
                    { -57, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 28 },
                    { -241, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 9 },
                    { -59, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 30 },
                    { -63, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 6 },
                    { -117, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 56 },
                    { -115, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 52 },
                    { -113, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 48 },
                    { -111, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 44 },
                    { -109, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 40 },
                    { -107, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 36 },
                    { -105, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 32 },
                    { -103, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 28 },
                    { -101, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 24 },
                    { -99, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 20 },
                    { -97, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 16 },
                    { -95, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 12 },
                    { -93, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 8 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "CreatedAt", "HallId", "IsDeleted", "Label", "SeatNumber" },
                values: new object[,]
                {
                    { -91, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 4 },
                    { -89, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 45 },
                    { -87, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 42 },
                    { -85, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 39 },
                    { -83, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 36 },
                    { -81, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 33 },
                    { -79, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 30 },
                    { -77, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 27 },
                    { -75, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 24 },
                    { -73, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 21 },
                    { -71, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 18 },
                    { -69, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 15 },
                    { -67, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 12 },
                    { -65, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 9 },
                    { -61, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 3 },
                    { -10, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 5 },
                    { -243, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 18 },
                    { -247, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 36 },
                    { -423, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 30 },
                    { -421, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 15 },
                    { -419, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 210 },
                    { -417, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 196 },
                    { -415, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 182 },
                    { -413, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 168 },
                    { -411, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 154 },
                    { -409, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 140 },
                    { -407, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 126 },
                    { -405, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 112 },
                    { -403, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 98 },
                    { -401, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 84 },
                    { -425, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 45 },
                    { -399, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 70 },
                    { -395, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 42 },
                    { -393, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 28 },
                    { -391, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 14 },
                    { -389, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 195 },
                    { -387, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 182 },
                    { -385, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 169 },
                    { -383, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 156 },
                    { -381, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 143 },
                    { -379, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 130 },
                    { -377, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 117 },
                    { -375, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 104 },
                    { -373, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 91 },
                    { -397, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 56 },
                    { -427, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 60 },
                    { -429, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 75 },
                    { -431, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 90 },
                    { -6, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 3 },
                    { -4, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 2 },
                    { -2, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, false, null, 1 },
                    { -479, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 240 },
                    { -477, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 224 },
                    { -475, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 208 },
                    { -473, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 192 },
                    { -471, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 176 },
                    { -469, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 160 },
                    { -467, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 144 },
                    { -465, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 128 },
                    { -463, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 112 },
                    { -461, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 96 },
                    { -459, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 80 },
                    { -457, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 64 },
                    { -455, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 48 },
                    { -453, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 32 },
                    { -451, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 16 },
                    { -449, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 225 },
                    { -447, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 210 },
                    { -445, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 195 },
                    { -443, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 180 },
                    { -441, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 165 },
                    { -439, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 150 },
                    { -437, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 135 },
                    { -435, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 120 },
                    { -433, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 105 },
                    { -371, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 78 },
                    { -245, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 27 },
                    { -369, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 65 },
                    { -365, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 39 },
                    { -301, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 11 },
                    { -299, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 150 },
                    { -297, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 140 },
                    { -295, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 130 },
                    { -293, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 120 },
                    { -291, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 110 },
                    { -289, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 100 },
                    { -287, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 90 },
                    { -285, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 80 },
                    { -283, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 70 },
                    { -281, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 60 },
                    { -279, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 50 },
                    { -277, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 40 },
                    { -275, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 30 },
                    { -273, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 20 },
                    { -271, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 10 },
                    { -269, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 135 },
                    { -267, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 126 },
                    { -265, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 117 },
                    { -263, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 108 },
                    { -261, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 99 },
                    { -259, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 90 },
                    { -257, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 81 },
                    { -255, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 72 },
                    { -253, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 63 },
                    { -251, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 54 },
                    { -249, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 45 },
                    { -303, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 22 },
                    { -367, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 52 },
                    { -305, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 33 },
                    { -309, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 55 },
                    { -363, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 26 },
                    { -361, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 13 },
                    { -359, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 180 },
                    { -357, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 168 },
                    { -355, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 156 },
                    { -353, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 144 },
                    { -351, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 132 },
                    { -349, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 120 },
                    { -347, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 108 },
                    { -345, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 96 },
                    { -343, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 84 },
                    { -341, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 72 },
                    { -307, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 44 },
                    { -339, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 60 },
                    { -335, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 36 },
                    { -333, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 24 },
                    { -331, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 12 },
                    { -329, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 165 },
                    { -327, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 154 },
                    { -325, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 143 },
                    { -323, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 132 },
                    { -321, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 121 },
                    { -319, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 110 },
                    { -317, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 99 },
                    { -315, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 88 },
                    { -313, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 77 },
                    { -311, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 66 },
                    { -337, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 48 },
                    { -1, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, false, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId", "Deleted" },
                values: new object[] { 1, -1, false });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_AuthorId1",
                table: "Events",
                column: "AuthorId1");

            migrationBuilder.CreateIndex(
                name: "IX_Events_TypeId",
                table: "Events",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GenreMovies_GenreId",
                table: "GenreMovies",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_GenreMovies_MovieId",
                table: "GenreMovies",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_OfferTypeId",
                table: "Invoices",
                column: "OfferTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ReservationId",
                table: "Invoices",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_News_AuthorId1",
                table: "News",
                column: "AuthorId1");

            migrationBuilder.CreateIndex(
                name: "IX_News_TypeId",
                table: "News",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ScreeningId",
                table: "Reservations",
                column: "ScreeningId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId1",
                table: "Reservations",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_MovieId",
                table: "Reviews",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId1",
                table: "Reviews",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_HallId",
                table: "Screenings",
                column: "HallId");

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_MovieId",
                table: "Screenings",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_PricingId",
                table: "Screenings",
                column: "PricingId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatReservations_ReservationId",
                table: "SeatReservations",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatReservations_SeatId",
                table: "SeatReservations",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_HallId",
                table: "Seats",
                column: "HallId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "GenreMovies");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "SeatReservations");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "EventTypes");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "NewsTypes");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Screenings");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Halls");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Pricing");
        }
    }
}
