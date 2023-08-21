using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskSystem.Migrations
{
    public partial class vinculandoUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarefa_Usuarios_UserId",
                table: "Tarefa");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Tarefa",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Tarefa_UserId",
                table: "Tarefa",
                newName: "IX_Tarefa_UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefa_Usuarios_UsuarioId",
                table: "Tarefa",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarefa_Usuarios_UsuarioId",
                table: "Tarefa");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Tarefa",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tarefa_UsuarioId",
                table: "Tarefa",
                newName: "IX_Tarefa_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefa_Usuarios_UserId",
                table: "Tarefa",
                column: "UserId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }
    }
}
