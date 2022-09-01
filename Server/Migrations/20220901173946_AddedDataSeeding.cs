using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stroom.Server.Migrations
{
    public partial class AddedDataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Task_User_AssigneeUserID",
                table: "Task");

            migrationBuilder.DropPrimaryKey(
                name: "TimeEntry_PK",
                table: "TimeEntry");

            migrationBuilder.DropIndex(
                name: "IX_TimeEntry_TaskID",
                table: "TimeEntry");

            migrationBuilder.DropColumn(
                name: "TimeEntryID",
                table: "TimeEntry");

            migrationBuilder.DropColumn(
                name: "CommentID",
                table: "Comment");

            migrationBuilder.RenameColumn(
                name: "AssigneeUserID",
                table: "Task",
                newName: "AssigneeID");

            migrationBuilder.RenameIndex(
                name: "IX_Task_AssigneeUserID",
                table: "Task",
                newName: "IX_Task_AssigneeID");

            migrationBuilder.AlterColumn<float>(
                name: "EstimatedTime",
                table: "Task",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddPrimaryKey(
                name: "TimeEntry_PK",
                table: "TimeEntry",
                columns: new[] { "TaskID", "UserID" });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectID", "Description", "Name" },
                values: new object[] { 1, "Moon landing program", "Moon colony" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "Email", "Name", "Role", "Surname" },
                values: new object[] { 1, "gl.pvn12@gmail.com", "Hlib", 0, "Pivniev" });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "TaskID", "AssigneeID", "Description", "DueDate", "EstimatedTime", "Name", "Priority", "ProjectID", "Status", "SubmitionDate" },
                values: new object[] { 1, 1, "Name speaks itself", null, null, "Change start button color", 0, 1, 0, new DateTime(2022, 9, 1, 19, 39, 46, 572, DateTimeKind.Local).AddTicks(9382) });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "TaskID", "UserID", "Comment", "TimeStamp" },
                values: new object[] { 1, 1, "Task is complicated...", new DateTime(2022, 9, 2, 19, 39, 46, 572, DateTimeKind.Local).AddTicks(9437) });

            migrationBuilder.InsertData(
                table: "TimeEntry",
                columns: new[] { "TaskID", "UserID", "Date", "Hours" },
                values: new object[] { 1, 1, new DateTime(2022, 8, 30, 19, 39, 46, 572, DateTimeKind.Local).AddTicks(9432), 3f });

            migrationBuilder.AddForeignKey(
                name: "FK_Task_User_AssigneeID",
                table: "Task",
                column: "AssigneeID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Task_User_AssigneeID",
                table: "Task");

            migrationBuilder.DropPrimaryKey(
                name: "TimeEntry_PK",
                table: "TimeEntry");

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumns: new[] { "TaskID", "UserID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "TimeEntry",
                keyColumns: new[] { "TaskID", "UserID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "TaskID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "AssigneeID",
                table: "Task",
                newName: "AssigneeUserID");

            migrationBuilder.RenameIndex(
                name: "IX_Task_AssigneeID",
                table: "Task",
                newName: "IX_Task_AssigneeUserID");

            migrationBuilder.AddColumn<int>(
                name: "TimeEntryID",
                table: "TimeEntry",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<float>(
                name: "EstimatedTime",
                table: "Task",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CommentID",
                table: "Comment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "TimeEntry_PK",
                table: "TimeEntry",
                column: "TimeEntryID");

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntry_TaskID",
                table: "TimeEntry",
                column: "TaskID");

            migrationBuilder.AddForeignKey(
                name: "FK_Task_User_AssigneeUserID",
                table: "Task",
                column: "AssigneeUserID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
