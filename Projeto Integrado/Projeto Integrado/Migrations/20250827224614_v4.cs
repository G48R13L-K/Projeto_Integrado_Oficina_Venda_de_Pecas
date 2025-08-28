using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto_Integrado.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PrecoTotal",
                table: "Vendas",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_ClienteId",
                table: "Vendas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_PecaId",
                table: "Vendas",
                column: "PecaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Pecas_PecaId",
                table: "Vendas",
                column: "PecaId",
                principalTable: "Pecas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Usuario_ClienteId",
                table: "Vendas",
                column: "ClienteId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Pecas_PecaId",
                table: "Vendas");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Usuario_ClienteId",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Vendas_ClienteId",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Vendas_PecaId",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "PrecoTotal",
                table: "Vendas");
        }
    }
}
