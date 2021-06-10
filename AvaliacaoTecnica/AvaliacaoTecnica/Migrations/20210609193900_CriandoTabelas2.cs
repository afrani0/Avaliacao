using Microsoft.EntityFrameworkCore.Migrations;

namespace AvaliacaoTecnica.Migrations
{
    public partial class CriandoTabelas2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "Tie" });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 2, "Vendas" });

            migrationBuilder.InsertData(
                table: "pessoas",
                columns: new[] { "Id", "DepartamentoId", "Nome", "Salario" },
                values: new object[,]
                {
                    { 1, 1, "Joe", 70000.0 },
                    { 4, 1, "Max", 90000.0 },
                    { 2, 2, "Henry", 80000.0 },
                    { 3, 2, "Sam", 60000.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "pessoas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "pessoas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "pessoas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "pessoas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
