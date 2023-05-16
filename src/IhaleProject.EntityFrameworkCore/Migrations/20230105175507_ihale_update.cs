using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IhaleProject.Migrations
{
    public partial class ihale_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IhaleArsivliMi",
                table: "Ihale",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IhaleArsivliMi",
                table: "Ihale");
        }
    }
}
