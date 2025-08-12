using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionAnticiposApp.Migrations
{
    /// <inheritdoc />
    public partial class ArregloModelos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aprobaciones_Personas_PersonaId1",
                table: "Aprobaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Aprobaciones_ProcesosVinculados_ProcesoVinculadoId",
                table: "Aprobaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Aprobaciones_ProcesosVinculados_ProcesoVinculadoId1",
                table: "Aprobaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Contratos_Personas_PersonaId1",
                table: "Contratos");

            migrationBuilder.DropForeignKey(
                name: "FK_Documento_Personas_PersonaId1",
                table: "Documento");

            migrationBuilder.DropForeignKey(
                name: "FK_Documento_ProcesosVinculados_ProcesoVinculadoId",
                table: "Documento");

            migrationBuilder.DropForeignKey(
                name: "FK_Documento_ProcesosVinculados_ProcesoVinculadoId1",
                table: "Documento");

            migrationBuilder.DropForeignKey(
                name: "FK_Notificaciones_Personas_PersonaId1",
                table: "Notificaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Notificaciones_ProcesosVinculados_ProcesoVinculadoId",
                table: "Notificaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Notificaciones_ProcesosVinculados_ProcesoVinculadoId1",
                table: "Notificaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_ProcesosVinculados_Contratos_ContratoId1",
                table: "ProcesosVinculados");

            migrationBuilder.DropForeignKey(
                name: "FK_ProcesosVinculados_Personas_PersonaId1",
                table: "ProcesosVinculados");

            migrationBuilder.DropIndex(
                name: "IX_ProcesosVinculados_ContratoId1",
                table: "ProcesosVinculados");

            migrationBuilder.DropIndex(
                name: "IX_ProcesosVinculados_PersonaId1",
                table: "ProcesosVinculados");

            migrationBuilder.DropIndex(
                name: "IX_Notificaciones_PersonaId1",
                table: "Notificaciones");

            migrationBuilder.DropIndex(
                name: "IX_Notificaciones_ProcesoVinculadoId1",
                table: "Notificaciones");

            migrationBuilder.DropIndex(
                name: "IX_Documento_PersonaId1",
                table: "Documento");

            migrationBuilder.DropIndex(
                name: "IX_Documento_ProcesoVinculadoId1",
                table: "Documento");

            migrationBuilder.DropIndex(
                name: "IX_Contratos_PersonaId1",
                table: "Contratos");

            migrationBuilder.DropIndex(
                name: "IX_Aprobaciones_PersonaId1",
                table: "Aprobaciones");

            migrationBuilder.DropIndex(
                name: "IX_Aprobaciones_ProcesoVinculadoId1",
                table: "Aprobaciones");

            migrationBuilder.DropColumn(
                name: "ContratoId1",
                table: "ProcesosVinculados");

            migrationBuilder.DropColumn(
                name: "PersonaId1",
                table: "ProcesosVinculados");

            migrationBuilder.DropColumn(
                name: "PersonaId1",
                table: "Notificaciones");

            migrationBuilder.DropColumn(
                name: "ProcesoVinculadoId1",
                table: "Notificaciones");

            migrationBuilder.DropColumn(
                name: "PersonaId1",
                table: "Documento");

            migrationBuilder.DropColumn(
                name: "ProcesoVinculadoId1",
                table: "Documento");

            migrationBuilder.DropColumn(
                name: "PersonaId1",
                table: "Contratos");

            migrationBuilder.DropColumn(
                name: "PersonaId1",
                table: "Aprobaciones");

            migrationBuilder.DropColumn(
                name: "ProcesoVinculadoId1",
                table: "Aprobaciones");

            migrationBuilder.AddForeignKey(
                name: "FK_Aprobaciones_ProcesosVinculados_ProcesoVinculadoId",
                table: "Aprobaciones",
                column: "ProcesoVinculadoId",
                principalTable: "ProcesosVinculados",
                principalColumn: "ProcesoVinculadoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Documento_ProcesosVinculados_ProcesoVinculadoId",
                table: "Documento",
                column: "ProcesoVinculadoId",
                principalTable: "ProcesosVinculados",
                principalColumn: "ProcesoVinculadoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notificaciones_ProcesosVinculados_ProcesoVinculadoId",
                table: "Notificaciones",
                column: "ProcesoVinculadoId",
                principalTable: "ProcesosVinculados",
                principalColumn: "ProcesoVinculadoId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aprobaciones_ProcesosVinculados_ProcesoVinculadoId",
                table: "Aprobaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Documento_ProcesosVinculados_ProcesoVinculadoId",
                table: "Documento");

            migrationBuilder.DropForeignKey(
                name: "FK_Notificaciones_ProcesosVinculados_ProcesoVinculadoId",
                table: "Notificaciones");

            migrationBuilder.AddColumn<int>(
                name: "ContratoId1",
                table: "ProcesosVinculados",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonaId1",
                table: "ProcesosVinculados",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonaId1",
                table: "Notificaciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProcesoVinculadoId1",
                table: "Notificaciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonaId1",
                table: "Documento",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProcesoVinculadoId1",
                table: "Documento",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonaId1",
                table: "Contratos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonaId1",
                table: "Aprobaciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProcesoVinculadoId1",
                table: "Aprobaciones",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProcesosVinculados_ContratoId1",
                table: "ProcesosVinculados",
                column: "ContratoId1");

            migrationBuilder.CreateIndex(
                name: "IX_ProcesosVinculados_PersonaId1",
                table: "ProcesosVinculados",
                column: "PersonaId1");

            migrationBuilder.CreateIndex(
                name: "IX_Notificaciones_PersonaId1",
                table: "Notificaciones",
                column: "PersonaId1");

            migrationBuilder.CreateIndex(
                name: "IX_Notificaciones_ProcesoVinculadoId1",
                table: "Notificaciones",
                column: "ProcesoVinculadoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Documento_PersonaId1",
                table: "Documento",
                column: "PersonaId1");

            migrationBuilder.CreateIndex(
                name: "IX_Documento_ProcesoVinculadoId1",
                table: "Documento",
                column: "ProcesoVinculadoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_PersonaId1",
                table: "Contratos",
                column: "PersonaId1");

            migrationBuilder.CreateIndex(
                name: "IX_Aprobaciones_PersonaId1",
                table: "Aprobaciones",
                column: "PersonaId1");

            migrationBuilder.CreateIndex(
                name: "IX_Aprobaciones_ProcesoVinculadoId1",
                table: "Aprobaciones",
                column: "ProcesoVinculadoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Aprobaciones_Personas_PersonaId1",
                table: "Aprobaciones",
                column: "PersonaId1",
                principalTable: "Personas",
                principalColumn: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aprobaciones_ProcesosVinculados_ProcesoVinculadoId",
                table: "Aprobaciones",
                column: "ProcesoVinculadoId",
                principalTable: "ProcesosVinculados",
                principalColumn: "ProcesoVinculadoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Aprobaciones_ProcesosVinculados_ProcesoVinculadoId1",
                table: "Aprobaciones",
                column: "ProcesoVinculadoId1",
                principalTable: "ProcesosVinculados",
                principalColumn: "ProcesoVinculadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contratos_Personas_PersonaId1",
                table: "Contratos",
                column: "PersonaId1",
                principalTable: "Personas",
                principalColumn: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documento_Personas_PersonaId1",
                table: "Documento",
                column: "PersonaId1",
                principalTable: "Personas",
                principalColumn: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documento_ProcesosVinculados_ProcesoVinculadoId",
                table: "Documento",
                column: "ProcesoVinculadoId",
                principalTable: "ProcesosVinculados",
                principalColumn: "ProcesoVinculadoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Documento_ProcesosVinculados_ProcesoVinculadoId1",
                table: "Documento",
                column: "ProcesoVinculadoId1",
                principalTable: "ProcesosVinculados",
                principalColumn: "ProcesoVinculadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notificaciones_Personas_PersonaId1",
                table: "Notificaciones",
                column: "PersonaId1",
                principalTable: "Personas",
                principalColumn: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notificaciones_ProcesosVinculados_ProcesoVinculadoId",
                table: "Notificaciones",
                column: "ProcesoVinculadoId",
                principalTable: "ProcesosVinculados",
                principalColumn: "ProcesoVinculadoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notificaciones_ProcesosVinculados_ProcesoVinculadoId1",
                table: "Notificaciones",
                column: "ProcesoVinculadoId1",
                principalTable: "ProcesosVinculados",
                principalColumn: "ProcesoVinculadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProcesosVinculados_Contratos_ContratoId1",
                table: "ProcesosVinculados",
                column: "ContratoId1",
                principalTable: "Contratos",
                principalColumn: "ContratoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProcesosVinculados_Personas_PersonaId1",
                table: "ProcesosVinculados",
                column: "PersonaId1",
                principalTable: "Personas",
                principalColumn: "PersonaId");
        }
    }
}
