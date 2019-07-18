using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class userIdToEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("74a70a06-ba76-45fb-b690-4ee3269fc301"));

            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("947bce20-0d33-4603-8913-914e3085ff0b"));

            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("b0008e62-df01-469d-9800-ae6e0fabfeb3"));

            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("f950005c-da88-4a5a-b049-6c72df637df3"));

            migrationBuilder.DeleteData(
                table: "ServiceEvent",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("08c9a0b9-c86f-4454-acd3-51f03b3ee434"), new Guid("a8bfd4a5-befe-4e26-a683-33327067c8e7") });

            migrationBuilder.DeleteData(
                table: "ServiceEvent",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("0dbdbf3f-7517-4967-bfa4-b01d6d29bceb"), new Guid("41e9be60-6648-4d59-8d6f-b173def33981") });

            migrationBuilder.DeleteData(
                table: "ServiceEvent",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("0dbdbf3f-7517-4967-bfa4-b01d6d29bceb"), new Guid("e0b4e09c-27f8-4bd8-9911-756ef749f5ad") });

            migrationBuilder.DeleteData(
                table: "ServiceEvent",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("23c78cc0-e33e-4787-84b3-2a2ee319ec13"), new Guid("68cd14af-0138-44b1-99dd-85ea813e1679") });

            migrationBuilder.DeleteData(
                table: "ServiceEvent",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("2872da91-24ac-446c-940f-3a3de122d318"), new Guid("a8bfd4a5-befe-4e26-a683-33327067c8e7") });

            migrationBuilder.DeleteData(
                table: "ServiceEvent",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("5cfe8311-cb39-4e30-8787-a2e37774c4b9"), new Guid("41e9be60-6648-4d59-8d6f-b173def33981") });

            migrationBuilder.DeleteData(
                table: "ServiceEvent",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("5cfe8311-cb39-4e30-8787-a2e37774c4b9"), new Guid("e0b4e09c-27f8-4bd8-9911-756ef749f5ad") });

            migrationBuilder.DeleteData(
                table: "ServiceEvent",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("a0eb86cd-1c65-47dc-8178-22f4e46fd73c"), new Guid("dc164a23-0aa3-4c82-b2eb-06b0b88b33ba") });

            migrationBuilder.DeleteData(
                table: "ServiceEvent",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("b86063bf-2249-4800-82f6-c653a9ee4f90"), new Guid("a8bfd4a5-befe-4e26-a683-33327067c8e7") });

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("02fb5dc2-05c6-4625-afb3-273bd408fbb7"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("12c4e609-43d3-4957-9221-b47baafb4e5b"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("2e41f38e-d6ed-4bfa-a0c9-225f052384f8"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("4237d65d-7a8b-4e3a-8e90-53255a828f8c"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("49089f47-e42d-401e-9d6f-c4994778d231"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("71022dc9-4e62-470b-97a9-98bd8d04657e"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("7885ae73-58ff-47e1-ab3b-010db458987b"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("8e76cf6a-3832-49f2-ba0c-a2b06cd614a4"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("b6b432c0-810c-4289-9560-2caeb6476d07"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("bb3a80c1-f7da-4729-a001-4a65d61de844"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("bdf11c3f-bbec-4fe0-92e2-62e55d47d03c"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("bee08999-8585-4561-8bfc-e5d050c64f32"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("d7465d8a-3c2c-4f6d-9d37-6e47b78af3b9"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("d84b368c-5b1b-4b42-b600-553309db8ba2"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("dc6428c4-4dde-43ea-89cb-f0914ba9852a"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("f26730fc-986b-4255-8aaf-e97b0b147c4d"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("47eb7711-2dea-4f0d-b4b2-2ac4861242fe"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("26aba2be-ccb6-43d7-a740-afae6609f082"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("08c9a0b9-c86f-4454-acd3-51f03b3ee434"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("0dbdbf3f-7517-4967-bfa4-b01d6d29bceb"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("23c78cc0-e33e-4787-84b3-2a2ee319ec13"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("2872da91-24ac-446c-940f-3a3de122d318"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("5cfe8311-cb39-4e30-8787-a2e37774c4b9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("a0eb86cd-1c65-47dc-8178-22f4e46fd73c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("b86063bf-2249-4800-82f6-c653a9ee4f90"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("4b598c83-00d9-4925-bf0a-015a5fc2c546"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("e442453f-b7ca-408c-8f24-7b0ff5327e72"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("22b5f743-76b3-4559-a67e-05440d0a7566"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("9cb1387c-c1ba-4905-9117-4fd925ae2608"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("b577a8be-b0b3-41a6-83d5-707c079c1f55"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("c8ecb943-d195-453d-8025-46e19cffdaa5"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("dc164a23-0aa3-4c82-b2eb-06b0b88b33ba"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("03874a74-d7f8-4502-8ee5-2653b7ae7661"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("67e3d99f-ccc0-4be2-a327-a28e0f50ce56"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("7625ad1e-0c3a-4a0d-b15f-867a0395473a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("7768477f-3e2d-4ee1-adc1-d5f1132ca612"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("897f9b1f-a950-4129-af5b-4079a315c381"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("965f9442-bcb0-4c85-bfe7-86bab000a7d4"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f4b731b0-a8fe-48f9-ab46-d98c442dc496"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("048be27e-bfb2-4bef-a03d-02a891d16197"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("41e9be60-6648-4d59-8d6f-b173def33981"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("68cd14af-0138-44b1-99dd-85ea813e1679"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("a8bfd4a5-befe-4e26-a683-33327067c8e7"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("e0b4e09c-27f8-4bd8-9911-756ef749f5ad"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("297f8fa9-48cb-42b9-a5c1-91b98b458b36"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2b9214a6-b007-482d-8718-cc2b47a165fd"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("38e8da3d-48b0-488f-a2b9-672be52268b9"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("727c2383-97e7-4fc1-a409-ccef46e1d795"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cb441dcd-d655-4ed8-be36-663a1432972e"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("1fee0599-3ba1-48f1-b1aa-74b4a8a3acca"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("279f65a3-39b2-4e7c-94f2-cb11420bba4c"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("7656296e-dccd-4e6a-8dc9-ff9d46205de1"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("03c964c8-cc59-4ec5-9cdf-f830faeb3ab1"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("385f82c0-58cd-4686-a75c-2bd6de275bee"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("aa634a39-46cc-4d76-b2ab-ded146b436cc"));

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Services",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ServicePlaces",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "EvenSchedules",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59317E0A-8F55-46F9-BF5A-A81680A41964",
                column: "ConcurrencyStamp",
                value: "bc9ab5e8-52de-49f3-9c3f-d8e20dd3beec");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4a5269bf-8059-4236-a361-8089a561d50f", "AQAAAAEAACcQAAAAEJ+3qfxb19IAfUXxkwlzmw8eOW7wOXU5UUUEXNirvKNBOMMDZRjfMW3yT/DPoFMWyw==" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Content", "Extension", "Name" },
                values: new object[,]
                {
                    { new Guid("9d005116-dcbe-4f86-99be-a8e1691aa49c"), null, "svg", "t10.svg" },
                    { new Guid("b6d155e9-06c4-40a2-bf9d-e96b2cab3f1e"), null, "svg", "t4.svg" },
                    { new Guid("960801d7-36d2-46b3-81d4-468ab05a1ec3"), null, "png", "masszazs.png" },
                    { new Guid("e2206d09-4313-43d7-be77-c08a14165e98"), null, "png", "ftc.png" },
                    { new Guid("4ecf735a-95c7-4a63-a9d9-4b98f8fe591b"), null, "png", "negyszogletu.png" },
                    { new Guid("481b5fce-fc4c-4bec-a076-3a1cae11e560"), null, "png", "shazam.png" },
                    { new Guid("0ab0163a-d66b-49a7-b3e5-aedbe6ac475c"), null, "png", "endgame.png" },
                    { new Guid("5f32dad5-3a06-47af-9d38-c528a6967fff"), null, "png", "aquapark.png" },
                    { new Guid("2b8c9710-e47f-45e1-883b-9e2cd513e978"), null, "png", "madach.png" },
                    { new Guid("8a7e43e0-8e58-4e34-b4f5-2023eb8b1b96"), null, "png", "groupama.png" },
                    { new Guid("a35a82b0-4751-48b0-9dae-d8fc6e01c805"), null, "png", "mom.png" },
                    { new Guid("7af3ed91-4d35-4fdf-a9a8-62156902b1ff"), null, "png", "alle.png" },
                    { new Guid("dd83df06-e039-4f04-95b8-28a26b6fba1a"), null, "png", "spa.png" },
                    { new Guid("6e9c798a-d077-4e6a-9c9d-c7a8e0cca1e8"), null, "png", "sport.png" },
                    { new Guid("4f237a06-9297-4b86-9ad2-cefd4ee95b35"), null, "png", "theater.png" },
                    { new Guid("eda5ec13-f96d-4560-8456-02a5c844c63c"), null, "png", "corvin_duma.png" },
                    { new Guid("b5af72ea-7c6e-4a9a-8683-38a15e325053"), null, "png", "cinema.png" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "ImageId", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("dba73196-153f-4263-9f6f-a06265549fb6"), "Thanos súlyos tette, amivel elpusztította az univerzum élőlényeinek felét és megtörte a Bosszúállókat, a megmaradt hősöket egy végső összecsapásra készteti a Marvel Studios huszonegy filmet megkoronázó, nagyszabású fináléjában, a Bosszúállók: Végjátékban.", new Guid("0ab0163a-d66b-49a7-b3e5-aedbe6ac475c"), "Bosszúállók: Végjáték", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("9a7f8b97-7929-4291-97bf-e867651e679d"), "Mindannyiunkban ott bujkál a szuperhős – de van, akiből elő is jön. Billy Batson 14 éves, egy árvaházból kerül nevelőszüleihez, és nem a legnépszerűbb srác az iskolában…de Shazam, az ősöreg, különleges erejű varázsló mégis kiválasztja. Amikor a srác hangosan kimondja: a varázsló nevét, átalakul. Igazi szuperhős válik belőle, annak minden kellékével: testhezálló, köpönyeggel kiegészített ruha, különleges eszközök, rendkívüli erő és meghökkentő képességek.", new Guid("481b5fce-fc4c-4bec-a076-3a1cae11e560"), "Shazam!", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("31fa3699-44fd-4fa4-8a20-7f3d14a354d6"), "Avagy a játéknak soha nincs vége", new Guid("4ecf735a-95c7-4a63-a9d9-4b98f8fe591b"), "Négyszögletű Kerek Erdő", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("8d5a9a83-3003-4afe-be5b-e57f6542703f"), "FÖRCH MAGYAR KUPA", new Guid("e2206d09-4313-43d7-be77-c08a14165e98"), "FTC-Telekom : DVTK", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("e0f539c1-edef-48a8-a495-13f6d35393e2"), "Egy óra.", new Guid("960801d7-36d2-46b3-81d4-468ab05a1ec3"), "Pihentető masszás (1 óra)", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("d2e35109-8473-42f8-ab4e-f5b622e47530"), "Másfél óra.", new Guid("960801d7-36d2-46b3-81d4-468ab05a1ec3"), "Pihentető masszás (1,5 óra)", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("93a6b227-fea5-457c-87cd-db021191ba0a"), "Két óra.", new Guid("960801d7-36d2-46b3-81d4-468ab05a1ec3"), "Pihentető masszás (2 óra)", "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "ImageId", "Name" },
                values: new object[,]
                {
                    { new Guid("1378b134-ab32-4504-9b37-8dc8cffb41d6"), new Guid("b5af72ea-7c6e-4a9a-8683-38a15e325053"), "Mozik" },
                    { new Guid("21f19257-8d37-4097-bef7-d4a9300f766a"), new Guid("4f237a06-9297-4b86-9ad2-cefd4ee95b35"), "Színházak" },
                    { new Guid("06226189-5384-429a-92da-cb3767e2e4de"), new Guid("6e9c798a-d077-4e6a-9c9d-c7a8e0cca1e8"), "Sport" },
                    { new Guid("4ef109a3-fff0-4e2c-9fea-0515d3ee9a1e"), new Guid("dd83df06-e039-4f04-95b8-28a26b6fba1a"), "Szabadidő" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "ImageId", "Name", "Street", "TypeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("8b49bcff-e923-4916-a2bb-ded947e90c7d"), "Budapest", "A 13 termes Cinema City Allee 2009. óta várja vendégeit a legjobb premier filmekkel - egyik termében kizárólag eredeti nyelvű filmvetítésekkel - az év minden napján. Nyitvatartás: pénztárnyitás az első előadás előtt 30 perccel, pénztár zárás az utolsó előadás kezdete után 15 perccel.", new Guid("7af3ed91-4d35-4fdf-a9a8-62156902b1ff"), "CinemaCity Alle", "Október huszonharmadika u. 8-10", new Guid("1378b134-ab32-4504-9b37-8dc8cffb41d6"), null },
                    { new Guid("43f74c5e-1222-4f88-9485-310c4640c3df"), "Budapest", "A CINEMApink MOM Park a jelenleg elérhető legjobb képminőséggel, prémium hangrendszerrel, kényelmi extrákkal és a legújabb sikerfilmekkel várja!", new Guid("a35a82b0-4751-48b0-9dae-d8fc6e01c805"), "CINEMApink MOM Park", "Alkotás u. 53", new Guid("1378b134-ab32-4504-9b37-8dc8cffb41d6"), null },
                    { new Guid("70e9e8e5-7833-4f7a-a425-f9a447739e95"), "Budapest", "Madách Színház néven több színházi vállalkozás is létrejött századunkban Budapesten. 1919-ben a Zeneakadémia kistermében Madách Színház néven kísérletezett egy társulat, mely zömmel a frontról hazatért, szerződés nélküli színészekből alakult. Alig több mint egy évig működtek, új típusú programmal indultak, legnagyobb sikerük a százas szériát futó Holnap reggel című Karinthy Frigyes dráma előadása.", new Guid("2b8c9710-e47f-45e1-883b-9e2cd513e978"), "Madách Színház", "Erzsébet krt. 29-33", new Guid("21f19257-8d37-4097-bef7-d4a9300f766a"), null },
                    { new Guid("52853a99-bfec-4565-a57b-69118112f184"), "Budapest", "Corvin Dumaszínház", new Guid("eda5ec13-f96d-4560-8456-02a5c844c63c"), "Corvin Dumaszínház", "Corvin sétány 1 1/b", new Guid("21f19257-8d37-4097-bef7-d4a9300f766a"), null },
                    { new Guid("6dc36bc3-5c54-46b3-9fca-edd8ef35f026"), "Budapest", "„BEST OF BUDAPEST & HUNGARY 2017” DÍJAT NYERT A FRADI OTTHONA, A GROUPAMA ARÉNA!", new Guid("8a7e43e0-8e58-4e34-b4f5-2023eb8b1b96"), "Groupama Aréna", "Üllői út 129", new Guid("06226189-5384-429a-92da-cb3767e2e4de"), null },
                    { new Guid("d29d1e7b-fe82-48cc-8a48-377877c190a3"), "Budapest", "Ha többre vágysz egy átlagos pihenésnél... nálunk egyszerre átélheted akár egy kényeztető wellness hétvége minden jótékony hatását vagy gyermekként élvezheted az Aquaworld élményekkel teli világát.", new Guid("5f32dad5-3a06-47af-9d38-c528a6967fff"), "Aquaworld Resort Budapest", "Íves út 16", new Guid("4ef109a3-fff0-4e2c-9fea-0515d3ee9a1e"), null }
                });

            migrationBuilder.InsertData(
                table: "ServiceEvent",
                columns: new[] { "EventId", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("dba73196-153f-4263-9f6f-a06265549fb6"), new Guid("8b49bcff-e923-4916-a2bb-ded947e90c7d") },
                    { new Guid("9a7f8b97-7929-4291-97bf-e867651e679d"), new Guid("8b49bcff-e923-4916-a2bb-ded947e90c7d") },
                    { new Guid("dba73196-153f-4263-9f6f-a06265549fb6"), new Guid("43f74c5e-1222-4f88-9485-310c4640c3df") },
                    { new Guid("9a7f8b97-7929-4291-97bf-e867651e679d"), new Guid("43f74c5e-1222-4f88-9485-310c4640c3df") },
                    { new Guid("31fa3699-44fd-4fa4-8a20-7f3d14a354d6"), new Guid("70e9e8e5-7833-4f7a-a425-f9a447739e95") },
                    { new Guid("8d5a9a83-3003-4afe-be5b-e57f6542703f"), new Guid("6dc36bc3-5c54-46b3-9fca-edd8ef35f026") },
                    { new Guid("e0f539c1-edef-48a8-a495-13f6d35393e2"), new Guid("d29d1e7b-fe82-48cc-8a48-377877c190a3") },
                    { new Guid("d2e35109-8473-42f8-ab4e-f5b622e47530"), new Guid("d29d1e7b-fe82-48cc-8a48-377877c190a3") },
                    { new Guid("93a6b227-fea5-457c-87cd-db021191ba0a"), new Guid("d29d1e7b-fe82-48cc-8a48-377877c190a3") }
                });

            migrationBuilder.InsertData(
                table: "ServicePlaces",
                columns: new[] { "Id", "LayoutImageId", "Name", "ServiceId", "UserId" },
                values: new object[,]
                {
                    { new Guid("8e57f3c9-c3ff-479c-8062-039877ec4f85"), new Guid("b6d155e9-06c4-40a2-bf9d-e96b2cab3f1e"), "4 helyes terem(allee)", new Guid("8b49bcff-e923-4916-a2bb-ded947e90c7d"), null },
                    { new Guid("41dbdc37-5e66-4873-826a-ad15a3f390ae"), new Guid("b6d155e9-06c4-40a2-bf9d-e96b2cab3f1e"), "4 helyes terem(mom)", new Guid("43f74c5e-1222-4f88-9485-310c4640c3df"), null },
                    { new Guid("e90b07e6-2070-4951-9bdd-a5ff0329d6e7"), new Guid("b6d155e9-06c4-40a2-bf9d-e96b2cab3f1e"), "4 helyes terem (madách)", new Guid("70e9e8e5-7833-4f7a-a425-f9a447739e95"), null },
                    { new Guid("021a5f78-236b-4027-8205-6bf75227860e"), new Guid("9d005116-dcbe-4f86-99be-a8e1691aa49c"), "10 helyes terem (groupama)", new Guid("6dc36bc3-5c54-46b3-9fca-edd8ef35f026"), null },
                    { new Guid("47d50669-c543-43f5-8b98-9ed166008a97"), new Guid("b6d155e9-06c4-40a2-bf9d-e96b2cab3f1e"), "4 helyes terem (aquaworld)", new Guid("d29d1e7b-fe82-48cc-8a48-377877c190a3"), null }
                });

            migrationBuilder.InsertData(
                table: "EvenSchedules",
                columns: new[] { "Id", "Description", "EventId", "From", "ServiceId", "ServicePlaceId", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("e74799ea-65d3-4435-a17c-3a3a35414787"), "", new Guid("dba73196-153f-4263-9f6f-a06265549fb6"), new DateTime(2019, 7, 18, 10, 54, 15, 501, DateTimeKind.Local), new Guid("8b49bcff-e923-4916-a2bb-ded947e90c7d"), new Guid("8e57f3c9-c3ff-479c-8062-039877ec4f85"), new DateTime(2019, 7, 18, 12, 54, 15, 502, DateTimeKind.Local), null },
                    { new Guid("4f1afef9-2249-410a-9b5d-fcb589cccc2b"), "", new Guid("dba73196-153f-4263-9f6f-a06265549fb6"), new DateTime(2019, 7, 18, 12, 54, 15, 502, DateTimeKind.Local), new Guid("8b49bcff-e923-4916-a2bb-ded947e90c7d"), new Guid("8e57f3c9-c3ff-479c-8062-039877ec4f85"), new DateTime(2019, 7, 18, 14, 54, 15, 502, DateTimeKind.Local), null },
                    { new Guid("e14587c4-25eb-4dfd-a7f3-2579f3cd0293"), "", new Guid("dba73196-153f-4263-9f6f-a06265549fb6"), new DateTime(2019, 7, 18, 10, 54, 15, 501, DateTimeKind.Local), new Guid("8b49bcff-e923-4916-a2bb-ded947e90c7d"), new Guid("41dbdc37-5e66-4873-826a-ad15a3f390ae"), new DateTime(2019, 7, 18, 12, 54, 15, 502, DateTimeKind.Local), null },
                    { new Guid("1342018d-0ad2-4918-9e01-3f5e02995504"), "", new Guid("dba73196-153f-4263-9f6f-a06265549fb6"), new DateTime(2019, 7, 18, 12, 54, 15, 502, DateTimeKind.Local), new Guid("43f74c5e-1222-4f88-9485-310c4640c3df"), new Guid("41dbdc37-5e66-4873-826a-ad15a3f390ae"), new DateTime(2019, 7, 18, 14, 54, 15, 502, DateTimeKind.Local), null }
                });

            migrationBuilder.InsertData(
                table: "ServicePlacePositions",
                columns: new[] { "Id", "Name", "ServicePlaceId" },
                values: new object[,]
                {
                    { new Guid("83b605db-0107-430f-8d74-0ab86c4e67cd"), "A2", new Guid("47d50669-c543-43f5-8b98-9ed166008a97") },
                    { new Guid("698bcd88-7b95-4995-a7a8-064daa516663"), "A1", new Guid("47d50669-c543-43f5-8b98-9ed166008a97") },
                    { new Guid("4b000cb6-321f-42ea-adba-05bf8172eb0b"), "A4", new Guid("e90b07e6-2070-4951-9bdd-a5ff0329d6e7") },
                    { new Guid("a66ecbd1-f1b5-4592-bc2e-ce0e7cc74010"), "A3", new Guid("e90b07e6-2070-4951-9bdd-a5ff0329d6e7") },
                    { new Guid("5a64fb30-9202-4414-90c5-d9fb65c1c528"), "A2", new Guid("e90b07e6-2070-4951-9bdd-a5ff0329d6e7") },
                    { new Guid("a6f5a649-fb99-4982-bae3-04a53099d340"), "A1", new Guid("e90b07e6-2070-4951-9bdd-a5ff0329d6e7") },
                    { new Guid("001d2195-11d4-4763-82c0-3d9d39c6a42a"), "A4", new Guid("41dbdc37-5e66-4873-826a-ad15a3f390ae") },
                    { new Guid("73b6ff7b-786c-4b4e-bf9c-62f269ba3b68"), "A2", new Guid("41dbdc37-5e66-4873-826a-ad15a3f390ae") },
                    { new Guid("5f26f7dd-42f5-40d2-924a-370c2239df51"), "A3", new Guid("47d50669-c543-43f5-8b98-9ed166008a97") },
                    { new Guid("9e05234f-7dc0-439d-a4c1-1c66454e8ef3"), "A1", new Guid("41dbdc37-5e66-4873-826a-ad15a3f390ae") },
                    { new Guid("ca9ebea0-fe77-4c23-9662-938e6ca98607"), "A4", new Guid("8e57f3c9-c3ff-479c-8062-039877ec4f85") },
                    { new Guid("893be820-c059-4a6d-a3e0-2dda1b4519a5"), "A3", new Guid("8e57f3c9-c3ff-479c-8062-039877ec4f85") },
                    { new Guid("c925e77f-406b-463f-9cc3-c1d8001bfedd"), "A2", new Guid("8e57f3c9-c3ff-479c-8062-039877ec4f85") },
                    { new Guid("e36fd015-db66-40bc-b04f-45aa0d8f6adb"), "A1", new Guid("8e57f3c9-c3ff-479c-8062-039877ec4f85") },
                    { new Guid("ca05da2f-1335-454a-8bce-190fd9fc6140"), "A3", new Guid("41dbdc37-5e66-4873-826a-ad15a3f390ae") },
                    { new Guid("222fd582-75bd-4761-bcd4-ae297d7eabaa"), "A4", new Guid("47d50669-c543-43f5-8b98-9ed166008a97") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Services_UserId",
                table: "Services",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicePlaces_UserId",
                table: "ServicePlaces",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EvenSchedules_UserId",
                table: "EvenSchedules",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_EvenSchedules_AspNetUsers_UserId",
                table: "EvenSchedules",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ServicePlaces_AspNetUsers_UserId",
                table: "ServicePlaces",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_AspNetUsers_UserId",
                table: "Services",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EvenSchedules_AspNetUsers_UserId",
                table: "EvenSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_ServicePlaces_AspNetUsers_UserId",
                table: "ServicePlaces");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_AspNetUsers_UserId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_UserId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_ServicePlaces_UserId",
                table: "ServicePlaces");

            migrationBuilder.DropIndex(
                name: "IX_EvenSchedules_UserId",
                table: "EvenSchedules");

            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("1342018d-0ad2-4918-9e01-3f5e02995504"));

            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("4f1afef9-2249-410a-9b5d-fcb589cccc2b"));

            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("e14587c4-25eb-4dfd-a7f3-2579f3cd0293"));

            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("e74799ea-65d3-4435-a17c-3a3a35414787"));

            migrationBuilder.DeleteData(
                table: "ServiceEvent",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("31fa3699-44fd-4fa4-8a20-7f3d14a354d6"), new Guid("70e9e8e5-7833-4f7a-a425-f9a447739e95") });

            migrationBuilder.DeleteData(
                table: "ServiceEvent",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("8d5a9a83-3003-4afe-be5b-e57f6542703f"), new Guid("6dc36bc3-5c54-46b3-9fca-edd8ef35f026") });

            migrationBuilder.DeleteData(
                table: "ServiceEvent",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("93a6b227-fea5-457c-87cd-db021191ba0a"), new Guid("d29d1e7b-fe82-48cc-8a48-377877c190a3") });

            migrationBuilder.DeleteData(
                table: "ServiceEvent",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("9a7f8b97-7929-4291-97bf-e867651e679d"), new Guid("43f74c5e-1222-4f88-9485-310c4640c3df") });

            migrationBuilder.DeleteData(
                table: "ServiceEvent",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("9a7f8b97-7929-4291-97bf-e867651e679d"), new Guid("8b49bcff-e923-4916-a2bb-ded947e90c7d") });

            migrationBuilder.DeleteData(
                table: "ServiceEvent",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("d2e35109-8473-42f8-ab4e-f5b622e47530"), new Guid("d29d1e7b-fe82-48cc-8a48-377877c190a3") });

            migrationBuilder.DeleteData(
                table: "ServiceEvent",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("dba73196-153f-4263-9f6f-a06265549fb6"), new Guid("43f74c5e-1222-4f88-9485-310c4640c3df") });

            migrationBuilder.DeleteData(
                table: "ServiceEvent",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("dba73196-153f-4263-9f6f-a06265549fb6"), new Guid("8b49bcff-e923-4916-a2bb-ded947e90c7d") });

            migrationBuilder.DeleteData(
                table: "ServiceEvent",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("e0f539c1-edef-48a8-a495-13f6d35393e2"), new Guid("d29d1e7b-fe82-48cc-8a48-377877c190a3") });

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("001d2195-11d4-4763-82c0-3d9d39c6a42a"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("222fd582-75bd-4761-bcd4-ae297d7eabaa"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("4b000cb6-321f-42ea-adba-05bf8172eb0b"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("5a64fb30-9202-4414-90c5-d9fb65c1c528"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("5f26f7dd-42f5-40d2-924a-370c2239df51"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("698bcd88-7b95-4995-a7a8-064daa516663"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("73b6ff7b-786c-4b4e-bf9c-62f269ba3b68"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("83b605db-0107-430f-8d74-0ab86c4e67cd"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("893be820-c059-4a6d-a3e0-2dda1b4519a5"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("9e05234f-7dc0-439d-a4c1-1c66454e8ef3"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("a66ecbd1-f1b5-4592-bc2e-ce0e7cc74010"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("a6f5a649-fb99-4982-bae3-04a53099d340"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("c925e77f-406b-463f-9cc3-c1d8001bfedd"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("ca05da2f-1335-454a-8bce-190fd9fc6140"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("ca9ebea0-fe77-4c23-9662-938e6ca98607"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("e36fd015-db66-40bc-b04f-45aa0d8f6adb"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("021a5f78-236b-4027-8205-6bf75227860e"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("52853a99-bfec-4565-a57b-69118112f184"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("31fa3699-44fd-4fa4-8a20-7f3d14a354d6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("8d5a9a83-3003-4afe-be5b-e57f6542703f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("93a6b227-fea5-457c-87cd-db021191ba0a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("9a7f8b97-7929-4291-97bf-e867651e679d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("d2e35109-8473-42f8-ab4e-f5b622e47530"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("dba73196-153f-4263-9f6f-a06265549fb6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e0f539c1-edef-48a8-a495-13f6d35393e2"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("9d005116-dcbe-4f86-99be-a8e1691aa49c"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("eda5ec13-f96d-4560-8456-02a5c844c63c"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("41dbdc37-5e66-4873-826a-ad15a3f390ae"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("47d50669-c543-43f5-8b98-9ed166008a97"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("8e57f3c9-c3ff-479c-8062-039877ec4f85"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("e90b07e6-2070-4951-9bdd-a5ff0329d6e7"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6dc36bc3-5c54-46b3-9fca-edd8ef35f026"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("0ab0163a-d66b-49a7-b3e5-aedbe6ac475c"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("481b5fce-fc4c-4bec-a076-3a1cae11e560"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("4ecf735a-95c7-4a63-a9d9-4b98f8fe591b"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("8a7e43e0-8e58-4e34-b4f5-2023eb8b1b96"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("960801d7-36d2-46b3-81d4-468ab05a1ec3"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b6d155e9-06c4-40a2-bf9d-e96b2cab3f1e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("e2206d09-4313-43d7-be77-c08a14165e98"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("06226189-5384-429a-92da-cb3767e2e4de"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("43f74c5e-1222-4f88-9485-310c4640c3df"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("70e9e8e5-7833-4f7a-a425-f9a447739e95"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("8b49bcff-e923-4916-a2bb-ded947e90c7d"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("d29d1e7b-fe82-48cc-8a48-377877c190a3"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2b8c9710-e47f-45e1-883b-9e2cd513e978"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5f32dad5-3a06-47af-9d38-c528a6967fff"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("6e9c798a-d077-4e6a-9c9d-c7a8e0cca1e8"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("7af3ed91-4d35-4fdf-a9a8-62156902b1ff"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a35a82b0-4751-48b0-9dae-d8fc6e01c805"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("1378b134-ab32-4504-9b37-8dc8cffb41d6"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("21f19257-8d37-4097-bef7-d4a9300f766a"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("4ef109a3-fff0-4e2c-9fea-0515d3ee9a1e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("4f237a06-9297-4b86-9ad2-cefd4ee95b35"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b5af72ea-7c6e-4a9a-8683-38a15e325053"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("dd83df06-e039-4f04-95b8-28a26b6fba1a"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ServicePlaces");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "EvenSchedules");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59317E0A-8F55-46F9-BF5A-A81680A41964",
                column: "ConcurrencyStamp",
                value: "b5fe7c04-c43f-4ead-bf42-b9405e23c6c5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c2c894d9-e835-4c09-b4ac-f8d18254a5c4", "AQAAAAEAACcQAAAAEHHO4fYEN4QG9yuKtpmp/r1+SjUpv9m8hwyQTeZaLYS+xusQaV8ULqowuyPtrnwMiw==" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Content", "Extension", "Name" },
                values: new object[,]
                {
                    { new Guid("e442453f-b7ca-408c-8f24-7b0ff5327e72"), null, "svg", "t10.svg" },
                    { new Guid("965f9442-bcb0-4c85-bfe7-86bab000a7d4"), null, "svg", "t4.svg" },
                    { new Guid("67e3d99f-ccc0-4be2-a327-a28e0f50ce56"), null, "png", "masszazs.png" },
                    { new Guid("f4b731b0-a8fe-48f9-ab46-d98c442dc496"), null, "png", "ftc.png" },
                    { new Guid("897f9b1f-a950-4129-af5b-4079a315c381"), null, "png", "negyszogletu.png" },
                    { new Guid("03874a74-d7f8-4502-8ee5-2653b7ae7661"), null, "png", "shazam.png" },
                    { new Guid("7625ad1e-0c3a-4a0d-b15f-867a0395473a"), null, "png", "endgame.png" },
                    { new Guid("cb441dcd-d655-4ed8-be36-663a1432972e"), null, "png", "aquapark.png" },
                    { new Guid("727c2383-97e7-4fc1-a409-ccef46e1d795"), null, "png", "madach.png" },
                    { new Guid("7768477f-3e2d-4ee1-adc1-d5f1132ca612"), null, "png", "groupama.png" },
                    { new Guid("2b9214a6-b007-482d-8718-cc2b47a165fd"), null, "png", "mom.png" },
                    { new Guid("297f8fa9-48cb-42b9-a5c1-91b98b458b36"), null, "png", "alle.png" },
                    { new Guid("385f82c0-58cd-4686-a75c-2bd6de275bee"), null, "png", "spa.png" },
                    { new Guid("38e8da3d-48b0-488f-a2b9-672be52268b9"), null, "png", "sport.png" },
                    { new Guid("aa634a39-46cc-4d76-b2ab-ded146b436cc"), null, "png", "theater.png" },
                    { new Guid("4b598c83-00d9-4925-bf0a-015a5fc2c546"), null, "png", "corvin_duma.png" },
                    { new Guid("03c964c8-cc59-4ec5-9cdf-f830faeb3ab1"), null, "png", "cinema.png" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "ImageId", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("0dbdbf3f-7517-4967-bfa4-b01d6d29bceb"), "Thanos súlyos tette, amivel elpusztította az univerzum élőlényeinek felét és megtörte a Bosszúállókat, a megmaradt hősöket egy végső összecsapásra készteti a Marvel Studios huszonegy filmet megkoronázó, nagyszabású fináléjában, a Bosszúállók: Végjátékban.", new Guid("7625ad1e-0c3a-4a0d-b15f-867a0395473a"), "Bosszúállók: Végjáték", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("5cfe8311-cb39-4e30-8787-a2e37774c4b9"), "Mindannyiunkban ott bujkál a szuperhős – de van, akiből elő is jön. Billy Batson 14 éves, egy árvaházból kerül nevelőszüleihez, és nem a legnépszerűbb srác az iskolában…de Shazam, az ősöreg, különleges erejű varázsló mégis kiválasztja. Amikor a srác hangosan kimondja: a varázsló nevét, átalakul. Igazi szuperhős válik belőle, annak minden kellékével: testhezálló, köpönyeggel kiegészített ruha, különleges eszközök, rendkívüli erő és meghökkentő képességek.", new Guid("03874a74-d7f8-4502-8ee5-2653b7ae7661"), "Shazam!", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("23c78cc0-e33e-4787-84b3-2a2ee319ec13"), "Avagy a játéknak soha nincs vége", new Guid("897f9b1f-a950-4129-af5b-4079a315c381"), "Négyszögletű Kerek Erdő", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("a0eb86cd-1c65-47dc-8178-22f4e46fd73c"), "FÖRCH MAGYAR KUPA", new Guid("f4b731b0-a8fe-48f9-ab46-d98c442dc496"), "FTC-Telekom : DVTK", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("08c9a0b9-c86f-4454-acd3-51f03b3ee434"), "Egy óra.", new Guid("67e3d99f-ccc0-4be2-a327-a28e0f50ce56"), "Pihentető masszás (1 óra)", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("b86063bf-2249-4800-82f6-c653a9ee4f90"), "Másfél óra.", new Guid("67e3d99f-ccc0-4be2-a327-a28e0f50ce56"), "Pihentető masszás (1,5 óra)", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("2872da91-24ac-446c-940f-3a3de122d318"), "Két óra.", new Guid("67e3d99f-ccc0-4be2-a327-a28e0f50ce56"), "Pihentető masszás (2 óra)", "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "ImageId", "Name" },
                values: new object[,]
                {
                    { new Guid("279f65a3-39b2-4e7c-94f2-cb11420bba4c"), new Guid("03c964c8-cc59-4ec5-9cdf-f830faeb3ab1"), "Mozik" },
                    { new Guid("1fee0599-3ba1-48f1-b1aa-74b4a8a3acca"), new Guid("aa634a39-46cc-4d76-b2ab-ded146b436cc"), "Színházak" },
                    { new Guid("048be27e-bfb2-4bef-a03d-02a891d16197"), new Guid("38e8da3d-48b0-488f-a2b9-672be52268b9"), "Sport" },
                    { new Guid("7656296e-dccd-4e6a-8dc9-ff9d46205de1"), new Guid("385f82c0-58cd-4686-a75c-2bd6de275bee"), "Szabadidő" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "ImageId", "Name", "Street", "TypeId" },
                values: new object[,]
                {
                    { new Guid("41e9be60-6648-4d59-8d6f-b173def33981"), "Budapest", "A 13 termes Cinema City Allee 2009. óta várja vendégeit a legjobb premier filmekkel - egyik termében kizárólag eredeti nyelvű filmvetítésekkel - az év minden napján. Nyitvatartás: pénztárnyitás az első előadás előtt 30 perccel, pénztár zárás az utolsó előadás kezdete után 15 perccel.", new Guid("297f8fa9-48cb-42b9-a5c1-91b98b458b36"), "CinemaCity Alle", "Október huszonharmadika u. 8-10", new Guid("279f65a3-39b2-4e7c-94f2-cb11420bba4c") },
                    { new Guid("e0b4e09c-27f8-4bd8-9911-756ef749f5ad"), "Budapest", "A CINEMApink MOM Park a jelenleg elérhető legjobb képminőséggel, prémium hangrendszerrel, kényelmi extrákkal és a legújabb sikerfilmekkel várja!", new Guid("2b9214a6-b007-482d-8718-cc2b47a165fd"), "CINEMApink MOM Park", "Alkotás u. 53", new Guid("279f65a3-39b2-4e7c-94f2-cb11420bba4c") },
                    { new Guid("68cd14af-0138-44b1-99dd-85ea813e1679"), "Budapest", "Madách Színház néven több színházi vállalkozás is létrejött századunkban Budapesten. 1919-ben a Zeneakadémia kistermében Madách Színház néven kísérletezett egy társulat, mely zömmel a frontról hazatért, szerződés nélküli színészekből alakult. Alig több mint egy évig működtek, új típusú programmal indultak, legnagyobb sikerük a százas szériát futó Holnap reggel című Karinthy Frigyes dráma előadása.", new Guid("727c2383-97e7-4fc1-a409-ccef46e1d795"), "Madách Színház", "Erzsébet krt. 29-33", new Guid("1fee0599-3ba1-48f1-b1aa-74b4a8a3acca") },
                    { new Guid("26aba2be-ccb6-43d7-a740-afae6609f082"), "Budapest", "Corvin Dumaszínház", new Guid("4b598c83-00d9-4925-bf0a-015a5fc2c546"), "Corvin Dumaszínház", "Corvin sétány 1 1/b", new Guid("1fee0599-3ba1-48f1-b1aa-74b4a8a3acca") },
                    { new Guid("dc164a23-0aa3-4c82-b2eb-06b0b88b33ba"), "Budapest", "„BEST OF BUDAPEST & HUNGARY 2017” DÍJAT NYERT A FRADI OTTHONA, A GROUPAMA ARÉNA!", new Guid("7768477f-3e2d-4ee1-adc1-d5f1132ca612"), "Groupama Aréna", "Üllői út 129", new Guid("048be27e-bfb2-4bef-a03d-02a891d16197") },
                    { new Guid("a8bfd4a5-befe-4e26-a683-33327067c8e7"), "Budapest", "Ha többre vágysz egy átlagos pihenésnél... nálunk egyszerre átélheted akár egy kényeztető wellness hétvége minden jótékony hatását vagy gyermekként élvezheted az Aquaworld élményekkel teli világát.", new Guid("cb441dcd-d655-4ed8-be36-663a1432972e"), "Aquaworld Resort Budapest", "Íves út 16", new Guid("7656296e-dccd-4e6a-8dc9-ff9d46205de1") }
                });

            migrationBuilder.InsertData(
                table: "ServiceEvent",
                columns: new[] { "EventId", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("0dbdbf3f-7517-4967-bfa4-b01d6d29bceb"), new Guid("41e9be60-6648-4d59-8d6f-b173def33981") },
                    { new Guid("5cfe8311-cb39-4e30-8787-a2e37774c4b9"), new Guid("41e9be60-6648-4d59-8d6f-b173def33981") },
                    { new Guid("0dbdbf3f-7517-4967-bfa4-b01d6d29bceb"), new Guid("e0b4e09c-27f8-4bd8-9911-756ef749f5ad") },
                    { new Guid("5cfe8311-cb39-4e30-8787-a2e37774c4b9"), new Guid("e0b4e09c-27f8-4bd8-9911-756ef749f5ad") },
                    { new Guid("23c78cc0-e33e-4787-84b3-2a2ee319ec13"), new Guid("68cd14af-0138-44b1-99dd-85ea813e1679") },
                    { new Guid("a0eb86cd-1c65-47dc-8178-22f4e46fd73c"), new Guid("dc164a23-0aa3-4c82-b2eb-06b0b88b33ba") },
                    { new Guid("08c9a0b9-c86f-4454-acd3-51f03b3ee434"), new Guid("a8bfd4a5-befe-4e26-a683-33327067c8e7") },
                    { new Guid("b86063bf-2249-4800-82f6-c653a9ee4f90"), new Guid("a8bfd4a5-befe-4e26-a683-33327067c8e7") },
                    { new Guid("2872da91-24ac-446c-940f-3a3de122d318"), new Guid("a8bfd4a5-befe-4e26-a683-33327067c8e7") }
                });

            migrationBuilder.InsertData(
                table: "ServicePlaces",
                columns: new[] { "Id", "LayoutImageId", "Name", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("b577a8be-b0b3-41a6-83d5-707c079c1f55"), new Guid("965f9442-bcb0-4c85-bfe7-86bab000a7d4"), "4 helyes terem(allee)", new Guid("41e9be60-6648-4d59-8d6f-b173def33981") },
                    { new Guid("22b5f743-76b3-4559-a67e-05440d0a7566"), new Guid("965f9442-bcb0-4c85-bfe7-86bab000a7d4"), "4 helyes terem(mom)", new Guid("e0b4e09c-27f8-4bd8-9911-756ef749f5ad") },
                    { new Guid("c8ecb943-d195-453d-8025-46e19cffdaa5"), new Guid("965f9442-bcb0-4c85-bfe7-86bab000a7d4"), "4 helyes terem (madách)", new Guid("68cd14af-0138-44b1-99dd-85ea813e1679") },
                    { new Guid("47eb7711-2dea-4f0d-b4b2-2ac4861242fe"), new Guid("e442453f-b7ca-408c-8f24-7b0ff5327e72"), "10 helyes terem (groupama)", new Guid("dc164a23-0aa3-4c82-b2eb-06b0b88b33ba") },
                    { new Guid("9cb1387c-c1ba-4905-9117-4fd925ae2608"), new Guid("965f9442-bcb0-4c85-bfe7-86bab000a7d4"), "4 helyes terem (aquaworld)", new Guid("a8bfd4a5-befe-4e26-a683-33327067c8e7") }
                });

            migrationBuilder.InsertData(
                table: "EvenSchedules",
                columns: new[] { "Id", "Description", "EventId", "From", "ServiceId", "ServicePlaceId", "To" },
                values: new object[,]
                {
                    { new Guid("947bce20-0d33-4603-8913-914e3085ff0b"), "", new Guid("0dbdbf3f-7517-4967-bfa4-b01d6d29bceb"), new DateTime(2019, 5, 14, 20, 6, 23, 761, DateTimeKind.Local), new Guid("41e9be60-6648-4d59-8d6f-b173def33981"), new Guid("b577a8be-b0b3-41a6-83d5-707c079c1f55"), new DateTime(2019, 5, 14, 22, 6, 23, 765, DateTimeKind.Local) },
                    { new Guid("74a70a06-ba76-45fb-b690-4ee3269fc301"), "", new Guid("0dbdbf3f-7517-4967-bfa4-b01d6d29bceb"), new DateTime(2019, 5, 14, 22, 6, 23, 765, DateTimeKind.Local), new Guid("41e9be60-6648-4d59-8d6f-b173def33981"), new Guid("b577a8be-b0b3-41a6-83d5-707c079c1f55"), new DateTime(2019, 5, 15, 0, 6, 23, 765, DateTimeKind.Local) },
                    { new Guid("f950005c-da88-4a5a-b049-6c72df637df3"), "", new Guid("0dbdbf3f-7517-4967-bfa4-b01d6d29bceb"), new DateTime(2019, 5, 14, 20, 6, 23, 761, DateTimeKind.Local), new Guid("41e9be60-6648-4d59-8d6f-b173def33981"), new Guid("22b5f743-76b3-4559-a67e-05440d0a7566"), new DateTime(2019, 5, 14, 22, 6, 23, 765, DateTimeKind.Local) },
                    { new Guid("b0008e62-df01-469d-9800-ae6e0fabfeb3"), "", new Guid("0dbdbf3f-7517-4967-bfa4-b01d6d29bceb"), new DateTime(2019, 5, 14, 22, 6, 23, 765, DateTimeKind.Local), new Guid("e0b4e09c-27f8-4bd8-9911-756ef749f5ad"), new Guid("22b5f743-76b3-4559-a67e-05440d0a7566"), new DateTime(2019, 5, 15, 0, 6, 23, 765, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "ServicePlacePositions",
                columns: new[] { "Id", "Name", "ServicePlaceId" },
                values: new object[,]
                {
                    { new Guid("bdf11c3f-bbec-4fe0-92e2-62e55d47d03c"), "A2", new Guid("9cb1387c-c1ba-4905-9117-4fd925ae2608") },
                    { new Guid("bb3a80c1-f7da-4729-a001-4a65d61de844"), "A1", new Guid("9cb1387c-c1ba-4905-9117-4fd925ae2608") },
                    { new Guid("7885ae73-58ff-47e1-ab3b-010db458987b"), "A4", new Guid("c8ecb943-d195-453d-8025-46e19cffdaa5") },
                    { new Guid("d7465d8a-3c2c-4f6d-9d37-6e47b78af3b9"), "A3", new Guid("c8ecb943-d195-453d-8025-46e19cffdaa5") },
                    { new Guid("12c4e609-43d3-4957-9221-b47baafb4e5b"), "A2", new Guid("c8ecb943-d195-453d-8025-46e19cffdaa5") },
                    { new Guid("4237d65d-7a8b-4e3a-8e90-53255a828f8c"), "A1", new Guid("c8ecb943-d195-453d-8025-46e19cffdaa5") },
                    { new Guid("dc6428c4-4dde-43ea-89cb-f0914ba9852a"), "A4", new Guid("22b5f743-76b3-4559-a67e-05440d0a7566") },
                    { new Guid("2e41f38e-d6ed-4bfa-a0c9-225f052384f8"), "A2", new Guid("22b5f743-76b3-4559-a67e-05440d0a7566") },
                    { new Guid("02fb5dc2-05c6-4625-afb3-273bd408fbb7"), "A3", new Guid("9cb1387c-c1ba-4905-9117-4fd925ae2608") },
                    { new Guid("d84b368c-5b1b-4b42-b600-553309db8ba2"), "A1", new Guid("22b5f743-76b3-4559-a67e-05440d0a7566") },
                    { new Guid("b6b432c0-810c-4289-9560-2caeb6476d07"), "A4", new Guid("b577a8be-b0b3-41a6-83d5-707c079c1f55") },
                    { new Guid("71022dc9-4e62-470b-97a9-98bd8d04657e"), "A3", new Guid("b577a8be-b0b3-41a6-83d5-707c079c1f55") },
                    { new Guid("f26730fc-986b-4255-8aaf-e97b0b147c4d"), "A2", new Guid("b577a8be-b0b3-41a6-83d5-707c079c1f55") },
                    { new Guid("bee08999-8585-4561-8bfc-e5d050c64f32"), "A1", new Guid("b577a8be-b0b3-41a6-83d5-707c079c1f55") },
                    { new Guid("49089f47-e42d-401e-9d6f-c4994778d231"), "A3", new Guid("22b5f743-76b3-4559-a67e-05440d0a7566") },
                    { new Guid("8e76cf6a-3832-49f2-ba0c-a2b06cd614a4"), "A4", new Guid("9cb1387c-c1ba-4905-9117-4fd925ae2608") }
                });
        }
    }
}
