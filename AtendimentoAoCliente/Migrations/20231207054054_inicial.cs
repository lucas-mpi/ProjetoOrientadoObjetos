using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtendimentoAoCliente.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeCompleto = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Cpf = table.Column<string>(type: "TEXT", nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Setores",
                columns: table => new
                {
                    SetorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setores", x => x.SetorId);
                });

            migrationBuilder.CreateTable(
                name: "TipoUsuarios",
                columns: table => new
                {
                    TipoUsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoUsuarios", x => x.TipoUsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeCompleto = table.Column<string>(type: "TEXT", nullable: false),
                    NomeUsuario = table.Column<string>(type: "TEXT", nullable: false),
                    Senha = table.Column<string>(type: "TEXT", nullable: false),
                    TipoUsuarioId = table.Column<int>(type: "INTEGER", nullable: false),
                    SetorId = table.Column<int>(type: "INTEGER", nullable: false),
                    UsuarioAtivo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Atendimentos",
                columns: table => new
                {
                    AtendimentoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ComentarioCliente = table.Column<string>(type: "TEXT", nullable: false),
                    ComentarioAtendente = table.Column<string>(type: "TEXT", nullable: true),
                    DataSolicitacao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    StatusAtendimento = table.Column<string>(type: "TEXT", nullable: true),
                    ClientesClienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    SetoresSetorId = table.Column<int>(type: "INTEGER", nullable: false),
                    UsuariosUsuarioId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atendimentos", x => x.AtendimentoId);
                    table.ForeignKey(
                        name: "FK_Atendimentos_Clientes_ClientesClienteId",
                        column: x => x.ClientesClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Atendimentos_Setores_SetoresSetorId",
                        column: x => x.SetoresSetorId,
                        principalTable: "Setores",
                        principalColumn: "SetorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Atendimentos_Usuarios_UsuariosUsuarioId",
                        column: x => x.UsuariosUsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atendimentos_ClientesClienteId",
                table: "Atendimentos",
                column: "ClientesClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimentos_SetoresSetorId",
                table: "Atendimentos",
                column: "SetoresSetorId");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimentos_UsuariosUsuarioId",
                table: "Atendimentos",
                column: "UsuariosUsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atendimentos");

            migrationBuilder.DropTable(
                name: "TipoUsuarios");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Setores");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
