using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IhaleProject.Migrations
{
    public partial class ihale_entity_modiy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ArsiveEklenmeTarihi",
                table: "Ihale",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArsiveEklenmeTarihi",
                table: "Ihale");
        }
    }
}
