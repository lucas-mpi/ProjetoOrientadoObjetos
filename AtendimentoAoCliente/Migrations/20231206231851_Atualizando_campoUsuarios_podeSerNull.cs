using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtendimentoAoCliente.Migrations
{
    public partial class Atualizando_campoUsuarios_podeSerNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atendimentos_Usuarios_UsuariosUsuarioId",
                table: "Atendimentos");

            migrationBuilder.AlterColumn<int>(
                name: "UsuariosUsuarioId",
                table: "Atendimentos",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Atendimentos",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimentos_Usuarios_UsuariosUsuarioId",
                table: "Atendimentos",
                column: "UsuariosUsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atendimentos_Usuarios_UsuariosUsuarioId",
                table: "Atendimentos");

            migrationBuilder.AlterColumn<int>(
                name: "UsuariosUsuarioId",
                table: "Atendimentos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Atendimentos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimentos_Usuarios_UsuariosUsuarioId",
                table: "Atendimentos",
                column: "UsuariosUsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
