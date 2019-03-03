using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class schemeChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_AspNetUsers_UserId1",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_UserId1",
                table: "Bookings");

            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("b44599c6-2926-4040-97f6-bea69948a448"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("5a2deda8-9d83-4214-b4de-7c9d5b6a24a4"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("5b8359fe-de97-496b-9235-bb488b5eb8c4"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("bdfcb3d3-88d5-4d6c-9534-52e464da2d1d"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("c6862817-114c-4176-8079-90550182f406"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("dbf24864-c651-4873-833c-6f58b070f6db"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("3e95692e-8368-4925-8149-e2be85ea45d7"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("c1eee715-dded-4144-8f5d-dbc02443ad54"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("a7497040-6830-4bd4-8b32-f66024ade852"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("bfe12332-d55e-4009-bd4e-215ed94f1b22"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("77a62336-d976-4cdb-96a6-507d36495920"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("d0635d3e-3ec7-4ce6-8a47-cc701285759b"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("dab78788-5240-465a-b90f-f918b75f8c9c"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Bookings");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Bookings",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Bookings",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Bookings",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Bookings");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Bookings",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Bookings",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "f8027159-14da-4dde-b2e8-0ba8c62b51e1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "56c30557-51a7-468b-abef-0d89ba052fde", "AQAAAAEAACcQAAAAEN3XPpUVi+zzjBOe/MVagkp4/3VbYaxTiuz8yIDURotm7XXAi6ARsFDKPA3/64vuUg==" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "EventImage", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("a7497040-6830-4bd4-8b32-f66024ade852"), null, null, "Shazam!", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("5a2deda8-9d83-4214-b4de-7c9d5b6a24a4"), null, null, "Négyszögletű Kerek Erdő", "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("dab78788-5240-465a-b90f-f918b75f8c9c"), "Mozi" },
                    { new Guid("77a62336-d976-4cdb-96a6-507d36495920"), "Színház" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("d0635d3e-3ec7-4ce6-8a47-cc701285759b"), "Budapest", "Allee Cinema City mozi", "Allee CC", "Október huszonharmadika u. 8-10", new Guid("dab78788-5240-465a-b90f-f918b75f8c9c") });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("c1eee715-dded-4144-8f5d-dbc02443ad54"), "Pécs", "Pécs Cinema City mozi", "Pécs Plaza CC", "Megyeri út 76.", new Guid("dab78788-5240-465a-b90f-f918b75f8c9c") });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "Name", "Street", "TypeId" },
                values: new object[] { new Guid("3e95692e-8368-4925-8149-e2be85ea45d7"), "Budapest", null, "Madách Színház", "Erzsébet krt. 29-33.", new Guid("77a62336-d976-4cdb-96a6-507d36495920") });

            migrationBuilder.InsertData(
                table: "ServicePlaces",
                columns: new[] { "Id", "Name", "ServiceId" },
                values: new object[] { new Guid("bfe12332-d55e-4009-bd4e-215ed94f1b22"), "Anyád", new Guid("d0635d3e-3ec7-4ce6-8a47-cc701285759b") });

            migrationBuilder.InsertData(
                table: "EvenSchedules",
                columns: new[] { "Id", "Description", "EventId", "From", "ServiceId", "ServicePlaceId", "To" },
                values: new object[] { new Guid("b44599c6-2926-4040-97f6-bea69948a448"), "Shazam bemutató", new Guid("a7497040-6830-4bd4-8b32-f66024ade852"), new DateTime(2019, 2, 28, 17, 58, 43, 171, DateTimeKind.Local), new Guid("d0635d3e-3ec7-4ce6-8a47-cc701285759b"), new Guid("bfe12332-d55e-4009-bd4e-215ed94f1b22"), new DateTime(2019, 2, 28, 19, 58, 43, 173, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "ServicePlacePositions",
                columns: new[] { "Id", "Name", "ServicePlaceId" },
                values: new object[,]
                {
                    { new Guid("5b8359fe-de97-496b-9235-bb488b5eb8c4"), "I1", new Guid("bfe12332-d55e-4009-bd4e-215ed94f1b22") },
                    { new Guid("c6862817-114c-4176-8079-90550182f406"), "I2", new Guid("bfe12332-d55e-4009-bd4e-215ed94f1b22") },
                    { new Guid("bdfcb3d3-88d5-4d6c-9534-52e464da2d1d"), "I3", new Guid("bfe12332-d55e-4009-bd4e-215ed94f1b22") },
                    { new Guid("dbf24864-c651-4873-833c-6f58b070f6db"), "I4", new Guid("bfe12332-d55e-4009-bd4e-215ed94f1b22") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserId1",
                table: "Bookings",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_AspNetUsers_UserId1",
                table: "Bookings",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
