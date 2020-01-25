using Microsoft.EntityFrameworkCore.Migrations;

namespace EstacionamentoVeiculos.Infra.Migrations
{
    public partial class Veiculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Veiculo",
                table: "Veiculo");

            migrationBuilder.AddPrimaryKey(
                name: "Id_Veiculo",
                table: "Veiculo",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "Id_Veiculo",
                table: "Veiculo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Veiculo",
                table: "Veiculo",
                column: "Id");
        }
    }
}
