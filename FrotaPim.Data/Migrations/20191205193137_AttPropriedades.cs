using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FrotaPim.Data.Migrations
{
    public partial class AttPropriedades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cargo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeCargo = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cargo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "carro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Placa = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Combustivel = table.Column<string>(nullable: true),
                    Cor = table.Column<string>(nullable: true),
                    Ano = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "contasAPagar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CentroDeCusto = table.Column<string>(nullable: true),
                    TipoDespesa = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Vencimento = table.Column<DateTime>(nullable: false),
                    Valor = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contasAPagar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "endereco",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Rua = table.Column<string>(nullable: true),
                    Numero = table.Column<int>(nullable: false),
                    Bairro = table.Column<string>(nullable: true),
                    CEP = table.Column<int>(nullable: false),
                    Cidade = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_endereco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "estoque",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomePeca = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Fornecedor = table.Column<string>(nullable: true),
                    ValorPeca = table.Column<decimal>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estoque", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "manutencao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescricaoManutencao = table.Column<string>(nullable: true),
                    Valor = table.Column<decimal>(nullable: false),
                    CarroId = table.Column<int>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manutencao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_manutencao_carro_CarroId",
                        column: x => x.CarroId,
                        principalTable: "carro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "seguro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Apolice = table.Column<string>(nullable: true),
                    Seguradora = table.Column<string>(nullable: true),
                    CarroId = table.Column<int>(nullable: true),
                    ValorSeguro = table.Column<decimal>(nullable: false),
                    DataContratacao = table.Column<DateTime>(nullable: false),
                    DataValidade = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seguro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_seguro_carro_CarroId",
                        column: x => x.CarroId,
                        principalTable: "carro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "pessoa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    CPF = table.Column<int>(nullable: false),
                    CargoId = table.Column<int>(nullable: true),
                    EnderecoId = table.Column<int>(nullable: true),
                    Admissao = table.Column<DateTime>(nullable: false),
                    Telefone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pessoa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pessoa_cargo_CargoId",
                        column: x => x.CargoId,
                        principalTable: "cargo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_pessoa_endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "multas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PessoaId = table.Column<int>(nullable: true),
                    TipoMulta = table.Column<string>(nullable: true),
                    Gravidade = table.Column<string>(nullable: true),
                    DataMulta = table.Column<DateTime>(nullable: false),
                    ValorMulta = table.Column<decimal>(nullable: false),
                    CarroId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_multas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_multas_carro_CarroId",
                        column: x => x.CarroId,
                        principalTable: "carro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_multas_pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_manutencao_CarroId",
                table: "manutencao",
                column: "CarroId");

            migrationBuilder.CreateIndex(
                name: "IX_multas_CarroId",
                table: "multas",
                column: "CarroId");

            migrationBuilder.CreateIndex(
                name: "IX_multas_PessoaId",
                table: "multas",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_pessoa_CargoId",
                table: "pessoa",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_pessoa_EnderecoId",
                table: "pessoa",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_seguro_CarroId",
                table: "seguro",
                column: "CarroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contasAPagar");

            migrationBuilder.DropTable(
                name: "estoque");

            migrationBuilder.DropTable(
                name: "manutencao");

            migrationBuilder.DropTable(
                name: "multas");

            migrationBuilder.DropTable(
                name: "seguro");

            migrationBuilder.DropTable(
                name: "pessoa");

            migrationBuilder.DropTable(
                name: "carro");

            migrationBuilder.DropTable(
                name: "cargo");

            migrationBuilder.DropTable(
                name: "endereco");
        }
    }
}
