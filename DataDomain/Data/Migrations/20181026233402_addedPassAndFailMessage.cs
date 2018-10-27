using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolSystem.Data.Migrations
{
    public partial class addedPassAndFailMessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Settings",
                newName: "PassMessage");

            migrationBuilder.RenameColumn(
                name: "Key",
                table: "Settings",
                newName: "FailMessage");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PassMessage",
                table: "Settings",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "FailMessage",
                table: "Settings",
                newName: "Key");
        }
    }
}
