using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stroom.Server.Migrations
{
    public partial class hotfix4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "TimeEntry_PK",
                table: "TimeEntry");

            migrationBuilder.DeleteData(
                table: "TimeEntry",
                keyColumns: new[] { "TaskID", "UserID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.AddColumn<int>(
                name: "TimeEntryID",
                table: "TimeEntry",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "TimeEntry_PK",
                table: "TimeEntry",
                column: "TimeEntryID");

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumns: new[] { "TaskID", "UserID" },
                keyValues: new object[] { 1, 1 },
                column: "TimeStamp",
                value: new DateTime(2022, 9, 3, 3, 44, 29, 847, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "TaskID",
                keyValue: 1,
                columns: new[] { "DueDate", "SubmitionDate" },
                values: new object[] { new DateTime(2022, 9, 9, 3, 44, 29, 847, DateTimeKind.Local).AddTicks(4122), new DateTime(2022, 9, 2, 3, 44, 29, 847, DateTimeKind.Local).AddTicks(4085) });

            migrationBuilder.InsertData(
                table: "TimeEntry",
                columns: new[] { "TimeEntryID", "Date", "Hours", "TaskID", "UserID" },
                values: new object[] { 1, new DateTime(2022, 8, 31, 3, 44, 29, 847, DateTimeKind.Local).AddTicks(4125), 3f, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntry_TaskID",
                table: "TimeEntry",
                column: "TaskID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "TimeEntry_PK",
                table: "TimeEntry");

            migrationBuilder.DropIndex(
                name: "IX_TimeEntry_TaskID",
                table: "TimeEntry");

            migrationBuilder.DropColumn(
                name: "TimeEntryID",
                table: "TimeEntry");

            migrationBuilder.AddPrimaryKey(
                name: "TimeEntry_PK",
                table: "TimeEntry",
                columns: new[] { "TaskID", "UserID" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumns: new[] { "TaskID", "UserID" },
                keyValues: new object[] { 1, 1 },
                column: "TimeStamp",
                value: new DateTime(2022, 9, 3, 1, 57, 46, 557, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "TaskID",
                keyValue: 1,
                columns: new[] { "DueDate", "SubmitionDate" },
                values: new object[] { new DateTime(2022, 9, 9, 1, 57, 46, 557, DateTimeKind.Local).AddTicks(8026), new DateTime(2022, 9, 2, 1, 57, 46, 557, DateTimeKind.Local).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumns: new[] { "TaskID", "UserID" },
                keyValues: new object[] { 1, 1 },
                column: "Date",
                value: new DateTime(2022, 8, 31, 1, 57, 46, 557, DateTimeKind.Local).AddTicks(8030));
        }
    }
}
