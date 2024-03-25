using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TipoRelacionamentosTabelas.Migrations
{
    /// <inheritdoc />
    public partial class CasaEnderecoRelacionamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CasaId",
                table: "Moradas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Moradas_CasaId",
                table: "Moradas",
                column: "CasaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Moradas_Casas_CasaId",
                table: "Moradas",
                column: "CasaId",
                principalTable: "Casas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moradas_Casas_CasaId",
                table: "Moradas");

            migrationBuilder.DropIndex(
                name: "IX_Moradas_CasaId",
                table: "Moradas");

            migrationBuilder.DropColumn(
                name: "CasaId",
                table: "Moradas");
        }
    }
}
