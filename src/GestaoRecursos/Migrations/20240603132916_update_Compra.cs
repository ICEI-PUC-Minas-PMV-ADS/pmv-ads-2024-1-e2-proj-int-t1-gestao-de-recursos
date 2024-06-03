using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoRecursos.Migrations
{
    /// <inheritdoc />
    public partial class update_Compra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FornecedorId",
                table: "Compra",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Fornecedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compra_FornecedorId",
                table: "Compra",
                column: "FornecedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Fornecedores_FornecedorId",
                table: "Compra",
                column: "FornecedorId",
                principalTable: "Fornecedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Fornecedores_FornecedorId",
                table: "Compra");

            migrationBuilder.DropTable(
                name: "Fornecedores");

            migrationBuilder.DropIndex(
                name: "IX_Compra_FornecedorId",
                table: "Compra");

            migrationBuilder.DropColumn(
                name: "FornecedorId",
                table: "Compra");
        }
    }
}
