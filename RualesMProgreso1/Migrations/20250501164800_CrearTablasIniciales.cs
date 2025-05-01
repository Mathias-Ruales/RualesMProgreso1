using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RualesMProgreso1.Migrations
{
    /// <inheritdoc />
    public partial class CrearTablasIniciales : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dueno",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    fechaVisita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tieneMascota = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dueno", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Mascota",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Raza = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    sexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaNacimiento = table.Column<DateOnly>(type: "date", nullable: false),
                    DuenoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mascota", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mascota_Dueno_DuenoId",
                        column: x => x.DuenoId,
                        principalTable: "Dueno",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Cita",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Motivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    requireMedicacion = table.Column<bool>(type: "bit", nullable: false),
                    tarifa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MascotaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cita", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cita_Mascota_MascotaId",
                        column: x => x.MascotaId,
                        principalTable: "Mascota",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cita_MascotaId",
                table: "Cita",
                column: "MascotaId");

            migrationBuilder.CreateIndex(
                name: "IX_Mascota_DuenoId",
                table: "Mascota",
                column: "DuenoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cita");

            migrationBuilder.DropTable(
                name: "Mascota");

            migrationBuilder.DropTable(
                name: "Dueno");
        }
    }
}
