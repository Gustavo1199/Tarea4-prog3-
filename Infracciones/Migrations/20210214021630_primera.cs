using Microsoft.EntityFrameworkCore.Migrations;

namespace Infracciones.Migrations
{
    public partial class primera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "error",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cedula = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", nullable: false),
                    Placa = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    Marca = table.Column<string>(type: "TEXT", nullable: true),
                    Latitud = table.Column<string>(type: "TEXT", nullable: true),
                    Longitud = table.Column<string>(type: "TEXT", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    pagado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_error", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "error");
        }
    }
}
