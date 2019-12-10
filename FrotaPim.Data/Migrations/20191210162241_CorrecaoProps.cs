using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FrotaPim.Data.Migrations
{
    public partial class CorrecaoProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ValorSeguro",
                table: "seguro",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<string>(
                name: "ValorMulta",
                table: "multas",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<string>(
                name: "ValorPeca",
                table: "estoque",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<string>(
                name: "Valor",
                table: "contasAPagar",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.CreateTable(
                name: "viagem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Origem = table.Column<string>(nullable: true),
                    Destino = table.Column<string>(nullable: true),
                    KM = table.Column<decimal>(nullable: false),
                    DataViagem = table.Column<DateTime>(nullable: false),
                    Valor = table.Column<string>(nullable: true),
                    CarroId = table.Column<int>(nullable: true),
                    PessoaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_viagem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_viagem_carro_CarroId",
                        column: x => x.CarroId,
                        principalTable: "carro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_viagem_pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_viagem_CarroId",
                table: "viagem",
                column: "CarroId");

            migrationBuilder.CreateIndex(
                name: "IX_viagem_PessoaId",
                table: "viagem",
                column: "PessoaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "viagem");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorSeguro",
                table: "seguro",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorMulta",
                table: "multas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorPeca",
                table: "estoque",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "contasAPagar",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
