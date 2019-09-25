using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.SeedServices
{
    public class SeedService : ISeedService
    {
        private const string ADMIN_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e575";
        private const string ROLE_ID = "59317E0A-8F55-46F9-BF5A-A81680A41964";

        public IDictionary<string, IdentityRole> Roles { get; } = new[]
        {
            new IdentityRole
            {
                Id = ROLE_ID,
                Name = DAL.Users.Roles.Administrators,
                NormalizedName = DAL.Users.Roles.Administrators.ToUpper()
            }
        }.ToDictionary(a => a.Name);

        public IDictionary<string, User> Users
        {
            get
            {
                var hasher = new PasswordHasher<User>();
                return new[]
                {
                    new User
                    {
                        Id = ADMIN_ID,
                        UserName = "admin",
                        NormalizedUserName = "admin",
                        Email = "admin@admin.hu",
                        NormalizedEmail = "admin@admin.hu",
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "Admin@123"),
                        SecurityStamp = string.Empty
                    }
                }.ToDictionary(a => a.UserName);
            }
        }

        public IList<IdentityUserRole<string>> UserRoles { get; } = new List<IdentityUserRole<string>>
        {
            new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            }
        };

        public Dictionary<string, Image> Images { get; } = new[]
        {
            new Image
            {
                Id = Id(),
                Extension = "png",
                Name = "cinema.png"
            },
            new Image
            {
                Id = Id(),
                Extension = "png",
                Name = "theater.png"
            },
            new Image
            {
                Id = Id(),
                Extension = "png",
                Name = "sport.png"
            },
            new Image
            {
                Id = Id(),
                Extension = "png",
                Name = "spa.png"
            },
            new Image
            {
                Id = Id(),
                Extension = "png",
                Name = "alle.png"
            },
            new Image
            {
                Id = Id(),
                Extension = "png",
                Name = "mom.png"
            },
            new Image
            {
                Id = Id(),
                Extension = "png",
                Name = "groupama.png"
            },
            new Image
            {
                Id = Id(),
                Extension = "png",
                Name = "madach.png"
            },
            new Image
            {
                Id = Id(),
                Extension = "png",
                Name = "corvin_duma.png"
            },
            new Image
            {
                Id = Id(),
                Extension = "png",
                Name = "aquapark.png"
            },
            new Image
            {
                Id = Id(),
                Extension = "png",
                Name = "endgame.png"
            },
            new Image
            {
                Id = Id(),
                Extension = "png",
                Name = "shazam.png"
            },
            new Image
            {
                Id = Id(),
                Extension = "png",
                Name = "negyszogletu.png"
            },
            new Image
            {
                Id = Id(),
                Extension = "png",
                Name = "ftc.png"
            },
            new Image
            {
                Id = Id(),
                Extension = "png",
                Name = "masszazs.png"
            },
            new Image
            {
                Id = Id(),
                Extension = "svg",
                Name = "t4.svg"
            },
            new Image
            {
                Id = Id(),
                Extension = "svg",
                Name = "t10.svg"
            },
            new Image
            {
                Id = Guid.Parse("2ECC93E0-08E2-4B00-8197-3FEDE4B3AA4D"),
                Extension = "svg",
                Name = "test.png"
            },
        }.ToDictionary(x => x.Name);

        public Dictionary<string, ServiceType> ServiceTypes { get; }

        public Dictionary<string, Service> Services { get; }

        public Dictionary<string, Event> Events { get; }

        public IList<ServiceEvent> ServiceEvents { get; }

        public IList<ServicePlacePosition> ServicePlacePositions { get; }

        public IList<EvenSchedule> EvenSchedules { get; }

        public Dictionary<string, ServicePlace> ServicePlaces { get; }

        public SeedService()
        {
            ServiceTypes = new[]
            {
                new ServiceType
                {
                    Id = Id(),
                    Name = "Mozik",
                    ImageId = Images["cinema.png"].Id
                },
                 new ServiceType
                {
                    Id = Id(),
                    Name = "Színházak",
                    ImageId = Images["theater.png"].Id
                },
                  new ServiceType
                {
                    Id = Id(),
                    Name = "Sport",
                    ImageId = Images["sport.png"].Id
                },
                   new ServiceType
                {
                    Id = Id(),
                    Name = "Szabadidő",
                    ImageId = Images["spa.png"].Id
                },
            }.ToDictionary(x => x.Name);
            Services = new List<Service>
            {
                new Service
                {
                    Id = Id(),
                    Name = "CinemaCity Alle",
                    City = "Budapest",
                    Street = "Október huszonharmadika u. 8-10",
                    Description = "A 13 termes Cinema City Allee 2009. óta várja vendégeit a legjobb premier filmekkel - egyik termében kizárólag eredeti nyelvű filmvetítésekkel - az év minden napján. Nyitvatartás: pénztárnyitás az első előadás előtt 30 perccel, pénztár zárás az utolsó előadás kezdete után 15 perccel.",
                    ImageId = Images["alle.png"].Id,
                    TypeId = ServiceTypes["Mozik"].Id
                },
                new Service
                {
                    Id = Id(),
                    Name = "CINEMApink MOM Park",
                    City = "Budapest",
                    Street = "Alkotás u. 53",
                    Description = "A CINEMApink MOM Park a jelenleg elérhető legjobb képminőséggel, prémium hangrendszerrel, kényelmi extrákkal és a legújabb sikerfilmekkel várja!",
                    ImageId = Images["mom.png"].Id,
                    TypeId = ServiceTypes["Mozik"].Id
                },
                new Service
                {
                    Id = Id(),
                    Name = "Groupama Aréna",
                    City = "Budapest",
                    Street = "Üllői út 129",
                    Description = "„BEST OF BUDAPEST & HUNGARY 2017” DÍJAT NYERT A FRADI OTTHONA, A GROUPAMA ARÉNA!",
                    ImageId = Images["groupama.png"].Id,
                    TypeId = ServiceTypes["Sport"].Id
                },
                new Service
                {
                    Id = Id(),
                    Name = "Madách Színház",
                    City = "Budapest",
                    Street = "Erzsébet krt. 29-33",
                    Description = "Madách Színház néven több színházi vállalkozás is létrejött századunkban Budapesten. 1919-ben a Zeneakadémia kistermében Madách Színház néven kísérletezett egy társulat, mely zömmel a frontról hazatért, szerződés nélküli színészekből alakult. Alig több mint egy évig működtek, új típusú programmal indultak, legnagyobb sikerük a százas szériát futó Holnap reggel című Karinthy Frigyes dráma előadása.",
                    ImageId = Images["madach.png"].Id,
                    TypeId = ServiceTypes["Színházak"].Id
                },
                new Service
                {
                    Id = Id(),
                    Name = "Corvin Dumaszínház",
                    City = "Budapest",
                    Street = "Corvin sétány 1 1/b",
                    Description = "Corvin Dumaszínház",
                    ImageId = Images["corvin_duma.png"].Id,
                    TypeId = ServiceTypes["Színházak"].Id
                },
                new Service
                {
                    Id = Id(),
                    Name = "Aquaworld Resort Budapest",
                    City = "Budapest",
                    Street = "Íves út 16",
                    Description = "Ha többre vágysz egy átlagos pihenésnél... nálunk egyszerre átélheted akár egy kényeztető wellness hétvége minden jótékony hatását vagy gyermekként élvezheted az Aquaworld élményekkel teli világát.",
                    ImageId = Images["aquapark.png"].Id,
                    TypeId = ServiceTypes["Szabadidő"].Id
                }
            }.ToDictionary(x => x.Name);
            Events = new[]
            {
                new Event
                {
                    Id = Id(),
                    Name = "Bosszúállók: Végjáték",
                    Description = "Thanos súlyos tette, amivel elpusztította az univerzum élőlényeinek felét és megtörte a Bosszúállókat, a megmaradt hősöket egy végső összecsapásra készteti a Marvel Studios huszonegy filmet megkoronázó, nagyszabású fináléjában, a Bosszúállók: Végjátékban.",
                    UserId = ADMIN_ID,
                    ImageId = Images["endgame.png"].Id
                },
                new Event
                {
                    Id = Id(),
                    Name = "Shazam!",
                    Description = "Mindannyiunkban ott bujkál a szuperhős – de van, akiből elő is jön. Billy Batson 14 éves, egy árvaházból kerül nevelőszüleihez, és nem a legnépszerűbb srác az iskolában…de Shazam, az ősöreg, különleges erejű varázsló mégis kiválasztja. Amikor a srác hangosan kimondja: a varázsló nevét, átalakul. Igazi szuperhős válik belőle, annak minden kellékével: testhezálló, köpönyeggel kiegészített ruha, különleges eszközök, rendkívüli erő és meghökkentő képességek.",
                    UserId = ADMIN_ID,
                    ImageId = Images["shazam.png"].Id
                },
                new Event
                {
                    Id = Id(),
                    Name = "Négyszögletű Kerek Erdő",
                    Description = "Avagy a játéknak soha nincs vége",
                    UserId = ADMIN_ID,
                    ImageId = Images["negyszogletu.png"].Id
                },
                new Event
                {
                    Id = Id(),
                    Name = "FTC-Telekom : DVTK",
                    Description = "FÖRCH MAGYAR KUPA",
                    UserId = ADMIN_ID,
                    ImageId = Images["ftc.png"].Id
                },
                new Event
                {
                    Id = Id(),
                    Name = "Pihentető masszás (1 óra)",
                    Description = "Egy óra.",
                    UserId = ADMIN_ID,
                    ImageId = Images["masszazs.png"].Id
                },
                new Event
                {
                    Id = Id(),
                    Name = "Pihentető masszás (1,5 óra)",
                    Description = "Másfél óra.",
                    UserId = ADMIN_ID,
                    ImageId = Images["masszazs.png"].Id
                },
                new Event
                {
                    Id = Id(),
                    Name = "Pihentető masszás (2 óra)",
                    Description = "Két óra.",
                    UserId = ADMIN_ID,
                    ImageId = Images["masszazs.png"].Id
                },
            }.ToDictionary(x => x.Name);
            ServiceEvents = new List<ServiceEvent>
            {
                new ServiceEvent
                {
                    EventId = Events["Bosszúállók: Végjáték"].Id,
                    ServiceId = Services["CinemaCity Alle"].Id
                },
                new ServiceEvent
                {
                    EventId = Events["Bosszúállók: Végjáték"].Id,
                    ServiceId = Services["CINEMApink MOM Park"].Id
                },
                new ServiceEvent
                {
                    EventId = Events["Shazam!"].Id,
                    ServiceId = Services["CinemaCity Alle"].Id
                },
                new ServiceEvent
                {
                    EventId = Events["Shazam!"].Id,
                    ServiceId = Services["CINEMApink MOM Park"].Id
                },
                new ServiceEvent
                {
                    EventId = Events["Négyszögletű Kerek Erdő"].Id,
                    ServiceId = Services["Madách Színház"].Id
                },
                new ServiceEvent
                {
                    EventId = Events["FTC-Telekom : DVTK"].Id,
                    ServiceId = Services["Groupama Aréna"].Id
                },
                new ServiceEvent
                {
                    EventId = Events["Pihentető masszás (1 óra)"].Id,
                    ServiceId = Services["Aquaworld Resort Budapest"].Id
                },
                new ServiceEvent
                {
                    EventId = Events["Pihentető masszás (1,5 óra)"].Id,
                    ServiceId = Services["Aquaworld Resort Budapest"].Id
                },
                new ServiceEvent
                {
                    EventId = Events["Pihentető masszás (2 óra)"].Id,
                    ServiceId = Services["Aquaworld Resort Budapest"].Id
                },
            };
            ServicePlaces = new[]
            {
                new ServicePlace
                {
                    Id = Id(),
                    Name = "4 helyes terem(mom)",
                    ServiceId = Services["CINEMApink MOM Park"].Id,
                    LayoutImageId = Images["t4.svg"].Id
                },
                new ServicePlace
                {
                    Id = Id(),
                    Name = "4 helyes terem(allee)",
                    ServiceId = Services["CinemaCity Alle"].Id,
                    LayoutImageId = Images["t4.svg"].Id
                },
                new ServicePlace
                {
                    Id = Id(),
                    Name = "4 helyes terem (madách)",
                    ServiceId = Services["Madách Színház"].Id,
                    LayoutImageId = Images["t4.svg"].Id
                },
                new ServicePlace
                {
                    Id = Id(),
                    Name = "4 helyes terem (aquaworld)",
                    ServiceId = Services["Aquaworld Resort Budapest"].Id,
                    LayoutImageId = Images["t4.svg"].Id
                },
                new ServicePlace
                {
                    Id = Id(),
                    Name = "10 helyes terem (groupama)",
                    ServiceId = Services["Groupama Aréna"].Id,
                    LayoutImageId = Images["t10.svg"].Id
                },
            }.ToDictionary(x => x.Name);
            ServicePlacePositions = new List<ServicePlacePosition>
            {
                new ServicePlacePosition
                {
                    Id = Id(),
                    Name = "A1",
                    ServicePlaceId = ServicePlaces["4 helyes terem(mom)"].Id
                },
                 new ServicePlacePosition
                {
                    Id = Id(),
                    Name = "A2",
                    ServicePlaceId = ServicePlaces["4 helyes terem(mom)"].Id
                },
                  new ServicePlacePosition
                {
                    Id = Id(),
                    Name = "A3",
                    ServicePlaceId = ServicePlaces["4 helyes terem(mom)"].Id
                },
                   new ServicePlacePosition
                {
                    Id = Id(),
                    Name = "A4",
                    ServicePlaceId = ServicePlaces["4 helyes terem(mom)"].Id
                },
                new ServicePlacePosition
                {
                    Id = Id(),
                    Name = "A1",
                    ServicePlaceId = ServicePlaces["4 helyes terem(allee)"].Id
                },
                new ServicePlacePosition
                {
                    Id = Id(),
                    Name = "A2",
                    ServicePlaceId = ServicePlaces["4 helyes terem(allee)"].Id
                },
                new ServicePlacePosition
                {
                    Id = Id(),
                    Name = "A3",
                    ServicePlaceId = ServicePlaces["4 helyes terem(allee)"].Id
                },
                new ServicePlacePosition
                {
                    Id = Id(),
                    Name = "A4",
                    ServicePlaceId = ServicePlaces["4 helyes terem(allee)"].Id
                },
                new ServicePlacePosition
                {
                    Id = Id(),
                    Name = "A1",
                    ServicePlaceId = ServicePlaces["4 helyes terem (madách)"].Id
                },
                new ServicePlacePosition
                {
                    Id = Id(),
                    Name = "A2",
                    ServicePlaceId = ServicePlaces["4 helyes terem (madách)"].Id
                },
                new ServicePlacePosition
                {
                    Id = Id(),
                    Name = "A3",
                    ServicePlaceId = ServicePlaces["4 helyes terem (madách)"].Id
                },
                new ServicePlacePosition
                {
                    Id = Id(),
                    Name = "A4",
                    ServicePlaceId = ServicePlaces["4 helyes terem (madách)"].Id
                },
                new ServicePlacePosition
                {
                    Id = Id(),
                    Name = "A1",
                    ServicePlaceId = ServicePlaces["4 helyes terem (aquaworld)"].Id
                },
                new ServicePlacePosition
                {
                    Id = Id(),
                    Name = "A2",
                    ServicePlaceId = ServicePlaces["4 helyes terem (aquaworld)"].Id
                },
                new ServicePlacePosition
                {
                    Id = Id(),
                    Name = "A3",
                    ServicePlaceId = ServicePlaces["4 helyes terem (aquaworld)"].Id
                },
                new ServicePlacePosition
                {
                    Id = Id(),
                    Name = "A4",
                    ServicePlaceId = ServicePlaces["4 helyes terem (aquaworld)"].Id
                },
            };
            DateTime now = DateTime.Now;
            DateTime now2 = DateTime.Now.AddHours(2);
            EvenSchedules = new List<EvenSchedule>
            {
                new EvenSchedule
                {
                    Id = Id(),
                    EventId = Events["Bosszúállók: Végjáték"].Id,
                    ServiceId = Services["CinemaCity Alle"].Id,
                    ServicePlaceId = ServicePlaces["4 helyes terem(allee)"].Id,
                    Description = string.Empty,
                    From = now,
                    To = now2
                },
                new EvenSchedule
                {
                    Id = Id(),
                    EventId = Events["Bosszúállók: Végjáték"].Id,
                    ServiceId = Services["CinemaCity Alle"].Id,
                    ServicePlaceId = ServicePlaces["4 helyes terem(allee)"].Id,
                    Description = string.Empty,
                    From = now2,
                    To = now2.AddHours(2)
                },
                new EvenSchedule
                {
                    Id = Id(),
                    EventId = Events["Bosszúállók: Végjáték"].Id,
                    ServiceId = Services["CinemaCity Alle"].Id,
                    ServicePlaceId = ServicePlaces["4 helyes terem(mom)"].Id,
                    Description = string.Empty,
                    From = now,
                    To = now2
                },
                new EvenSchedule
                {
                    Id = Id(),
                    EventId = Events["Bosszúállók: Végjáték"].Id,
                    ServiceId = Services["CINEMApink MOM Park"].Id,
                    ServicePlaceId = ServicePlaces["4 helyes terem(mom)"].Id,
                    Description = string.Empty,
                    From = now2,
                    To = now2.AddHours(2)
                },
            };
        }

        private static Guid Id()
        {
            return Guid.NewGuid();
        }
    }
}
