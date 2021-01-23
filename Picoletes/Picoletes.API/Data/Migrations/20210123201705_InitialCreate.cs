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
                        .Annotation("Sqlite:Autoincrement", true),
                    qntSFloc = table.Column<int>(nullable: false),
                    qntSMor = table.Column<int>(nullable: false),
                    qntSChoc = table.Column<int>(nullable: false),
                    qntPChoc = table.Column<int>(nullable: false),
                    qntPMor = table.Column<int>(nullable: false),
                    qntAFrut = table.Column<int>(nullable: false),
                    qntPLim = table.Column<int>(nullable: false)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PedidoRetirada");

            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
