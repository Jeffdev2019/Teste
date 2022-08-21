using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Confitec_Test.Migrations
{
    public partial class AddTabelasbaseOnDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbUsuario_TbEscolaridade_EscolaridadeId",
                table: "TbUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_TbUsuario_TbHistoricoEscolar_HistoricoEscolarId",
                table: "TbUsuario");

            migrationBuilder.DropColumn(
                name: "IdEscolaridade",
                table: "TbUsuario");

            migrationBuilder.DropColumn(
                name: "IdHistoricoEscolar",
                table: "TbUsuario");

            migrationBuilder.AlterColumn<int>(
                name: "HistoricoEscolarId",
                table: "TbUsuario",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EscolaridadeId",
                table: "TbUsuario",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TbUsuario_TbEscolaridade_EscolaridadeId",
                table: "TbUsuario",
                column: "EscolaridadeId",
                principalTable: "TbEscolaridade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TbUsuario_TbHistoricoEscolar_HistoricoEscolarId",
                table: "TbUsuario",
                column: "HistoricoEscolarId",
                principalTable: "TbHistoricoEscolar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbUsuario_TbEscolaridade_EscolaridadeId",
                table: "TbUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_TbUsuario_TbHistoricoEscolar_HistoricoEscolarId",
                table: "TbUsuario");

            migrationBuilder.AlterColumn<int>(
                name: "HistoricoEscolarId",
                table: "TbUsuario",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EscolaridadeId",
                table: "TbUsuario",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdEscolaridade",
                table: "TbUsuario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdHistoricoEscolar",
                table: "TbUsuario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_TbUsuario_TbEscolaridade_EscolaridadeId",
                table: "TbUsuario",
                column: "EscolaridadeId",
                principalTable: "TbEscolaridade",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TbUsuario_TbHistoricoEscolar_HistoricoEscolarId",
                table: "TbUsuario",
                column: "HistoricoEscolarId",
                principalTable: "TbHistoricoEscolar",
                principalColumn: "Id");
        }
    }
}
