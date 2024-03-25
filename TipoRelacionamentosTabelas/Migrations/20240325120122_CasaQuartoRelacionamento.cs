using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TipoRelacionamentosTabelas.Migrations
{
    /// <inheritdoc />
    public partial class CasaQuartoRelacionamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "quartoModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CasaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quartoModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_quartoModel_Casas_CasaId",
                        column: x => x.CasaId,
                        principalTable: "Casas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_quartoModel_CasaId",
                table: "quartoModel",
                column: "CasaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "quartoModel");
        }
    }
}
