﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportNewspeper_core.Context;

#nullable disable

namespace SportNewspeper_core.Migrations
{
    [DbContext(typeof(SportNewspaperDbContext))]
    [Migration("20240501151804_kk")]
    partial class kk
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SportNewspeper_core.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("PhoneNumber")
                        .IsUnique()
                        .HasFilter("[PhoneNumber] IS NOT NULL");

                    b.ToTable("admins", t =>
                        {
                            t.HasCheckConstraint("Ch_Admin_Email", "Email Like '%@gmail.com%' Or Email Like  '%@outlook.com%' or Email Like '%@yahoo.com%'");

                            t.HasCheckConstraint("Ch_Admin_Name", "len(Name)>5");

                            t.HasCheckConstraint("Ch_Admin_Password", "LEN(password) >= 8 AND LEN(password) <= 16");

                            t.HasCheckConstraint("Ch_Admin_Phone", "(len([PhoneNumber])=(10) AND ([PhoneNumber] like '079%' OR [PhoneNumber] like '078%' OR [PhoneNumber] like '077%'))");
                        });
                });

            modelBuilder.Entity("SportNewspeper_core.Models.Competaition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("continent")
                        .HasColumnType("int");

                    b.Property<int>("countries")
                        .HasColumnType("int");

                    b.Property<int>("sports")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("competaitions", t =>
                        {
                            t.HasCheckConstraint("CH_Competaition_Name", "len(Name)>5");
                        });
                });

            modelBuilder.Entity("SportNewspeper_core.Models.CompetaitionTems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompetaitionId")
                        .HasColumnType("int");

                    b.Property<int>("TemsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompetaitionId");

                    b.HasIndex("TemsId");

                    b.ToTable("competaitionTems");
                });

            modelBuilder.Entity("SportNewspeper_core.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsImportant")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("RefereeName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("StadiumName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("StartTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 5, 1, 18, 18, 4, 378, DateTimeKind.Local).AddTicks(2447));

                    b.Property<int>("continent")
                        .HasColumnType("int");

                    b.Property<int>("countries")
                        .HasColumnType("int");

                    b.Property<int>("sports")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("matches");
                });

            modelBuilder.Entity("SportNewspeper_core.Models.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CompetaitionId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsImportant")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("PublishTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("VedeoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("continent")
                        .HasColumnType("int");

                    b.Property<int>("countries")
                        .HasColumnType("int");

                    b.Property<int>("sports")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompetaitionId");

                    b.ToTable("news");
                });

            modelBuilder.Entity("SportNewspeper_core.Models.Subscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("subscriptionType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("subscriptions", t =>
                        {
                            t.HasCheckConstraint("Ch_Subscription_price", "Price>=0");
                        });
                });

            modelBuilder.Entity("SportNewspeper_core.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CoachName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("FoundingDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("continent")
                        .HasColumnType("int");

                    b.Property<int>("countries")
                        .HasColumnType("int");

                    b.Property<int>("sports")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("teams", t =>
                        {
                            t.HasCheckConstraint("CH_Competaition_Name", "len(Name)>5")
                                .HasName("CH_Competaition_Name1");
                        });
                });

            modelBuilder.Entity("SportNewspeper_core.Models.TeamMatsh", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MatchId")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.HasIndex("TeamId");

                    b.ToTable("teamsMatshs");
                });

            modelBuilder.Entity("SportNewspeper_core.Models.TeamNews", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 5, 1, 18, 18, 4, 378, DateTimeKind.Local).AddTicks(9574));

                    b.Property<int>("NewsId")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NewsId");

                    b.HasIndex("TeamId");

                    b.ToTable("teamNews");
                });

            modelBuilder.Entity("SportNewspeper_core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("PhoneNumber")
                        .IsUnique()
                        .HasFilter("[PhoneNumber] IS NOT NULL");

                    b.ToTable("users", t =>
                        {
                            t.HasCheckConstraint("CH_User_Email", "Email Like '%@gmail.com%' Or Email Like  '%@outlook.com%' or Email Like '%@yahoo.com%'");

                            t.HasCheckConstraint("CH_User_Name", "len(Name)>5");

                            t.HasCheckConstraint("CH_User_Password", "LEN(password) >= 8 AND LEN(password) <= 16");

                            t.HasCheckConstraint("ch_User_Phone", "(len([PhoneNumber])=(10) AND ([PhoneNumber] like '079%' OR [PhoneNumber] like '078%' OR [PhoneNumber] like '077%'))");
                        });
                });

            modelBuilder.Entity("SportNewspeper_core.Models.UserSubscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 5, 1, 18, 18, 4, 380, DateTimeKind.Local).AddTicks(786));

                    b.Property<int>("SubscriptionId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubscriptionId");

                    b.HasIndex("UserId");

                    b.ToTable("userSubscriptions");
                });

            modelBuilder.Entity("SportNewspeper_core.Models.CompetaitionTems", b =>
                {
                    b.HasOne("SportNewspeper_core.Models.Competaition", "Competaition")
                        .WithMany("Tems")
                        .HasForeignKey("CompetaitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportNewspeper_core.Models.Team", "Tems")
                        .WithMany("Tems")
                        .HasForeignKey("TemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Competaition");

                    b.Navigation("Tems");
                });

            modelBuilder.Entity("SportNewspeper_core.Models.News", b =>
                {
                    b.HasOne("SportNewspeper_core.Models.Competaition", "Competaition")
                        .WithMany("News")
                        .HasForeignKey("CompetaitionId");

                    b.Navigation("Competaition");
                });

            modelBuilder.Entity("SportNewspeper_core.Models.TeamMatsh", b =>
                {
                    b.HasOne("SportNewspeper_core.Models.Match", "Match")
                        .WithMany("TeamMatshes")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportNewspeper_core.Models.Team", "Team")
                        .WithMany("TeamMatshes")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Match");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("SportNewspeper_core.Models.TeamNews", b =>
                {
                    b.HasOne("SportNewspeper_core.Models.News", "News")
                        .WithMany("TeamNews")
                        .HasForeignKey("NewsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportNewspeper_core.Models.Team", "Team")
                        .WithMany("TeamNews")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("News");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("SportNewspeper_core.Models.UserSubscription", b =>
                {
                    b.HasOne("SportNewspeper_core.Models.Subscription", "Subscription")
                        .WithMany("Subscriptions")
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportNewspeper_core.Models.User", "User")
                        .WithMany("Subscriptions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subscription");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SportNewspeper_core.Models.Competaition", b =>
                {
                    b.Navigation("News");

                    b.Navigation("Tems");
                });

            modelBuilder.Entity("SportNewspeper_core.Models.Match", b =>
                {
                    b.Navigation("TeamMatshes");
                });

            modelBuilder.Entity("SportNewspeper_core.Models.News", b =>
                {
                    b.Navigation("TeamNews");
                });

            modelBuilder.Entity("SportNewspeper_core.Models.Subscription", b =>
                {
                    b.Navigation("Subscriptions");
                });

            modelBuilder.Entity("SportNewspeper_core.Models.Team", b =>
                {
                    b.Navigation("TeamMatshes");

                    b.Navigation("TeamNews");

                    b.Navigation("Tems");
                });

            modelBuilder.Entity("SportNewspeper_core.Models.User", b =>
                {
                    b.Navigation("Subscriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
