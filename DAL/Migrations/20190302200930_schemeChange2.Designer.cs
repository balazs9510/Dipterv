﻿// <auto-generated />
using System;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(BookingSystemDbContext))]
    [Migration("20190302200930_schemeChange2")]
    partial class schemeChange2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Entities.Booking", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<Guid>("PositionId");

                    b.Property<Guid>("ScheduleId");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("DAL.Entities.EvenSchedule", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<Guid>("EventId");

                    b.Property<DateTime>("From");

                    b.Property<Guid>("ServiceId");

                    b.Property<Guid>("ServicePlaceId");

                    b.Property<DateTime?>("To");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("ServiceId");

                    b.HasIndex("ServicePlaceId");

                    b.ToTable("EvenSchedules");

                    b.HasData(
                        new { Id = new Guid("ee72b5d5-6ed9-478a-9f23-e94e71624f29"), Description = "Shazam bemutató", EventId = new Guid("10d882e2-b737-4e3c-b89b-0ff041b55154"), From = new DateTime(2019, 3, 2, 21, 9, 30, 358, DateTimeKind.Local), ServiceId = new Guid("df94fe62-98ce-46d3-82bc-a4e488d0e947"), ServicePlaceId = new Guid("4e384cf9-c791-404d-a503-2f7d518a34df"), To = new DateTime(2019, 3, 2, 23, 9, 30, 360, DateTimeKind.Local) }
                    );
                });

            modelBuilder.Entity("DAL.Entities.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<byte[]>("EventImage");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Events");

                    b.HasData(
                        new { Id = new Guid("10d882e2-b737-4e3c-b89b-0ff041b55154"), Name = "Shazam!", UserId = "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                        new { Id = new Guid("4aff2483-c234-4c12-8e79-38dbdad39d1b"), Name = "Négyszögletű Kerek Erdő", UserId = "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
                    );
                });

            modelBuilder.Entity("DAL.Entities.PendingBooking", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<Guid>("EvenScheduleId");

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<Guid>("ServicePlacePositionId");

                    b.HasKey("Id");

                    b.HasIndex("EvenScheduleId");

                    b.HasIndex("ServicePlacePositionId");

                    b.ToTable("PendingBookings");
                });

            modelBuilder.Entity("DAL.Entities.Service", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<Guid>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Services");

                    b.HasData(
                        new { Id = new Guid("df94fe62-98ce-46d3-82bc-a4e488d0e947"), City = "Budapest", Description = "Allee Cinema City mozi", Name = "Allee CC", Street = "Október huszonharmadika u. 8-10", TypeId = new Guid("b1093d2f-a0ce-4db8-8748-1e60aa1d6f8d") },
                        new { Id = new Guid("6f38eb96-89ce-4883-bd18-b13b7020c4c5"), City = "Pécs", Description = "Pécs Cinema City mozi", Name = "Pécs Plaza CC", Street = "Megyeri út 76.", TypeId = new Guid("b1093d2f-a0ce-4db8-8748-1e60aa1d6f8d") },
                        new { Id = new Guid("29a53edf-8207-469f-b96a-bc8bde2b6331"), City = "Budapest", Name = "Madách Színház", Street = "Erzsébet krt. 29-33.", TypeId = new Guid("51b6754c-ff6c-48d0-9800-ee568950655f") }
                    );
                });

            modelBuilder.Entity("DAL.Entities.ServicePlace", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<Guid>("ServiceId");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.ToTable("ServicePlaces");

                    b.HasData(
                        new { Id = new Guid("4e384cf9-c791-404d-a503-2f7d518a34df"), Name = "Anyád", ServiceId = new Guid("df94fe62-98ce-46d3-82bc-a4e488d0e947") }
                    );
                });

            modelBuilder.Entity("DAL.Entities.ServicePlacePosition", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<Guid>("ServicePlaceId");

                    b.HasKey("Id");

                    b.HasIndex("ServicePlaceId");

                    b.ToTable("ServicePlacePositions");

                    b.HasData(
                        new { Id = new Guid("df4c91bd-fd20-4b84-99b7-608ad83b9dad"), Name = "I1", ServicePlaceId = new Guid("4e384cf9-c791-404d-a503-2f7d518a34df") },
                        new { Id = new Guid("2aadfaf2-a9e1-440c-b9c6-7534d854eb18"), Name = "I2", ServicePlaceId = new Guid("4e384cf9-c791-404d-a503-2f7d518a34df") },
                        new { Id = new Guid("6d35c993-438a-4b5e-91e4-fb2276904f1a"), Name = "I3", ServicePlaceId = new Guid("4e384cf9-c791-404d-a503-2f7d518a34df") },
                        new { Id = new Guid("a4a10c1b-337b-49b6-8cb0-560b088efbbe"), Name = "I4", ServicePlaceId = new Guid("4e384cf9-c791-404d-a503-2f7d518a34df") }
                    );
                });

            modelBuilder.Entity("DAL.Entities.ServiceType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("ServiceTypes");

                    b.HasData(
                        new { Id = new Guid("b1093d2f-a0ce-4db8-8748-1e60aa1d6f8d"), Name = "Mozi" },
                        new { Id = new Guid("51b6754c-ff6c-48d0-9800-ee568950655f"), Name = "Színház" }
                    );
                });

            modelBuilder.Entity("DAL.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new { Id = "a18be9c0-aa65-4af8-bd17-00bd9344e575", AccessFailedCount = 0, ConcurrencyStamp = "ecd11774-84af-45b6-8e16-6620528341cd", Email = "admin@admin.hu", EmailConfirmed = true, LockoutEnabled = false, NormalizedEmail = "admin@admin.hu", NormalizedUserName = "admin", PasswordHash = "AQAAAAEAACcQAAAAECbcsHHzpMCan8V+DucHzJbw3pLDLuEcnyNYf8eilHkf0LyV9S1Y9VPQ1oDaYpYK+w==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "admin" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new { Id = "a18be9c0-aa65-4af8-bd17-00bd9344e575", ConcurrencyStamp = "83758f26-3843-46a7-94d8-7ecfa10bd80e", Name = "admin", NormalizedName = "admin" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new { UserId = "a18be9c0-aa65-4af8-bd17-00bd9344e575", RoleId = "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DAL.Entities.Booking", b =>
                {
                    b.HasOne("DAL.Entities.ServicePlacePosition", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Entities.EvenSchedule", "Schedule")
                        .WithMany("Bookings")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Entities.EvenSchedule", b =>
                {
                    b.HasOne("DAL.Entities.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Entities.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Entities.ServicePlace", "ServicePlace")
                        .WithMany()
                        .HasForeignKey("ServicePlaceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Entities.Event", b =>
                {
                    b.HasOne("DAL.Entities.User", "User")
                        .WithMany("Event")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Entities.PendingBooking", b =>
                {
                    b.HasOne("DAL.Entities.EvenSchedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("EvenScheduleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Entities.ServicePlacePosition", "Position")
                        .WithMany()
                        .HasForeignKey("ServicePlacePositionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Entities.Service", b =>
                {
                    b.HasOne("DAL.Entities.ServiceType", "Type")
                        .WithMany("Services")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Entities.ServicePlace", b =>
                {
                    b.HasOne("DAL.Entities.Service", "Service")
                        .WithMany("Places")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Entities.ServicePlacePosition", b =>
                {
                    b.HasOne("DAL.Entities.ServicePlace", "ServicePlace")
                        .WithMany("Layout")
                        .HasForeignKey("ServicePlaceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DAL.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DAL.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DAL.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
