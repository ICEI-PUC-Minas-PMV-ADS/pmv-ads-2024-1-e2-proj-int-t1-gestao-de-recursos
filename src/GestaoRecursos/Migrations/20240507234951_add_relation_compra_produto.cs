using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoRecursos.Migrations
{
    /// <inheritdoc />
    public partial class add_relation_compra_produto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Compra_CompraId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_CompraId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "CompraId",
                table: "Produtos");

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "Compra",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Compra_ProdutoId",
                table: "Compra",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Produtos_ProdutoId",
                table: "Compra",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Produtos_ProdutoId",
                table: "Compra");

            migrationBuilder.DropIndex(
                name: "IX_Compra_ProdutoId",
                table: "Compra");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Compra");

            migrationBuilder.AddColumn<int>(
                name: "CompraId",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CompraId",
                table: "Produtos",
                column: "CompraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Compra_CompraId",
                table: "Produtos",
                column: "CompraId",
                principalTable: "Compra",
                principalColumn: "Id");
        }
    }
}
