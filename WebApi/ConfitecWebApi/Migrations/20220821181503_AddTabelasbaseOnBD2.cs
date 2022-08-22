using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Confitec_Test.Migrations
{
    public partial class AddTabelasbaseOnBD2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TbEscolaridade",
                columns: new[] { "IdEscolaridade", "Descricao" },
                values: new object[,]
                {
                    { 1, "Infantil" },
                    { 2, "Fundamental" },
                    { 3, "Médio" },
                    { 4, "Superior" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TbEscolaridade",
                keyColumn: "IdEscolaridade",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TbEscolaridade",
                keyColumn: "IdEscolaridade",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TbEscolaridade",
                keyColumn: "IdEscolaridade",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TbEscolaridade",
                keyColumn: "IdEscolaridade",
                keyValue: 4);
        }
    }
}
