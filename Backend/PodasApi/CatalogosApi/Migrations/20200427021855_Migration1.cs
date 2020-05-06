using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PodasApi.Catalogo.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "arbol",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UsuarioCreacion = table.Column<string>(nullable: true),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false),
                    id_municipio = table.Column<int>(nullable: false),
                    id_localidad = table.Column<int>(nullable: false),
                    id_barrio = table.Column<int>(nullable: false),
                    codigo1 = table.Column<int>(nullable: false),
                    codigo2 = table.Column<string>(nullable: true),
                    id_familia = table.Column<int>(nullable: false),
                    id_especie = table.Column<int>(nullable: false),
                    id_categoria = table.Column<int>(nullable: false),
                    altura = table.Column<float>(nullable: false),
                    latitud = table.Column<double>(nullable: false),
                    longitud = table.Column<double>(nullable: false),
                    id_tipo_emplazamiento = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_arbol", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "arbol");
        }
    }
}
