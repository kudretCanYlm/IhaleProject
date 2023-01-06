using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IhaleProject.Migrations
{
    public partial class ihale_entity_modify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IhaleState",
                table: "Ihale",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IhaleState",
                table: "Ihale");
        }
    }
}
