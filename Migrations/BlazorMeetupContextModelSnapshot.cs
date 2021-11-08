﻿// <auto-generated />
using System;
using BlazorMeetup.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorMeetup.Migrations
{
    [DbContext(typeof(BlazorMeetupContext))]
    partial class BlazorMeetupContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("BlazorMeetup.Data.AttendeeEvent", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("AttendeeId")
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("CanAttendProposedDate")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("EventId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("AttendeeId");

                    b.HasIndex("EventId");

                    b.ToTable("AttendeeEvents");
                });

            modelBuilder.Entity("BlazorMeetup.Data.AvatarSettings", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("AttendeeId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("AvatarIdentification")
                        .HasColumnType("longtext");

                    b.Property<string>("AvatarUrl")
                        .HasColumnType("longtext");

                    b.Property<int>("Left")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<int>("Top")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AttendeeId")
                        .IsUnique();

                    b.ToTable("AvatarSettings");
                });

            modelBuilder.Entity("BlazorMeetup.Data.Event", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("AttendeeId")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("DateAndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("MaximumAttendees")
                        .HasColumnType("int");

                    b.Property<int>("MinimumAttendees")
                        .HasColumnType("int");

                    b.Property<string>("ServerId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("AttendeeId");

                    b.HasIndex("ServerId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("BlazorMeetup.Data.RestrictDate", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EventId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("RestrictDates");
                });

            modelBuilder.Entity("BlazorMeetup.Data.Server", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Servers");
                });

            modelBuilder.Entity("BlazorMeetup.Data.SuggestedDate", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("AttendeeId")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EventId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("AttendeeId");

                    b.HasIndex("EventId");

                    b.ToTable("SuggestedDates");
                });

            modelBuilder.Entity("BlazorMeetup.Data.SuggestedDateAttendee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("AttendeeId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("SuggestedDateId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("AttendeeId");

                    b.HasIndex("SuggestedDateId");

                    b.ToTable("SuggestedDateAttendees");
                });

            modelBuilder.Entity("BlazorMeetup.Data.Team", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("EventId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("BlazorMeetup.Data.TeamAttendee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("AttendeeId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("EventId")
                        .HasColumnType("longtext");

                    b.Property<string>("TeamId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("AttendeeId");

                    b.HasIndex("TeamId");

                    b.ToTable("TeamAttendees");
                });

            modelBuilder.Entity("BlazorMeetup.Data.TeamAvatarSettings", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("AvatarIdentification")
                        .HasColumnType("longtext");

                    b.Property<string>("AvatarUrl")
                        .HasColumnType("longtext");

                    b.Property<int>("Left")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<string>("TeamId")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Top")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId")
                        .IsUnique();

                    b.ToTable("TeamAvatarSettings");
                });

            modelBuilder.Entity("BlazorMeetup.Data.TimesAllowed", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("BeginningHour")
                        .HasColumnType("int");

                    b.Property<int>("BeginningMinute")
                        .HasColumnType("int");

                    b.Property<int>("EndingHour")
                        .HasColumnType("int");

                    b.Property<int>("EndingMinute")
                        .HasColumnType("int");

                    b.Property<string>("RestrictDateId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RestrictDateId");

                    b.ToTable("TimesAlloweds");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BlazorMeetup.Data.Attendee", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.HasDiscriminator().HasValue("Attendee");
                });

            modelBuilder.Entity("BlazorMeetup.Data.AttendeeEvent", b =>
                {
                    b.HasOne("BlazorMeetup.Data.Attendee", "Attendee")
                        .WithMany("Events")
                        .HasForeignKey("AttendeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BlazorMeetup.Data.Event", "Event")
                        .WithMany("Attendees")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Attendee");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("BlazorMeetup.Data.AvatarSettings", b =>
                {
                    b.HasOne("BlazorMeetup.Data.Attendee", null)
                        .WithOne("AvatarSettings")
                        .HasForeignKey("BlazorMeetup.Data.AvatarSettings", "AttendeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BlazorMeetup.Data.Event", b =>
                {
                    b.HasOne("BlazorMeetup.Data.Attendee", "Attendee")
                        .WithMany("EventsOwned")
                        .HasForeignKey("AttendeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BlazorMeetup.Data.Server", "Server")
                        .WithMany("Events")
                        .HasForeignKey("ServerId");

                    b.Navigation("Attendee");

                    b.Navigation("Server");
                });

            modelBuilder.Entity("BlazorMeetup.Data.RestrictDate", b =>
                {
                    b.HasOne("BlazorMeetup.Data.Event", "Event")
                        .WithMany("RestrictDates")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Event");
                });

            modelBuilder.Entity("BlazorMeetup.Data.SuggestedDate", b =>
                {
                    b.HasOne("BlazorMeetup.Data.Attendee", "Attendee")
                        .WithMany()
                        .HasForeignKey("AttendeeId");

                    b.HasOne("BlazorMeetup.Data.Event", "Event")
                        .WithMany("SuggestedDates")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Attendee");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("BlazorMeetup.Data.SuggestedDateAttendee", b =>
                {
                    b.HasOne("BlazorMeetup.Data.Attendee", "Attendee")
                        .WithMany("SuggestedDates")
                        .HasForeignKey("AttendeeId");

                    b.HasOne("BlazorMeetup.Data.SuggestedDate", "SuggestedDate")
                        .WithMany("Attendees")
                        .HasForeignKey("SuggestedDateId");

                    b.Navigation("Attendee");

                    b.Navigation("SuggestedDate");
                });

            modelBuilder.Entity("BlazorMeetup.Data.Team", b =>
                {
                    b.HasOne("BlazorMeetup.Data.Event", "Event")
                        .WithMany("Teams")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Event");
                });

            modelBuilder.Entity("BlazorMeetup.Data.TeamAttendee", b =>
                {
                    b.HasOne("BlazorMeetup.Data.Attendee", "Attendee")
                        .WithMany("Teams")
                        .HasForeignKey("AttendeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BlazorMeetup.Data.Team", "Team")
                        .WithMany("Attendees")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Attendee");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("BlazorMeetup.Data.TeamAvatarSettings", b =>
                {
                    b.HasOne("BlazorMeetup.Data.Team", null)
                        .WithOne("TeamAvatarSettings")
                        .HasForeignKey("BlazorMeetup.Data.TeamAvatarSettings", "TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BlazorMeetup.Data.TimesAllowed", b =>
                {
                    b.HasOne("BlazorMeetup.Data.RestrictDate", "RestrictDate")
                        .WithMany("TimesAlloweds")
                        .HasForeignKey("RestrictDateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("RestrictDate");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlazorMeetup.Data.Event", b =>
                {
                    b.Navigation("Attendees");

                    b.Navigation("RestrictDates");

                    b.Navigation("SuggestedDates");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("BlazorMeetup.Data.RestrictDate", b =>
                {
                    b.Navigation("TimesAlloweds");
                });

            modelBuilder.Entity("BlazorMeetup.Data.Server", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("BlazorMeetup.Data.SuggestedDate", b =>
                {
                    b.Navigation("Attendees");
                });

            modelBuilder.Entity("BlazorMeetup.Data.Team", b =>
                {
                    b.Navigation("Attendees");

                    b.Navigation("TeamAvatarSettings");
                });

            modelBuilder.Entity("BlazorMeetup.Data.Attendee", b =>
                {
                    b.Navigation("AvatarSettings");

                    b.Navigation("Events");

                    b.Navigation("EventsOwned");

                    b.Navigation("SuggestedDates");

                    b.Navigation("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
