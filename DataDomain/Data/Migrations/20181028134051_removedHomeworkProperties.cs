using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolSystem.Data.Migrations
{
    public partial class removedHomeworkProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Homeworks_AspNetUsers_ApplicationUserId",
                table: "Homeworks");

            migrationBuilder.DropIndex(
                name: "IX_Homeworks_ApplicationUserId",
                table: "Homeworks");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Homeworks");

            migrationBuilder.DropColumn(
                name: "DateSubmitted",
                table: "Homeworks");

            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "Homeworks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Homeworks",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateSubmitted",
                table: "Homeworks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "Homeworks",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Homeworks_ApplicationUserId",
                table: "Homeworks",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Homeworks_AspNetUsers_ApplicationUserId",
                table: "Homeworks",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
