﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220512024046_MigrationVer1")]
    partial class MigrationVer1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Entities.StoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AwardIconUrl")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AwardName")
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TopicId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("tbl_story", "dbo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Phú Quốc, Việt Nam",
                            AwardIconUrl = "../assets/gateway-resort.svg",
                            AwardName = "",
                            CreatedAt = new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified),
                            CreatedBy = "KIEU",
                            Description = "Located in an open space with clouds,\r\n                                    sky, and sea, the special highlight of\r\n                                    the resort is the architectural style\r\n                                    combining the three countries of Japan,\r\n                                    France and Vietnam.",
                            PhotoUrl = "../assets/topic.png",
                            Title = "Beautiful beach at Sunrise Resort, in Hoi An, Quang Nam",
                            TopicId = 1,
                            UpdatedAt = new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified),
                            UpdatedBy = "KIEU"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Phú Quốc, Việt Nam",
                            AwardIconUrl = "../assets/gateway-resort.svg",
                            AwardName = "",
                            CreatedAt = new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified),
                            CreatedBy = "KIEU",
                            Description = "Located in an open space with clouds,\r\n                                    sky, and sea, the special highlight of\r\n                                    the resort is the architectural style\r\n                                    combining the three countries of Japan,\r\n                                    France and Vietnam.",
                            PhotoUrl = "../assets/city-cultures.svg",
                            Title = "Topas Ecolodge - Service and comfort in the clouds",
                            TopicId = 1,
                            UpdatedAt = new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified),
                            UpdatedBy = "KIEU"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Phú Quốc, Việt Nam",
                            AwardIconUrl = "../assets/gateway-resort.svg",
                            AwardName = "",
                            CreatedAt = new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified),
                            CreatedBy = "KIEU",
                            Description = "Located in an open space with clouds,\r\n                                    sky, and sea, the special highlight of\r\n                                    the resort is the architectural style\r\n                                    combining the three countries of Japan,\r\n                                    France and Vietnam.",
                            PhotoUrl = "../assets/city-cultures.svg",
                            Title = "Topas Ecolodge - Service and comfort in the clouds",
                            TopicId = 1,
                            UpdatedAt = new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified),
                            UpdatedBy = "KIEU"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Quảng Nam, Việt Nam",
                            AwardIconUrl = "../assets/gateway-resort.svg",
                            AwardName = "Nature Adventure",
                            CreatedAt = new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified),
                            CreatedBy = "KIEU",
                            Description = "Located in an open space with clouds,\r\n                                    sky, and sea, the special highlight of\r\n                                    the resort is the architectural style\r\n                                    combining the three countries of Japan,\r\n                                    France and Vietnam.",
                            PhotoUrl = "../assets/nature-adventure.svg",
                            Title = "Experience traveling 4 days 3 nights in Quang Ngai pearl island",
                            TopicId = 1,
                            UpdatedAt = new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified),
                            UpdatedBy = "KIEU"
                        });
                });

            modelBuilder.Entity("Core.Entities.TopicEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("TopicIcon")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("TopicName")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("tbl_topic", "dbo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified),
                            CreatedBy = "KIEU",
                            TopicIcon = "../assets/food-drink.svg",
                            TopicName = "Food & Drinks",
                            UpdatedAt = new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified),
                            UpdatedBy = "KIEU"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified),
                            CreatedBy = "KIEU",
                            TopicIcon = "../assets/city-cultures.svg",
                            TopicName = "City & Culture",
                            UpdatedAt = new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified),
                            UpdatedBy = "KIEU"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified),
                            CreatedBy = "KIEU",
                            TopicIcon = "../assets/gateway-resort.svg",
                            TopicName = "Getaway & Resorts",
                            UpdatedAt = new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified),
                            UpdatedBy = "KIEU"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified),
                            CreatedBy = "KIEU",
                            TopicIcon = "../assets/nature-adventure.svg",
                            TopicName = "Nature & Adventure",
                            UpdatedAt = new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified),
                            UpdatedBy = "KIEU"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
