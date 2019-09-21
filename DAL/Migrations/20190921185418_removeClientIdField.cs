using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class removeClientIdField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "PendingBookings");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59317E0A-8F55-46F9-BF5A-A81680A41964",
                column: "ConcurrencyStamp",
                value: "3f86a552-eabe-4a59-b3e2-32b239bdabe1");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId",
                table: "PendingBookings",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
        }
    }
}
