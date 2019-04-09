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
                    ServiceId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicePlaces", x => x.Id);
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
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "0fe4169b-aca1-4418-8089-ed17c5ad8b29", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, "fc239f1a-2280-4d55-bd24-14c91fb31419", "admin@admin.hu", true, false, null, "admin@admin.hu", "admin", "AQAAAAEAACcQAAAAEKzONXXUKX8rrMGUG63472fs2RzRO00B6V9ZraC3sXZrzXFlSD85ldiQEZxym64fJQ==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Content", "Extension", "Name" },
                values: new object[,]
                {
                    { new Guid("d75b4eb8-7bd5-4ac7-8b33-0a999347b881"), null, "jpg", "Shazam.jpg" },
                    { new Guid("4abbe9a2-316b-4bda-bdf7-1f7eebc86ba0"), null, "jpg", "Negyszogletu.jpg" }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "ImageId", "Name" },
                values: new object[,]
                {
                    { new Guid("79c61293-825d-4f62-8a92-e1bbe107e1e9"), null, "Mozi" },
                    { new Guid("20c73139-a4ad-466f-949f-e03db03e23bc"), null, "Színház" }
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
                    { new Guid("b0ae14c8-0170-4b1a-9110-0d0e2114c6a6"), null, new Guid("d75b4eb8-7bd5-4ac7-8b33-0a999347b881"), "Shazam!", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("9ff6d57f-9892-4310-8325-da990f864cd8"), null, new Guid("4abbe9a2-316b-4bda-bdf7-1f7eebc86ba0"), "Négyszögletű Kerek Erdő", "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "ImageId", "Name", "Street", "TypeId" },
                values: new object[,]
                {
                    { new Guid("c81efe43-7df1-416f-b55a-b5107c5e8549"), "Budapest", "Allee Cinema City mozi", null, "Allee CC", "Október huszonharmadika u. 8-10", new Guid("79c61293-825d-4f62-8a92-e1bbe107e1e9") },
                    { new Guid("7d869ffd-29ba-477c-9f1b-2b04ebac1bc0"), "Pécs", "Pécs Cinema City mozi", null, "Pécs Plaza CC", "Megyeri út 76.", new Guid("79c61293-825d-4f62-8a92-e1bbe107e1e9") },
                    { new Guid("ad9cc55d-628b-40af-8de5-ff6bc96905d8"), "Budapest", null, null, "Madách Színház", "Erzsébet krt. 29-33.", new Guid("20c73139-a4ad-466f-949f-e03db03e23bc") }
                });

            migrationBuilder.InsertData(
                table: "ServiceEvent",
                columns: new[] { "EventId", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("b0ae14c8-0170-4b1a-9110-0d0e2114c6a6"), new Guid("c81efe43-7df1-416f-b55a-b5107c5e8549") },
                    { new Guid("b0ae14c8-0170-4b1a-9110-0d0e2114c6a6"), new Guid("7d869ffd-29ba-477c-9f1b-2b04ebac1bc0") },
                    { new Guid("9ff6d57f-9892-4310-8325-da990f864cd8"), new Guid("ad9cc55d-628b-40af-8de5-ff6bc96905d8") }
                });

            migrationBuilder.InsertData(
                table: "ServicePlaces",
                columns: new[] { "Id", "Name", "ServiceId" },
                values: new object[] { new Guid("0572d7fd-1bf0-441b-8d90-e41a14d46002"), "Anyád", new Guid("c81efe43-7df1-416f-b55a-b5107c5e8549") });

            migrationBuilder.InsertData(
                table: "EvenSchedules",
                columns: new[] { "Id", "Description", "EventId", "From", "ServiceId", "ServicePlaceId", "To" },
                values: new object[] { new Guid("5b64e934-7747-4129-947b-828e4a5779df"), "Shazam bemutató", new Guid("b0ae14c8-0170-4b1a-9110-0d0e2114c6a6"), new DateTime(2019, 4, 9, 18, 38, 44, 862, DateTimeKind.Local), new Guid("c81efe43-7df1-416f-b55a-b5107c5e8549"), new Guid("0572d7fd-1bf0-441b-8d90-e41a14d46002"), new DateTime(2019, 4, 9, 20, 38, 44, 865, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "ServicePlacePositions",
                columns: new[] { "Id", "Name", "ServicePlaceId" },
                values: new object[,]
                {
                    { new Guid("241f9628-8874-425a-bd27-f23ae92d0794"), "I1", new Guid("0572d7fd-1bf0-441b-8d90-e41a14d46002") },
                    { new Guid("6103ab17-1999-4e68-856a-9ed8bed44d98"), "I2", new Guid("0572d7fd-1bf0-441b-8d90-e41a14d46002") },
                    { new Guid("48737fe2-167d-4875-af1c-41905bfa2c39"), "I3", new Guid("0572d7fd-1bf0-441b-8d90-e41a14d46002") },
                    { new Guid("9564f10f-e7fc-4c80-9728-9c50da80323e"), "I4", new Guid("0572d7fd-1bf0-441b-8d90-e41a14d46002") }
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
