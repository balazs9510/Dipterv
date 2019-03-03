using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class schemeChange2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("144b1e7b-0be3-42b4-a886-e076746fd410"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("dadb5891-9799-4fa7-909e-1f414e8c8dbb"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("75def101-ce19-4bd5-8207-71e418a1b59f"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("8f337973-2503-4101-ab21-4193edc53e54"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("97a8bdc8-cdce-4205-928b-8efc16df3a46"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("ad8b4b54-9586-4c72-9505-3ec031e5df1c"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("589fcfe0-1f38-48fb-9459-84eb754a977e"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("b91719b3-30e1-4911-9c9a-5e6db33bacbc"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("ab38a10c-f94c-4a7d-9c08-2d4651e96cfe"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("fe18d39f-dfbe-492d-8940-7cc00e8fb309"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("4f7e9b99-c103-4370-be38-2e6d1788c298"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("9cf3997e-6263-48db-9b2d-9476a48698f9"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("643c9713-b08c-4647-a768-5fec6fe7a613"));

            migrationBuilder.CreateTable(
                name: "PendingBookings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    ServicePlacePositionId = table.Column<Guid>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_PendingBookings_ServicePlacePositions_ServicePlacePositionId",
                        column: x => x.ServicePlacePositionId,
                        principalTable: "ServicePlacePositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "83758f26-3843-46a7-94d8-7ecfa10bd80e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ecd11774-84af-45b6-8e16-6620528341cd", "AQAAAAEAACcQAAAAECbcsHHzpMCan8V+DucHzJbw3pLDLuEcnyNYf8eilHkf0LyV9S1Y9VPQ1oDaYpYK+w==" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "EventImage", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("10d882e2-b737-4e3c-b89b-0ff041b55154"), null, null, "Shazam!", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("4aff2483-c234-4c12-8e79-38dbdad39d1b"), null, null, "Négyszögletű Kerek Erdő", "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("b1093d2f-a0ce-4db8-8748-1e60aa1d6f8d"), "Mozi" },
                    { new Guid("51b6754c-ff6c-48d0-9800-ee568950655f"), "Színház" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("df94fe62-98ce-46d3-82bc-a4e488d0e947"), "Budapest", "Allee Cinema City mozi", "Allee CC", "Október huszonharmadika u. 8-10", new Guid("b1093d2f-a0ce-4db8-8748-1e60aa1d6f8d") });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("6f38eb96-89ce-4883-bd18-b13b7020c4c5"), "Pécs", "Pécs Cinema City mozi", "Pécs Plaza CC", "Megyeri út 76.", new Guid("b1093d2f-a0ce-4db8-8748-1e60aa1d6f8d") });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("29a53edf-8207-469f-b96a-bc8bde2b6331"), "Budapest", null, "Madách Színház", "Erzsébet krt. 29-33.", new Guid("51b6754c-ff6c-48d0-9800-ee568950655f") });

            migrationBuilder.InsertData(
                table: "ServicePlaces",
                columns: new[] { "Id", "Name", "ServiceId" },
                values: new object[] { new Guid("4e384cf9-c791-404d-a503-2f7d518a34df"), "Anyád", new Guid("df94fe62-98ce-46d3-82bc-a4e488d0e947") });

            migrationBuilder.InsertData(
                table: "EvenSchedules",
                columns: new[] { "Id", "Description", "EventId", "From", "ServiceId", "ServicePlaceId", "To" },
                values: new object[] { new Guid("ee72b5d5-6ed9-478a-9f23-e94e71624f29"), "Shazam bemutató", new Guid("10d882e2-b737-4e3c-b89b-0ff041b55154"), new DateTime(2019, 3, 2, 21, 9, 30, 358, DateTimeKind.Local), new Guid("df94fe62-98ce-46d3-82bc-a4e488d0e947"), new Guid("4e384cf9-c791-404d-a503-2f7d518a34df"), new DateTime(2019, 3, 2, 23, 9, 30, 360, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "ServicePlacePositions",
                columns: new[] { "Id", "Name", "ServicePlaceId" },
                values: new object[,]
                {
                    { new Guid("df4c91bd-fd20-4b84-99b7-608ad83b9dad"), "I1", new Guid("4e384cf9-c791-404d-a503-2f7d518a34df") },
                    { new Guid("2aadfaf2-a9e1-440c-b9c6-7534d854eb18"), "I2", new Guid("4e384cf9-c791-404d-a503-2f7d518a34df") },
                    { new Guid("6d35c993-438a-4b5e-91e4-fb2276904f1a"), "I3", new Guid("4e384cf9-c791-404d-a503-2f7d518a34df") },
                    { new Guid("a4a10c1b-337b-49b6-8cb0-560b088efbbe"), "I4", new Guid("4e384cf9-c791-404d-a503-2f7d518a34df") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PendingBookings_EvenScheduleId",
                table: "PendingBookings",
                column: "EvenScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_PendingBookings_ServicePlacePositionId",
                table: "PendingBookings",
                column: "ServicePlacePositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PendingBookings");

            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("ee72b5d5-6ed9-478a-9f23-e94e71624f29"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("4aff2483-c234-4c12-8e79-38dbdad39d1b"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("2aadfaf2-a9e1-440c-b9c6-7534d854eb18"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("6d35c993-438a-4b5e-91e4-fb2276904f1a"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("a4a10c1b-337b-49b6-8cb0-560b088efbbe"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("df4c91bd-fd20-4b84-99b7-608ad83b9dad"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("29a53edf-8207-469f-b96a-bc8bde2b6331"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6f38eb96-89ce-4883-bd18-b13b7020c4c5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("10d882e2-b737-4e3c-b89b-0ff041b55154"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("4e384cf9-c791-404d-a503-2f7d518a34df"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("51b6754c-ff6c-48d0-9800-ee568950655f"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("df94fe62-98ce-46d3-82bc-a4e488d0e947"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("b1093d2f-a0ce-4db8-8748-1e60aa1d6f8d"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "1fb9a33f-76b5-410c-8375-d87d1dbc4585");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "192305dd-f24d-4431-91c6-9e1c8b1788a0", "AQAAAAEAACcQAAAAEE2zdRfHCsjLT594iwZdmBySweVBMZKhQ/feDEA8JoYbSMKNe19hwVCve7GUa3DKXA==" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "EventImage", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("ab38a10c-f94c-4a7d-9c08-2d4651e96cfe"), null, null, "Shazam!", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("dadb5891-9799-4fa7-909e-1f414e8c8dbb"), null, null, "Négyszögletű Kerek Erdő", "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("643c9713-b08c-4647-a768-5fec6fe7a613"), "Mozi" },
                    { new Guid("4f7e9b99-c103-4370-be38-2e6d1788c298"), "Színház" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("9cf3997e-6263-48db-9b2d-9476a48698f9"), "Budapest", "Allee Cinema City mozi", "Allee CC", "Október huszonharmadika u. 8-10", new Guid("643c9713-b08c-4647-a768-5fec6fe7a613") });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("589fcfe0-1f38-48fb-9459-84eb754a977e"), "Pécs", "Pécs Cinema City mozi", "Pécs Plaza CC", "Megyeri út 76.", new Guid("643c9713-b08c-4647-a768-5fec6fe7a613") });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("b91719b3-30e1-4911-9c9a-5e6db33bacbc"), "Budapest", null, "Madách Színház", "Erzsébet krt. 29-33.", new Guid("4f7e9b99-c103-4370-be38-2e6d1788c298") });

            migrationBuilder.InsertData(
                table: "ServicePlaces",
                columns: new[] { "Id", "Name", "ServiceId" },
                values: new object[] { new Guid("fe18d39f-dfbe-492d-8940-7cc00e8fb309"), "Anyád", new Guid("9cf3997e-6263-48db-9b2d-9476a48698f9") });

            migrationBuilder.InsertData(
                table: "EvenSchedules",
                columns: new[] { "Id", "Description", "EventId", "From", "ServiceId", "ServicePlaceId", "To" },
                values: new object[] { new Guid("144b1e7b-0be3-42b4-a886-e076746fd410"), "Shazam bemutató", new Guid("ab38a10c-f94c-4a7d-9c08-2d4651e96cfe"), new DateTime(2019, 3, 2, 21, 7, 53, 914, DateTimeKind.Local), new Guid("9cf3997e-6263-48db-9b2d-9476a48698f9"), new Guid("fe18d39f-dfbe-492d-8940-7cc00e8fb309"), new DateTime(2019, 3, 2, 23, 7, 53, 917, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "ServicePlacePositions",
                columns: new[] { "Id", "Name", "ServicePlaceId" },
                values: new object[,]
                {
                    { new Guid("97a8bdc8-cdce-4205-928b-8efc16df3a46"), "I1", new Guid("fe18d39f-dfbe-492d-8940-7cc00e8fb309") },
                    { new Guid("ad8b4b54-9586-4c72-9505-3ec031e5df1c"), "I2", new Guid("fe18d39f-dfbe-492d-8940-7cc00e8fb309") },
                    { new Guid("75def101-ce19-4bd5-8207-71e418a1b59f"), "I3", new Guid("fe18d39f-dfbe-492d-8940-7cc00e8fb309") },
                    { new Guid("8f337973-2503-4101-ab21-4193edc53e54"), "I4", new Guid("fe18d39f-dfbe-492d-8940-7cc00e8fb309") }
                });
        }
    }
}
