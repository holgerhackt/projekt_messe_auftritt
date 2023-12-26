using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebcamApp.Migrations
{
    public partial class AddedImagePropertyOfUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "important",
                table: "Addresses");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Users",
                type: "BLOB",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "important",
                table: "Addresses",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
