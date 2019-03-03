using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ClientIdAddToPendingBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId",
                table: "PendingBookings",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "338df01a-30f5-4e4d-b696-71a10ac7a10a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "73cdf224-24e7-4351-a1bc-8574460d5844", "AQAAAAEAACcQAAAAEB1Osyuo76tUWNKxh4CDzVnAw0pDwxD2pvgaIR6wxyajUOmVkussh8/0BrqJfC1KoQ==" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "EventImage", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("bed2d79c-6da1-40e5-aff8-96b41bdc5e92"), null, null, "Shazam!", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("a4cf5458-06e1-4d9e-b29b-4500f5812872"), null, null, "Négyszögletű Kerek Erdő", "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("7a13ad8c-fbb2-466e-8bcc-6d4ce8999a9e"), "Mozi" },
                    { new Guid("782433e7-009a-49d6-90e6-faea6d4d4519"), "Színház" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("b981813c-7036-4589-ada7-489469ee463d"), "Budapest", "Allee Cinema City mozi", "Allee CC", "Október huszonharmadika u. 8-10", new Guid("7a13ad8c-fbb2-466e-8bcc-6d4ce8999a9e") });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("b4902115-8705-4c8d-8479-ea6aef9cad31"), "Pécs", "Pécs Cinema City mozi", "Pécs Plaza CC", "Megyeri út 76.", new Guid("7a13ad8c-fbb2-466e-8bcc-6d4ce8999a9e") });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("470a3780-f30d-4311-93ae-f38170f63b9b"), "Budapest", null, "Madách Színház", "Erzsébet krt. 29-33.", new Guid("782433e7-009a-49d6-90e6-faea6d4d4519") });

            migrationBuilder.InsertData(
                table: "ServicePlaces",
                columns: new[] { "Id", "Name", "ServiceId" },
                values: new object[] { new Guid("65562565-b5a3-45d0-81a8-607b1340f61e"), "Anyád", new Guid("b981813c-7036-4589-ada7-489469ee463d") });

            migrationBuilder.InsertData(
                table: "EvenSchedules",
                columns: new[] { "Id", "Description", "EventId", "From", "ServiceId", "ServicePlaceId", "To" },
                values: new object[] { new Guid("92903e00-5c63-45ec-a78d-3c83a8798c63"), "Shazam bemutató", new Guid("bed2d79c-6da1-40e5-aff8-96b41bdc5e92"), new DateTime(2019, 3, 3, 12, 40, 43, 108, DateTimeKind.Local), new Guid("b981813c-7036-4589-ada7-489469ee463d"), new Guid("65562565-b5a3-45d0-81a8-607b1340f61e"), new DateTime(2019, 3, 3, 14, 40, 43, 111, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "ServicePlacePositions",
                columns: new[] { "Id", "Name", "ServicePlaceId" },
                values: new object[,]
                {
                    { new Guid("7e8cfd96-e934-405d-a584-f54cd27517ca"), "I1", new Guid("65562565-b5a3-45d0-81a8-607b1340f61e") },
                    { new Guid("2fc171ad-cd6d-42ff-9c50-d389ee736e4a"), "I2", new Guid("65562565-b5a3-45d0-81a8-607b1340f61e") },
                    { new Guid("9bf0a2e3-e2e9-4706-8ea8-4775061559f9"), "I3", new Guid("65562565-b5a3-45d0-81a8-607b1340f61e") },
                    { new Guid("c12d8ef2-8425-4557-9822-1f8803ca1e4b"), "I4", new Guid("65562565-b5a3-45d0-81a8-607b1340f61e") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("92903e00-5c63-45ec-a78d-3c83a8798c63"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("a4cf5458-06e1-4d9e-b29b-4500f5812872"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("2fc171ad-cd6d-42ff-9c50-d389ee736e4a"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("7e8cfd96-e934-405d-a584-f54cd27517ca"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("9bf0a2e3-e2e9-4706-8ea8-4775061559f9"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("c12d8ef2-8425-4557-9822-1f8803ca1e4b"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("470a3780-f30d-4311-93ae-f38170f63b9b"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("b4902115-8705-4c8d-8479-ea6aef9cad31"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("bed2d79c-6da1-40e5-aff8-96b41bdc5e92"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("65562565-b5a3-45d0-81a8-607b1340f61e"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("782433e7-009a-49d6-90e6-faea6d4d4519"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("b981813c-7036-4589-ada7-489469ee463d"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("7a13ad8c-fbb2-466e-8bcc-6d4ce8999a9e"));

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "PendingBookings");

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
        }
    }
}
