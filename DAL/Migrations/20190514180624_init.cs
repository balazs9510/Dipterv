using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
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
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Content = table.Column<byte[]>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    ImageId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Events_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    ImageId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceTypes_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    City = table.Column<string>(maxLength: 250, nullable: false),
                    Street = table.Column<string>(maxLength: 300, nullable: false),
                    TypeId = table.Column<Guid>(nullable: false),
                    ImageId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Services_ServiceTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "ServiceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceEvent",
                columns: table => new
                {
                    ServiceId = table.Column<Guid>(nullable: false),
                    EventId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceEvent", x => new { x.EventId, x.ServiceId });
                    table.ForeignKey(
                        name: "FK_ServiceEvent_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceEvent_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServicePlaces",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    ServiceId = table.Column<Guid>(nullable: false),
                    LayoutImageId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicePlaces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServicePlaces_Images_LayoutImageId",
                        column: x => x.LayoutImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServicePlaces_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvenSchedules",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    From = table.Column<DateTime>(nullable: false),
                    To = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    EventId = table.Column<Guid>(nullable: false),
                    ServiceId = table.Column<Guid>(nullable: false),
                    ServicePlaceId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvenSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvenSchedules_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EvenSchedules_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EvenSchedules_ServicePlaces_ServicePlaceId",
                        column: x => x.ServicePlaceId,
                        principalTable: "ServicePlaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServicePlacePositions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 10, nullable: false),
                    ServicePlaceId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicePlacePositions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServicePlacePositions_ServicePlaces_ServicePlaceId",
                        column: x => x.ServicePlaceId,
                        principalTable: "ServicePlaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    ScheduleId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_EvenSchedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "EvenSchedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PendingBookings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    EvenScheduleId = table.Column<Guid>(nullable: false),
                    ClientId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PendingBookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PendingBookings_EvenSchedules_EvenScheduleId",
                        column: x => x.EvenScheduleId,
                        principalTable: "EvenSchedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingPositions",
                columns: table => new
                {
                    BookingId = table.Column<string>(nullable: false),
                    ServicePlacePositionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingPositions", x => new { x.BookingId, x.ServicePlacePositionId });
                    table.ForeignKey(
                        name: "FK_BookingPositions_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookingPositions_ServicePlacePositions_ServicePlacePositionId",
                        column: x => x.ServicePlacePositionId,
                        principalTable: "ServicePlacePositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PendingBookingPositions",
                columns: table => new
                {
                    PendingBookingId = table.Column<Guid>(nullable: false),
                    ServicePlacePositionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PendingBookingPositions", x => new { x.PendingBookingId, x.ServicePlacePositionId });
                    table.ForeignKey(
                        name: "FK_PendingBookingPositions_PendingBookings_PendingBookingId",
                        column: x => x.PendingBookingId,
                        principalTable: "PendingBookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PendingBookingPositions_ServicePlacePositions_ServicePlacePositionId",
                        column: x => x.ServicePlacePositionId,
                        principalTable: "ServicePlacePositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "59317E0A-8F55-46F9-BF5A-A81680A41964", "b5fe7c04-c43f-4ead-bf42-b9405e23c6c5", "Administrators", "ADMINISTRATORS" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, "c2c894d9-e835-4c09-b4ac-f8d18254a5c4", "admin@admin.hu", true, false, null, "admin@admin.hu", "admin", "AQAAAAEAACcQAAAAEHHO4fYEN4QG9yuKtpmp/r1+SjUpv9m8hwyQTeZaLYS+xusQaV8ULqowuyPtrnwMiw==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Content", "Extension", "Name" },
                values: new object[,]
                {
                    { new Guid("e442453f-b7ca-408c-8f24-7b0ff5327e72"), null, "svg", "t10.svg" },
                    { new Guid("965f9442-bcb0-4c85-bfe7-86bab000a7d4"), null, "svg", "t4.svg" },
                    { new Guid("67e3d99f-ccc0-4be2-a327-a28e0f50ce56"), null, "png", "masszazs.png" },
                    { new Guid("f4b731b0-a8fe-48f9-ab46-d98c442dc496"), null, "png", "ftc.png" },
                    { new Guid("897f9b1f-a950-4129-af5b-4079a315c381"), null, "png", "negyszogletu.png" },
                    { new Guid("03874a74-d7f8-4502-8ee5-2653b7ae7661"), null, "png", "shazam.png" },
                    { new Guid("7625ad1e-0c3a-4a0d-b15f-867a0395473a"), null, "png", "endgame.png" },
                    { new Guid("cb441dcd-d655-4ed8-be36-663a1432972e"), null, "png", "aquapark.png" },
                    { new Guid("727c2383-97e7-4fc1-a409-ccef46e1d795"), null, "png", "madach.png" },
                    { new Guid("7768477f-3e2d-4ee1-adc1-d5f1132ca612"), null, "png", "groupama.png" },
                    { new Guid("2b9214a6-b007-482d-8718-cc2b47a165fd"), null, "png", "mom.png" },
                    { new Guid("297f8fa9-48cb-42b9-a5c1-91b98b458b36"), null, "png", "alle.png" },
                    { new Guid("385f82c0-58cd-4686-a75c-2bd6de275bee"), null, "png", "spa.png" },
                    { new Guid("38e8da3d-48b0-488f-a2b9-672be52268b9"), null, "png", "sport.png" },
                    { new Guid("aa634a39-46cc-4d76-b2ab-ded146b436cc"), null, "png", "theater.png" },
                    { new Guid("4b598c83-00d9-4925-bf0a-015a5fc2c546"), null, "png", "corvin_duma.png" },
                    { new Guid("03c964c8-cc59-4ec5-9cdf-f830faeb3ab1"), null, "png", "cinema.png" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "59317E0A-8F55-46F9-BF5A-A81680A41964" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "ImageId", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("0dbdbf3f-7517-4967-bfa4-b01d6d29bceb"), "Thanos súlyos tette, amivel elpusztította az univerzum élőlényeinek felét és megtörte a Bosszúállókat, a megmaradt hősöket egy végső összecsapásra készteti a Marvel Studios huszonegy filmet megkoronázó, nagyszabású fináléjában, a Bosszúállók: Végjátékban.", new Guid("7625ad1e-0c3a-4a0d-b15f-867a0395473a"), "Bosszúállók: Végjáték", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("5cfe8311-cb39-4e30-8787-a2e37774c4b9"), "Mindannyiunkban ott bujkál a szuperhős – de van, akiből elő is jön. Billy Batson 14 éves, egy árvaházból kerül nevelőszüleihez, és nem a legnépszerűbb srác az iskolában…de Shazam, az ősöreg, különleges erejű varázsló mégis kiválasztja. Amikor a srác hangosan kimondja: a varázsló nevét, átalakul. Igazi szuperhős válik belőle, annak minden kellékével: testhezálló, köpönyeggel kiegészített ruha, különleges eszközök, rendkívüli erő és meghökkentő képességek.", new Guid("03874a74-d7f8-4502-8ee5-2653b7ae7661"), "Shazam!", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("23c78cc0-e33e-4787-84b3-2a2ee319ec13"), "Avagy a játéknak soha nincs vége", new Guid("897f9b1f-a950-4129-af5b-4079a315c381"), "Négyszögletű Kerek Erdő", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("a0eb86cd-1c65-47dc-8178-22f4e46fd73c"), "FÖRCH MAGYAR KUPA", new Guid("f4b731b0-a8fe-48f9-ab46-d98c442dc496"), "FTC-Telekom : DVTK", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("08c9a0b9-c86f-4454-acd3-51f03b3ee434"), "Egy óra.", new Guid("67e3d99f-ccc0-4be2-a327-a28e0f50ce56"), "Pihentető masszás (1 óra)", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("b86063bf-2249-4800-82f6-c653a9ee4f90"), "Másfél óra.", new Guid("67e3d99f-ccc0-4be2-a327-a28e0f50ce56"), "Pihentető masszás (1,5 óra)", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("2872da91-24ac-446c-940f-3a3de122d318"), "Két óra.", new Guid("67e3d99f-ccc0-4be2-a327-a28e0f50ce56"), "Pihentető masszás (2 óra)", "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "ImageId", "Name" },
                values: new object[,]
                {
                    { new Guid("279f65a3-39b2-4e7c-94f2-cb11420bba4c"), new Guid("03c964c8-cc59-4ec5-9cdf-f830faeb3ab1"), "Mozik" },
                    { new Guid("1fee0599-3ba1-48f1-b1aa-74b4a8a3acca"), new Guid("aa634a39-46cc-4d76-b2ab-ded146b436cc"), "Színházak" },
                    { new Guid("048be27e-bfb2-4bef-a03d-02a891d16197"), new Guid("38e8da3d-48b0-488f-a2b9-672be52268b9"), "Sport" },
                    { new Guid("7656296e-dccd-4e6a-8dc9-ff9d46205de1"), new Guid("385f82c0-58cd-4686-a75c-2bd6de275bee"), "Szabadidő" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "ImageId", "Name", "Street", "TypeId" },
                values: new object[,]
                {
                    { new Guid("41e9be60-6648-4d59-8d6f-b173def33981"), "Budapest", "A 13 termes Cinema City Allee 2009. óta várja vendégeit a legjobb premier filmekkel - egyik termében kizárólag eredeti nyelvű filmvetítésekkel - az év minden napján. Nyitvatartás: pénztárnyitás az első előadás előtt 30 perccel, pénztár zárás az utolsó előadás kezdete után 15 perccel.", new Guid("297f8fa9-48cb-42b9-a5c1-91b98b458b36"), "CinemaCity Alle", "Október huszonharmadika u. 8-10", new Guid("279f65a3-39b2-4e7c-94f2-cb11420bba4c") },
                    { new Guid("e0b4e09c-27f8-4bd8-9911-756ef749f5ad"), "Budapest", "A CINEMApink MOM Park a jelenleg elérhető legjobb képminőséggel, prémium hangrendszerrel, kényelmi extrákkal és a legújabb sikerfilmekkel várja!", new Guid("2b9214a6-b007-482d-8718-cc2b47a165fd"), "CINEMApink MOM Park", "Alkotás u. 53", new Guid("279f65a3-39b2-4e7c-94f2-cb11420bba4c") },
                    { new Guid("68cd14af-0138-44b1-99dd-85ea813e1679"), "Budapest", "Madách Színház néven több színházi vállalkozás is létrejött századunkban Budapesten. 1919-ben a Zeneakadémia kistermében Madách Színház néven kísérletezett egy társulat, mely zömmel a frontról hazatért, szerződés nélküli színészekből alakult. Alig több mint egy évig működtek, új típusú programmal indultak, legnagyobb sikerük a százas szériát futó Holnap reggel című Karinthy Frigyes dráma előadása.", new Guid("727c2383-97e7-4fc1-a409-ccef46e1d795"), "Madách Színház", "Erzsébet krt. 29-33", new Guid("1fee0599-3ba1-48f1-b1aa-74b4a8a3acca") },
                    { new Guid("26aba2be-ccb6-43d7-a740-afae6609f082"), "Budapest", "Corvin Dumaszínház", new Guid("4b598c83-00d9-4925-bf0a-015a5fc2c546"), "Corvin Dumaszínház", "Corvin sétány 1 1/b", new Guid("1fee0599-3ba1-48f1-b1aa-74b4a8a3acca") },
                    { new Guid("dc164a23-0aa3-4c82-b2eb-06b0b88b33ba"), "Budapest", "„BEST OF BUDAPEST & HUNGARY 2017” DÍJAT NYERT A FRADI OTTHONA, A GROUPAMA ARÉNA!", new Guid("7768477f-3e2d-4ee1-adc1-d5f1132ca612"), "Groupama Aréna", "Üllői út 129", new Guid("048be27e-bfb2-4bef-a03d-02a891d16197") },
                    { new Guid("a8bfd4a5-befe-4e26-a683-33327067c8e7"), "Budapest", "Ha többre vágysz egy átlagos pihenésnél... nálunk egyszerre átélheted akár egy kényeztető wellness hétvége minden jótékony hatását vagy gyermekként élvezheted az Aquaworld élményekkel teli világát.", new Guid("cb441dcd-d655-4ed8-be36-663a1432972e"), "Aquaworld Resort Budapest", "Íves út 16", new Guid("7656296e-dccd-4e6a-8dc9-ff9d46205de1") }
                });

            migrationBuilder.InsertData(
                table: "ServiceEvent",
                columns: new[] { "EventId", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("0dbdbf3f-7517-4967-bfa4-b01d6d29bceb"), new Guid("41e9be60-6648-4d59-8d6f-b173def33981") },
                    { new Guid("5cfe8311-cb39-4e30-8787-a2e37774c4b9"), new Guid("41e9be60-6648-4d59-8d6f-b173def33981") },
                    { new Guid("0dbdbf3f-7517-4967-bfa4-b01d6d29bceb"), new Guid("e0b4e09c-27f8-4bd8-9911-756ef749f5ad") },
                    { new Guid("5cfe8311-cb39-4e30-8787-a2e37774c4b9"), new Guid("e0b4e09c-27f8-4bd8-9911-756ef749f5ad") },
                    { new Guid("23c78cc0-e33e-4787-84b3-2a2ee319ec13"), new Guid("68cd14af-0138-44b1-99dd-85ea813e1679") },
                    { new Guid("a0eb86cd-1c65-47dc-8178-22f4e46fd73c"), new Guid("dc164a23-0aa3-4c82-b2eb-06b0b88b33ba") },
                    { new Guid("08c9a0b9-c86f-4454-acd3-51f03b3ee434"), new Guid("a8bfd4a5-befe-4e26-a683-33327067c8e7") },
                    { new Guid("b86063bf-2249-4800-82f6-c653a9ee4f90"), new Guid("a8bfd4a5-befe-4e26-a683-33327067c8e7") },
                    { new Guid("2872da91-24ac-446c-940f-3a3de122d318"), new Guid("a8bfd4a5-befe-4e26-a683-33327067c8e7") }
                });

            migrationBuilder.InsertData(
                table: "ServicePlaces",
                columns: new[] { "Id", "LayoutImageId", "Name", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("b577a8be-b0b3-41a6-83d5-707c079c1f55"), new Guid("965f9442-bcb0-4c85-bfe7-86bab000a7d4"), "4 helyes terem(allee)", new Guid("41e9be60-6648-4d59-8d6f-b173def33981") },
                    { new Guid("22b5f743-76b3-4559-a67e-05440d0a7566"), new Guid("965f9442-bcb0-4c85-bfe7-86bab000a7d4"), "4 helyes terem(mom)", new Guid("e0b4e09c-27f8-4bd8-9911-756ef749f5ad") },
                    { new Guid("c8ecb943-d195-453d-8025-46e19cffdaa5"), new Guid("965f9442-bcb0-4c85-bfe7-86bab000a7d4"), "4 helyes terem (madách)", new Guid("68cd14af-0138-44b1-99dd-85ea813e1679") },
                    { new Guid("47eb7711-2dea-4f0d-b4b2-2ac4861242fe"), new Guid("e442453f-b7ca-408c-8f24-7b0ff5327e72"), "10 helyes terem (groupama)", new Guid("dc164a23-0aa3-4c82-b2eb-06b0b88b33ba") },
                    { new Guid("9cb1387c-c1ba-4905-9117-4fd925ae2608"), new Guid("965f9442-bcb0-4c85-bfe7-86bab000a7d4"), "4 helyes terem (aquaworld)", new Guid("a8bfd4a5-befe-4e26-a683-33327067c8e7") }
                });

            migrationBuilder.InsertData(
                table: "EvenSchedules",
                columns: new[] { "Id", "Description", "EventId", "From", "ServiceId", "ServicePlaceId", "To" },
                values: new object[,]
                {
                    { new Guid("947bce20-0d33-4603-8913-914e3085ff0b"), "", new Guid("0dbdbf3f-7517-4967-bfa4-b01d6d29bceb"), new DateTime(2019, 5, 14, 20, 6, 23, 761, DateTimeKind.Local), new Guid("41e9be60-6648-4d59-8d6f-b173def33981"), new Guid("b577a8be-b0b3-41a6-83d5-707c079c1f55"), new DateTime(2019, 5, 14, 22, 6, 23, 765, DateTimeKind.Local) },
                    { new Guid("74a70a06-ba76-45fb-b690-4ee3269fc301"), "", new Guid("0dbdbf3f-7517-4967-bfa4-b01d6d29bceb"), new DateTime(2019, 5, 14, 22, 6, 23, 765, DateTimeKind.Local), new Guid("41e9be60-6648-4d59-8d6f-b173def33981"), new Guid("b577a8be-b0b3-41a6-83d5-707c079c1f55"), new DateTime(2019, 5, 15, 0, 6, 23, 765, DateTimeKind.Local) },
                    { new Guid("f950005c-da88-4a5a-b049-6c72df637df3"), "", new Guid("0dbdbf3f-7517-4967-bfa4-b01d6d29bceb"), new DateTime(2019, 5, 14, 20, 6, 23, 761, DateTimeKind.Local), new Guid("41e9be60-6648-4d59-8d6f-b173def33981"), new Guid("22b5f743-76b3-4559-a67e-05440d0a7566"), new DateTime(2019, 5, 14, 22, 6, 23, 765, DateTimeKind.Local) },
                    { new Guid("b0008e62-df01-469d-9800-ae6e0fabfeb3"), "", new Guid("0dbdbf3f-7517-4967-bfa4-b01d6d29bceb"), new DateTime(2019, 5, 14, 22, 6, 23, 765, DateTimeKind.Local), new Guid("e0b4e09c-27f8-4bd8-9911-756ef749f5ad"), new Guid("22b5f743-76b3-4559-a67e-05440d0a7566"), new DateTime(2019, 5, 15, 0, 6, 23, 765, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "ServicePlacePositions",
                columns: new[] { "Id", "Name", "ServicePlaceId" },
                values: new object[,]
                {
                    { new Guid("bdf11c3f-bbec-4fe0-92e2-62e55d47d03c"), "A2", new Guid("9cb1387c-c1ba-4905-9117-4fd925ae2608") },
                    { new Guid("bb3a80c1-f7da-4729-a001-4a65d61de844"), "A1", new Guid("9cb1387c-c1ba-4905-9117-4fd925ae2608") },
                    { new Guid("7885ae73-58ff-47e1-ab3b-010db458987b"), "A4", new Guid("c8ecb943-d195-453d-8025-46e19cffdaa5") },
                    { new Guid("d7465d8a-3c2c-4f6d-9d37-6e47b78af3b9"), "A3", new Guid("c8ecb943-d195-453d-8025-46e19cffdaa5") },
                    { new Guid("12c4e609-43d3-4957-9221-b47baafb4e5b"), "A2", new Guid("c8ecb943-d195-453d-8025-46e19cffdaa5") },
                    { new Guid("4237d65d-7a8b-4e3a-8e90-53255a828f8c"), "A1", new Guid("c8ecb943-d195-453d-8025-46e19cffdaa5") },
                    { new Guid("dc6428c4-4dde-43ea-89cb-f0914ba9852a"), "A4", new Guid("22b5f743-76b3-4559-a67e-05440d0a7566") },
                    { new Guid("2e41f38e-d6ed-4bfa-a0c9-225f052384f8"), "A2", new Guid("22b5f743-76b3-4559-a67e-05440d0a7566") },
                    { new Guid("02fb5dc2-05c6-4625-afb3-273bd408fbb7"), "A3", new Guid("9cb1387c-c1ba-4905-9117-4fd925ae2608") },
                    { new Guid("d84b368c-5b1b-4b42-b600-553309db8ba2"), "A1", new Guid("22b5f743-76b3-4559-a67e-05440d0a7566") },
                    { new Guid("b6b432c0-810c-4289-9560-2caeb6476d07"), "A4", new Guid("b577a8be-b0b3-41a6-83d5-707c079c1f55") },
                    { new Guid("71022dc9-4e62-470b-97a9-98bd8d04657e"), "A3", new Guid("b577a8be-b0b3-41a6-83d5-707c079c1f55") },
                    { new Guid("f26730fc-986b-4255-8aaf-e97b0b147c4d"), "A2", new Guid("b577a8be-b0b3-41a6-83d5-707c079c1f55") },
                    { new Guid("bee08999-8585-4561-8bfc-e5d050c64f32"), "A1", new Guid("b577a8be-b0b3-41a6-83d5-707c079c1f55") },
                    { new Guid("49089f47-e42d-401e-9d6f-c4994778d231"), "A3", new Guid("22b5f743-76b3-4559-a67e-05440d0a7566") },
                    { new Guid("8e76cf6a-3832-49f2-ba0c-a2b06cd614a4"), "A4", new Guid("9cb1387c-c1ba-4905-9117-4fd925ae2608") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BookingPositions_ServicePlacePositionId",
                table: "BookingPositions",
                column: "ServicePlacePositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ScheduleId",
                table: "Bookings",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_EvenSchedules_EventId",
                table: "EvenSchedules",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EvenSchedules_ServiceId",
                table: "EvenSchedules",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_EvenSchedules_ServicePlaceId",
                table: "EvenSchedules",
                column: "ServicePlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_ImageId",
                table: "Events",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserId",
                table: "Events",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PendingBookingPositions_ServicePlacePositionId",
                table: "PendingBookingPositions",
                column: "ServicePlacePositionId");

            migrationBuilder.CreateIndex(
                name: "IX_PendingBookings_EvenScheduleId",
                table: "PendingBookings",
                column: "EvenScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceEvent_ServiceId",
                table: "ServiceEvent",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicePlacePositions_ServicePlaceId",
                table: "ServicePlacePositions",
                column: "ServicePlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicePlaces_LayoutImageId",
                table: "ServicePlaces",
                column: "LayoutImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicePlaces_ServiceId",
                table: "ServicePlaces",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ImageId",
                table: "Services",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_TypeId",
                table: "Services",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceTypes_ImageId",
                table: "ServiceTypes",
                column: "ImageId");
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
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BookingPositions");

            migrationBuilder.DropTable(
                name: "PendingBookingPositions");

            migrationBuilder.DropTable(
                name: "ServiceEvent");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "PendingBookings");

            migrationBuilder.DropTable(
                name: "ServicePlacePositions");

            migrationBuilder.DropTable(
                name: "EvenSchedules");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "ServicePlaces");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "ServiceTypes");

            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
