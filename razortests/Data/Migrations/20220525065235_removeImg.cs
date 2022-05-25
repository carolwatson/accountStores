using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountStoreApp.Data.Migrations
{
    public partial class removeImg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "ImageType",
                table: "Accounts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "Accounts",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageType",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
