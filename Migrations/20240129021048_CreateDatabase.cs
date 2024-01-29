using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelWEBAPI.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    CodCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCliente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EndCliente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NacioCliente = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    EmailCliente = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TelCliente = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.CodCliente);
                });

            migrationBuilder.CreateTable(
                name: "Filiais",
                columns: table => new
                {
                    CodFilial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFilial = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EndFilial = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Estrelas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filiais", x => x.CodFilial);
                });

            migrationBuilder.CreateTable(
                name: "FiliaisQuartos",
                columns: table => new
                {
                    FkFilialCodFilial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkQuartoNumQuarto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FiliaisQuartos", x => x.FkFilialCodFilial);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    CodFuncionario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CargoFuncionario = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    NomeFuncionario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TelFuncionario = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    FkFilialCodFilial = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.CodFuncionario);
                });

            migrationBuilder.CreateTable(
                name: "Pratos",
                columns: table => new
                {
                    CodPrato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePrato = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ValorPrato = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pratos", x => x.CodPrato);
                });

            migrationBuilder.CreateTable(
                name: "PratosContas",
                columns: table => new
                {
                    FkPratoCodPrato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkReservaContaCodReserva = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PratosContas", x => x.FkPratoCodPrato);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    CodProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProduto = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    PrecoProduto = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.CodProduto);
                });

            migrationBuilder.CreateTable(
                name: "ProdutosContas",
                columns: table => new
                {
                    FkProdutoCodProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkReservaContaCodReserva = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutosContas", x => x.FkProdutoCodProduto);
                });

            migrationBuilder.CreateTable(
                name: "Quartos",
                columns: table => new
                {
                    CodQuarto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumQuarto = table.Column<int>(type: "int", nullable: false),
                    TipoQuarto = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Adaptado = table.Column<bool>(type: "bit", nullable: false),
                    ValorQuarto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CapacidadeQuarto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quartos", x => x.CodQuarto);
                });

            migrationBuilder.CreateTable(
                name: "ReservasContas",
                columns: table => new
                {
                    CodReserva = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCheckin = table.Column<DateOnly>(type: "date", nullable: false),
                    StatusReserva = table.Column<bool>(type: "bit", nullable: false),
                    TipoPagamento = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DataCheckout = table.Column<DateOnly>(type: "date", nullable: false),
                    CamaAdicional = table.Column<bool>(type: "bit", nullable: false),
                    FkClienteCodCliente = table.Column<int>(type: "int", nullable: false),
                    FkQuartoNumQuarto = table.Column<int>(type: "int", nullable: false),
                    FkFuncionarioCodFuncionario = table.Column<int>(type: "int", nullable: false),
                    Pago = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservasContas", x => x.CodReserva);
                });

            migrationBuilder.CreateTable(
                name: "Servicos",
                columns: table => new
                {
                    CodServico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescServico = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ValorServico = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicos", x => x.CodServico);
                });

            migrationBuilder.CreateTable(
                name: "ServicosContas",
                columns: table => new
                {
                    FkServicoCodServico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkReservaContaCodReserva = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicosContas", x => x.FkServicoCodServico);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Filiais");

            migrationBuilder.DropTable(
                name: "FiliaisQuartos");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Pratos");

            migrationBuilder.DropTable(
                name: "PratosContas");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "ProdutosContas");

            migrationBuilder.DropTable(
                name: "Quartos");

            migrationBuilder.DropTable(
                name: "ReservasContas");

            migrationBuilder.DropTable(
                name: "Servicos");

            migrationBuilder.DropTable(
                name: "ServicosContas");
        }
    }
}
