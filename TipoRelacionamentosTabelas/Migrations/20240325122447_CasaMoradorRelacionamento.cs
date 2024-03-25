using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TipoRelacionamentosTabelas.Migrations
{
    /// <inheritdoc />
    public partial class CasaMoradorRelacionamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MoradorModelcasaModel",
                columns: table => new
                {
                    CasasId = table.Column<int>(type: "int", nullable: false),
                    MoradoresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoradorModelcasaModel", x => new { x.CasasId, x.MoradoresId });
                    table.ForeignKey(
                        name: "FK_MoradorModelcasaModel_Casas_CasasId",
                        column: x => x.CasasId,
                        principalTable: "Casas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoradorModelcasaModel_Moradores_MoradoresId",
                        column: x => x.MoradoresId,
                        principalTable: "Moradores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MoradorModelcasaModel_MoradoresId",
                table: "MoradorModelcasaModel",
                column: "MoradoresId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoradorModelcasaModel");
        }
    }
}
