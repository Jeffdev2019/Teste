using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Confitec_Test.Migrations
{
    public partial class AddTabelasbaseOnBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbEscolaridade",
                columns: table => new
                {
                    IdEscolaridade = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbEscolaridade", x => x.IdEscolaridade);
                });

            migrationBuilder.CreateTable(
                name: "TbHistoricoEscolar",
                columns: table => new
                {
                    IdHistoricoEscolar = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Formato = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FileBase64 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbHistoricoEscolar", x => x.IdHistoricoEscolar);
                });

            migrationBuilder.CreateTable(
                name: "TbUsuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SobreNome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EscolaridadeId = table.Column<int>(type: "int", nullable: true),
                    HistoricoEscolarId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbUsuario", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_TbUsuario_TbEscolaridade_EscolaridadeId",
                        column: x => x.EscolaridadeId,
                        principalTable: "TbEscolaridade",
                        principalColumn: "IdEscolaridade");
                    table.ForeignKey(
                        name: "FK_TbUsuario_TbHistoricoEscolar_HistoricoEscolarId",
                        column: x => x.HistoricoEscolarId,
                        principalTable: "TbHistoricoEscolar",
                        principalColumn: "IdHistoricoEscolar");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbUsuario_EscolaridadeId",
                table: "TbUsuario",
                column: "EscolaridadeId");

            migrationBuilder.CreateIndex(
                name: "IX_TbUsuario_HistoricoEscolarId",
                table: "TbUsuario",
                column: "HistoricoEscolarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbUsuario");

            migrationBuilder.DropTable(
                name: "TbEscolaridade");

            migrationBuilder.DropTable(
                name: "TbHistoricoEscolar");
        }
    }
}
