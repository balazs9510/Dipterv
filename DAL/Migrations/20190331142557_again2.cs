using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class again2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("8ad60121-eb20-4fc1-83e3-450050b8a83d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("b3ade006-caf6-458f-b04a-769eb8275c37"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("1be8dd7c-8777-4aa2-8b02-cde1e9b75885"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("7b0caa09-8063-4839-ae17-d4f5d2068f49"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("bf13a42c-89c4-4d97-9c11-929277d19342"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("e2f78159-df61-4b0b-a02f-acca3d6815be"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("0f9a0bcb-4f55-444b-9b1e-a47598c818b4"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("d917cb95-e6cb-453b-bcaa-6a0b4da0c829"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("ecefdaf5-957d-433d-965b-21909f6ccd10"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("9636bf29-fff0-4807-96de-6c749d26b05b"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("ebec169a-b5fe-445d-9e35-d5583c8afe2a"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("f266bf2d-ccf8-4492-8f63-7464dcbbbc5d"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("83727b9b-277a-4cae-a4c4-ea4dc42aa694"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "e39d91da-4b2a-458d-a908-8fc432d244cb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1982c863-b68d-4e47-b25d-59fc2c3ff5d9", "AQAAAAEAACcQAAAAEDVXxlvR9Jh+2LiszEpdOtSaoWxnVFa7esqQrgDUg2MCiJOrScqJ6rITfomRm9V3nQ==" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "EventImage", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("7613e41d-d275-440e-b481-85879a47d1cf"), null, null, "Shazam!", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("b919096c-a963-4227-b980-eefa289f9f9d"), null, null, "Négyszögletű Kerek Erdő", "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3b8ce517-a1bf-4104-9fd8-3f2df57296bf"), "Mozi" },
                    { new Guid("77a70f1f-3990-4a0b-b81c-eb397d56824f"), "Színház" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("b7a125d3-49dc-4403-82e4-ad64936d3007"), "Budapest", "Allee Cinema City mozi", "Allee CC", "Október huszonharmadika u. 8-10", new Guid("3b8ce517-a1bf-4104-9fd8-3f2df57296bf") });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("c8bb45f9-8461-4e0f-9b00-2d8328f9cb19"), "Pécs", "Pécs Cinema City mozi", "Pécs Plaza CC", "Megyeri út 76.", new Guid("3b8ce517-a1bf-4104-9fd8-3f2df57296bf") });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("771a4745-5397-4492-82c8-7f26afe63e22"), "Budapest", null, "Madách Színház", "Erzsébet krt. 29-33.", new Guid("77a70f1f-3990-4a0b-b81c-eb397d56824f") });

            migrationBuilder.InsertData(
                table: "ServicePlaces",
                columns: new[] { "Id", "Name", "ServiceId" },
                values: new object[] { new Guid("56d705a4-9d40-4689-89c4-ec006d084538"), "Anyád", new Guid("b7a125d3-49dc-4403-82e4-ad64936d3007") });

            migrationBuilder.InsertData(
                table: "EvenSchedules",
                columns: new[] { "Id", "Description", "EventId", "From", "ServiceId", "ServicePlaceId", "To" },
                values: new object[] { new Guid("44be9aef-4f96-4878-a936-537a70c4e4c7"), "Shazam bemutató", new Guid("7613e41d-d275-440e-b481-85879a47d1cf"), new DateTime(2019, 3, 31, 16, 25, 56, 528, DateTimeKind.Local), new Guid("b7a125d3-49dc-4403-82e4-ad64936d3007"), new Guid("56d705a4-9d40-4689-89c4-ec006d084538"), new DateTime(2019, 3, 31, 18, 25, 56, 530, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "ServicePlacePositions",
                columns: new[] { "Id", "Name", "ServicePlaceId" },
                values: new object[,]
                {
                    { new Guid("5e9eadc3-a10c-4ddb-9e98-24196800b184"), "I1", new Guid("56d705a4-9d40-4689-89c4-ec006d084538") },
                    { new Guid("9c969a46-25aa-4e8f-9477-bbb6c837b8b7"), "I2", new Guid("56d705a4-9d40-4689-89c4-ec006d084538") },
                    { new Guid("983d82e3-9898-407f-800d-aa8d322d4999"), "I3", new Guid("56d705a4-9d40-4689-89c4-ec006d084538") },
                    { new Guid("b0b6a3d5-1c66-4e9e-9fa0-d9519bcf0f37"), "I4", new Guid("56d705a4-9d40-4689-89c4-ec006d084538") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("44be9aef-4f96-4878-a936-537a70c4e4c7"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("b919096c-a963-4227-b980-eefa289f9f9d"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("5e9eadc3-a10c-4ddb-9e98-24196800b184"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("983d82e3-9898-407f-800d-aa8d322d4999"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("9c969a46-25aa-4e8f-9477-bbb6c837b8b7"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("b0b6a3d5-1c66-4e9e-9fa0-d9519bcf0f37"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("771a4745-5397-4492-82c8-7f26afe63e22"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("c8bb45f9-8461-4e0f-9b00-2d8328f9cb19"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("7613e41d-d275-440e-b481-85879a47d1cf"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("56d705a4-9d40-4689-89c4-ec006d084538"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("77a70f1f-3990-4a0b-b81c-eb397d56824f"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("b7a125d3-49dc-4403-82e4-ad64936d3007"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("3b8ce517-a1bf-4104-9fd8-3f2df57296bf"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "3bdeec53-2ed2-45a3-bd4a-a24b52ba9506");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8bc24b4f-6455-4d0d-bc2c-697c18dbc550", "AQAAAAEAACcQAAAAEPG2ahIlDhzsh/601JetD1/PxyGYH8ApotNH/fx8pc+PEqnaIrQI65jKI8IsqtXo3A==" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "EventImage", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("ecefdaf5-957d-433d-965b-21909f6ccd10"), null, null, "Shazam!", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("b3ade006-caf6-458f-b04a-769eb8275c37"), null, null, "Négyszögletű Kerek Erdő", "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("83727b9b-277a-4cae-a4c4-ea4dc42aa694"), "Mozi" },
                    { new Guid("ebec169a-b5fe-445d-9e35-d5583c8afe2a"), "Színház" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("f266bf2d-ccf8-4492-8f63-7464dcbbbc5d"), "Budapest", "Allee Cinema City mozi", "Allee CC", "Október huszonharmadika u. 8-10", new Guid("83727b9b-277a-4cae-a4c4-ea4dc42aa694") });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("0f9a0bcb-4f55-444b-9b1e-a47598c818b4"), "Pécs", "Pécs Cinema City mozi", "Pécs Plaza CC", "Megyeri út 76.", new Guid("83727b9b-277a-4cae-a4c4-ea4dc42aa694") });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("d917cb95-e6cb-453b-bcaa-6a0b4da0c829"), "Budapest", null, "Madách Színház", "Erzsébet krt. 29-33.", new Guid("ebec169a-b5fe-445d-9e35-d5583c8afe2a") });

            migrationBuilder.InsertData(
                table: "ServicePlaces",
                columns: new[] { "Id", "Name", "ServiceId" },
                values: new object[] { new Guid("9636bf29-fff0-4807-96de-6c749d26b05b"), "Anyád", new Guid("f266bf2d-ccf8-4492-8f63-7464dcbbbc5d") });

            migrationBuilder.InsertData(
                table: "EvenSchedules",
                columns: new[] { "Id", "Description", "EventId", "From", "ServiceId", "ServicePlaceId", "To" },
                values: new object[] { new Guid("8ad60121-eb20-4fc1-83e3-450050b8a83d"), "Shazam bemutató", new Guid("ecefdaf5-957d-433d-965b-21909f6ccd10"), new DateTime(2019, 3, 31, 16, 24, 58, 819, DateTimeKind.Local), new Guid("f266bf2d-ccf8-4492-8f63-7464dcbbbc5d"), new Guid("9636bf29-fff0-4807-96de-6c749d26b05b"), new DateTime(2019, 3, 31, 18, 24, 58, 848, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "ServicePlacePositions",
                columns: new[] { "Id", "Name", "ServicePlaceId" },
                values: new object[,]
                {
                    { new Guid("1be8dd7c-8777-4aa2-8b02-cde1e9b75885"), "I1", new Guid("9636bf29-fff0-4807-96de-6c749d26b05b") },
                    { new Guid("e2f78159-df61-4b0b-a02f-acca3d6815be"), "I2", new Guid("9636bf29-fff0-4807-96de-6c749d26b05b") },
                    { new Guid("7b0caa09-8063-4839-ae17-d4f5d2068f49"), "I3", new Guid("9636bf29-fff0-4807-96de-6c749d26b05b") },
                    { new Guid("bf13a42c-89c4-4d97-9c11-929277d19342"), "I4", new Guid("9636bf29-fff0-4807-96de-6c749d26b05b") }
                });
        }
    }
}
