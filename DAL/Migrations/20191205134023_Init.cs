using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Init : Migration
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
                    ImageId = table.Column<Guid>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Services_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceEvents",
                columns: table => new
                {
                    ServiceId = table.Column<Guid>(nullable: false),
                    EventId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceEvents", x => new { x.EventId, x.ServiceId });
                    table.ForeignKey(
                        name: "FK_ServiceEvents_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceEvents_Services_ServiceId",
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
                    UserId = table.Column<string>(nullable: true),
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
                    table.ForeignKey(
                        name: "FK_ServicePlaces_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    ServicePlaceId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
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
                    table.ForeignKey(
                        name: "FK_EvenSchedules_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
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
                    EvenScheduleId = table.Column<Guid>(nullable: false)
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
                values: new object[,]
                {
                    { "487bdd19-dc0a-4208-911c-6141988e6b51", "fec61269-b058-4025-a9e2-2be6339f99d6", "SystemAdmin", "SYSTEMADMIN" },
                    { "59317E0A-8F55-46F9-BF5A-A81680A41964", "a17fe9fd-208a-4509-88ec-cf543683dd84", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4366b4cd-06f4-4d81-aeb5-7cd2d1795743", 0, "69e2da06-e712-4d4c-aa41-b510949bd6b9", "sysadmin@admin.hu", true, false, null, "sysadmin@admin.hu", "sysadmin", "AQAAAAEAACcQAAAAEAxy9Qxemjk637qfyYzIwnq2cFE1q4WmDCuTXmwtqUuV2epQii9Q2IWt0jZUJKDa4A==", null, false, "", false, "sysadmin" },
                    { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, "e24300d1-3cfa-4b1d-86dc-ec7b0854741b", "admin@admin.hu", true, false, null, "admin@admin.hu", "admin", "AQAAAAEAACcQAAAAECdopTSe+FdnrMB5N8dGDBw+/R/e1xMcqMkXXJ02GU/5HikIaMlDFA3bPK3veDVjwA==", null, false, "", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Content", "Extension", "Name" },
                values: new object[,]
                {
                    { new Guid("e4033899-118d-4664-b2b3-3c1f019a3820"), null, "svg", "t4.svg" },
                    { new Guid("fc24a599-e787-4f34-936e-51a3dd5de00d"), null, "png", "masszazs.png" },
                    { new Guid("6595544a-cc08-4cf7-b746-e195d2ac636f"), null, "png", "ftc.png" },
                    { new Guid("5404aafd-2dd5-4cfc-8196-c7f9de792105"), null, "png", "negyszogletu.png" },
                    { new Guid("8acfe208-054e-4f25-8ec8-45f94ae21311"), null, "png", "shazam.png" },
                    { new Guid("6286f9eb-0227-4db6-9a06-08d261095e30"), null, "png", "endgame.png" },
                    { new Guid("a6980a82-440d-4d0c-a72d-6955ef8830b1"), null, "png", "aquapark.png" },
                    { new Guid("383d3600-51b8-4b2e-9af6-d6432b95f92f"), null, "png", "madach.png" },
                    { new Guid("c911afe3-352c-4bd1-89be-3ac23a26a9ea"), null, "png", "groupama.png" },
                    { new Guid("973b4b03-f971-4c1b-ba17-edc59f592b00"), null, "png", "mom.png" },
                    { new Guid("49071411-213e-4822-9d5e-8a0354a762ce"), null, "png", "alle.png" },
                    { new Guid("61b5792a-a836-46ef-98c9-4d0af8225b52"), null, "png", "spa.png" },
                    { new Guid("8dea7035-43f2-4735-a309-a8bc566b0f80"), null, "png", "sport.png" },
                    { new Guid("f7b64fe4-cd58-4d4f-becb-cc10fa365cda"), null, "png", "theater.png" },
                    { new Guid("623a2c4d-614d-4bdd-9263-989a68ace1ea"), null, "png", "corvin_duma.png" },
                    { new Guid("34177eb6-e990-4cfa-8aa4-cd55a18f718e"), null, "png", "cinema.png" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "59317E0A-8F55-46F9-BF5A-A81680A41964" },
                    { "4366b4cd-06f4-4d81-aeb5-7cd2d1795743", "487bdd19-dc0a-4208-911c-6141988e6b51" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "ImageId", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("a8bf7e26-8032-4f8d-81b3-1ff33687450e"), "Thanos súlyos tette, amivel elpusztította az univerzum élőlényeinek felét és megtörte a Bosszúállókat, a megmaradt hősöket egy végső összecsapásra készteti a Marvel Studios huszonegy filmet megkoronázó, nagyszabású fináléjában, a Bosszúállók: Végjátékban.", new Guid("6286f9eb-0227-4db6-9a06-08d261095e30"), "Bosszúállók: Végjáték", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("6c6423ad-6127-4178-b834-b54bb12a67f6"), "Mindannyiunkban ott bujkál a szuperhős – de van, akiből elő is jön. Billy Batson 14 éves, egy árvaházból kerül nevelőszüleihez, és nem a legnépszerűbb srác az iskolában…de Shazam, az ősöreg, különleges erejű varázsló mégis kiválasztja. Amikor a srác hangosan kimondja: a varázsló nevét, átalakul. Igazi szuperhős válik belőle, annak minden kellékével: testhezálló, köpönyeggel kiegészített ruha, különleges eszközök, rendkívüli erő és meghökkentő képességek.", new Guid("8acfe208-054e-4f25-8ec8-45f94ae21311"), "Shazam!", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("bf6ba414-9aeb-4cf5-a8de-0cd3d6bcead1"), "Avagy a játéknak soha nincs vége", new Guid("5404aafd-2dd5-4cfc-8196-c7f9de792105"), "Négyszögletű Kerek Erdő", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("edaf3675-c590-4aa5-a581-7ec9815a5236"), "FÖRCH MAGYAR KUPA", new Guid("6595544a-cc08-4cf7-b746-e195d2ac636f"), "FTC-Telekom : DVTK", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("ee3c856d-a602-47a5-b4b0-dfc3f8e90b90"), "Egy óra.", new Guid("fc24a599-e787-4f34-936e-51a3dd5de00d"), "Pihentető masszás (1 óra)", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("928fbd5d-5a4c-47ab-98d9-c00e6c4a2e2b"), "Másfél óra.", new Guid("fc24a599-e787-4f34-936e-51a3dd5de00d"), "Pihentető masszás (1,5 óra)", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("5f9c19a7-0975-4f74-b033-6f09694b56d2"), "Két óra.", new Guid("fc24a599-e787-4f34-936e-51a3dd5de00d"), "Pihentető masszás (2 óra)", "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "ImageId", "Name" },
                values: new object[,]
                {
                    { new Guid("a74aa1d1-1037-4b68-930a-fa34d139461a"), new Guid("34177eb6-e990-4cfa-8aa4-cd55a18f718e"), "Mozik" },
                    { new Guid("de721af7-9653-41c2-8eeb-7bce758358d0"), new Guid("f7b64fe4-cd58-4d4f-becb-cc10fa365cda"), "Színházak" },
                    { new Guid("07103174-dbdd-4b26-ab03-01f45ab25b19"), new Guid("8dea7035-43f2-4735-a309-a8bc566b0f80"), "Sport" },
                    { new Guid("e1d8259c-0ef8-4a7a-b97c-5aa277e51955"), new Guid("61b5792a-a836-46ef-98c9-4d0af8225b52"), "Szabadidő" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "ImageId", "Name", "Street", "TypeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("509c677e-a9f1-49be-b778-0c2141b083eb"), "Budapest", "A 13 termes Cinema City Allee 2009. óta várja vendégeit a legjobb premier filmekkel - egyik termében kizárólag eredeti nyelvű filmvetítésekkel - az év minden napján. Nyitvatartás: pénztárnyitás az első előadás előtt 30 perccel, pénztár zárás az utolsó előadás kezdete után 15 perccel.", new Guid("49071411-213e-4822-9d5e-8a0354a762ce"), "CinemaCity Alle", "Október huszonharmadika u. 8-10", new Guid("a74aa1d1-1037-4b68-930a-fa34d139461a"), null },
                    { new Guid("cae1e812-907c-479c-8ab5-2bed84d2869d"), "Budapest", "A CINEMApink MOM Park a jelenleg elérhető legjobb képminőséggel, prémium hangrendszerrel, kényelmi extrákkal és a legújabb sikerfilmekkel várja!", new Guid("973b4b03-f971-4c1b-ba17-edc59f592b00"), "CINEMApink MOM Park", "Alkotás u. 53", new Guid("a74aa1d1-1037-4b68-930a-fa34d139461a"), null },
                    { new Guid("942809d9-4a6d-4d4f-aed5-894916cf851f"), "Budapest", "Madách Színház néven több színházi vállalkozás is létrejött századunkban Budapesten. 1919-ben a Zeneakadémia kistermében Madách Színház néven kísérletezett egy társulat, mely zömmel a frontról hazatért, szerződés nélküli színészekből alakult. Alig több mint egy évig működtek, új típusú programmal indultak, legnagyobb sikerük a százas szériát futó Holnap reggel című Karinthy Frigyes dráma előadása.", new Guid("383d3600-51b8-4b2e-9af6-d6432b95f92f"), "Madách Színház", "Erzsébet krt. 29-33", new Guid("de721af7-9653-41c2-8eeb-7bce758358d0"), null },
                    { new Guid("bf3f6cad-67a5-43b0-ae18-cb5d96acff7c"), "Budapest", "Corvin Dumaszínház", new Guid("623a2c4d-614d-4bdd-9263-989a68ace1ea"), "Corvin Dumaszínház", "Corvin sétány 1 1/b", new Guid("de721af7-9653-41c2-8eeb-7bce758358d0"), null },
                    { new Guid("8c3b7421-23f1-4537-bc7d-605bfc964c2e"), "Budapest", "„BEST OF BUDAPEST & HUNGARY 2017” DÍJAT NYERT A FRADI OTTHONA, A GROUPAMA ARÉNA!", new Guid("c911afe3-352c-4bd1-89be-3ac23a26a9ea"), "Groupama Aréna", "Üllői út 129", new Guid("07103174-dbdd-4b26-ab03-01f45ab25b19"), null },
                    { new Guid("e6ef6fbf-652b-492f-b661-d64d28db3091"), "Budapest", "Ha többre vágysz egy átlagos pihenésnél... nálunk egyszerre átélheted akár egy kényeztető wellness hétvége minden jótékony hatását vagy gyermekként élvezheted az Aquaworld élményekkel teli világát.", new Guid("a6980a82-440d-4d0c-a72d-6955ef8830b1"), "Aquaworld Resort Budapest", "Íves út 16", new Guid("e1d8259c-0ef8-4a7a-b97c-5aa277e51955"), null }
                });

            migrationBuilder.InsertData(
                table: "ServiceEvents",
                columns: new[] { "EventId", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("a8bf7e26-8032-4f8d-81b3-1ff33687450e"), new Guid("509c677e-a9f1-49be-b778-0c2141b083eb") },
                    { new Guid("6c6423ad-6127-4178-b834-b54bb12a67f6"), new Guid("509c677e-a9f1-49be-b778-0c2141b083eb") },
                    { new Guid("a8bf7e26-8032-4f8d-81b3-1ff33687450e"), new Guid("cae1e812-907c-479c-8ab5-2bed84d2869d") },
                    { new Guid("6c6423ad-6127-4178-b834-b54bb12a67f6"), new Guid("cae1e812-907c-479c-8ab5-2bed84d2869d") },
                    { new Guid("bf6ba414-9aeb-4cf5-a8de-0cd3d6bcead1"), new Guid("942809d9-4a6d-4d4f-aed5-894916cf851f") },
                    { new Guid("edaf3675-c590-4aa5-a581-7ec9815a5236"), new Guid("8c3b7421-23f1-4537-bc7d-605bfc964c2e") },
                    { new Guid("ee3c856d-a602-47a5-b4b0-dfc3f8e90b90"), new Guid("e6ef6fbf-652b-492f-b661-d64d28db3091") },
                    { new Guid("928fbd5d-5a4c-47ab-98d9-c00e6c4a2e2b"), new Guid("e6ef6fbf-652b-492f-b661-d64d28db3091") },
                    { new Guid("5f9c19a7-0975-4f74-b033-6f09694b56d2"), new Guid("e6ef6fbf-652b-492f-b661-d64d28db3091") }
                });

            migrationBuilder.InsertData(
                table: "ServicePlaces",
                columns: new[] { "Id", "LayoutImageId", "Name", "ServiceId", "UserId" },
                values: new object[] { new Guid("6ded3dfc-82a5-4c21-8440-d47910ba11e8"), new Guid("e4033899-118d-4664-b2b3-3c1f019a3820"), "4 helyes terem(allee)", new Guid("509c677e-a9f1-49be-b778-0c2141b083eb"), null });

            migrationBuilder.InsertData(
                table: "EvenSchedules",
                columns: new[] { "Id", "Description", "EventId", "From", "ServiceId", "ServicePlaceId", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("817e3e23-75bf-40c9-b9e1-aef15fb3374b"), "", new Guid("a8bf7e26-8032-4f8d-81b3-1ff33687450e"), new DateTime(2019, 12, 5, 14, 40, 21, 925, DateTimeKind.Local), new Guid("509c677e-a9f1-49be-b778-0c2141b083eb"), new Guid("6ded3dfc-82a5-4c21-8440-d47910ba11e8"), new DateTime(2019, 12, 5, 16, 40, 21, 928, DateTimeKind.Local), null },
                    { new Guid("392ba299-50b9-4828-815c-a0fce1269a19"), "", new Guid("a8bf7e26-8032-4f8d-81b3-1ff33687450e"), new DateTime(2019, 12, 5, 16, 40, 21, 928, DateTimeKind.Local), new Guid("509c677e-a9f1-49be-b778-0c2141b083eb"), new Guid("6ded3dfc-82a5-4c21-8440-d47910ba11e8"), new DateTime(2019, 12, 5, 18, 40, 21, 928, DateTimeKind.Local), null }
                });

            migrationBuilder.InsertData(
                table: "ServicePlacePositions",
                columns: new[] { "Id", "Name", "ServicePlaceId" },
                values: new object[,]
                {
                    { new Guid("bee08999-8585-4561-8bfc-e5d050c64f32"), "A1", new Guid("6ded3dfc-82a5-4c21-8440-d47910ba11e8") },
                    { new Guid("f26730fc-986b-4255-8aaf-e97b0b147c4d"), "A2", new Guid("6ded3dfc-82a5-4c21-8440-d47910ba11e8") },
                    { new Guid("71022dc9-4e62-470b-97a9-98bd8d04657e"), "A3", new Guid("6ded3dfc-82a5-4c21-8440-d47910ba11e8") },
                    { new Guid("b6b432c0-810c-4289-9560-2caeb6476d07"), "A4", new Guid("6ded3dfc-82a5-4c21-8440-d47910ba11e8") }
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
                name: "IX_EvenSchedules_UserId",
                table: "EvenSchedules",
                column: "UserId");

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
                name: "IX_ServiceEvents_ServiceId",
                table: "ServiceEvents",
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
                name: "IX_ServicePlaces_UserId",
                table: "ServicePlaces",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ImageId",
                table: "Services",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_TypeId",
                table: "Services",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_UserId",
                table: "Services",
                column: "UserId");

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
                name: "ServiceEvents");

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
                name: "Services");

            migrationBuilder.DropTable(
                name: "ServiceTypes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
