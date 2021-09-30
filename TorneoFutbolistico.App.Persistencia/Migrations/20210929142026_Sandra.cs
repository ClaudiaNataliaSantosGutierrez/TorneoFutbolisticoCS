using Microsoft.EntityFrameworkCore.Migrations;

namespace TorneoFutbolistico.App.Persistencia.Migrations
{
    public partial class Sandra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NovedadesPartido",
                table: "NovedadesPartido");

            migrationBuilder.RenameTable(
                name: "NovedadesPartido",
                newName: "NovedadPartidos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NovedadPartidos",
                table: "NovedadPartidos",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NovedadPartidos",
                table: "NovedadPartidos");

            migrationBuilder.RenameTable(
                name: "NovedadPartidos",
                newName: "NovedadesPartido");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NovedadesPartido",
                table: "NovedadesPartido",
                column: "Id");
        }
    }
}
