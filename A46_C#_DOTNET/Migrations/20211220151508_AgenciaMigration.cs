using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Agencia46.Migrations
{
    public partial class AgenciaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agendamento",
                columns: table => new
                {
                    Id_Agendamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Viagem = table.Column<int>(type: "int", nullable: false),
                    Id_Cliente = table.Column<int>(type: "int", nullable: false),
                    Num_Voo = table.Column<int>(type: "int", nullable: false),
                    Assento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamento", x => x.Id_Agendamento);
                });

            migrationBuilder.CreateTable(
                name: "Destinos",
                columns: table => new
                {
                    Id_Destino = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Dest = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Preco = table.Column<decimal>(type: "money", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinos", x => x.Id_Destino);
                });

            migrationBuilder.CreateTable(
                name: "Origem",
                columns: table => new
                {
                    Id_Origem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Ori = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Origem", x => x.Id_Origem);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CPF = table.Column<string>(type: "char(11)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Viagem",
                columns: table => new
                {
                    Id_Viagem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Origem = table.Column<int>(type: "int", nullable: false),
                    Id_Destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Pagamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo_pag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parcelas = table.Column<int>(type: "int", nullable: false),
                    data_pagamento = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viagem", x => x.Id_Viagem);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendamento");

            migrationBuilder.DropTable(
                name: "Destinos");

            migrationBuilder.DropTable(
                name: "Origem");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Viagem");
        }
    }
}
