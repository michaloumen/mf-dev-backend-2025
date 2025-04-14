using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mf_dev_backend_2025.Migrations
{
    public partial class CorrigeColunaVeiculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumos_Veículos_VeículoId",
                table: "Consumos");

            migrationBuilder.DropIndex(
                name: "IX_Consumos_VeículoId",
                table: "Consumos");

            migrationBuilder.DropColumn(
                name: "Veiculo",
                table: "Consumos");

            migrationBuilder.DropColumn(
                name: "VeículoId",
                table: "Consumos");

            migrationBuilder.CreateIndex(
                name: "IX_Consumos_VeiculoId",
                table: "Consumos",
                column: "VeiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumos_Veículos_VeiculoId",
                table: "Consumos",
                column: "VeiculoId",
                principalTable: "Veículos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumos_Veículos_VeiculoId",
                table: "Consumos");

            migrationBuilder.DropIndex(
                name: "IX_Consumos_VeiculoId",
                table: "Consumos");

            migrationBuilder.AddColumn<int>(
                name: "Veiculo",
                table: "Consumos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VeículoId",
                table: "Consumos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Consumos_VeículoId",
                table: "Consumos",
                column: "VeículoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumos_Veículos_VeículoId",
                table: "Consumos",
                column: "VeículoId",
                principalTable: "Veículos",
                principalColumn: "Id");
        }
    }
}
