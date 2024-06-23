using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoRecursos.Migrations
{
    /// <inheritdoc />
    public partial class new_listatecnica_fields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ListasTecnicas_ProdutoId",
                table: "ListasTecnicas");

            migrationBuilder.AddColumn<float>(
                name: "Quantidade",
                table: "ListasTecnicas",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateIndex(
                name: "IX_ListasTecnicas_ProdutoId_MateriaPrimaId",
                table: "ListasTecnicas",
                columns: new[] { "ProdutoId", "MateriaPrimaId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ListasTecnicas_ProdutoId_MateriaPrimaId",
                table: "ListasTecnicas");

            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "ListasTecnicas");

            migrationBuilder.CreateIndex(
                name: "IX_ListasTecnicas_ProdutoId",
                table: "ListasTecnicas",
                column: "ProdutoId");
        }
    }
}
