using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stroom.Server.Migrations
{
    public partial class hotfix5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 8, 31, 3, 44, 29, 847, DateTimeKind.Local).AddTicks(4125));
        }
    }
}
