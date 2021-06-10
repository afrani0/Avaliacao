using Microsoft.EntityFrameworkCore.Migrations;

namespace AvaliacaoTecnica.Migrations
{
    public partial class CriandoTabelas3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pessoas_Departamentos_DepartamentoId",
                table: "pessoas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pessoas",
                table: "pessoas");

            migrationBuilder.RenameTable(
                name: "pessoas",
                newName: "Pessoas");

            migrationBuilder.RenameIndex(
                name: "IX_pessoas_DepartamentoId",
                table: "Pessoas",
                newName: "IX_Pessoas_DepartamentoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pessoas",
                table: "Pessoas",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nome",
                value: "Ti");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Departamentos_DepartamentoId",
                table: "Pessoas",
                column: "DepartamentoId",
                principalTable: "Departamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Departamentos_DepartamentoId",
                table: "Pessoas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pessoas",
                table: "Pessoas");

            migrationBuilder.RenameTable(
                name: "Pessoas",
                newName: "pessoas");

            migrationBuilder.RenameIndex(
                name: "IX_Pessoas_DepartamentoId",
                table: "pessoas",
                newName: "IX_pessoas_DepartamentoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pessoas",
                table: "pessoas",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nome",
                value: "Tie");

            migrationBuilder.AddForeignKey(
                name: "FK_pessoas_Departamentos_DepartamentoId",
                table: "pessoas",
                column: "DepartamentoId",
                principalTable: "Departamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
