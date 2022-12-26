using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IhaleProject.Migrations
{
    public partial class ihale_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ihale",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IhaleNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IhaleAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DosyaAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DosyaUzantisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bytes = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    IhaleAktifMi = table.Column<bool>(type: "bit", nullable: false),
                    BirimId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    alimTuruId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    alimUsuluId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ihale", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ihale");
        }
    }
}
