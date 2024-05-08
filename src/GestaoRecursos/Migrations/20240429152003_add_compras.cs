using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoRecursos.Migrations
{
    /// <inheritdoc />
    public partial class add_compras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompraId",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra", x => x.Id);
                });

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

            migrationBuilder.AddColumn<int>(
               name: "Quantidade",
               table: "Produtos",
               type: "int",
               nullable: false,
               defaultValue: 0);
        }



        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Compra_CompraId",
                table: "Produtos");

            migrationBuilder.DropTable(
                name: "Compra");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_CompraId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "CompraId",
                table: "Produtos");
        }
    }
}
