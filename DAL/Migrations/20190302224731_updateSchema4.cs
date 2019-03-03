using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class updateSchema4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "BookingPosition",
                columns: table => new
                {
                    BookingId = table.Column<Guid>(nullable: false),
                    ServicePlacePositionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingPosition", x => new { x.BookingId, x.ServicePlacePositionId });
                    table.ForeignKey(
                        name: "FK_BookingPosition_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingPosition_ServicePlacePositions_ServicePlacePositionId",
                        column: x => x.ServicePlacePositionId,
                        principalTable: "ServicePlacePositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PendingBookingPosition",
                columns: table => new
                {
                    PendingBookingId = table.Column<Guid>(nullable: false),
                    ServicePlacePositionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PendingBookingPosition", x => new { x.PendingBookingId, x.ServicePlacePositionId });
                    table.ForeignKey(
                        name: "FK_PendingBookingPosition_PendingBookings_PendingBookingId",
                        column: x => x.PendingBookingId,
                        principalTable: "PendingBookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PendingBookingPosition_ServicePlacePositions_ServicePlacePositionId",
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
                value: "cb2579d7-0000-4588-9860-c08fefba606f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "669b0ce7-d677-47be-bd51-16e023b8a873", "AQAAAAEAACcQAAAAEKyU72BHHg/8L1y2+T8k+gkYwdpYM7B/4PMvg2excx3eBEzIDO6A5KdG2QWDgaXziw==" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "EventImage", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("69dd301f-c77d-43e0-8688-cf01aef5b774"), null, null, "Shazam!", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("aa6c2d2f-2111-4e72-bbc1-f2888093c00a"), null, null, "Négyszögletű Kerek Erdő", "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5aa1af02-2f97-48e6-8c2b-8277be819514"), "Mozi" },
                    { new Guid("6accdc9f-a496-4ab8-88f0-f01221cf7b0f"), "Színház" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("28d1d1f4-3328-4711-95c2-1cb1fb2997ac"), "Budapest", "Allee Cinema City mozi", "Allee CC", "Október huszonharmadika u. 8-10", new Guid("5aa1af02-2f97-48e6-8c2b-8277be819514") });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("7c3d45cc-70e7-4c80-851d-b16a7f7e0576"), "Pécs", "Pécs Cinema City mozi", "Pécs Plaza CC", "Megyeri út 76.", new Guid("5aa1af02-2f97-48e6-8c2b-8277be819514") });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("4760c873-1128-4bfc-a580-8fc030086290"), "Budapest", null, "Madách Színház", "Erzsébet krt. 29-33.", new Guid("6accdc9f-a496-4ab8-88f0-f01221cf7b0f") });

            migrationBuilder.InsertData(
                table: "ServicePlaces",
                columns: new[] { "Id", "Name", "ServiceId" },
                values: new object[] { new Guid("06f091a1-b043-428b-8365-42121cbd0c0b"), "Anyád", new Guid("28d1d1f4-3328-4711-95c2-1cb1fb2997ac") });

            migrationBuilder.InsertData(
                table: "EvenSchedules",
                columns: new[] { "Id", "Description", "EventId", "From", "ServiceId", "ServicePlaceId", "To" },
                values: new object[] { new Guid("8b1d6b18-844e-470c-9094-d479e3ee2ee1"), "Shazam bemutató", new Guid("69dd301f-c77d-43e0-8688-cf01aef5b774"), new DateTime(2019, 3, 2, 23, 47, 31, 80, DateTimeKind.Local), new Guid("28d1d1f4-3328-4711-95c2-1cb1fb2997ac"), new Guid("06f091a1-b043-428b-8365-42121cbd0c0b"), new DateTime(2019, 3, 3, 1, 47, 31, 82, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "ServicePlacePositions",
                columns: new[] { "Id", "Name", "ServicePlaceId" },
                values: new object[,]
                {
                    { new Guid("09cae3a9-7ab9-4705-b479-5dba58f1ac8e"), "I1", new Guid("06f091a1-b043-428b-8365-42121cbd0c0b") },
                    { new Guid("1e4b94f9-9331-4c4f-ba3b-c72065c919b7"), "I2", new Guid("06f091a1-b043-428b-8365-42121cbd0c0b") },
                    { new Guid("4575bf5f-2edb-4636-8d0a-5a5659e6ac4c"), "I3", new Guid("06f091a1-b043-428b-8365-42121cbd0c0b") },
                    { new Guid("1dfd1c6e-08e3-4c8c-899a-2a986ef86149"), "I4", new Guid("06f091a1-b043-428b-8365-42121cbd0c0b") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingPosition_ServicePlacePositionId",
                table: "BookingPosition",
                column: "ServicePlacePositionId");

            migrationBuilder.CreateIndex(
                name: "IX_PendingBookingPosition_ServicePlacePositionId",
                table: "PendingBookingPosition",
                column: "ServicePlacePositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingPosition");

            migrationBuilder.DropTable(
                name: "PendingBookingPosition");

            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("8b1d6b18-844e-470c-9094-d479e3ee2ee1"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("aa6c2d2f-2111-4e72-bbc1-f2888093c00a"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("09cae3a9-7ab9-4705-b479-5dba58f1ac8e"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("1dfd1c6e-08e3-4c8c-899a-2a986ef86149"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("1e4b94f9-9331-4c4f-ba3b-c72065c919b7"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("4575bf5f-2edb-4636-8d0a-5a5659e6ac4c"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("4760c873-1128-4bfc-a580-8fc030086290"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("7c3d45cc-70e7-4c80-851d-b16a7f7e0576"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("69dd301f-c77d-43e0-8688-cf01aef5b774"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("06f091a1-b043-428b-8365-42121cbd0c0b"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("6accdc9f-a496-4ab8-88f0-f01221cf7b0f"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("28d1d1f4-3328-4711-95c2-1cb1fb2997ac"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("5aa1af02-2f97-48e6-8c2b-8277be819514"));

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
    }
}
