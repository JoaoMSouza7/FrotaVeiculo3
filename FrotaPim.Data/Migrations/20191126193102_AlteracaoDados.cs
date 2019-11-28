using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FrotaPim.Data.Migrations
{
    public partial class AlteracaoDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_manutencao_carro__CarroId",
                table: "manutencao");

            migrationBuilder.DropForeignKey(
                name: "FK_multas_carro__CarroId",
                table: "multas");

            migrationBuilder.DropForeignKey(
                name: "FK_seguro_carro__CarroId",
                table: "seguro");

            migrationBuilder.DropTable(
                name: "estacionamento");

            migrationBuilder.DropColumn(
                name: "DataEntrada",
                table: "estoque");

            migrationBuilder.RenameColumn(
                name: "_CarroId",
                table: "seguro",
                newName: "CarroId");

            migrationBuilder.RenameIndex(
                name: "IX_seguro__CarroId",
                table: "seguro",
                newName: "IX_seguro_CarroId");

            migrationBuilder.RenameColumn(
                name: "_CarroId",
                table: "multas",
                newName: "CarroId");

            migrationBuilder.RenameIndex(
                name: "IX_multas__CarroId",
                table: "multas",
                newName: "IX_multas_CarroId");

            migrationBuilder.RenameColumn(
                name: "_CarroId",
                table: "manutencao",
                newName: "CarroId");

            migrationBuilder.RenameIndex(
                name: "IX_manutencao__CarroId",
                table: "manutencao",
                newName: "IX_manutencao_CarroId");

            migrationBuilder.AddForeignKey(
                name: "FK_manutencao_carro_CarroId",
                table: "manutencao",
                column: "CarroId",
                principalTable: "carro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_multas_carro_CarroId",
                table: "multas",
                column: "CarroId",
                principalTable: "carro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_seguro_carro_CarroId",
                table: "seguro",
                column: "CarroId",
                principalTable: "carro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_manutencao_carro_CarroId",
                table: "manutencao");

            migrationBuilder.DropForeignKey(
                name: "FK_multas_carro_CarroId",
                table: "multas");

            migrationBuilder.DropForeignKey(
                name: "FK_seguro_carro_CarroId",
                table: "seguro");

            migrationBuilder.RenameColumn(
                name: "CarroId",
                table: "seguro",
                newName: "_CarroId");

            migrationBuilder.RenameIndex(
                name: "IX_seguro_CarroId",
                table: "seguro",
                newName: "IX_seguro__CarroId");

            migrationBuilder.RenameColumn(
                name: "CarroId",
                table: "multas",
                newName: "_CarroId");

            migrationBuilder.RenameIndex(
                name: "IX_multas_CarroId",
                table: "multas",
                newName: "IX_multas__CarroId");

            migrationBuilder.RenameColumn(
                name: "CarroId",
                table: "manutencao",
                newName: "_CarroId");

            migrationBuilder.RenameIndex(
                name: "IX_manutencao_CarroId",
                table: "manutencao",
                newName: "IX_manutencao__CarroId");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataEntrada",
                table: "estoque",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "estacionamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarroId = table.Column<int>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Local = table.Column<string>(nullable: true),
                    Valor = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estacionamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_estacionamento_carro_CarroId",
                        column: x => x.CarroId,
                        principalTable: "carro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_estacionamento_CarroId",
                table: "estacionamento",
                column: "CarroId");

            migrationBuilder.AddForeignKey(
                name: "FK_manutencao_carro__CarroId",
                table: "manutencao",
                column: "_CarroId",
                principalTable: "carro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_multas_carro__CarroId",
                table: "multas",
                column: "_CarroId",
                principalTable: "carro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_seguro_carro__CarroId",
                table: "seguro",
                column: "_CarroId",
                principalTable: "carro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
