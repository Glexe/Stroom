using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stroom.Server.Migrations
{
    public partial class hotfix7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "Comment_PK",
                table: "Comment");

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumns: new[] { "TaskID", "UserID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.AddColumn<int>(
                name: "CommentID",
                table: "Comment",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "Comment_PK",
                table: "Comment",
                column: "CommentID");

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentID", "Comment", "TaskID", "TimeStamp", "UserID" },
                values: new object[] { 1, "Task is complicated...", 1, new DateTime(2022, 9, 3, 5, 31, 7, 886, DateTimeKind.Local).AddTicks(734), 1 });

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "TaskID",
                keyValue: 1,
                columns: new[] { "DueDate", "SubmitionDate" },
                values: new object[] { new DateTime(2022, 9, 9, 5, 31, 7, 886, DateTimeKind.Local).AddTicks(726), new DateTime(2022, 9, 2, 5, 31, 7, 886, DateTimeKind.Local).AddTicks(687) });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 8, 31, 5, 31, 7, 886, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.CreateIndex(
                name: "IX_Comment_TaskID",
                table: "Comment",
                column: "TaskID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "Comment_PK",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_TaskID",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "CommentID",
                table: "Comment");

            migrationBuilder.AddPrimaryKey(
                name: "Comment_PK",
                table: "Comment",
                columns: new[] { "TaskID", "UserID" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumns: new[] { "TaskID", "UserID" },
                keyValues: new object[] { 1, 1 },
                column: "TimeStamp",
                value: new DateTime(2022, 9, 3, 4, 59, 26, 441, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "TaskID",
                keyValue: 1,
                columns: new[] { "DueDate", "SubmitionDate" },
                values: new object[] { new DateTime(2022, 9, 9, 4, 59, 26, 441, DateTimeKind.Local).AddTicks(2200), new DateTime(2022, 9, 2, 4, 59, 26, 441, DateTimeKind.Local).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 8, 31, 4, 59, 26, 441, DateTimeKind.Local).AddTicks(2205));
        }
    }
}
