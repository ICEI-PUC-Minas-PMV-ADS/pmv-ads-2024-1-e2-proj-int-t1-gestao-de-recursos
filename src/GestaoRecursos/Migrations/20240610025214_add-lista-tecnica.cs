using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoRecursos.Migrations
{
    /// <inheritdoc />
    public partial class addlistatecnica : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LancamentoProducao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListaTecnicaId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LancamentoProducao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LancamentoProducao_ListasTecnicas_ListaTecnicaId",
                        column: x => x.ListaTecnicaId,
                        principalTable: "ListasTecnicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LancamentoProducao_ListaTecnicaId",
                table: "LancamentoProducao",
                column: "ListaTecnicaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LancamentoProducao");
        }
    }
}
