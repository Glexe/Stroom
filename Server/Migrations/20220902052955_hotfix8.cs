using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stroom.Server.Migrations
{
    public partial class hotfix8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("UserRole_PK", x => new { x.ProjectID, x.UserID });
                    table.ForeignKey(
                        name: "FK_UserRole_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID");
                    table.ForeignKey(
                        name: "FK_UserRole_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentID",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 9, 3, 7, 29, 54, 593, DateTimeKind.Local).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "TaskID",
                keyValue: 1,
                columns: new[] { "DueDate", "SubmitionDate" },
                values: new object[] { new DateTime(2022, 9, 9, 7, 29, 54, 593, DateTimeKind.Local).AddTicks(4245), new DateTime(2022, 9, 2, 7, 29, 54, 593, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumn: "TimeEntryID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 8, 31, 7, 29, 54, 593, DateTimeKind.Local).AddTicks(4248));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "ProjectID", "UserID", "Role" },
                values: new object[] { 1, 1, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserID",
                table: "UserRole",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentID",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 9, 3, 5, 31, 7, 886, DateTimeKind.Local).AddTicks(734));

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
        }
    }
}
