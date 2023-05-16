using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IhaleProject.Migrations
{
    public partial class email_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Ihale_alimTuruId",
                table: "Ihale",
                column: "alimTuruId");

            migrationBuilder.CreateIndex(
                name: "IX_Ihale_alimUsuluId",
                table: "Ihale",
                column: "alimUsuluId");

            migrationBuilder.CreateIndex(
                name: "IX_Ihale_BirimId",
                table: "Ihale",
                column: "BirimId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ihale_AlimTuru_alimTuruId",
                table: "Ihale",
                column: "alimTuruId",
                principalTable: "AlimTuru",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ihale_AlimUsulu_alimUsuluId",
                table: "Ihale",
                column: "alimUsuluId",
                principalTable: "AlimUsulu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ihale_Birim_BirimId",
                table: "Ihale",
                column: "BirimId",
                principalTable: "Birim",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ihale_AlimTuru_alimTuruId",
                table: "Ihale");

            migrationBuilder.DropForeignKey(
                name: "FK_Ihale_AlimUsulu_alimUsuluId",
                table: "Ihale");

            migrationBuilder.DropForeignKey(
                name: "FK_Ihale_Birim_BirimId",
                table: "Ihale");

            migrationBuilder.DropIndex(
                name: "IX_Ihale_alimTuruId",
                table: "Ihale");

            migrationBuilder.DropIndex(
                name: "IX_Ihale_alimUsuluId",
                table: "Ihale");

            migrationBuilder.DropIndex(
                name: "IX_Ihale_BirimId",
                table: "Ihale");
        }
    }
}
