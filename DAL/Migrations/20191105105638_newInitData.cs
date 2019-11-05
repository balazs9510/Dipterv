using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class newInitData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("0868c0c3-7be5-4b9b-b6e5-79a0ed81384d"));

            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("a3625495-420a-41e3-861e-f394eae9f384"));

            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("bd9fad4f-4206-4036-9bd1-80c08dd1ba58"));

            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d33d2d1d-89d8-443e-800a-57505707ea0d"));

            migrationBuilder.DeleteData(
                table: "ServiceEvents",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("0d765255-7c31-4395-8218-a4f32c41c3d3"), new Guid("221eb09e-00c5-4ebb-8a1e-75ede4c05950") });

            migrationBuilder.DeleteData(
                table: "ServiceEvents",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("235dc3e9-7783-46db-9439-0c2893236b46"), new Guid("7415e445-013b-4f54-a228-63165a8f969b") });

            migrationBuilder.DeleteData(
                table: "ServiceEvents",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("25dc3518-e7e1-4acb-9101-97188771782d"), new Guid("221eb09e-00c5-4ebb-8a1e-75ede4c05950") });

            migrationBuilder.DeleteData(
                table: "ServiceEvents",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("b0dedf96-e69c-46bc-ae44-7c136ad4adf6"), new Guid("5109d33a-5bce-4d51-a920-2612c773d0ed") });

            migrationBuilder.DeleteData(
                table: "ServiceEvents",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("b0dedf96-e69c-46bc-ae44-7c136ad4adf6"), new Guid("5ab7a6d4-5e05-480c-a473-fbca8b6c511e") });

            migrationBuilder.DeleteData(
                table: "ServiceEvents",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("c7d23a7e-1e39-468f-b289-2c9072c82da8"), new Guid("307a5d83-40ae-4df9-8c25-6433fb571a60") });

            migrationBuilder.DeleteData(
                table: "ServiceEvents",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("d02b9ebe-6b69-4501-b54e-cc7da9179d3e"), new Guid("5109d33a-5bce-4d51-a920-2612c773d0ed") });

            migrationBuilder.DeleteData(
                table: "ServiceEvents",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("d02b9ebe-6b69-4501-b54e-cc7da9179d3e"), new Guid("5ab7a6d4-5e05-480c-a473-fbca8b6c511e") });

            migrationBuilder.DeleteData(
                table: "ServiceEvents",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("d30959e7-ccf0-45dc-ab60-a5c36b42bc34"), new Guid("221eb09e-00c5-4ebb-8a1e-75ede4c05950") });

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("00473d15-affa-49c9-a1b0-de867cb04559"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("13c26d08-5405-40e4-be0a-62dcf0fd0578"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("2cd89e64-1c2a-4901-a701-a2eb2e56c345"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("33a38cd7-17e1-44a4-af32-3e08724dd348"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("47a6d737-6202-4850-a794-0f586c1e4cb8"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("50d14075-776e-4a36-933e-0deca9dbb987"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("59686326-a43e-4fa7-9919-cde7ce95f2eb"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("693d6695-03be-4a37-b026-dacf32416396"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("6cffa015-1d0e-41a0-ae76-70bda94fe206"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("7c177b8b-9f6a-40bd-a3fa-1fa5e399278e"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("8f5f9683-a1b0-459e-8801-3862b98456f3"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("9d687017-8d7c-4031-88f3-8dc5188cfa55"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("a9c9cd87-b4f0-4d79-aeec-85811950a3b4"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("abe4ed19-e7ce-492d-bd80-02467e07282d"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("be61d476-6fbb-4fa3-b67a-7ab6f957eef4"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("f12ba09b-0347-4443-8d32-54b7cbdfdc05"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("1f9afb63-2c3a-4fb7-b0e2-6bc3fd794151"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("40f379a7-033e-4886-80d9-f94d342cfaa1"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("0d765255-7c31-4395-8218-a4f32c41c3d3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("235dc3e9-7783-46db-9439-0c2893236b46"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("25dc3518-e7e1-4acb-9101-97188771782d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("b0dedf96-e69c-46bc-ae44-7c136ad4adf6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("c7d23a7e-1e39-468f-b289-2c9072c82da8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("d02b9ebe-6b69-4501-b54e-cc7da9179d3e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("d30959e7-ccf0-45dc-ab60-a5c36b42bc34"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("27085f99-ff6b-4cdd-b3af-c3b28d0a6894"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("8117bcb5-126b-4a8a-a313-348683d004cc"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("2553c85d-b95e-49b9-ac0f-a59e47c15d8d"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("6c5eb7be-0f2f-4c11-98ae-797fabf73293"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("9a5fc6cd-57ba-4060-b33e-87311baf23b0"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("d0cf801c-ef14-44f8-809b-1741a9b755c0"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("7415e445-013b-4f54-a228-63165a8f969b"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("1808cb52-1035-4666-97e4-314fb61b667d"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("6b60bad5-faf1-4d86-9afb-692e786dc295"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("7917cd6e-5148-44c9-9842-74fe097af7fd"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("91483404-87a3-4830-b083-b44d9bdcf5bc"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("93fd0c33-3f74-4dc3-a3e7-e12fbb199ee6"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a3bddae0-0492-446a-b65e-2276dac45033"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d956e6d5-af00-455f-b648-994a7ee4d824"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("4fa6edec-e7d3-4c88-b990-0efd99c713b4"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("221eb09e-00c5-4ebb-8a1e-75ede4c05950"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("307a5d83-40ae-4df9-8c25-6433fb571a60"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("5109d33a-5bce-4d51-a920-2612c773d0ed"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("5ab7a6d4-5e05-480c-a473-fbca8b6c511e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("274663ee-bdcb-48bc-9db8-a6ad2a7d4c55"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("34b6aaae-1852-4273-8ea9-3d3e3ea33703"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("7637a166-c565-4a06-bce2-6391eb2137e2"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("84526581-a935-421f-9865-1e5d31cb3d1f"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("bafe0567-48d4-4c78-b588-9a0ec69cc4ba"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("01dd128f-40ab-4dc0-a544-55e97b327591"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("5c0bc8c5-4e05-483c-97ac-f810d400b191"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("840a697d-2411-4072-848c-f6d64075cd79"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("efad6f97-5a70-42b4-9af2-998e0ad1e5ce"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f167931f-adec-4ff5-bc6e-e6cfd33d2092"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f1b6dc09-1dfd-4070-a476-6488099eaa77"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59317E0A-8F55-46F9-BF5A-A81680A41964",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "454ab521-095f-4feb-981a-72787cae0a4d", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "487bdd19-dc0a-4208-911c-6141988e6b51", "d156f84f-6875-4e95-8d59-6ac545769127", "SystemAdmin", "SYSTEMADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8d6429d0-f8a9-4b5c-835a-f226a816f8ca", "AQAAAAEAACcQAAAAEM6ojca5Vkxl8jEO1i+OtZTLtD+Hu6ixFooak1tjvD/xU4pzkfoHFU15Wixau+hZQQ==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4366b4cd-06f4-4d81-aeb5-7cd2d1795743", 0, "60021c74-b6d8-46e9-9c85-8b85feebef8f", "sysadmin@admin.hu", true, false, null, "sysadmin@admin.hu", "sysadmin", "AQAAAAEAACcQAAAAEDm6GZ2UDjwq9k2ICzYgSAbz6ibZ731JJtASdP4qBMRehtUJgFFYB80ywLa8O4FlEw==", null, false, "", false, "sysadmin" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Content", "Extension", "Name" },
                values: new object[,]
                {
                    { new Guid("2ecc93e0-08e2-4b00-8197-3fede4b3aa4d"), null, "svg", "test.png" },
                    { new Guid("a0e1483f-b0ca-4050-845a-c047bec64e0f"), null, "svg", "t10.svg" },
                    { new Guid("96fa095c-2e45-4e27-9c2b-006292f586b6"), null, "svg", "t4.svg" },
                    { new Guid("c8ed6b84-5d2c-43dd-a5cf-5be2e7d5f6de"), null, "png", "masszazs.png" },
                    { new Guid("080e75ab-16c6-44a2-a841-2e281da58bfe"), null, "png", "ftc.png" },
                    { new Guid("54ee2a0d-e3a2-4359-9737-15f3c2c3bf6e"), null, "png", "negyszogletu.png" },
                    { new Guid("9449ce7c-cc01-4998-8f99-0785ef0f6463"), null, "png", "shazam.png" },
                    { new Guid("7d5b9241-f40c-44a0-9ddd-98df4bd59d37"), null, "png", "endgame.png" },
                    { new Guid("685119e1-3614-4ac0-8918-7dcfbb3a55ad"), null, "png", "corvin_duma.png" },
                    { new Guid("2b26e822-14a0-4e2a-88d3-ca06928fc2ab"), null, "png", "madach.png" },
                    { new Guid("0c24621d-e43e-4adf-a9f3-63673a743c21"), null, "png", "groupama.png" },
                    { new Guid("10e451c4-2d06-47e5-a3c2-a7f9188a34de"), null, "png", "mom.png" },
                    { new Guid("abf1830c-f973-4e34-8545-c9839e09fb69"), null, "png", "alle.png" },
                    { new Guid("bb04c23a-1a9a-49a3-8268-2fde72b117e0"), null, "png", "spa.png" },
                    { new Guid("e486bcea-f414-4c59-be7f-6b44f7c76b16"), null, "png", "sport.png" },
                    { new Guid("0fd526e9-b232-4b6a-bd07-525b2ac4c24a"), null, "png", "theater.png" },
                    { new Guid("28c8defb-5bde-4fae-bfc1-668a2e78125a"), null, "png", "aquapark.png" },
                    { new Guid("878806a5-a01e-495a-91ba-9c13c02b0dae"), null, "png", "cinema.png" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "4366b4cd-06f4-4d81-aeb5-7cd2d1795743", "487bdd19-dc0a-4208-911c-6141988e6b51" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "ImageId", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("623d672a-2b92-4118-94cb-50207b8ef0a1"), "Thanos súlyos tette, amivel elpusztította az univerzum élőlényeinek felét és megtörte a Bosszúállókat, a megmaradt hősöket egy végső összecsapásra készteti a Marvel Studios huszonegy filmet megkoronázó, nagyszabású fináléjában, a Bosszúállók: Végjátékban.", new Guid("7d5b9241-f40c-44a0-9ddd-98df4bd59d37"), "Bosszúállók: Végjáték", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("fa02afcf-289b-446b-ba9d-fe2a0b3b42a6"), "Mindannyiunkban ott bujkál a szuperhős – de van, akiből elő is jön. Billy Batson 14 éves, egy árvaházból kerül nevelőszüleihez, és nem a legnépszerűbb srác az iskolában…de Shazam, az ősöreg, különleges erejű varázsló mégis kiválasztja. Amikor a srác hangosan kimondja: a varázsló nevét, átalakul. Igazi szuperhős válik belőle, annak minden kellékével: testhezálló, köpönyeggel kiegészített ruha, különleges eszközök, rendkívüli erő és meghökkentő képességek.", new Guid("9449ce7c-cc01-4998-8f99-0785ef0f6463"), "Shazam!", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("bf63fd48-d4e3-4f74-8965-bd2a7d5a2629"), "Avagy a játéknak soha nincs vége", new Guid("54ee2a0d-e3a2-4359-9737-15f3c2c3bf6e"), "Négyszögletű Kerek Erdő", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("42fea743-2387-4eff-a88e-f5bd3113ae52"), "FÖRCH MAGYAR KUPA", new Guid("080e75ab-16c6-44a2-a841-2e281da58bfe"), "FTC-Telekom : DVTK", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("5b1fe04f-394d-412b-bfb8-00a25e71872d"), "Egy óra.", new Guid("c8ed6b84-5d2c-43dd-a5cf-5be2e7d5f6de"), "Pihentető masszás (1 óra)", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("ad75b84a-9c74-4258-a20f-a828b788e6c5"), "Másfél óra.", new Guid("c8ed6b84-5d2c-43dd-a5cf-5be2e7d5f6de"), "Pihentető masszás (1,5 óra)", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("97f5504d-cb63-4f09-8f0a-8ec16279ffee"), "Két óra.", new Guid("c8ed6b84-5d2c-43dd-a5cf-5be2e7d5f6de"), "Pihentető masszás (2 óra)", "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "ImageId", "Name" },
                values: new object[,]
                {
                    { new Guid("5dffc3a8-0121-43c1-8e76-ba8dfd1f2a08"), new Guid("878806a5-a01e-495a-91ba-9c13c02b0dae"), "Mozik" },
                    { new Guid("dc32d0ae-1a64-4e38-8422-044089e3ef1d"), new Guid("0fd526e9-b232-4b6a-bd07-525b2ac4c24a"), "Színházak" },
                    { new Guid("f8dd7270-6a79-46bf-8a9c-ff02a303a7de"), new Guid("e486bcea-f414-4c59-be7f-6b44f7c76b16"), "Sport" },
                    { new Guid("ca7eb334-41d3-49e0-8916-549cfcfe2643"), new Guid("bb04c23a-1a9a-49a3-8268-2fde72b117e0"), "Szabadidő" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "ImageId", "Name", "Street", "TypeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("4fb05494-28e2-40ba-8b18-4e06f9d29405"), "Budapest", "A 13 termes Cinema City Allee 2009. óta várja vendégeit a legjobb premier filmekkel - egyik termében kizárólag eredeti nyelvű filmvetítésekkel - az év minden napján. Nyitvatartás: pénztárnyitás az első előadás előtt 30 perccel, pénztár zárás az utolsó előadás kezdete után 15 perccel.", new Guid("abf1830c-f973-4e34-8545-c9839e09fb69"), "CinemaCity Alle", "Október huszonharmadika u. 8-10", new Guid("5dffc3a8-0121-43c1-8e76-ba8dfd1f2a08"), null },
                    { new Guid("7b466636-5803-4930-b983-ff29cacadefb"), "Budapest", "A CINEMApink MOM Park a jelenleg elérhető legjobb képminőséggel, prémium hangrendszerrel, kényelmi extrákkal és a legújabb sikerfilmekkel várja!", new Guid("10e451c4-2d06-47e5-a3c2-a7f9188a34de"), "CINEMApink MOM Park", "Alkotás u. 53", new Guid("5dffc3a8-0121-43c1-8e76-ba8dfd1f2a08"), null },
                    { new Guid("f63ecf47-d8ae-45fc-bc82-d9b88f8296f9"), "Budapest", "Madách Színház néven több színházi vállalkozás is létrejött századunkban Budapesten. 1919-ben a Zeneakadémia kistermében Madách Színház néven kísérletezett egy társulat, mely zömmel a frontról hazatért, szerződés nélküli színészekből alakult. Alig több mint egy évig működtek, új típusú programmal indultak, legnagyobb sikerük a százas szériát futó Holnap reggel című Karinthy Frigyes dráma előadása.", new Guid("2b26e822-14a0-4e2a-88d3-ca06928fc2ab"), "Madách Színház", "Erzsébet krt. 29-33", new Guid("dc32d0ae-1a64-4e38-8422-044089e3ef1d"), null },
                    { new Guid("b201616c-0679-4ee1-ab91-6573d9a7af11"), "Budapest", "Corvin Dumaszínház", new Guid("685119e1-3614-4ac0-8918-7dcfbb3a55ad"), "Corvin Dumaszínház", "Corvin sétány 1 1/b", new Guid("dc32d0ae-1a64-4e38-8422-044089e3ef1d"), null },
                    { new Guid("efe358e2-8cb3-45a3-86d2-d36c27ce68fb"), "Budapest", "„BEST OF BUDAPEST & HUNGARY 2017” DÍJAT NYERT A FRADI OTTHONA, A GROUPAMA ARÉNA!", new Guid("0c24621d-e43e-4adf-a9f3-63673a743c21"), "Groupama Aréna", "Üllői út 129", new Guid("f8dd7270-6a79-46bf-8a9c-ff02a303a7de"), null },
                    { new Guid("2995c5b6-5e0f-4b9d-bbfb-3a24793bf35a"), "Budapest", "Ha többre vágysz egy átlagos pihenésnél... nálunk egyszerre átélheted akár egy kényeztető wellness hétvége minden jótékony hatását vagy gyermekként élvezheted az Aquaworld élményekkel teli világát.", new Guid("28c8defb-5bde-4fae-bfc1-668a2e78125a"), "Aquaworld Resort Budapest", "Íves út 16", new Guid("ca7eb334-41d3-49e0-8916-549cfcfe2643"), null }
                });

            migrationBuilder.InsertData(
                table: "ServiceEvents",
                columns: new[] { "EventId", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("623d672a-2b92-4118-94cb-50207b8ef0a1"), new Guid("4fb05494-28e2-40ba-8b18-4e06f9d29405") },
                    { new Guid("fa02afcf-289b-446b-ba9d-fe2a0b3b42a6"), new Guid("4fb05494-28e2-40ba-8b18-4e06f9d29405") },
                    { new Guid("623d672a-2b92-4118-94cb-50207b8ef0a1"), new Guid("7b466636-5803-4930-b983-ff29cacadefb") },
                    { new Guid("fa02afcf-289b-446b-ba9d-fe2a0b3b42a6"), new Guid("7b466636-5803-4930-b983-ff29cacadefb") },
                    { new Guid("bf63fd48-d4e3-4f74-8965-bd2a7d5a2629"), new Guid("f63ecf47-d8ae-45fc-bc82-d9b88f8296f9") },
                    { new Guid("42fea743-2387-4eff-a88e-f5bd3113ae52"), new Guid("efe358e2-8cb3-45a3-86d2-d36c27ce68fb") },
                    { new Guid("5b1fe04f-394d-412b-bfb8-00a25e71872d"), new Guid("2995c5b6-5e0f-4b9d-bbfb-3a24793bf35a") },
                    { new Guid("ad75b84a-9c74-4258-a20f-a828b788e6c5"), new Guid("2995c5b6-5e0f-4b9d-bbfb-3a24793bf35a") },
                    { new Guid("97f5504d-cb63-4f09-8f0a-8ec16279ffee"), new Guid("2995c5b6-5e0f-4b9d-bbfb-3a24793bf35a") }
                });

            migrationBuilder.InsertData(
                table: "ServicePlaces",
                columns: new[] { "Id", "LayoutImageId", "Name", "ServiceId", "UserId" },
                values: new object[,]
                {
                    { new Guid("c3b851fc-288e-4d2b-9a7d-c8de55828841"), new Guid("96fa095c-2e45-4e27-9c2b-006292f586b6"), "4 helyes terem(allee)", new Guid("4fb05494-28e2-40ba-8b18-4e06f9d29405"), null },
                    { new Guid("b0278747-ff55-417a-9c1f-c9f65a47a3bb"), new Guid("96fa095c-2e45-4e27-9c2b-006292f586b6"), "4 helyes terem(mom)", new Guid("7b466636-5803-4930-b983-ff29cacadefb"), null },
                    { new Guid("93c205fb-9a3e-4790-af9d-fcb21cbbad2a"), new Guid("96fa095c-2e45-4e27-9c2b-006292f586b6"), "4 helyes terem (madách)", new Guid("f63ecf47-d8ae-45fc-bc82-d9b88f8296f9"), null },
                    { new Guid("e4a8982a-985b-4f9e-b6fc-5430a7d8b9bc"), new Guid("a0e1483f-b0ca-4050-845a-c047bec64e0f"), "10 helyes terem (groupama)", new Guid("efe358e2-8cb3-45a3-86d2-d36c27ce68fb"), null },
                    { new Guid("ead5fb76-f359-43fc-8837-f547e8aabb16"), new Guid("96fa095c-2e45-4e27-9c2b-006292f586b6"), "4 helyes terem (aquaworld)", new Guid("2995c5b6-5e0f-4b9d-bbfb-3a24793bf35a"), null }
                });

            migrationBuilder.InsertData(
                table: "EvenSchedules",
                columns: new[] { "Id", "Description", "EventId", "From", "ServiceId", "ServicePlaceId", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("bec3e7f2-6e9a-4ba6-93cd-bec1d9696754"), "", new Guid("623d672a-2b92-4118-94cb-50207b8ef0a1"), new DateTime(2019, 11, 5, 11, 56, 37, 1, DateTimeKind.Local), new Guid("4fb05494-28e2-40ba-8b18-4e06f9d29405"), new Guid("c3b851fc-288e-4d2b-9a7d-c8de55828841"), new DateTime(2019, 11, 5, 13, 56, 37, 3, DateTimeKind.Local), null },
                    { new Guid("8a3415de-b1f4-453a-a02e-fd65de022626"), "", new Guid("623d672a-2b92-4118-94cb-50207b8ef0a1"), new DateTime(2019, 11, 5, 13, 56, 37, 3, DateTimeKind.Local), new Guid("4fb05494-28e2-40ba-8b18-4e06f9d29405"), new Guid("c3b851fc-288e-4d2b-9a7d-c8de55828841"), new DateTime(2019, 11, 5, 15, 56, 37, 3, DateTimeKind.Local), null },
                    { new Guid("b1f7ee55-482a-44b1-9dbc-4872529d50d9"), "", new Guid("623d672a-2b92-4118-94cb-50207b8ef0a1"), new DateTime(2019, 11, 5, 11, 56, 37, 1, DateTimeKind.Local), new Guid("4fb05494-28e2-40ba-8b18-4e06f9d29405"), new Guid("b0278747-ff55-417a-9c1f-c9f65a47a3bb"), new DateTime(2019, 11, 5, 13, 56, 37, 3, DateTimeKind.Local), null },
                    { new Guid("1f6008bd-de4e-4f07-9b5a-6ea563701f93"), "", new Guid("623d672a-2b92-4118-94cb-50207b8ef0a1"), new DateTime(2019, 11, 5, 13, 56, 37, 3, DateTimeKind.Local), new Guid("7b466636-5803-4930-b983-ff29cacadefb"), new Guid("b0278747-ff55-417a-9c1f-c9f65a47a3bb"), new DateTime(2019, 11, 5, 15, 56, 37, 3, DateTimeKind.Local), null }
                });

            migrationBuilder.InsertData(
                table: "ServicePlacePositions",
                columns: new[] { "Id", "Name", "ServicePlaceId" },
                values: new object[,]
                {
                    { new Guid("315a5b23-b96c-49c0-8a3b-f8ae06862a36"), "A2", new Guid("ead5fb76-f359-43fc-8837-f547e8aabb16") },
                    { new Guid("e080b7f8-8520-4af3-8f04-b13653bd8a5a"), "A1", new Guid("ead5fb76-f359-43fc-8837-f547e8aabb16") },
                    { new Guid("a55c59bf-d1b9-4804-9d2f-9f3a9d7542b9"), "A4", new Guid("93c205fb-9a3e-4790-af9d-fcb21cbbad2a") },
                    { new Guid("b88fd568-47c8-405e-9ab2-34dab565b7b9"), "A3", new Guid("93c205fb-9a3e-4790-af9d-fcb21cbbad2a") },
                    { new Guid("ddf113e9-acf7-4059-858b-cc8e1acfd0cc"), "A2", new Guid("93c205fb-9a3e-4790-af9d-fcb21cbbad2a") },
                    { new Guid("da6190c7-370d-404e-b77b-f37577db0fb7"), "A1", new Guid("93c205fb-9a3e-4790-af9d-fcb21cbbad2a") },
                    { new Guid("85396881-fc6a-427a-ae65-bcb2f2215152"), "A4", new Guid("b0278747-ff55-417a-9c1f-c9f65a47a3bb") },
                    { new Guid("43272b21-682d-40ff-b0af-d920523c9198"), "A2", new Guid("b0278747-ff55-417a-9c1f-c9f65a47a3bb") },
                    { new Guid("a351374e-2866-4d4f-9f23-c4779f58fbde"), "A3", new Guid("ead5fb76-f359-43fc-8837-f547e8aabb16") },
                    { new Guid("40979da2-a9a9-4c4c-8e45-17377e04195d"), "A1", new Guid("b0278747-ff55-417a-9c1f-c9f65a47a3bb") },
                    { new Guid("4624ca7b-46a5-48e5-847d-832b6ac6dd64"), "A4", new Guid("c3b851fc-288e-4d2b-9a7d-c8de55828841") },
                    { new Guid("44e9eb52-05d6-4d83-9320-0ed6ddd3927b"), "A3", new Guid("c3b851fc-288e-4d2b-9a7d-c8de55828841") },
                    { new Guid("587a8ed1-5653-4f47-a82a-0e5f0b59f57b"), "A2", new Guid("c3b851fc-288e-4d2b-9a7d-c8de55828841") },
                    { new Guid("69102d73-092c-4e5a-9e4c-d84b38bf6187"), "A1", new Guid("c3b851fc-288e-4d2b-9a7d-c8de55828841") },
                    { new Guid("154e6e27-4e78-4c25-bece-778e140e40be"), "A3", new Guid("b0278747-ff55-417a-9c1f-c9f65a47a3bb") },
                    { new Guid("cd0ffde2-6344-4660-9b69-bc3f44c01763"), "A4", new Guid("ead5fb76-f359-43fc-8837-f547e8aabb16") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4366b4cd-06f4-4d81-aeb5-7cd2d1795743", "487bdd19-dc0a-4208-911c-6141988e6b51" });

            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("1f6008bd-de4e-4f07-9b5a-6ea563701f93"));

            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("8a3415de-b1f4-453a-a02e-fd65de022626"));

            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("b1f7ee55-482a-44b1-9dbc-4872529d50d9"));

            migrationBuilder.DeleteData(
                table: "EvenSchedules",
                keyColumn: "Id",
                keyValue: new Guid("bec3e7f2-6e9a-4ba6-93cd-bec1d9696754"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2ecc93e0-08e2-4b00-8197-3fede4b3aa4d"));

            migrationBuilder.DeleteData(
                table: "ServiceEvents",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("42fea743-2387-4eff-a88e-f5bd3113ae52"), new Guid("efe358e2-8cb3-45a3-86d2-d36c27ce68fb") });

            migrationBuilder.DeleteData(
                table: "ServiceEvents",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("5b1fe04f-394d-412b-bfb8-00a25e71872d"), new Guid("2995c5b6-5e0f-4b9d-bbfb-3a24793bf35a") });

            migrationBuilder.DeleteData(
                table: "ServiceEvents",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("623d672a-2b92-4118-94cb-50207b8ef0a1"), new Guid("4fb05494-28e2-40ba-8b18-4e06f9d29405") });

            migrationBuilder.DeleteData(
                table: "ServiceEvents",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("623d672a-2b92-4118-94cb-50207b8ef0a1"), new Guid("7b466636-5803-4930-b983-ff29cacadefb") });

            migrationBuilder.DeleteData(
                table: "ServiceEvents",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("97f5504d-cb63-4f09-8f0a-8ec16279ffee"), new Guid("2995c5b6-5e0f-4b9d-bbfb-3a24793bf35a") });

            migrationBuilder.DeleteData(
                table: "ServiceEvents",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("ad75b84a-9c74-4258-a20f-a828b788e6c5"), new Guid("2995c5b6-5e0f-4b9d-bbfb-3a24793bf35a") });

            migrationBuilder.DeleteData(
                table: "ServiceEvents",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("bf63fd48-d4e3-4f74-8965-bd2a7d5a2629"), new Guid("f63ecf47-d8ae-45fc-bc82-d9b88f8296f9") });

            migrationBuilder.DeleteData(
                table: "ServiceEvents",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("fa02afcf-289b-446b-ba9d-fe2a0b3b42a6"), new Guid("4fb05494-28e2-40ba-8b18-4e06f9d29405") });

            migrationBuilder.DeleteData(
                table: "ServiceEvents",
                keyColumns: new[] { "EventId", "ServiceId" },
                keyValues: new object[] { new Guid("fa02afcf-289b-446b-ba9d-fe2a0b3b42a6"), new Guid("7b466636-5803-4930-b983-ff29cacadefb") });

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("154e6e27-4e78-4c25-bece-778e140e40be"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("315a5b23-b96c-49c0-8a3b-f8ae06862a36"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("40979da2-a9a9-4c4c-8e45-17377e04195d"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("43272b21-682d-40ff-b0af-d920523c9198"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("44e9eb52-05d6-4d83-9320-0ed6ddd3927b"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("4624ca7b-46a5-48e5-847d-832b6ac6dd64"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("587a8ed1-5653-4f47-a82a-0e5f0b59f57b"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("69102d73-092c-4e5a-9e4c-d84b38bf6187"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("85396881-fc6a-427a-ae65-bcb2f2215152"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("a351374e-2866-4d4f-9f23-c4779f58fbde"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("a55c59bf-d1b9-4804-9d2f-9f3a9d7542b9"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("b88fd568-47c8-405e-9ab2-34dab565b7b9"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("cd0ffde2-6344-4660-9b69-bc3f44c01763"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("da6190c7-370d-404e-b77b-f37577db0fb7"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("ddf113e9-acf7-4059-858b-cc8e1acfd0cc"));

            migrationBuilder.DeleteData(
                table: "ServicePlacePositions",
                keyColumn: "Id",
                keyValue: new Guid("e080b7f8-8520-4af3-8f04-b13653bd8a5a"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("e4a8982a-985b-4f9e-b6fc-5430a7d8b9bc"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("b201616c-0679-4ee1-ab91-6573d9a7af11"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "487bdd19-dc0a-4208-911c-6141988e6b51", "d156f84f-6875-4e95-8d59-6ac545769127" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "4366b4cd-06f4-4d81-aeb5-7cd2d1795743", "60021c74-b6d8-46e9-9c85-8b85feebef8f" });

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("42fea743-2387-4eff-a88e-f5bd3113ae52"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("5b1fe04f-394d-412b-bfb8-00a25e71872d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("623d672a-2b92-4118-94cb-50207b8ef0a1"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("97f5504d-cb63-4f09-8f0a-8ec16279ffee"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("ad75b84a-9c74-4258-a20f-a828b788e6c5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("bf63fd48-d4e3-4f74-8965-bd2a7d5a2629"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("fa02afcf-289b-446b-ba9d-fe2a0b3b42a6"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("685119e1-3614-4ac0-8918-7dcfbb3a55ad"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a0e1483f-b0ca-4050-845a-c047bec64e0f"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("93c205fb-9a3e-4790-af9d-fcb21cbbad2a"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("b0278747-ff55-417a-9c1f-c9f65a47a3bb"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("c3b851fc-288e-4d2b-9a7d-c8de55828841"));

            migrationBuilder.DeleteData(
                table: "ServicePlaces",
                keyColumn: "Id",
                keyValue: new Guid("ead5fb76-f359-43fc-8837-f547e8aabb16"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("efe358e2-8cb3-45a3-86d2-d36c27ce68fb"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("080e75ab-16c6-44a2-a841-2e281da58bfe"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("0c24621d-e43e-4adf-a9f3-63673a743c21"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("54ee2a0d-e3a2-4359-9737-15f3c2c3bf6e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("7d5b9241-f40c-44a0-9ddd-98df4bd59d37"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("9449ce7c-cc01-4998-8f99-0785ef0f6463"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("96fa095c-2e45-4e27-9c2b-006292f586b6"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("c8ed6b84-5d2c-43dd-a5cf-5be2e7d5f6de"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("f8dd7270-6a79-46bf-8a9c-ff02a303a7de"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("2995c5b6-5e0f-4b9d-bbfb-3a24793bf35a"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("4fb05494-28e2-40ba-8b18-4e06f9d29405"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("7b466636-5803-4930-b983-ff29cacadefb"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("f63ecf47-d8ae-45fc-bc82-d9b88f8296f9"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("10e451c4-2d06-47e5-a3c2-a7f9188a34de"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("28c8defb-5bde-4fae-bfc1-668a2e78125a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2b26e822-14a0-4e2a-88d3-ca06928fc2ab"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("abf1830c-f973-4e34-8545-c9839e09fb69"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("e486bcea-f414-4c59-be7f-6b44f7c76b16"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("5dffc3a8-0121-43c1-8e76-ba8dfd1f2a08"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("ca7eb334-41d3-49e0-8916-549cfcfe2643"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("dc32d0ae-1a64-4e38-8422-044089e3ef1d"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("0fd526e9-b232-4b6a-bd07-525b2ac4c24a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("878806a5-a01e-495a-91ba-9c13c02b0dae"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("bb04c23a-1a9a-49a3-8268-2fde72b117e0"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59317E0A-8F55-46F9-BF5A-A81680A41964",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3f86a552-eabe-4a59-b3e2-32b239bdabe1", "Administrators", "ADMINISTRATORS" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "78714a36-4370-4751-9927-ffb771263a98", "AQAAAAEAACcQAAAAEOgX6O/AZ5Tn4F5yrQLHeQop5ttyCeER/ioh/uh5z7Ln33j2YBaV8fTvLAM3/5d6Yw==" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Content", "Extension", "Name" },
                values: new object[,]
                {
                    { new Guid("27085f99-ff6b-4cdd-b3af-c3b28d0a6894"), null, "svg", "t10.svg" },
                    { new Guid("a3bddae0-0492-446a-b65e-2276dac45033"), null, "svg", "t4.svg" },
                    { new Guid("6b60bad5-faf1-4d86-9afb-692e786dc295"), null, "png", "masszazs.png" },
                    { new Guid("d956e6d5-af00-455f-b648-994a7ee4d824"), null, "png", "ftc.png" },
                    { new Guid("7917cd6e-5148-44c9-9842-74fe097af7fd"), null, "png", "negyszogletu.png" },
                    { new Guid("1808cb52-1035-4666-97e4-314fb61b667d"), null, "png", "shazam.png" },
                    { new Guid("93fd0c33-3f74-4dc3-a3e7-e12fbb199ee6"), null, "png", "endgame.png" },
                    { new Guid("274663ee-bdcb-48bc-9db8-a6ad2a7d4c55"), null, "png", "aquapark.png" },
                    { new Guid("84526581-a935-421f-9865-1e5d31cb3d1f"), null, "png", "madach.png" },
                    { new Guid("91483404-87a3-4830-b083-b44d9bdcf5bc"), null, "png", "groupama.png" },
                    { new Guid("34b6aaae-1852-4273-8ea9-3d3e3ea33703"), null, "png", "mom.png" },
                    { new Guid("7637a166-c565-4a06-bce2-6391eb2137e2"), null, "png", "alle.png" },
                    { new Guid("efad6f97-5a70-42b4-9af2-998e0ad1e5ce"), null, "png", "spa.png" },
                    { new Guid("bafe0567-48d4-4c78-b588-9a0ec69cc4ba"), null, "png", "sport.png" },
                    { new Guid("f1b6dc09-1dfd-4070-a476-6488099eaa77"), null, "png", "theater.png" },
                    { new Guid("8117bcb5-126b-4a8a-a313-348683d004cc"), null, "png", "corvin_duma.png" },
                    { new Guid("f167931f-adec-4ff5-bc6e-e6cfd33d2092"), null, "png", "cinema.png" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "ImageId", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("d02b9ebe-6b69-4501-b54e-cc7da9179d3e"), "Thanos súlyos tette, amivel elpusztította az univerzum élőlényeinek felét és megtörte a Bosszúállókat, a megmaradt hősöket egy végső összecsapásra készteti a Marvel Studios huszonegy filmet megkoronázó, nagyszabású fináléjában, a Bosszúállók: Végjátékban.", new Guid("93fd0c33-3f74-4dc3-a3e7-e12fbb199ee6"), "Bosszúállók: Végjáték", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("b0dedf96-e69c-46bc-ae44-7c136ad4adf6"), "Mindannyiunkban ott bujkál a szuperhős – de van, akiből elő is jön. Billy Batson 14 éves, egy árvaházból kerül nevelőszüleihez, és nem a legnépszerűbb srác az iskolában…de Shazam, az ősöreg, különleges erejű varázsló mégis kiválasztja. Amikor a srác hangosan kimondja: a varázsló nevét, átalakul. Igazi szuperhős válik belőle, annak minden kellékével: testhezálló, köpönyeggel kiegészített ruha, különleges eszközök, rendkívüli erő és meghökkentő képességek.", new Guid("1808cb52-1035-4666-97e4-314fb61b667d"), "Shazam!", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("c7d23a7e-1e39-468f-b289-2c9072c82da8"), "Avagy a játéknak soha nincs vége", new Guid("7917cd6e-5148-44c9-9842-74fe097af7fd"), "Négyszögletű Kerek Erdő", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("235dc3e9-7783-46db-9439-0c2893236b46"), "FÖRCH MAGYAR KUPA", new Guid("d956e6d5-af00-455f-b648-994a7ee4d824"), "FTC-Telekom : DVTK", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("25dc3518-e7e1-4acb-9101-97188771782d"), "Egy óra.", new Guid("6b60bad5-faf1-4d86-9afb-692e786dc295"), "Pihentető masszás (1 óra)", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("0d765255-7c31-4395-8218-a4f32c41c3d3"), "Másfél óra.", new Guid("6b60bad5-faf1-4d86-9afb-692e786dc295"), "Pihentető masszás (1,5 óra)", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { new Guid("d30959e7-ccf0-45dc-ab60-a5c36b42bc34"), "Két óra.", new Guid("6b60bad5-faf1-4d86-9afb-692e786dc295"), "Pihentető masszás (2 óra)", "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "ImageId", "Name" },
                values: new object[,]
                {
                    { new Guid("840a697d-2411-4072-848c-f6d64075cd79"), new Guid("f167931f-adec-4ff5-bc6e-e6cfd33d2092"), "Mozik" },
                    { new Guid("01dd128f-40ab-4dc0-a544-55e97b327591"), new Guid("f1b6dc09-1dfd-4070-a476-6488099eaa77"), "Színházak" },
                    { new Guid("4fa6edec-e7d3-4c88-b990-0efd99c713b4"), new Guid("bafe0567-48d4-4c78-b588-9a0ec69cc4ba"), "Sport" },
                    { new Guid("5c0bc8c5-4e05-483c-97ac-f810d400b191"), new Guid("efad6f97-5a70-42b4-9af2-998e0ad1e5ce"), "Szabadidő" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "City", "Description", "ImageId", "Name", "Street", "TypeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("5ab7a6d4-5e05-480c-a473-fbca8b6c511e"), "Budapest", "A 13 termes Cinema City Allee 2009. óta várja vendégeit a legjobb premier filmekkel - egyik termében kizárólag eredeti nyelvű filmvetítésekkel - az év minden napján. Nyitvatartás: pénztárnyitás az első előadás előtt 30 perccel, pénztár zárás az utolsó előadás kezdete után 15 perccel.", new Guid("7637a166-c565-4a06-bce2-6391eb2137e2"), "CinemaCity Alle", "Október huszonharmadika u. 8-10", new Guid("840a697d-2411-4072-848c-f6d64075cd79"), null },
                    { new Guid("5109d33a-5bce-4d51-a920-2612c773d0ed"), "Budapest", "A CINEMApink MOM Park a jelenleg elérhető legjobb képminőséggel, prémium hangrendszerrel, kényelmi extrákkal és a legújabb sikerfilmekkel várja!", new Guid("34b6aaae-1852-4273-8ea9-3d3e3ea33703"), "CINEMApink MOM Park", "Alkotás u. 53", new Guid("840a697d-2411-4072-848c-f6d64075cd79"), null },
                    { new Guid("307a5d83-40ae-4df9-8c25-6433fb571a60"), "Budapest", "Madách Színház néven több színházi vállalkozás is létrejött századunkban Budapesten. 1919-ben a Zeneakadémia kistermében Madách Színház néven kísérletezett egy társulat, mely zömmel a frontról hazatért, szerződés nélküli színészekből alakult. Alig több mint egy évig működtek, új típusú programmal indultak, legnagyobb sikerük a százas szériát futó Holnap reggel című Karinthy Frigyes dráma előadása.", new Guid("84526581-a935-421f-9865-1e5d31cb3d1f"), "Madách Színház", "Erzsébet krt. 29-33", new Guid("01dd128f-40ab-4dc0-a544-55e97b327591"), null },
                    { new Guid("40f379a7-033e-4886-80d9-f94d342cfaa1"), "Budapest", "Corvin Dumaszínház", new Guid("8117bcb5-126b-4a8a-a313-348683d004cc"), "Corvin Dumaszínház", "Corvin sétány 1 1/b", new Guid("01dd128f-40ab-4dc0-a544-55e97b327591"), null },
                    { new Guid("7415e445-013b-4f54-a228-63165a8f969b"), "Budapest", "„BEST OF BUDAPEST & HUNGARY 2017” DÍJAT NYERT A FRADI OTTHONA, A GROUPAMA ARÉNA!", new Guid("91483404-87a3-4830-b083-b44d9bdcf5bc"), "Groupama Aréna", "Üllői út 129", new Guid("4fa6edec-e7d3-4c88-b990-0efd99c713b4"), null },
                    { new Guid("221eb09e-00c5-4ebb-8a1e-75ede4c05950"), "Budapest", "Ha többre vágysz egy átlagos pihenésnél... nálunk egyszerre átélheted akár egy kényeztető wellness hétvége minden jótékony hatását vagy gyermekként élvezheted az Aquaworld élményekkel teli világát.", new Guid("274663ee-bdcb-48bc-9db8-a6ad2a7d4c55"), "Aquaworld Resort Budapest", "Íves út 16", new Guid("5c0bc8c5-4e05-483c-97ac-f810d400b191"), null }
                });

            migrationBuilder.InsertData(
                table: "ServiceEvents",
                columns: new[] { "EventId", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("d02b9ebe-6b69-4501-b54e-cc7da9179d3e"), new Guid("5ab7a6d4-5e05-480c-a473-fbca8b6c511e") },
                    { new Guid("b0dedf96-e69c-46bc-ae44-7c136ad4adf6"), new Guid("5ab7a6d4-5e05-480c-a473-fbca8b6c511e") },
                    { new Guid("d02b9ebe-6b69-4501-b54e-cc7da9179d3e"), new Guid("5109d33a-5bce-4d51-a920-2612c773d0ed") },
                    { new Guid("b0dedf96-e69c-46bc-ae44-7c136ad4adf6"), new Guid("5109d33a-5bce-4d51-a920-2612c773d0ed") },
                    { new Guid("c7d23a7e-1e39-468f-b289-2c9072c82da8"), new Guid("307a5d83-40ae-4df9-8c25-6433fb571a60") },
                    { new Guid("235dc3e9-7783-46db-9439-0c2893236b46"), new Guid("7415e445-013b-4f54-a228-63165a8f969b") },
                    { new Guid("25dc3518-e7e1-4acb-9101-97188771782d"), new Guid("221eb09e-00c5-4ebb-8a1e-75ede4c05950") },
                    { new Guid("0d765255-7c31-4395-8218-a4f32c41c3d3"), new Guid("221eb09e-00c5-4ebb-8a1e-75ede4c05950") },
                    { new Guid("d30959e7-ccf0-45dc-ab60-a5c36b42bc34"), new Guid("221eb09e-00c5-4ebb-8a1e-75ede4c05950") }
                });

            migrationBuilder.InsertData(
                table: "ServicePlaces",
                columns: new[] { "Id", "LayoutImageId", "Name", "ServiceId", "UserId" },
                values: new object[,]
                {
                    { new Guid("6c5eb7be-0f2f-4c11-98ae-797fabf73293"), new Guid("a3bddae0-0492-446a-b65e-2276dac45033"), "4 helyes terem(allee)", new Guid("5ab7a6d4-5e05-480c-a473-fbca8b6c511e"), null },
                    { new Guid("9a5fc6cd-57ba-4060-b33e-87311baf23b0"), new Guid("a3bddae0-0492-446a-b65e-2276dac45033"), "4 helyes terem(mom)", new Guid("5109d33a-5bce-4d51-a920-2612c773d0ed"), null },
                    { new Guid("2553c85d-b95e-49b9-ac0f-a59e47c15d8d"), new Guid("a3bddae0-0492-446a-b65e-2276dac45033"), "4 helyes terem (madách)", new Guid("307a5d83-40ae-4df9-8c25-6433fb571a60"), null },
                    { new Guid("1f9afb63-2c3a-4fb7-b0e2-6bc3fd794151"), new Guid("27085f99-ff6b-4cdd-b3af-c3b28d0a6894"), "10 helyes terem (groupama)", new Guid("7415e445-013b-4f54-a228-63165a8f969b"), null },
                    { new Guid("d0cf801c-ef14-44f8-809b-1741a9b755c0"), new Guid("a3bddae0-0492-446a-b65e-2276dac45033"), "4 helyes terem (aquaworld)", new Guid("221eb09e-00c5-4ebb-8a1e-75ede4c05950"), null }
                });

            migrationBuilder.InsertData(
                table: "EvenSchedules",
                columns: new[] { "Id", "Description", "EventId", "From", "ServiceId", "ServicePlaceId", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("a3625495-420a-41e3-861e-f394eae9f384"), "", new Guid("d02b9ebe-6b69-4501-b54e-cc7da9179d3e"), new DateTime(2019, 9, 21, 20, 54, 17, 274, DateTimeKind.Local), new Guid("5ab7a6d4-5e05-480c-a473-fbca8b6c511e"), new Guid("6c5eb7be-0f2f-4c11-98ae-797fabf73293"), new DateTime(2019, 9, 21, 22, 54, 17, 275, DateTimeKind.Local), null },
                    { new Guid("0868c0c3-7be5-4b9b-b6e5-79a0ed81384d"), "", new Guid("d02b9ebe-6b69-4501-b54e-cc7da9179d3e"), new DateTime(2019, 9, 21, 22, 54, 17, 275, DateTimeKind.Local), new Guid("5ab7a6d4-5e05-480c-a473-fbca8b6c511e"), new Guid("6c5eb7be-0f2f-4c11-98ae-797fabf73293"), new DateTime(2019, 9, 22, 0, 54, 17, 275, DateTimeKind.Local), null },
                    { new Guid("bd9fad4f-4206-4036-9bd1-80c08dd1ba58"), "", new Guid("d02b9ebe-6b69-4501-b54e-cc7da9179d3e"), new DateTime(2019, 9, 21, 20, 54, 17, 274, DateTimeKind.Local), new Guid("5ab7a6d4-5e05-480c-a473-fbca8b6c511e"), new Guid("9a5fc6cd-57ba-4060-b33e-87311baf23b0"), new DateTime(2019, 9, 21, 22, 54, 17, 275, DateTimeKind.Local), null },
                    { new Guid("d33d2d1d-89d8-443e-800a-57505707ea0d"), "", new Guid("d02b9ebe-6b69-4501-b54e-cc7da9179d3e"), new DateTime(2019, 9, 21, 22, 54, 17, 275, DateTimeKind.Local), new Guid("5109d33a-5bce-4d51-a920-2612c773d0ed"), new Guid("9a5fc6cd-57ba-4060-b33e-87311baf23b0"), new DateTime(2019, 9, 22, 0, 54, 17, 275, DateTimeKind.Local), null }
                });

            migrationBuilder.InsertData(
                table: "ServicePlacePositions",
                columns: new[] { "Id", "Name", "ServicePlaceId" },
                values: new object[,]
                {
                    { new Guid("6cffa015-1d0e-41a0-ae76-70bda94fe206"), "A2", new Guid("d0cf801c-ef14-44f8-809b-1741a9b755c0") },
                    { new Guid("9d687017-8d7c-4031-88f3-8dc5188cfa55"), "A1", new Guid("d0cf801c-ef14-44f8-809b-1741a9b755c0") },
                    { new Guid("a9c9cd87-b4f0-4d79-aeec-85811950a3b4"), "A4", new Guid("2553c85d-b95e-49b9-ac0f-a59e47c15d8d") },
                    { new Guid("8f5f9683-a1b0-459e-8801-3862b98456f3"), "A3", new Guid("2553c85d-b95e-49b9-ac0f-a59e47c15d8d") },
                    { new Guid("47a6d737-6202-4850-a794-0f586c1e4cb8"), "A2", new Guid("2553c85d-b95e-49b9-ac0f-a59e47c15d8d") },
                    { new Guid("33a38cd7-17e1-44a4-af32-3e08724dd348"), "A1", new Guid("2553c85d-b95e-49b9-ac0f-a59e47c15d8d") },
                    { new Guid("abe4ed19-e7ce-492d-bd80-02467e07282d"), "A4", new Guid("9a5fc6cd-57ba-4060-b33e-87311baf23b0") },
                    { new Guid("693d6695-03be-4a37-b026-dacf32416396"), "A2", new Guid("9a5fc6cd-57ba-4060-b33e-87311baf23b0") },
                    { new Guid("50d14075-776e-4a36-933e-0deca9dbb987"), "A3", new Guid("d0cf801c-ef14-44f8-809b-1741a9b755c0") },
                    { new Guid("be61d476-6fbb-4fa3-b67a-7ab6f957eef4"), "A1", new Guid("9a5fc6cd-57ba-4060-b33e-87311baf23b0") },
                    { new Guid("2cd89e64-1c2a-4901-a701-a2eb2e56c345"), "A4", new Guid("6c5eb7be-0f2f-4c11-98ae-797fabf73293") },
                    { new Guid("13c26d08-5405-40e4-be0a-62dcf0fd0578"), "A3", new Guid("6c5eb7be-0f2f-4c11-98ae-797fabf73293") },
                    { new Guid("59686326-a43e-4fa7-9919-cde7ce95f2eb"), "A2", new Guid("6c5eb7be-0f2f-4c11-98ae-797fabf73293") },
                    { new Guid("7c177b8b-9f6a-40bd-a3fa-1fa5e399278e"), "A1", new Guid("6c5eb7be-0f2f-4c11-98ae-797fabf73293") },
                    { new Guid("f12ba09b-0347-4443-8d32-54b7cbdfdc05"), "A3", new Guid("9a5fc6cd-57ba-4060-b33e-87311baf23b0") },
                    { new Guid("00473d15-affa-49c9-a1b0-de867cb04559"), "A4", new Guid("d0cf801c-ef14-44f8-809b-1741a9b755c0") }
                });
        }
    }
}
