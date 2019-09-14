using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class dbsetChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceEvent_Events_EventId",
                table: "ServiceEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceEvent_Services_ServiceId",
                table: "ServiceEvent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceEvent",
                table: "ServiceEvent");

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

            migrationBuilder.RenameTable(
                name: "ServiceEvent",
                newName: "ServiceEvents");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceEvent_ServiceId",
                table: "ServiceEvents",
                newName: "IX_ServiceEvents_ServiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceEvents",
                table: "ServiceEvents",
                columns: new[] { "EventId", "ServiceId" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59317E0A-8F55-46F9-BF5A-A81680A41964",
                column: "ConcurrencyStamp",
                value: "16bdf2cd-79d2-438c-a6aa-4e0d26262b6f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "59627fb5-ec6e-4909-a951-1dbc267def76", "AQAAAAEAACcQAAAAEGhJp9AX7viRUHhLgo5L0VkxkEWjvJxYigCUvZ3/1pH8SFd3iTsYTp034a+d18gRiA==" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Content", "Extension", "Name" },
                values: new object[,]
                {
                    { new Guid("c53b3366-4bb1-472c-8fda-439d44efb5a5"), null, "svg", "t10.svg" },
                    { new Guid("1ddd52aa-8864-4f55-9e8a-6a014ef2a783"), null, "svg", "t4.svg" },
                    { new Guid("d3daee66-c582-41c2-84ee-2bf3eb5ee82a"), null, "png", "masszazs.png" },
                    { new Guid("dfb2a838-2e1b-47d5-9307-1c81c3a7943b"), null, "png", "ftc.png" },
                    { new Guid("8dc3a817-b7b1-465c-a70c-1d8dcdf54c71"), null, "png", "negyszogletu.png" },
                    { new Guid("9585b911-9030-4918-8bc7-2856a2cc6772"), null, "png", "shazam.png" },
                    { new Guid("6ccb851e-b14e-4e28-b7e1-c3da3a8bbd21"), null, "png", "endgame.png" },
                    { new Guid("8619ffdb-30d3-46fb-8d4e-d3ea87706487"), null, "png", "aquapark.png" },
                    { new Guid("375ba3d7-2c9b-49c7-97a8-4d41ea25a092"), null, "png", "madach.png" },
                    { new Guid("69ede672-96b0-40c8-b1b2-480c8548e9a6"), null, "png", "groupama.png" },
                    { new Guid("a7eed056-0461-4c88-a4c1-cbd4d28cb948"), null, "png", "mom.png" },
                    { new Guid("306eafd9-3431-4848-b78e-779c4277fc2a"), null, "png", "alle.png" },
                    { new Guid("3e08dcae-fcc2-4d9e-b3ea-d4787dcc6263"), null, "png", "spa.png" },
                    { new Guid("68a267b3-3fc5-4b38-be1d-35b7cce673b1"), null, "png", "sport.png" },
                    { new Guid("a6b21a35-cee6-49d3-98df-8c7d90e3c831"), null, "png", "theater.png" },
                    { new Guid("032b419c-358e-4168-9897-b6348ec1f3a9"), null, "png", "corvin_duma.png" },
                    { new Guid("d31992a4-d45d-4323-a28c-070f48a723ad"), null, "png", "cinema.png" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "ImageId", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("22f9d41b-0b06-4f76-acc2-45fb36a96ac7"), "Thanos súlyos tette, amivel elpusztította az univerzum élőlényeinek felét és megtörte a Bosszúállókat, a megmaradt hősöket egy végső összecsapásra készteti a Marvel Studios huszonegy filmet megkoronázó, nagyszabású fináléjában, a Bosszúállók: Végjátékban.", new Guid("6ccb851e-b14e-4e28-b7e1-c3da3a8bbd21"), "Bosszúállók: Végjáték", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("e9141e68-1390-49c8-8bc9-4455287c51b6"), "Mindannyiunkban ott bujkál a szuperhős – de van, akiből elő is jön. Billy Batson 14 éves, egy árvaházból kerül nevelőszüleihez, és nem a legnépszerűbb srác az iskolában…de Shazam, az ősöreg, különleges erejű varázsló mégis kiválasztja. Amikor a srác hangosan kimondja: a varázsló nevét, átalakul. Igazi szuperhős válik belőle, annak minden kellékével: testhezálló, köpönyeggel kiegészített ruha, különleges eszközök, rendkívüli erő és meghökkentő képességek.", new Guid("9585b911-9030-4918-8bc7-2856a2cc6772"), "Shazam!", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("b4d1535a-963c-4081-9ccd-90d440788dff"), "Avagy a játéknak soha nincs vége", new Guid("8dc3a817-b7b1-465c-a70c-1d8dcdf54c71"), "Négyszögletű Kerek Erdő", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("cef08499-c7de-4494-9fa6-1c0b00346f0c"), "FÖRCH MAGYAR KUPA", new Guid("dfb2a838-2e1b-47d5-9307-1c81c3a7943b"), "FTC-Telekom : DVTK", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("93b3c0dd-f7ca-4715-8532-d3454e3d4a89"), "Egy óra.", new Guid("d3daee66-c582-41c2-84ee-2bf3eb5ee82a"), "Pihentető masszás (1 óra)", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("fe6cc18b-1827-46d1-bd09-e046e4ff3126"), "Másfél óra.", new Guid("d3daee66-c582-41c2-84ee-2bf3eb5ee82a"), "Pihentető masszás (1,5 óra)", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("eae9d35e-0af4-4da5-9404-44e5752fd7de"), "Két óra.", new Guid("d3daee66-c582-41c2-84ee-2bf3eb5ee82a"), "Pihentető masszás (2 óra)", "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "ImageId", "Name" },
                values: new object[,]
                {
                    { new Guid("9dfa33ee-2300-4f62-b7fe-2b3a100b5860"), new Guid("d31992a4-d45d-4323-a28c-070f48a723ad"), "Mozik" },
                    { new Guid("d778ccea-6b01-48cb-be2d-52ae99ff74b7"), new Guid("a6b21a35-cee6-49d3-98df-8c7d90e3c831"), "Színházak" },
                    { new Guid("f5f0fc60-8a8f-4c77-9179-68ab676ba9b8"), new Guid("68a267b3-3fc5-4b38-be1d-35b7cce673b1"), "Sport" },
                    { new Guid("8136592c-2752-42b8-8a28-20c83a5b4f0f"), new Guid("3e08dcae-fcc2-4d9e-b3ea-d4787dcc6263"), "Szabadidő" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "ImageId", "Name", "Street", "TypeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("bdc8b70b-ed6d-4ead-8f8b-121dda44301d"), "Budapest", "A 13 termes Cinema City Allee 2009. óta várja vendégeit a legjobb premier filmekkel - egyik termében kizárólag eredeti nyelvű filmvetítésekkel - az év minden napján. Nyitvatartás: pénztárnyitás az első előadás előtt 30 perccel, pénztár zárás az utolsó előadás kezdete után 15 perccel.", new Guid("306eafd9-3431-4848-b78e-779c4277fc2a"), "CinemaCity Alle", "Október huszonharmadika u. 8-10", new Guid("9dfa33ee-2300-4f62-b7fe-2b3a100b5860"), null },
                    { new Guid("41c4af48-5d35-415a-b128-9d63ea17f4b2"), "Budapest", "A CINEMApink MOM Park a jelenleg elérhető legjobb képminőséggel, prémium hangrendszerrel, kényelmi extrákkal és a legújabb sikerfilmekkel várja!", new Guid("a7eed056-0461-4c88-a4c1-cbd4d28cb948"), "CINEMApink MOM Park", "Alkotás u. 53", new Guid("9dfa33ee-2300-4f62-b7fe-2b3a100b5860"), null },
                    { new Guid("073fbf1b-ad3d-4153-a0fd-512a8882fa31"), "Budapest", "Madách Színház néven több színházi vállalkozás is létrejött századunkban Budapesten. 1919-ben a Zeneakadémia kistermében Madách Színház néven kísérletezett egy társulat, mely zömmel a frontról hazatért, szerződés nélküli színészekből alakult. Alig több mint egy évig működtek, új típusú programmal indultak, legnagyobb sikerük a százas szériát futó Holnap reggel című Karinthy Frigyes dráma előadása.", new Guid("375ba3d7-2c9b-49c7-97a8-4d41ea25a092"), "Madách Színház", "Erzsébet krt. 29-33", new Guid("d778ccea-6b01-48cb-be2d-52ae99ff74b7"), null },
                    { new Guid("9b37bca6-bcf3-45ad-8d1a-7fc6f5abde1d"), "Budapest", "Corvin Dumaszínház", new Guid("032b419c-358e-4168-9897-b6348ec1f3a9"), "Corvin Dumaszínház", "Corvin sétány 1 1/b", new Guid("d778ccea-6b01-48cb-be2d-52ae99ff74b7"), null },
                    { new Guid("c5a49b18-62d7-47df-9731-7f5972e86e7a"), "Budapest", "„BEST OF BUDAPEST & HUNGARY 2017” DÍJAT NYERT A FRADI OTTHONA, A GROUPAMA ARÉNA!", new Guid("69ede672-96b0-40c8-b1b2-480c8548e9a6"), "Groupama Aréna", "Üllői út 129", new Guid("f5f0fc60-8a8f-4c77-9179-68ab676ba9b8"), null },
                    { new Guid("1da2bd88-daf5-440c-9e25-2b235086cfb5"), "Budapest", "Ha többre vágysz egy átlagos pihenésnél... nálunk egyszerre átélheted akár egy kényeztető wellness hétvége minden jótékony hatását vagy gyermekként élvezheted az Aquaworld élményekkel teli világát.", new Guid("8619ffdb-30d3-46fb-8d4e-d3ea87706487"), "Aquaworld Resort Budapest", "Íves út 16", new Guid("8136592c-2752-42b8-8a28-20c83a5b4f0f"), null }
                });

            migrationBuilder.InsertData(
                table: "ServiceEvents",
                columns: new[] { "EventId", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("22f9d41b-0b06-4f76-acc2-45fb36a96ac7"), new Guid("bdc8b70b-ed6d-4ead-8f8b-121dda44301d") },
                    { new Guid("e9141e68-1390-49c8-8bc9-4455287c51b6"), new Guid("bdc8b70b-ed6d-4ead-8f8b-121dda44301d") },
                    { new Guid("22f9d41b-0b06-4f76-acc2-45fb36a96ac7"), new Guid("41c4af48-5d35-415a-b128-9d63ea17f4b2") },
                    { new Guid("e9141e68-1390-49c8-8bc9-4455287c51b6"), new Guid("41c4af48-5d35-415a-b128-9d63ea17f4b2") },
                    { new Guid("b4d1535a-963c-4081-9ccd-90d440788dff"), new Guid("073fbf1b-ad3d-4153-a0fd-512a8882fa31") },
                    { new Guid("cef08499-c7de-4494-9fa6-1c0b00346f0c"), new Guid("c5a49b18-62d7-47df-9731-7f5972e86e7a") },
                    { new Guid("93b3c0dd-f7ca-4715-8532-d3454e3d4a89"), new Guid("1da2bd88-daf5-440c-9e25-2b235086cfb5") },
                    { new Guid("fe6cc18b-1827-46d1-bd09-e046e4ff3126"), new Guid("1da2bd88-daf5-440c-9e25-2b235086cfb5") },
                    { new Guid("eae9d35e-0af4-4da5-9404-44e5752fd7de"), new Guid("1da2bd88-daf5-440c-9e25-2b235086cfb5") }
                });

            migrationBuilder.InsertData(
                table: "ServicePlaces",
                columns: new[] { "Id", "LayoutImageId", "Name", "ServiceId", "UserId" },
                values: new object[,]
                {
                    { new Guid("3a9e2b40-457d-4978-bb71-20fd5904dc95"), new Guid("1ddd52aa-8864-4f55-9e8a-6a014ef2a783"), "4 helyes terem(allee)", new Guid("bdc8b70b-ed6d-4ead-8f8b-121dda44301d"), null },
                    { new Guid("57d7c2ae-23af-4a28-8672-76f0c73de317"), new Guid("1ddd52aa-8864-4f55-9e8a-6a014ef2a783"), "4 helyes terem(mom)", new Guid("41c4af48-5d35-415a-b128-9d63ea17f4b2"), null },
                    { new Guid("106a5e0b-8837-4897-a106-a946ccff3f48"), new Guid("1ddd52aa-8864-4f55-9e8a-6a014ef2a783"), "4 helyes terem (madách)", new Guid("073fbf1b-ad3d-4153-a0fd-512a8882fa31"), null },
                    { new Guid("30f7c1b5-b9b6-4aeb-8072-fd3fb4ff892e"), new Guid("c53b3366-4bb1-472c-8fda-439d44efb5a5"), "10 helyes terem (groupama)", new Guid("c5a49b18-62d7-47df-9731-7f5972e86e7a"), null },
                    { new Guid("27fcccd2-f32e-40ed-9aaa-c2803f22d197"), new Guid("1ddd52aa-8864-4f55-9e8a-6a014ef2a783"), "4 helyes terem (aquaworld)", new Guid("1da2bd88-daf5-440c-9e25-2b235086cfb5"), null }
                });

            migrationBuilder.InsertData(
                table: "EvenSchedules",
                columns: new[] { "Id", "Description", "EventId", "From", "ServiceId", "ServicePlaceId", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("eede4d1f-52c7-4c32-ba24-ec85540919a5"), "", new Guid("22f9d41b-0b06-4f76-acc2-45fb36a96ac7"), new DateTime(2019, 9, 14, 19, 34, 59, 571, DateTimeKind.Local), new Guid("bdc8b70b-ed6d-4ead-8f8b-121dda44301d"), new Guid("3a9e2b40-457d-4978-bb71-20fd5904dc95"), new DateTime(2019, 9, 14, 21, 34, 59, 573, DateTimeKind.Local), null },
                    { new Guid("e78ae7ca-3148-48c3-8b0b-7e94801ad10f"), "", new Guid("22f9d41b-0b06-4f76-acc2-45fb36a96ac7"), new DateTime(2019, 9, 14, 21, 34, 59, 573, DateTimeKind.Local), new Guid("bdc8b70b-ed6d-4ead-8f8b-121dda44301d"), new Guid("3a9e2b40-457d-4978-bb71-20fd5904dc95"), new DateTime(2019, 9, 14, 23, 34, 59, 573, DateTimeKind.Local), null },
                    { new Guid("c165bbde-92a8-4586-a66f-cccb614ae7be"), "", new Guid("22f9d41b-0b06-4f76-acc2-45fb36a96ac7"), new DateTime(2019, 9, 14, 19, 34, 59, 571, DateTimeKind.Local), new Guid("bdc8b70b-ed6d-4ead-8f8b-121dda44301d"), new Guid("57d7c2ae-23af-4a28-8672-76f0c73de317"), new DateTime(2019, 9, 14, 21, 34, 59, 573, DateTimeKind.Local), null },
                    { new Guid("f28c5a4b-7a05-4049-bc81-a0a9f9a86c6e"), "", new Guid("22f9d41b-0b06-4f76-acc2-45fb36a96ac7"), new DateTime(2019, 9, 14, 21, 34, 59, 573, DateTimeKind.Local), new Guid("41c4af48-5d35-415a-b128-9d63ea17f4b2"), new Guid("57d7c2ae-23af-4a28-8672-76f0c73de317"), new DateTime(2019, 9, 14, 23, 34, 59, 573, DateTimeKind.Local), null }
                });

            migrationBuilder.InsertData(
                table: "ServicePlacePositions",
                columns: new[] { "Id", "Name", "ServicePlaceId" },
                values: new object[,]
                {
                    { new Guid("e37adfc7-cf54-4fd0-af7b-e84bf82805ea"), "A2", new Guid("27fcccd2-f32e-40ed-9aaa-c2803f22d197") },
                    { new Guid("303e430c-deee-4eac-936a-f3c7921a0ed3"), "A1", new Guid("27fcccd2-f32e-40ed-9aaa-c2803f22d197") },
                    { new Guid("02d51612-25d5-4a21-a760-eeacc0057483"), "A4", new Guid("106a5e0b-8837-4897-a106-a946ccff3f48") },
                    { new Guid("559a81fb-2aba-4793-9f5f-cfa9ffec1303"), "A3", new Guid("106a5e0b-8837-4897-a106-a946ccff3f48") },
                    { new Guid("9c2dea15-647b-4840-bfcf-47cf26dbc907"), "A2", new Guid("106a5e0b-8837-4897-a106-a946ccff3f48") },
                    { new Guid("441df5f4-3275-4bf1-99c6-43cce5e66019"), "A1", new Guid("106a5e0b-8837-4897-a106-a946ccff3f48") },
                    { new Guid("05f0c058-f880-4620-8cc2-66e050806fa9"), "A4", new Guid("57d7c2ae-23af-4a28-8672-76f0c73de317") },
                    { new Guid("3bef16cc-2a1e-45e8-a3b7-49a442c08b04"), "A2", new Guid("57d7c2ae-23af-4a28-8672-76f0c73de317") },
                    { new Guid("2ab46f29-fa8a-4627-88dc-1e2b6efd7bac"), "A3", new Guid("27fcccd2-f32e-40ed-9aaa-c2803f22d197") },
                    { new Guid("9363b3e0-d037-4d72-936c-7f8f6477c05c"), "A1", new Guid("57d7c2ae-23af-4a28-8672-76f0c73de317") },
                    { new Guid("d03c39e0-789a-41c1-9110-ddd96d9add8c"), "A4", new Guid("3a9e2b40-457d-4978-bb71-20fd5904dc95") },
                    { new Guid("a36dd087-acec-4a45-959d-cb76a5dc9bab"), "A3", new Guid("3a9e2b40-457d-4978-bb71-20fd5904dc95") },
                    { new Guid("a110991f-eb16-48f3-91f2-6ae0beb8d840"), "A2", new Guid("3a9e2b40-457d-4978-bb71-20fd5904dc95") },
                    { new Guid("c74e18e9-111c-4105-a1db-cc30e44b4fb5"), "A1", new Guid("3a9e2b40-457d-4978-bb71-20fd5904dc95") },
                    { new Guid("5ec247f7-a8b3-42ec-b277-28ab8bb70728"), "A3", new Guid("57d7c2ae-23af-4a28-8672-76f0c73de317") },
                    { new Guid("77dcc314-7fc6-4bb9-9af1-617204e938a4"), "A4", new Guid("27fcccd2-f32e-40ed-9aaa-c2803f22d197") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceEvents_Events_EventId",
                table: "ServiceEvents",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceEvents_Services_ServiceId",
                table: "ServiceEvents",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceEvents_Events_EventId",
                table: "ServiceEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceEvents_Services_ServiceId",
                table: "ServiceEvents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceEvents",
                table: "ServiceEvents");

            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("c165bbde-92a8-4586-a66f-cccb614ae7be"));

            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("e78ae7ca-3148-48c3-8b0b-7e94801ad10f"));

            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("eede4d1f-52c7-4c32-ba24-ec85540919a5"));

            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("f28c5a4b-7a05-4049-bc81-a0a9f9a86c6e"));

            migrationBuilder.DeleteData(
                table: "ServiceEvents",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("22f9d41b-0b06-4f76-acc2-45fb36a96ac7"), new Guid("41c4af48-5d35-415a-b128-9d63ea17f4b2") });

            migrationBuilder.DeleteData(
                table: "ServiceEvents",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("22f9d41b-0b06-4f76-acc2-45fb36a96ac7"), new Guid("bdc8b70b-ed6d-4ead-8f8b-121dda44301d") });

            migrationBuilder.DeleteData(
                table: "ServiceEvents",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("93b3c0dd-f7ca-4715-8532-d3454e3d4a89"), new Guid("1da2bd88-daf5-440c-9e25-2b235086cfb5") });

            migrationBuilder.DeleteData(
                table: "ServiceEvents",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("b4d1535a-963c-4081-9ccd-90d440788dff"), new Guid("073fbf1b-ad3d-4153-a0fd-512a8882fa31") });

            migrationBuilder.DeleteData(
                table: "ServiceEvents",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("cef08499-c7de-4494-9fa6-1c0b00346f0c"), new Guid("c5a49b18-62d7-47df-9731-7f5972e86e7a") });

            migrationBuilder.DeleteData(
                table: "ServiceEvents",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("e9141e68-1390-49c8-8bc9-4455287c51b6"), new Guid("41c4af48-5d35-415a-b128-9d63ea17f4b2") });

            migrationBuilder.DeleteData(
                table: "ServiceEvents",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("e9141e68-1390-49c8-8bc9-4455287c51b6"), new Guid("bdc8b70b-ed6d-4ead-8f8b-121dda44301d") });

            migrationBuilder.DeleteData(
                table: "ServiceEvents",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("eae9d35e-0af4-4da5-9404-44e5752fd7de"), new Guid("1da2bd88-daf5-440c-9e25-2b235086cfb5") });

            migrationBuilder.DeleteData(
                table: "ServiceEvents",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("fe6cc18b-1827-46d1-bd09-e046e4ff3126"), new Guid("1da2bd88-daf5-440c-9e25-2b235086cfb5") });

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("02d51612-25d5-4a21-a760-eeacc0057483"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("05f0c058-f880-4620-8cc2-66e050806fa9"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("2ab46f29-fa8a-4627-88dc-1e2b6efd7bac"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("303e430c-deee-4eac-936a-f3c7921a0ed3"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("3bef16cc-2a1e-45e8-a3b7-49a442c08b04"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("441df5f4-3275-4bf1-99c6-43cce5e66019"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("559a81fb-2aba-4793-9f5f-cfa9ffec1303"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("5ec247f7-a8b3-42ec-b277-28ab8bb70728"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("77dcc314-7fc6-4bb9-9af1-617204e938a4"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("9363b3e0-d037-4d72-936c-7f8f6477c05c"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("9c2dea15-647b-4840-bfcf-47cf26dbc907"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("a110991f-eb16-48f3-91f2-6ae0beb8d840"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("a36dd087-acec-4a45-959d-cb76a5dc9bab"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("c74e18e9-111c-4105-a1db-cc30e44b4fb5"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("d03c39e0-789a-41c1-9110-ddd96d9add8c"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("e37adfc7-cf54-4fd0-af7b-e84bf82805ea"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("30f7c1b5-b9b6-4aeb-8072-fd3fb4ff892e"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("9b37bca6-bcf3-45ad-8d1a-7fc6f5abde1d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("22f9d41b-0b06-4f76-acc2-45fb36a96ac7"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("93b3c0dd-f7ca-4715-8532-d3454e3d4a89"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("b4d1535a-963c-4081-9ccd-90d440788dff"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("cef08499-c7de-4494-9fa6-1c0b00346f0c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e9141e68-1390-49c8-8bc9-4455287c51b6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("eae9d35e-0af4-4da5-9404-44e5752fd7de"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("fe6cc18b-1827-46d1-bd09-e046e4ff3126"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("032b419c-358e-4168-9897-b6348ec1f3a9"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("c53b3366-4bb1-472c-8fda-439d44efb5a5"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("106a5e0b-8837-4897-a106-a946ccff3f48"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("27fcccd2-f32e-40ed-9aaa-c2803f22d197"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("3a9e2b40-457d-4978-bb71-20fd5904dc95"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("57d7c2ae-23af-4a28-8672-76f0c73de317"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("c5a49b18-62d7-47df-9731-7f5972e86e7a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("1ddd52aa-8864-4f55-9e8a-6a014ef2a783"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("69ede672-96b0-40c8-b1b2-480c8548e9a6"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("6ccb851e-b14e-4e28-b7e1-c3da3a8bbd21"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("8dc3a817-b7b1-465c-a70c-1d8dcdf54c71"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("9585b911-9030-4918-8bc7-2856a2cc6772"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d3daee66-c582-41c2-84ee-2bf3eb5ee82a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("dfb2a838-2e1b-47d5-9307-1c81c3a7943b"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("f5f0fc60-8a8f-4c77-9179-68ab676ba9b8"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("073fbf1b-ad3d-4153-a0fd-512a8882fa31"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("1da2bd88-daf5-440c-9e25-2b235086cfb5"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("41c4af48-5d35-415a-b128-9d63ea17f4b2"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("bdc8b70b-ed6d-4ead-8f8b-121dda44301d"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("306eafd9-3431-4848-b78e-779c4277fc2a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("375ba3d7-2c9b-49c7-97a8-4d41ea25a092"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("68a267b3-3fc5-4b38-be1d-35b7cce673b1"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("8619ffdb-30d3-46fb-8d4e-d3ea87706487"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a7eed056-0461-4c88-a4c1-cbd4d28cb948"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("8136592c-2752-42b8-8a28-20c83a5b4f0f"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("9dfa33ee-2300-4f62-b7fe-2b3a100b5860"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("d778ccea-6b01-48cb-be2d-52ae99ff74b7"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3e08dcae-fcc2-4d9e-b3ea-d4787dcc6263"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a6b21a35-cee6-49d3-98df-8c7d90e3c831"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d31992a4-d45d-4323-a28c-070f48a723ad"));

            migrationBuilder.RenameTable(
                name: "ServiceEvents",
                newName: "ServiceEvent");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceEvents_ServiceId",
                table: "ServiceEvent",
                newName: "IX_ServiceEvent_ServiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceEvent",
                table: "ServiceEvent",
                columns: new[] { "EventId", "ServiceId" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceEvent_Events_EventId",
                table: "ServiceEvent",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceEvent_Services_ServiceId",
                table: "ServiceEvent",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
