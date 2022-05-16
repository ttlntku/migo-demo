using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class MigrationVer2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StoryEntityId",
                schema: "dbo",
                table: "tbl_topic",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "tbl_story",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AwardIconUrl", "CreatedAt", "UpdatedAt" },
                values: new object[] { "../assets/nature-adventure.svg", new DateTime(2022, 5, 16, 2, 49, 6, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 2, 49, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "tbl_story",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AwardIconUrl", "CreatedAt", "PhotoUrl", "UpdatedAt" },
                values: new object[] { "../assets/nature-adventure.svg", new DateTime(2022, 5, 16, 2, 49, 6, 0, DateTimeKind.Unspecified), "../assets/card-second.png", new DateTime(2022, 5, 16, 2, 49, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "tbl_story",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AwardIconUrl", "CreatedAt", "PhotoUrl", "UpdatedAt" },
                values: new object[] { "../assets/nature-adventure.svg", new DateTime(2022, 5, 16, 2, 49, 6, 0, DateTimeKind.Unspecified), "../assets/card-third.png", new DateTime(2022, 5, 16, 2, 49, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "tbl_story",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AwardIconUrl", "CreatedAt", "PhotoUrl", "UpdatedAt" },
                values: new object[] { "../assets/nature-adventure.svg", new DateTime(2022, 5, 16, 2, 49, 6, 0, DateTimeKind.Unspecified), "../assets/card-first.png", new DateTime(2022, 5, 16, 2, 49, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "tbl_topic",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 16, 2, 49, 6, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 2, 49, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "tbl_topic",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 16, 2, 49, 6, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 2, 49, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "tbl_topic",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 16, 2, 49, 6, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 2, 49, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "tbl_topic",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 16, 2, 49, 6, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 2, 49, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_topic_StoryEntityId",
                schema: "dbo",
                table: "tbl_topic",
                column: "StoryEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_topic_tbl_story_StoryEntityId",
                schema: "dbo",
                table: "tbl_topic",
                column: "StoryEntityId",
                principalSchema: "dbo",
                principalTable: "tbl_story",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_topic_tbl_story_StoryEntityId",
                schema: "dbo",
                table: "tbl_topic");

            migrationBuilder.DropIndex(
                name: "IX_tbl_topic_StoryEntityId",
                schema: "dbo",
                table: "tbl_topic");

            migrationBuilder.DropColumn(
                name: "StoryEntityId",
                schema: "dbo",
                table: "tbl_topic");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "tbl_story",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AwardIconUrl", "CreatedAt", "UpdatedAt" },
                values: new object[] { "../assets/gateway-resort.svg", new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "tbl_story",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AwardIconUrl", "CreatedAt", "PhotoUrl", "UpdatedAt" },
                values: new object[] { "../assets/gateway-resort.svg", new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified), "../assets/city-cultures.svg", new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "tbl_story",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AwardIconUrl", "CreatedAt", "PhotoUrl", "UpdatedAt" },
                values: new object[] { "../assets/gateway-resort.svg", new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified), "../assets/city-cultures.svg", new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "tbl_story",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AwardIconUrl", "CreatedAt", "PhotoUrl", "UpdatedAt" },
                values: new object[] { "../assets/gateway-resort.svg", new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified), "../assets/nature-adventure.svg", new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "tbl_topic",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "tbl_topic",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "tbl_topic",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "tbl_topic",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 12, 9, 40, 46, 0, DateTimeKind.Unspecified) });
        }
    }
}
