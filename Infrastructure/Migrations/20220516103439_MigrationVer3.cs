using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class MigrationVer3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "TopicEntityId",
                schema: "dbo",
                table: "tbl_story",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "tbl_story",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 16, 5, 34, 39, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 5, 34, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "tbl_story",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 16, 5, 34, 39, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 5, 34, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "tbl_story",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 16, 5, 34, 39, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 5, 34, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "tbl_story",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 16, 5, 34, 39, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 5, 34, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "tbl_topic",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 16, 5, 34, 39, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 5, 34, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "tbl_topic",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 16, 5, 34, 39, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 5, 34, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "tbl_topic",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 16, 5, 34, 39, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 5, 34, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "tbl_topic",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 16, 5, 34, 39, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 5, 34, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_story_TopicEntityId",
                schema: "dbo",
                table: "tbl_story",
                column: "TopicEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_story_tbl_topic_TopicEntityId",
                schema: "dbo",
                table: "tbl_story",
                column: "TopicEntityId",
                principalSchema: "dbo",
                principalTable: "tbl_topic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_story_tbl_topic_TopicEntityId",
                schema: "dbo",
                table: "tbl_story");

            migrationBuilder.DropIndex(
                name: "IX_tbl_story_TopicEntityId",
                schema: "dbo",
                table: "tbl_story");

            migrationBuilder.DropColumn(
                name: "TopicEntityId",
                schema: "dbo",
                table: "tbl_story");

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 16, 2, 49, 6, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 2, 49, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "tbl_story",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 16, 2, 49, 6, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 2, 49, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "tbl_story",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 16, 2, 49, 6, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 2, 49, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "tbl_story",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 16, 2, 49, 6, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 2, 49, 6, 0, DateTimeKind.Unspecified) });

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
    }
}
