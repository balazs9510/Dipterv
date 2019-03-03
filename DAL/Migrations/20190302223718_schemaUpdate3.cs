using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class schemaUpdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_ServicePlacePositions_PositionId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_PendingBookings_ServicePlacePositions_ServicePlacePositionId",
                table: "PendingBookings");

            migrationBuilder.DropIndex(
                name: "IX_PendingBookings_ServicePlacePositionId",
                table: "PendingBookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_PositionId",
                table: "Bookings");

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

            migrationBuilder.DropColumn(
                name: "ServicePlacePositionId",
                table: "PendingBookings");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "Bookings");

            migrationBuilder.AddColumn<Guid>(
                name: "BookingId",
                table: "ServicePlacePositions",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PendingBookingId",
                table: "ServicePlacePositions",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "67e0d40f-d767-40f2-a41e-d17ae7cef210");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "612850a4-1a7c-4478-b22e-f2d5bd7c264a", "AQAAAAEAACcQAAAAEOR8tCheZ/MX2idKcrPkDbZ2mLGdmG5ipdt0ipbK/IRSJsQ0MUtpULsj/axZMmTnkA==" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "EventImage", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("35945c3d-c5b5-4fda-8507-d8da96c31535"), null, null, "Shazam!", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("a86d76a0-1d28-49cc-ae1c-eac7359057a1"), null, null, "Négyszögletű Kerek Erdő", "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("38243888-072a-4b3c-8351-5e04e5aac884"), "Mozi" },
                    { new Guid("af7206fa-fa27-4c02-8a65-b1c4ff98a776"), "Színház" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("279f8688-327a-417e-9d8e-43c7f0a7e898"), "Budapest", "Allee Cinema City mozi", "Allee CC", "Október huszonharmadika u. 8-10", new Guid("38243888-072a-4b3c-8351-5e04e5aac884") });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("fa89d61b-f006-407e-9d7f-159171c2313b"), "Pécs", "Pécs Cinema City mozi", "Pécs Plaza CC", "Megyeri út 76.", new Guid("38243888-072a-4b3c-8351-5e04e5aac884") });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("5be381fc-6161-496c-a936-2fe3297d6106"), "Budapest", null, "Madách Színház", "Erzsébet krt. 29-33.", new Guid("af7206fa-fa27-4c02-8a65-b1c4ff98a776") });

            migrationBuilder.InsertData(
                table: "ServicePlaces",
                columns: new[] { "Id", "Name", "ServiceId" },
                values: new object[] { new Guid("98d5b02b-7d3f-4dbc-b1a4-87cd0b8a99ec"), "Anyád", new Guid("279f8688-327a-417e-9d8e-43c7f0a7e898") });

            migrationBuilder.InsertData(
                table: "EvenSchedules",
                columns: new[] { "Id", "Description", "EventId", "From", "ServiceId", "ServicePlaceId", "To" },
                values: new object[] { new Guid("d396dbe9-411a-4cab-a7c0-2a08fae8f02b"), "Shazam bemutató", new Guid("35945c3d-c5b5-4fda-8507-d8da96c31535"), new DateTime(2019, 3, 2, 23, 37, 18, 397, DateTimeKind.Local), new Guid("279f8688-327a-417e-9d8e-43c7f0a7e898"), new Guid("98d5b02b-7d3f-4dbc-b1a4-87cd0b8a99ec"), new DateTime(2019, 3, 3, 1, 37, 18, 399, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "ServicePlacePositions",
                columns: new[] { "Id", "BookingId", "Name", "PendingBookingId", "ServicePlaceId" },
                values: new object[,]
                {
                    { new Guid("e3f4dddc-f90e-4b39-a13c-43c44c6f7be8"), null, "I1", null, new Guid("98d5b02b-7d3f-4dbc-b1a4-87cd0b8a99ec") },
                    { new Guid("6062109c-86eb-429c-9f9d-3e3d119e4ab7"), null, "I2", null, new Guid("98d5b02b-7d3f-4dbc-b1a4-87cd0b8a99ec") },
                    { new Guid("6214ad6c-56a8-40ec-a7ea-3f0c2b2bd08c"), null, "I3", null, new Guid("98d5b02b-7d3f-4dbc-b1a4-87cd0b8a99ec") },
                    { new Guid("0ab5bb22-9a6b-4375-a56f-7adbdec1e47a"), null, "I4", null, new Guid("98d5b02b-7d3f-4dbc-b1a4-87cd0b8a99ec") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServicePlacePositions_BookingId",
                table: "ServicePlacePositions",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicePlacePositions_PendingBookingId",
                table: "ServicePlacePositions",
                column: "PendingBookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServicePlacePositions_Bookings_BookingId",
                table: "ServicePlacePositions",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ServicePlacePositions_PendingBookings_PendingBookingId",
                table: "ServicePlacePositions",
                column: "PendingBookingId",
                principalTable: "PendingBookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServicePlacePositions_Bookings_BookingId",
                table: "ServicePlacePositions");

            migrationBuilder.DropForeignKey(
                name: "FK_ServicePlacePositions_PendingBookings_PendingBookingId",
                table: "ServicePlacePositions");

            migrationBuilder.DropIndex(
                name: "IX_ServicePlacePositions_BookingId",
                table: "ServicePlacePositions");

            migrationBuilder.DropIndex(
                name: "IX_ServicePlacePositions_PendingBookingId",
                table: "ServicePlacePositions");

            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d396dbe9-411a-4cab-a7c0-2a08fae8f02b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("a86d76a0-1d28-49cc-ae1c-eac7359057a1"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("0ab5bb22-9a6b-4375-a56f-7adbdec1e47a"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("6062109c-86eb-429c-9f9d-3e3d119e4ab7"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("6214ad6c-56a8-40ec-a7ea-3f0c2b2bd08c"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("e3f4dddc-f90e-4b39-a13c-43c44c6f7be8"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("5be381fc-6161-496c-a936-2fe3297d6106"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("fa89d61b-f006-407e-9d7f-159171c2313b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("35945c3d-c5b5-4fda-8507-d8da96c31535"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("98d5b02b-7d3f-4dbc-b1a4-87cd0b8a99ec"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("af7206fa-fa27-4c02-8a65-b1c4ff98a776"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("279f8688-327a-417e-9d8e-43c7f0a7e898"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("38243888-072a-4b3c-8351-5e04e5aac884"));

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "ServicePlacePositions");

            migrationBuilder.DropColumn(
                name: "PendingBookingId",
                table: "ServicePlacePositions");

            migrationBuilder.AddColumn<Guid>(
                name: "ServicePlacePositionId",
                table: "PendingBookings",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PositionId",
                table: "Bookings",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                name: "IX_PendingBookings_ServicePlacePositionId",
                table: "PendingBookings",
                column: "ServicePlacePositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_PositionId",
                table: "Bookings",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_ServicePlacePositions_PositionId",
                table: "Bookings",
                column: "PositionId",
                principalTable: "ServicePlacePositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PendingBookings_ServicePlacePositions_ServicePlacePositionId",
                table: "PendingBookings",
                column: "ServicePlacePositionId",
                principalTable: "ServicePlacePositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
