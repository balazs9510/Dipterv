using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class updateSchema5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingPosition_Bookings_BookingId",
                table: "BookingPosition");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingPosition_ServicePlacePositions_ServicePlacePositionId",
                table: "BookingPosition");

            migrationBuilder.DropForeignKey(
                name: "FK_PendingBookingPosition_PendingBookings_PendingBookingId",
                table: "PendingBookingPosition");

            migrationBuilder.DropForeignKey(
                name: "FK_PendingBookingPosition_ServicePlacePositions_ServicePlacePositionId",
                table: "PendingBookingPosition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PendingBookingPosition",
                table: "PendingBookingPosition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookingPosition",
                table: "BookingPosition");

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

            migrationBuilder.RenameTable(
                name: "PendingBookingPosition",
                newName: "PendingBookingPositions");

            migrationBuilder.RenameTable(
                name: "BookingPosition",
                newName: "BookingPositions");

            migrationBuilder.RenameIndex(
                name: "IX_PendingBookingPosition_ServicePlacePositionId",
                table: "PendingBookingPositions",
                newName: "IX_PendingBookingPositions_ServicePlacePositionId");

            migrationBuilder.RenameIndex(
                name: "IX_BookingPosition_ServicePlacePositionId",
                table: "BookingPositions",
                newName: "IX_BookingPositions_ServicePlacePositionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PendingBookingPositions",
                table: "PendingBookingPositions",
                columns: new[] { "PendingBookingId", "ServicePlacePositionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookingPositions",
                table: "BookingPositions",
                columns: new[] { "BookingId", "ServicePlacePositionId" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "7b8f7ac7-11fc-481a-a3b7-2f0650c0f3f0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dcc3e7c2-425d-4db5-8deb-8b4d26f191e1", "AQAAAAEAACcQAAAAEG0thBx+Dl2aocbAAwF0mXXvcKFa29tAOLFduSd3HacaEGpXTOBS02xjXABZIK4cEg==" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "EventImage", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("5265774b-eefc-4a99-b5a2-0dbc7301b07b"), null, null, "Shazam!", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("48449950-e67d-40c1-99d1-cd9c45fd21b0"), null, null, "Négyszögletű Kerek Erdő", "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("d5c70e36-e38c-4031-8741-a942af771594"), "Mozi" },
                    { new Guid("5f651d8f-b91d-49e3-9c80-29d80835766d"), "Színház" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("86ca092e-7898-444a-87ba-a4ee417c6b4b"), "Budapest", "Allee Cinema City mozi", "Allee CC", "Október huszonharmadika u. 8-10", new Guid("d5c70e36-e38c-4031-8741-a942af771594") });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("b64a4451-b343-46c4-b662-e88840b371f9"), "Pécs", "Pécs Cinema City mozi", "Pécs Plaza CC", "Megyeri út 76.", new Guid("d5c70e36-e38c-4031-8741-a942af771594") });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("7fbba624-157e-455c-9cde-f989b57f1379"), "Budapest", null, "Madách Színház", "Erzsébet krt. 29-33.", new Guid("5f651d8f-b91d-49e3-9c80-29d80835766d") });

            migrationBuilder.InsertData(
                table: "ServicePlaces",
                columns: new[] { "Id", "Name", "ServiceId" },
                values: new object[] { new Guid("cfdf34ab-d53b-42d7-ba64-a6fefbb4af77"), "Anyád", new Guid("86ca092e-7898-444a-87ba-a4ee417c6b4b") });

            migrationBuilder.InsertData(
                table: "EvenSchedules",
                columns: new[] { "Id", "Description", "EventId", "From", "ServiceId", "ServicePlaceId", "To" },
                values: new object[] { new Guid("6decccc2-0f7e-4b4d-b8f5-f3d9b086aa53"), "Shazam bemutató", new Guid("5265774b-eefc-4a99-b5a2-0dbc7301b07b"), new DateTime(2019, 3, 3, 0, 58, 59, 469, DateTimeKind.Local), new Guid("86ca092e-7898-444a-87ba-a4ee417c6b4b"), new Guid("cfdf34ab-d53b-42d7-ba64-a6fefbb4af77"), new DateTime(2019, 3, 3, 2, 58, 59, 471, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "ServicePlacePositions",
                columns: new[] { "Id", "Name", "ServicePlaceId" },
                values: new object[,]
                {
                    { new Guid("21fe9b50-1dc5-49be-8d25-34a2772a6747"), "I1", new Guid("cfdf34ab-d53b-42d7-ba64-a6fefbb4af77") },
                    { new Guid("578bef4b-ed40-48c8-af67-79957f42bd49"), "I2", new Guid("cfdf34ab-d53b-42d7-ba64-a6fefbb4af77") },
                    { new Guid("8ccaf0d2-435e-40df-9d8a-71c31dc55914"), "I3", new Guid("cfdf34ab-d53b-42d7-ba64-a6fefbb4af77") },
                    { new Guid("dfc33be9-15d8-44b0-8be5-df3c236bc26e"), "I4", new Guid("cfdf34ab-d53b-42d7-ba64-a6fefbb4af77") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BookingPositions_Bookings_BookingId",
                table: "BookingPositions",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookingPositions_ServicePlacePositions_ServicePlacePositionId",
                table: "BookingPositions",
                column: "ServicePlacePositionId",
                principalTable: "ServicePlacePositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PendingBookingPositions_PendingBookings_PendingBookingId",
                table: "PendingBookingPositions",
                column: "PendingBookingId",
                principalTable: "PendingBookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PendingBookingPositions_ServicePlacePositions_ServicePlacePositionId",
                table: "PendingBookingPositions",
                column: "ServicePlacePositionId",
                principalTable: "ServicePlacePositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingPositions_Bookings_BookingId",
                table: "BookingPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingPositions_ServicePlacePositions_ServicePlacePositionId",
                table: "BookingPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_PendingBookingPositions_PendingBookings_PendingBookingId",
                table: "PendingBookingPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_PendingBookingPositions_ServicePlacePositions_ServicePlacePositionId",
                table: "PendingBookingPositions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PendingBookingPositions",
                table: "PendingBookingPositions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookingPositions",
                table: "BookingPositions");

            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("6decccc2-0f7e-4b4d-b8f5-f3d9b086aa53"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("48449950-e67d-40c1-99d1-cd9c45fd21b0"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("21fe9b50-1dc5-49be-8d25-34a2772a6747"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("578bef4b-ed40-48c8-af67-79957f42bd49"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("8ccaf0d2-435e-40df-9d8a-71c31dc55914"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("dfc33be9-15d8-44b0-8be5-df3c236bc26e"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("7fbba624-157e-455c-9cde-f989b57f1379"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("b64a4451-b343-46c4-b662-e88840b371f9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("5265774b-eefc-4a99-b5a2-0dbc7301b07b"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("cfdf34ab-d53b-42d7-ba64-a6fefbb4af77"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("5f651d8f-b91d-49e3-9c80-29d80835766d"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("86ca092e-7898-444a-87ba-a4ee417c6b4b"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("d5c70e36-e38c-4031-8741-a942af771594"));

            migrationBuilder.RenameTable(
                name: "PendingBookingPositions",
                newName: "PendingBookingPosition");

            migrationBuilder.RenameTable(
                name: "BookingPositions",
                newName: "BookingPosition");

            migrationBuilder.RenameIndex(
                name: "IX_PendingBookingPositions_ServicePlacePositionId",
                table: "PendingBookingPosition",
                newName: "IX_PendingBookingPosition_ServicePlacePositionId");

            migrationBuilder.RenameIndex(
                name: "IX_BookingPositions_ServicePlacePositionId",
                table: "BookingPosition",
                newName: "IX_BookingPosition_ServicePlacePositionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PendingBookingPosition",
                table: "PendingBookingPosition",
                columns: new[] { "PendingBookingId", "ServicePlacePositionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookingPosition",
                table: "BookingPosition",
                columns: new[] { "BookingId", "ServicePlacePositionId" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_BookingPosition_Bookings_BookingId",
                table: "BookingPosition",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookingPosition_ServicePlacePositions_ServicePlacePositionId",
                table: "BookingPosition",
                column: "ServicePlacePositionId",
                principalTable: "ServicePlacePositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PendingBookingPosition_PendingBookings_PendingBookingId",
                table: "PendingBookingPosition",
                column: "PendingBookingId",
                principalTable: "PendingBookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PendingBookingPosition_ServicePlacePositions_ServicePlacePositionId",
                table: "PendingBookingPosition",
                column: "ServicePlacePositionId",
                principalTable: "ServicePlacePositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
