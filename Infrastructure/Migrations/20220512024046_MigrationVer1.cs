using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class MigrationVer1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "tbl_story",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    PhotoUrl = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    AwardName = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    AwardIconUrl = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_story", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_topic",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopicName = table.Column<string>(type: "varchar(50)", nullable: true),
                    TopicIcon = table.Column<string>(type: "varchar(100)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_topic", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "tbl_story",
                columns: new[] { "Id", "Address", "AwardIconUrl", "AwardName", "CreatedAt", "CreatedBy", "Description", "PhotoUrl", "Title", "TopicId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Phú Quốc, Việt Nam", "../assets/gateway-resort.svg", "", new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified), "KIEU", "Located in an open space with clouds,\r\n                                    sky, and sea, the special highlight of\r\n                                    the resort is the architectural style\r\n                                    combining the three countries of Japan,\r\n                                    France and Vietnam.", "../assets/topic.png", "Beautiful beach at Sunrise Resort, in Hoi An, Quang Nam", 1, new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified), "KIEU" },
                    { 2, "Phú Quốc, Việt Nam", "../assets/gateway-resort.svg", "", new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified), "KIEU", "Located in an open space with clouds,\r\n                                    sky, and sea, the special highlight of\r\n                                    the resort is the architectural style\r\n                                    combining the three countries of Japan,\r\n                                    France and Vietnam.", "../assets/city-cultures.svg", "Topas Ecolodge - Service and comfort in the clouds", 1, new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified), "KIEU" },
                    { 3, "Phú Quốc, Việt Nam", "../assets/gateway-resort.svg", "", new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified), "KIEU", "Located in an open space with clouds,\r\n                                    sky, and sea, the special highlight of\r\n                                    the resort is the architectural style\r\n                                    combining the three countries of Japan,\r\n                                    France and Vietnam.", "../assets/city-cultures.svg", "Topas Ecolodge - Service and comfort in the clouds", 1, new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified), "KIEU" },
                    { 4, "Quảng Nam, Việt Nam", "../assets/gateway-resort.svg", "Nature Adventure", new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified), "KIEU", "Located in an open space with clouds,\r\n                                    sky, and sea, the special highlight of\r\n                                    the resort is the architectural style\r\n                                    combining the three countries of Japan,\r\n                                    France and Vietnam.", "../assets/nature-adventure.svg", "Experience traveling 4 days 3 nights in Quang Ngai pearl island", 1, new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified), "KIEU" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "tbl_topic",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "TopicIcon", "TopicName", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified), "KIEU", "../assets/food-drink.svg", "Food & Drinks", new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified), "KIEU" },
                    { 2, new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified), "KIEU", "../assets/city-cultures.svg", "City & Culture", new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified), "KIEU" },
                    { 3, new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified), "KIEU", "../assets/gateway-resort.svg", "Getaway & Resorts", new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified), "KIEU" },
                    { 4, new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified), "KIEU", "../assets/nature-adventure.svg", "Nature & Adventure", new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified), "KIEU" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_story",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbl_topic",
                schema: "dbo");
        }
    }
}
