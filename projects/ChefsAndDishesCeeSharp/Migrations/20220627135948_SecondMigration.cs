using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChefsAndDishesCeeSharp.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChefAge",
                table: "Chefs");

            migrationBuilder.AddColumn<DateTime>(
                name: "ChefDOB",
                table: "Chefs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChefDOB",
                table: "Chefs");

            migrationBuilder.AddColumn<int>(
                name: "ChefAge",
                table: "Chefs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
