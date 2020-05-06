using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PodasApi3._1.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "actualizaciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreTabla = table.Column<string>(maxLength: 50, nullable: false),
                    Version = table.Column<int>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actualizaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "categoria_arbol",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: false),
                    AlturaMinima = table.Column<string>(nullable: false),
                    AlturaMaxima = table.Column<string>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoria_arbol", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "departamentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "estado_fisico",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<int>(maxLength: 50, nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estado_fisico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "estado_fitosanitario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<int>(maxLength: 50, nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estado_fitosanitario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "familia_arbol",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_familia_arbol", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "programacion_poda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Observacion = table.Column<string>(nullable: false),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    FechaFin = table.Column<DateTime>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_programacion_poda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tipo_emplazamiento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_emplazamiento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tipo_intervencion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(maxLength: 60, nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_intervencion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tipo_novedad",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_novedad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "municipios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false),
                    DepartamentoId = table.Column<int>(nullable: false),
                    CodigoDane = table.Column<string>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_municipios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_municipios_departamentos_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "especie_arbol",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreComun = table.Column<string>(nullable: false),
                    NombreCientifico = table.Column<string>(nullable: false),
                    FamiliaArbolId = table.Column<int>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_especie_arbol", x => x.Id);
                    table.ForeignKey(
                        name: "FK_especie_arbol_familia_arbol_FamiliaArbolId",
                        column: x => x.FamiliaArbolId,
                        principalTable: "familia_arbol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "detalle_programacion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProgramacionPodaId = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(maxLength: 100, nullable: false),
                    FechaInicial = table.Column<DateTime>(nullable: false),
                    FechaFinal = table.Column<DateTime>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalle_programacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_detalle_programacion_programacion_poda_ProgramacionPodaId",
                        column: x => x.ProgramacionPodaId,
                        principalTable: "programacion_poda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "localidades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    MunicipioId = table.Column<int>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_localidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_localidades_municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tarifa_poda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CategoriaArbolId = table.Column<int>(nullable: false),
                    MunicipioId = table.Column<int>(nullable: false),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    FechaFin = table.Column<DateTime>(nullable: false),
                    Valor = table.Column<decimal>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tarifa_poda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tarifa_poda_categoria_arbol_CategoriaArbolId",
                        column: x => x.CategoriaArbolId,
                        principalTable: "categoria_arbol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tarifa_poda_municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "terceros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 100, nullable: false),
                    TipoIdentificacion = table.Column<string>(maxLength: 1, nullable: false),
                    NumeroIdentificacion = table.Column<double>(nullable: false),
                    Contacto = table.Column<string>(maxLength: 100, nullable: true),
                    Direccion = table.Column<string>(maxLength: 100, nullable: false),
                    Telefono1 = table.Column<string>(maxLength: 20, nullable: true),
                    Telefono2 = table.Column<string>(maxLength: 20, nullable: true),
                    DepartamentoId = table.Column<int>(nullable: false),
                    MunicipioId = table.Column<int>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_terceros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_terceros_departamentos_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_terceros_municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "barrios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 100, nullable: false),
                    MunicipioId = table.Column<int>(nullable: false),
                    LocalidadId = table.Column<int>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_barrios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_barrios_localidades_LocalidadId",
                        column: x => x.LocalidadId,
                        principalTable: "localidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_barrios_municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cuadrillas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<int>(maxLength: 50, nullable: false),
                    TerceroId = table.Column<int>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cuadrillas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cuadrillas_terceros_TerceroId",
                        column: x => x.TerceroId,
                        principalTable: "terceros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    login = table.Column<string>(maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(maxLength: 100, nullable: false),
                    Correo = table.Column<string>(maxLength: 100, nullable: false),
                    TipoIdentificacion = table.Column<string>(maxLength: 1, nullable: false),
                    NumeroIdentificacion = table.Column<double>(nullable: false),
                    Telefono1 = table.Column<string>(maxLength: 20, nullable: false),
                    Telefono2 = table.Column<string>(maxLength: 20, nullable: false),
                    TipoUsuario = table.Column<string>(maxLength: 1, nullable: false),
                    TerceroId = table.Column<int>(nullable: false),
                    Pasword = table.Column<byte[]>(nullable: false),
                    Salt = table.Column<byte[]>(nullable: false),
                    CambioClave = table.Column<bool>(nullable: false),
                    CorreoConfirmado = table.Column<bool>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_usuarios_terceros_TerceroId",
                        column: x => x.TerceroId,
                        principalTable: "terceros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "arboles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MunicipioId = table.Column<int>(nullable: false),
                    LocalidadId = table.Column<int>(nullable: false),
                    BarrioId = table.Column<int>(nullable: false),
                    Codigo1 = table.Column<int>(nullable: true),
                    Codigo2 = table.Column<string>(maxLength: 20, nullable: true),
                    FamiliaArbolId = table.Column<int>(nullable: false),
                    EspecieArbolId = table.Column<int>(nullable: false),
                    CategoriaArbolId = table.Column<int>(nullable: false),
                    Altura = table.Column<float>(nullable: false),
                    Latitud = table.Column<double>(nullable: false),
                    Longitud = table.Column<double>(nullable: false),
                    TipoEmplazamientoId = table.Column<int>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_arboles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_arboles_barrios_BarrioId",
                        column: x => x.BarrioId,
                        principalTable: "barrios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_arboles_categoria_arbol_CategoriaArbolId",
                        column: x => x.CategoriaArbolId,
                        principalTable: "categoria_arbol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_arboles_especie_arbol_EspecieArbolId",
                        column: x => x.EspecieArbolId,
                        principalTable: "especie_arbol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_arboles_familia_arbol_FamiliaArbolId",
                        column: x => x.FamiliaArbolId,
                        principalTable: "familia_arbol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_arboles_localidades_LocalidadId",
                        column: x => x.LocalidadId,
                        principalTable: "localidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_arboles_municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_arboles_tipo_emplazamiento_TipoEmplazamientoId",
                        column: x => x.TipoEmplazamientoId,
                        principalTable: "tipo_emplazamiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "asignaciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProgramacionPodaId = table.Column<int>(nullable: false),
                    DetalleProgramacionId = table.Column<int>(nullable: false),
                    MunicipioId = table.Column<int>(nullable: false),
                    LocalidadId = table.Column<int>(nullable: false),
                    BarrioId = table.Column<int>(nullable: false),
                    ContratistaId = table.Column<int>(nullable: false),
                    CuadrillaId = table.Column<int>(nullable: false),
                    TotalCensadoInicial = table.Column<int>(nullable: false),
                    TotalNoCensadoInicial = table.Column<int>(nullable: false),
                    TotalCensadoFinal = table.Column<int>(nullable: false),
                    TotalNoCensadoFinal = table.Column<int>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false),
                    TerceroId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asignaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_asignaciones_barrios_BarrioId",
                        column: x => x.BarrioId,
                        principalTable: "barrios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_asignaciones_cuadrillas_CuadrillaId",
                        column: x => x.CuadrillaId,
                        principalTable: "cuadrillas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_asignaciones_detalle_programacion_DetalleProgramacionId",
                        column: x => x.DetalleProgramacionId,
                        principalTable: "detalle_programacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_asignaciones_localidades_LocalidadId",
                        column: x => x.LocalidadId,
                        principalTable: "localidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_asignaciones_municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_asignaciones_programacion_poda_ProgramacionPodaId",
                        column: x => x.ProgramacionPodaId,
                        principalTable: "programacion_poda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_asignaciones_terceros_TerceroId",
                        column: x => x.TerceroId,
                        principalTable: "terceros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cambios_estado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ArbolId = table.Column<int>(nullable: false),
                    Observacion = table.Column<string>(maxLength: 100, nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cambios_estado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cambios_estado_arboles_ArbolId",
                        column: x => x.ArbolId,
                        principalTable: "arboles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "conflicto_arbol",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ArbolId = table.Column<int>(nullable: false),
                    RedesElectricas = table.Column<bool>(nullable: false),
                    RedesHidraulicas = table.Column<bool>(nullable: false),
                    OtrosArboles = table.Column<bool>(nullable: false),
                    Estructuras = table.Column<bool>(nullable: false),
                    InfraestructuraVial = table.Column<bool>(nullable: false),
                    RedesTelefonicas = table.Column<bool>(nullable: false),
                    RedesGas = table.Column<bool>(nullable: false),
                    Alumbrado = table.Column<bool>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conflicto_arbol", x => x.Id);
                    table.ForeignKey(
                        name: "FK_conflicto_arbol_arboles_ArbolId",
                        column: x => x.ArbolId,
                        principalTable: "arboles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "detalle_rechazos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ArbolId = table.Column<int>(nullable: false),
                    TerceroId = table.Column<int>(nullable: false),
                    FechaNovedad = table.Column<DateTime>(nullable: false),
                    Observacion = table.Column<string>(maxLength: 100, nullable: false),
                    Corregir = table.Column<bool>(nullable: false),
                    Inactivar = table.Column<bool>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalle_rechazos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_detalle_rechazos_arboles_ArbolId",
                        column: x => x.ArbolId,
                        principalTable: "arboles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalle_rechazos_terceros_TerceroId",
                        column: x => x.TerceroId,
                        principalTable: "terceros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "medidas_arbol",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ArbolId = table.Column<int>(nullable: false),
                    TipoEmplazamientoId = table.Column<int>(nullable: false),
                    Altura = table.Column<float>(nullable: false),
                    AlturaFus = table.Column<float>(nullable: false),
                    DiametroC = table.Column<float>(nullable: false),
                    DiametroN = table.Column<float>(nullable: false),
                    Volumen = table.Column<float>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medidas_arbol", x => x.Id);
                    table.ForeignKey(
                        name: "FK_medidas_arbol_arboles_ArbolId",
                        column: x => x.ArbolId,
                        principalTable: "arboles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medidas_arbol_tipo_emplazamiento_TipoEmplazamientoId",
                        column: x => x.TipoEmplazamientoId,
                        principalTable: "tipo_emplazamiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "riesgo_arbol",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ArbolId = table.Column<int>(nullable: false),
                    Volcamiento = table.Column<bool>(nullable: false),
                    Ramas = table.Column<bool>(nullable: false),
                    CaidaElementos = table.Column<bool>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_riesgo_arbol", x => x.Id);
                    table.ForeignKey(
                        name: "FK_riesgo_arbol_arboles_ArbolId",
                        column: x => x.ArbolId,
                        principalTable: "arboles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "detalle_asignacion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AsignacionId = table.Column<int>(nullable: false),
                    ArbolId = table.Column<int>(nullable: false),
                    TerceroId = table.Column<int>(nullable: false),
                    CuadrillaId = table.Column<int>(nullable: false),
                    TipoIntervencionId = table.Column<int>(nullable: true),
                    CategoriaInicialId = table.Column<int>(nullable: false),
                    AlturaInicial = table.Column<float>(nullable: false),
                    DiametroCInicial = table.Column<float>(nullable: false),
                    DiametroNInicial = table.Column<float>(nullable: false),
                    CategoriaFinalId = table.Column<int>(nullable: false),
                    AlturaFinal = table.Column<float>(nullable: false),
                    DiametroCFinal = table.Column<float>(nullable: false),
                    DiametroNFinal = table.Column<float>(nullable: false),
                    EstadoFisicoId = table.Column<int>(nullable: true),
                    EstadoFitosanitarioId = table.Column<int>(nullable: true),
                    FechaEjecucion = table.Column<DateTime>(nullable: true),
                    TipoNovedadPodaId = table.Column<int>(nullable: true),
                    Observacion = table.Column<string>(maxLength: 100, nullable: false),
                    NumeroRadicado = table.Column<int>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalle_asignacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_detalle_asignacion_arboles_ArbolId",
                        column: x => x.ArbolId,
                        principalTable: "arboles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalle_asignacion_asignaciones_AsignacionId",
                        column: x => x.AsignacionId,
                        principalTable: "asignaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalle_asignacion_categoria_arbol_CategoriaFinalId",
                        column: x => x.CategoriaFinalId,
                        principalTable: "categoria_arbol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalle_asignacion_categoria_arbol_CategoriaInicialId",
                        column: x => x.CategoriaInicialId,
                        principalTable: "categoria_arbol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalle_asignacion_cuadrillas_CuadrillaId",
                        column: x => x.CuadrillaId,
                        principalTable: "cuadrillas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalle_asignacion_estado_fisico_EstadoFisicoId",
                        column: x => x.EstadoFisicoId,
                        principalTable: "estado_fisico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_detalle_asignacion_estado_fitosanitario_EstadoFitosanitarioId",
                        column: x => x.EstadoFitosanitarioId,
                        principalTable: "estado_fitosanitario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_detalle_asignacion_terceros_TerceroId",
                        column: x => x.TerceroId,
                        principalTable: "terceros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalle_asignacion_tipo_intervencion_TipoIntervencionId",
                        column: x => x.TipoIntervencionId,
                        principalTable: "tipo_intervencion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_detalle_asignacion_tipo_novedad_TipoNovedadPodaId",
                        column: x => x.TipoNovedadPodaId,
                        principalTable: "tipo_novedad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_arboles_BarrioId",
                table: "arboles",
                column: "BarrioId");

            migrationBuilder.CreateIndex(
                name: "IX_arboles_CategoriaArbolId",
                table: "arboles",
                column: "CategoriaArbolId");

            migrationBuilder.CreateIndex(
                name: "IX_arboles_EspecieArbolId",
                table: "arboles",
                column: "EspecieArbolId");

            migrationBuilder.CreateIndex(
                name: "IX_arboles_FamiliaArbolId",
                table: "arboles",
                column: "FamiliaArbolId");

            migrationBuilder.CreateIndex(
                name: "IX_arboles_LocalidadId",
                table: "arboles",
                column: "LocalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_arboles_MunicipioId",
                table: "arboles",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_arboles_TipoEmplazamientoId",
                table: "arboles",
                column: "TipoEmplazamientoId");

            migrationBuilder.CreateIndex(
                name: "IX_asignaciones_BarrioId",
                table: "asignaciones",
                column: "BarrioId");

            migrationBuilder.CreateIndex(
                name: "IX_asignaciones_CuadrillaId",
                table: "asignaciones",
                column: "CuadrillaId");

            migrationBuilder.CreateIndex(
                name: "IX_asignaciones_DetalleProgramacionId",
                table: "asignaciones",
                column: "DetalleProgramacionId");

            migrationBuilder.CreateIndex(
                name: "IX_asignaciones_LocalidadId",
                table: "asignaciones",
                column: "LocalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_asignaciones_MunicipioId",
                table: "asignaciones",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_asignaciones_ProgramacionPodaId",
                table: "asignaciones",
                column: "ProgramacionPodaId");

            migrationBuilder.CreateIndex(
                name: "IX_asignaciones_TerceroId",
                table: "asignaciones",
                column: "TerceroId");

            migrationBuilder.CreateIndex(
                name: "IX_barrios_LocalidadId",
                table: "barrios",
                column: "LocalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_barrios_MunicipioId",
                table: "barrios",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_cambios_estado_ArbolId",
                table: "cambios_estado",
                column: "ArbolId");

            migrationBuilder.CreateIndex(
                name: "IX_conflicto_arbol_ArbolId",
                table: "conflicto_arbol",
                column: "ArbolId");

            migrationBuilder.CreateIndex(
                name: "IX_cuadrillas_TerceroId",
                table: "cuadrillas",
                column: "TerceroId");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_asignacion_ArbolId",
                table: "detalle_asignacion",
                column: "ArbolId");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_asignacion_AsignacionId",
                table: "detalle_asignacion",
                column: "AsignacionId");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_asignacion_CategoriaFinalId",
                table: "detalle_asignacion",
                column: "CategoriaFinalId");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_asignacion_CategoriaInicialId",
                table: "detalle_asignacion",
                column: "CategoriaInicialId");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_asignacion_CuadrillaId",
                table: "detalle_asignacion",
                column: "CuadrillaId");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_asignacion_EstadoFisicoId",
                table: "detalle_asignacion",
                column: "EstadoFisicoId");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_asignacion_EstadoFitosanitarioId",
                table: "detalle_asignacion",
                column: "EstadoFitosanitarioId");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_asignacion_TerceroId",
                table: "detalle_asignacion",
                column: "TerceroId");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_asignacion_TipoIntervencionId",
                table: "detalle_asignacion",
                column: "TipoIntervencionId");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_asignacion_TipoNovedadPodaId",
                table: "detalle_asignacion",
                column: "TipoNovedadPodaId");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_programacion_ProgramacionPodaId",
                table: "detalle_programacion",
                column: "ProgramacionPodaId");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_rechazos_ArbolId",
                table: "detalle_rechazos",
                column: "ArbolId");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_rechazos_TerceroId",
                table: "detalle_rechazos",
                column: "TerceroId");

            migrationBuilder.CreateIndex(
                name: "IX_especie_arbol_FamiliaArbolId",
                table: "especie_arbol",
                column: "FamiliaArbolId");

            migrationBuilder.CreateIndex(
                name: "IX_localidades_MunicipioId",
                table: "localidades",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_medidas_arbol_ArbolId",
                table: "medidas_arbol",
                column: "ArbolId");

            migrationBuilder.CreateIndex(
                name: "IX_medidas_arbol_TipoEmplazamientoId",
                table: "medidas_arbol",
                column: "TipoEmplazamientoId");

            migrationBuilder.CreateIndex(
                name: "IX_municipios_DepartamentoId",
                table: "municipios",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_riesgo_arbol_ArbolId",
                table: "riesgo_arbol",
                column: "ArbolId");

            migrationBuilder.CreateIndex(
                name: "IX_tarifa_poda_CategoriaArbolId",
                table: "tarifa_poda",
                column: "CategoriaArbolId");

            migrationBuilder.CreateIndex(
                name: "IX_tarifa_poda_MunicipioId",
                table: "tarifa_poda",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_terceros_DepartamentoId",
                table: "terceros",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_terceros_MunicipioId",
                table: "terceros",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_TerceroId",
                table: "usuarios",
                column: "TerceroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "actualizaciones");

            migrationBuilder.DropTable(
                name: "cambios_estado");

            migrationBuilder.DropTable(
                name: "conflicto_arbol");

            migrationBuilder.DropTable(
                name: "detalle_asignacion");

            migrationBuilder.DropTable(
                name: "detalle_rechazos");

            migrationBuilder.DropTable(
                name: "medidas_arbol");

            migrationBuilder.DropTable(
                name: "riesgo_arbol");

            migrationBuilder.DropTable(
                name: "tarifa_poda");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "asignaciones");

            migrationBuilder.DropTable(
                name: "estado_fisico");

            migrationBuilder.DropTable(
                name: "estado_fitosanitario");

            migrationBuilder.DropTable(
                name: "tipo_intervencion");

            migrationBuilder.DropTable(
                name: "tipo_novedad");

            migrationBuilder.DropTable(
                name: "arboles");

            migrationBuilder.DropTable(
                name: "cuadrillas");

            migrationBuilder.DropTable(
                name: "detalle_programacion");

            migrationBuilder.DropTable(
                name: "barrios");

            migrationBuilder.DropTable(
                name: "categoria_arbol");

            migrationBuilder.DropTable(
                name: "especie_arbol");

            migrationBuilder.DropTable(
                name: "tipo_emplazamiento");

            migrationBuilder.DropTable(
                name: "terceros");

            migrationBuilder.DropTable(
                name: "programacion_poda");

            migrationBuilder.DropTable(
                name: "localidades");

            migrationBuilder.DropTable(
                name: "familia_arbol");

            migrationBuilder.DropTable(
                name: "municipios");

            migrationBuilder.DropTable(
                name: "departamentos");
        }
    }
}
