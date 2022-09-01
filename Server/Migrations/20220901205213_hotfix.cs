using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stroom.Server.Migrations
{
    public partial class hotfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumns: new[] { "TaskID", "UserID" },
                keyValues: new object[] { 1, 1 },
                column: "TimeStamp",
                value: new DateTime(2022, 9, 2, 22, 52, 12, 826, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "TaskID",
                keyValue: 1,
                column: "SubmitionDate",
                value: new DateTime(2022, 9, 1, 22, 52, 12, 826, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumns: new[] { "TaskID", "UserID" },
                keyValues: new object[] { 1, 1 },
                column: "Date",
                value: new DateTime(2022, 8, 30, 22, 52, 12, 826, DateTimeKind.Local).AddTicks(4422));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumns: new[] { "TaskID", "UserID" },
                keyValues: new object[] { 1, 1 },
                column: "TimeStamp",
                value: new DateTime(2022, 9, 2, 22, 51, 42, 81, DateTimeKind.Local).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "TaskID",
                keyValue: 1,
                column: "SubmitionDate",
                value: new DateTime(2022, 9, 1, 22, 51, 42, 81, DateTimeKind.Local).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumns: new[] { "TaskID", "UserID" },
                keyValues: new object[] { 1, 1 },
                column: "Date",
                value: new DateTime(2022, 8, 30, 22, 51, 42, 81, DateTimeKind.Local).AddTicks(9702));
        }
    }
}
