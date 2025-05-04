using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class AgregarOrdenesTrabajo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Empresa_EmpresaId",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Equipo_EquipoId",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_OrdenTrabajo_OrdenTrabajoId",
                table: "Pagos");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Empresa_EmpresaId",
                table: "Pagos",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Equipo_EquipoId",
                table: "Pagos",
                column: "EquipoId",
                principalTable: "Equipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_OrdenTrabajo_OrdenTrabajoId",
                table: "Pagos",
                column: "OrdenTrabajoId",
                principalTable: "OrdenTrabajo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Empresa_EmpresaId",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Equipo_EquipoId",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_OrdenTrabajo_OrdenTrabajoId",
                table: "Pagos");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Empresa_EmpresaId",
                table: "Pagos",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Equipo_EquipoId",
                table: "Pagos",
                column: "EquipoId",
                principalTable: "Equipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_OrdenTrabajo_OrdenTrabajoId",
                table: "Pagos",
                column: "OrdenTrabajoId",
                principalTable: "OrdenTrabajo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
