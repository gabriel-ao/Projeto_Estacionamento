using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EstacionamentoVeiculos.Infra.Migrations
{
    public partial class Relacionamento_Usuario_Veiculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioId",
                table: "Veiculo",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_UsuarioId",
                table: "Veiculo",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_Usuario_UsuarioId",
                table: "Veiculo",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_Usuario_UsuarioId",
                table: "Veiculo");

            migrationBuilder.DropIndex(
                name: "IX_Veiculo_UsuarioId",
                table: "Veiculo");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Veiculo");
        }
    }
}
