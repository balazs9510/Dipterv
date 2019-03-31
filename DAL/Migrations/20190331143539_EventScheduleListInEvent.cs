using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class EventScheduleListInEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "fd235acf-bd5b-4115-8640-bdfb190ebdcd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d556e2a7-4867-436a-bd79-8d828ac8a6da", "AQAAAAEAACcQAAAAELUMPXyftER2xG1Mdq7Hg0An9o9tkNXShHv3MVtUr13KIQRKTHLBtv9gZse1FO2ybw==" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "EventImage", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("0dbb6fb9-5b98-4774-a041-5a6a623d2735"), null, null, "Shazam!", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("bde370b8-fb1a-4c16-abf9-13d40c8ffd3c"), null, null, "Négyszögletű Kerek Erdő", "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("101eb8b9-ed03-4511-bd83-09cf5260911a"), "Mozi" },
                    { new Guid("39d79ce5-8cc4-4710-a3d1-43e87be7bea5"), "Színház" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("de112c3e-ad2c-4700-80a1-efba60adcc71"), "Budapest", "Allee Cinema City mozi", "Allee CC", "Október huszonharmadika u. 8-10", new Guid("101eb8b9-ed03-4511-bd83-09cf5260911a") });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("393fc61f-cf69-4171-abda-c19a5a160176"), "Pécs", "Pécs Cinema City mozi", "Pécs Plaza CC", "Megyeri út 76.", new Guid("101eb8b9-ed03-4511-bd83-09cf5260911a") });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("00ddbd6c-ce63-4f4d-a53b-97f7b265c78c"), "Budapest", null, "Madách Színház", "Erzsébet krt. 29-33.", new Guid("39d79ce5-8cc4-4710-a3d1-43e87be7bea5") });

            migrationBuilder.InsertData(
                table: "ServicePlaces",
                columns: new[] { "Id", "Name", "ServiceId" },
                values: new object[] { new Guid("030380c8-ba9a-4673-aa5a-521f2747e2c6"), "Anyád", new Guid("de112c3e-ad2c-4700-80a1-efba60adcc71") });

            migrationBuilder.InsertData(
                table: "EvenSchedules",
                columns: new[] { "Id", "Description", "EventId", "From", "ServiceId", "ServicePlaceId", "To" },
                values: new object[] { new Guid("49805678-1648-4c21-ba8b-37b971f1bd51"), "Shazam bemutató", new Guid("0dbb6fb9-5b98-4774-a041-5a6a623d2735"), new DateTime(2019, 3, 31, 16, 35, 38, 997, DateTimeKind.Local), new Guid("de112c3e-ad2c-4700-80a1-efba60adcc71"), new Guid("030380c8-ba9a-4673-aa5a-521f2747e2c6"), new DateTime(2019, 3, 31, 18, 35, 38, 999, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "ServicePlacePositions",
                columns: new[] { "Id", "Name", "ServicePlaceId" },
                values: new object[,]
                {
                    { new Guid("ce0c37a7-8633-4bb1-839c-11766af4ec7a"), "I1", new Guid("030380c8-ba9a-4673-aa5a-521f2747e2c6") },
                    { new Guid("224c2202-9e1e-454a-96c3-7e8a50444c3b"), "I2", new Guid("030380c8-ba9a-4673-aa5a-521f2747e2c6") },
                    { new Guid("6324a1bf-5fc2-47a2-be0c-7f8951470181"), "I3", new Guid("030380c8-ba9a-4673-aa5a-521f2747e2c6") },
                    { new Guid("390686eb-020a-420b-ad78-d9cd3e7e3c05"), "I4", new Guid("030380c8-ba9a-4673-aa5a-521f2747e2c6") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("49805678-1648-4c21-ba8b-37b971f1bd51"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("bde370b8-fb1a-4c16-abf9-13d40c8ffd3c"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("224c2202-9e1e-454a-96c3-7e8a50444c3b"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("390686eb-020a-420b-ad78-d9cd3e7e3c05"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("6324a1bf-5fc2-47a2-be0c-7f8951470181"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("ce0c37a7-8633-4bb1-839c-11766af4ec7a"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("00ddbd6c-ce63-4f4d-a53b-97f7b265c78c"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("393fc61f-cf69-4171-abda-c19a5a160176"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("0dbb6fb9-5b98-4774-a041-5a6a623d2735"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("030380c8-ba9a-4673-aa5a-521f2747e2c6"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("39d79ce5-8cc4-4710-a3d1-43e87be7bea5"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("de112c3e-ad2c-4700-80a1-efba60adcc71"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("101eb8b9-ed03-4511-bd83-09cf5260911a"));

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
    }
}
