using Microsoft.EntityFrameworkCore.Migrations;

namespace Picoletes.API.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PedidoRetirada",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoRetirada", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Codigo = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    ValidadeForaFreezer = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnidadeRetirada",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    DescricaoProduto = table.Column<string>(nullable: true),
                    QtdEstoque = table.Column<int>(nullable: false),
                    QtdRetirada = table.Column<int>(nullable: false),
                    ValidadeForaFreezer = table.Column<int>(nullable: false),
                    PedidoRetiradaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadeRetirada", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnidadeRetirada_PedidoRetirada_PedidoRetiradaId",
                        column: x => x.PedidoRetiradaId,
                        principalTable: "PedidoRetirada",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UnidadeRetirada_PedidoRetiradaId",
                table: "UnidadeRetirada",
                column: "PedidoRetiradaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "UnidadeRetirada");

            migrationBuilder.DropTable(
                name: "PedidoRetirada");
        }
    }
}
