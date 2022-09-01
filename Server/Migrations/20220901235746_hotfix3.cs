using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stroom.Server.Migrations
{
    public partial class hotfix3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "DueDate", "EstimatedTime", "SubmitionDate" },
                values: new object[] { new DateTime(2022, 9, 9, 1, 57, 46, 557, DateTimeKind.Local).AddTicks(8026), 13f, new DateTime(2022, 9, 2, 1, 57, 46, 557, DateTimeKind.Local).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumns: new[] { "TaskID", "UserID" },
                keyValues: new object[] { 1, 1 },
                column: "Date",
                value: new DateTime(2022, 8, 31, 1, 57, 46, 557, DateTimeKind.Local).AddTicks(8030));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumns: new[] { "TaskID", "UserID" },
                keyValues: new object[] { 1, 1 },
                column: "TimeStamp",
                value: new DateTime(2022, 9, 2, 23, 50, 25, 392, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "TaskID",
                keyValue: 1,
                columns: new[] { "DueDate", "EstimatedTime", "SubmitionDate" },
                values: new object[] { null, null, new DateTime(2022, 9, 1, 23, 50, 25, 392, DateTimeKind.Local).AddTicks(1025) });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumns: new[] { "TaskID", "UserID" },
                keyValues: new object[] { 1, 1 },
                column: "Date",
                value: new DateTime(2022, 8, 30, 23, 50, 25, 392, DateTimeKind.Local).AddTicks(1059));
        }
    }
}
