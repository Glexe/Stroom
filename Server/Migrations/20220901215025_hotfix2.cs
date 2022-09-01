using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stroom.Server.Migrations
{
    public partial class hotfix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_User_UserID",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_User_UserID",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_User_AssigneeID",
                table: "Task");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeEntry_User_UserID",
                table: "TimeEntry");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserID");

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
                column: "SubmitionDate",
                value: new DateTime(2022, 9, 1, 23, 50, 25, 392, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "TimeEntry",
                keyColumns: new[] { "TaskID", "UserID" },
                keyValues: new object[] { 1, 1 },
                column: "Date",
                value: new DateTime(2022, 8, 30, 23, 50, 25, 392, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Users_UserID",
                table: "Comment",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Users_UserID",
                table: "Project",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Users_AssigneeID",
                table: "Task",
                column: "AssigneeID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeEntry_Users_UserID",
                table: "TimeEntry",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Users_UserID",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_Users_UserID",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_Users_AssigneeID",
                table: "Task");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeEntry_Users_UserID",
                table: "TimeEntry");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_User_UserID",
                table: "Comment",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_User_UserID",
                table: "Project",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Task_User_AssigneeID",
                table: "Task",
                column: "AssigneeID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeEntry_User_UserID",
                table: "TimeEntry",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserID");
        }
    }
}
