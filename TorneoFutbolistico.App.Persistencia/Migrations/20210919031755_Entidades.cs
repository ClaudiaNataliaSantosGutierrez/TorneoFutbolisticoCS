using Microsoft.EntityFrameworkCore.Migrations;

namespace TorneoFutbolistico.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Personas",
                newName: "id");

            migrationBuilder.AddColumn<string>(
                name: "Colegio",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DirectorTecnico_EquipoId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EquipoId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id_A",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id_DS",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id_P",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "N_equipo",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Numero",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Posicion",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Desempeños",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartidosJugados = table.Column<int>(type: "int", nullable: false),
                    PartidosGanados = table.Column<int>(type: "int", nullable: false),
                    PartidosEmpatados = table.Column<int>(type: "int", nullable: false),
                    PartidosPerdidos = table.Column<int>(type: "int", nullable: false),
                    GolesFavor = table.Column<int>(type: "int", nullable: false),
                    GolesContra = table.Column<int>(type: "int", nullable: false),
                    Puntos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desempeños", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NovedadesPartido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Novedad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JugadorInvolucrado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TarjetasAmarillas = table.Column<int>(type: "int", nullable: false),
                    TarjetasRojas = table.Column<int>(type: "int", nullable: false),
                    Goles = table.Column<int>(type: "int", nullable: false),
                    Minuto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NovedadesPartido", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEquipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DesempeñoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipos_Desempeños_DesempeñoId",
                        column: x => x.DesempeñoId,
                        principalTable: "Desempeños",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMunicipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Municipios_Equipos_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estadios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEstadio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MunicipioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estadios_Municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Partidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipoLocal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarcadorLocal = table.Column<int>(type: "int", nullable: false),
                    EquipoVisitante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarcadorVisitante = table.Column<int>(type: "int", nullable: false),
                    EstadioId = table.Column<int>(type: "int", nullable: true),
                    Arbitroid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partidos_Estadios_EstadioId",
                        column: x => x.EstadioId,
                        principalTable: "Estadios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partidos_Personas_Arbitroid",
                        column: x => x.Arbitroid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_DirectorTecnico_EquipoId",
                table: "Personas",
                column: "DirectorTecnico_EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_EquipoId",
                table: "Personas",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_DesempeñoId",
                table: "Equipos",
                column: "DesempeñoId");

            migrationBuilder.CreateIndex(
                name: "IX_Estadios_MunicipioId",
                table: "Estadios",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Municipios_EquipoId",
                table: "Municipios",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_Arbitroid",
                table: "Partidos",
                column: "Arbitroid");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_EstadioId",
                table: "Partidos",
                column: "EstadioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Equipos_DirectorTecnico_EquipoId",
                table: "Personas",
                column: "DirectorTecnico_EquipoId",
                principalTable: "Equipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Equipos_EquipoId",
                table: "Personas",
                column: "EquipoId",
                principalTable: "Equipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Equipos_DirectorTecnico_EquipoId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Equipos_EquipoId",
                table: "Personas");

            migrationBuilder.DropTable(
                name: "NovedadesPartido");

            migrationBuilder.DropTable(
                name: "Partidos");

            migrationBuilder.DropTable(
                name: "Estadios");

            migrationBuilder.DropTable(
                name: "Municipios");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "Desempeños");

            migrationBuilder.DropIndex(
                name: "IX_Personas_DirectorTecnico_EquipoId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_EquipoId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Colegio",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "DirectorTecnico_EquipoId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "EquipoId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Id_A",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Id_DS",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Id_P",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "N_equipo",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Posicion",
                table: "Personas");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Personas",
                newName: "Id");
        }
    }
}
