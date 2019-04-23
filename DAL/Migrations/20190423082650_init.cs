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
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Events_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ServiceEvent_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_EvenSchedules_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_EvenSchedules_ServicePlaces_ServicePlaceId",
                        column: x => x.ServicePlaceId,
                        principalTable: "ServicePlaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
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
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "BookingPositions",
                columns: table => new
                {
                    BookingId = table.Column<Guid>(nullable: false),
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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BookingPositions_ServicePlacePositions_ServicePlacePositionId",
                        column: x => x.ServicePlacePositionId,
                        principalTable: "ServicePlacePositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PendingBookingPositions_ServicePlacePositions_ServicePlacePositionId",
                        column: x => x.ServicePlacePositionId,
                        principalTable: "ServicePlacePositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "a4732752-a4e8-4dd0-a5f8-b520ff0a7d02", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, "9e642be5-8d92-4b14-8397-7c29f4194de1", "admin@admin.hu", true, false, null, "admin@admin.hu", "admin", "AQAAAAEAACcQAAAAEDDU75dr919rxbZmBumhxtY1ZW++5BvyJJY9KtY/1nVD6TadDTaXH3NKbnyR6SFvmQ==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Content", "Extension", "Name" },
                values: new object[,]
                {
                    { new Guid("fbc46f23-6780-4084-a996-33ee563dfe19"), null, "jpg", "Shazam.jpg" },
                    { new Guid("3e9aa31d-37c6-45c4-b6c9-4fc793df9740"), null, "jpg", "Negyszogletu.jpg" }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "ImageId", "Name" },
                values: new object[,]
                {
                    { new Guid("5bb6d28c-122c-4de6-8fe9-b7e994a01beb"), null, "Mozi" },
                    { new Guid("17d5da61-4c53-4d74-b14a-655a1f9f6f5f"), null, "Színház" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "a18be9c0-aa65-4af8-bd17-00bd9344e575" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "ImageId", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("fc3d3845-9e94-4672-945c-12f070de4c35"), null, new Guid("fbc46f23-6780-4084-a996-33ee563dfe19"), "Shazam!", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("c36d4669-1a8a-4bd3-99fa-1d15101ad67c"), null, new Guid("3e9aa31d-37c6-45c4-b6c9-4fc793df9740"), "Négyszögletű Kerek Erdő", "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "ImageId", "Name", "Street", "TypeId" },
                values: new object[,]
                {
                    { new Guid("f760356c-da89-4064-a6bf-65b04fdcbdfd"), "Budapest", "Allee Cinema City mozi", null, "Allee CC", "Október huszonharmadika u. 8-10", new Guid("5bb6d28c-122c-4de6-8fe9-b7e994a01beb") },
                    { new Guid("91a6f2ff-9514-4745-bd16-84f39faa1021"), "Pécs", "Pécs Cinema City mozi", null, "Pécs Plaza CC", "Megyeri út 76.", new Guid("5bb6d28c-122c-4de6-8fe9-b7e994a01beb") },
                    { new Guid("7ce7df2e-d035-40d6-b5f7-a04de6e51092"), "Budapest", null, null, "Madách Színház", "Erzsébet krt. 29-33.", new Guid("17d5da61-4c53-4d74-b14a-655a1f9f6f5f") }
                });

            migrationBuilder.InsertData(
                table: "ServiceEvent",
                columns: new[] { "EventId", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("fc3d3845-9e94-4672-945c-12f070de4c35"), new Guid("f760356c-da89-4064-a6bf-65b04fdcbdfd") },
                    { new Guid("fc3d3845-9e94-4672-945c-12f070de4c35"), new Guid("91a6f2ff-9514-4745-bd16-84f39faa1021") },
                    { new Guid("c36d4669-1a8a-4bd3-99fa-1d15101ad67c"), new Guid("7ce7df2e-d035-40d6-b5f7-a04de6e51092") }
                });

            migrationBuilder.InsertData(
                table: "ServicePlaces",
                columns: new[] { "Id", "LayoutImageId", "Name", "ServiceId" },
                values: new object[] { new Guid("af9a038d-4e2b-41af-8b92-b39902cad66e"), null, "Anyád", new Guid("f760356c-da89-4064-a6bf-65b04fdcbdfd") });

            migrationBuilder.InsertData(
                table: "EvenSchedules",
                columns: new[] { "Id", "Description", "EventId", "From", "ServiceId", "ServicePlaceId", "To" },
                values: new object[] { new Guid("7c5ad244-bcc8-498b-8dcc-16107532573e"), "Shazam bemutató", new Guid("fc3d3845-9e94-4672-945c-12f070de4c35"), new DateTime(2019, 4, 23, 10, 26, 49, 825, DateTimeKind.Local), new Guid("f760356c-da89-4064-a6bf-65b04fdcbdfd"), new Guid("af9a038d-4e2b-41af-8b92-b39902cad66e"), new DateTime(2019, 4, 23, 12, 26, 49, 829, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "ServicePlacePositions",
                columns: new[] { "Id", "Name", "ServicePlaceId" },
                values: new object[,]
                {
                    { new Guid("04faa239-1355-40ce-9369-05b9f8ff4bce"), "I1", new Guid("af9a038d-4e2b-41af-8b92-b39902cad66e") },
                    { new Guid("f33a6d2b-8e76-4215-af72-678c5049dca7"), "I2", new Guid("af9a038d-4e2b-41af-8b92-b39902cad66e") },
                    { new Guid("92197a7e-197b-40dd-9cad-299a6ba54034"), "I3", new Guid("af9a038d-4e2b-41af-8b92-b39902cad66e") },
                    { new Guid("93545c62-ff98-47d7-ab84-5ca0f8eb9870"), "I4", new Guid("af9a038d-4e2b-41af-8b92-b39902cad66e") }
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
