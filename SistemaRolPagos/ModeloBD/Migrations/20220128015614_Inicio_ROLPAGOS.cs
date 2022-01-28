using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModeloBD.Migrations
{
    public partial class Inicio_ROLPAGOS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "asistencias",
                columns: table => new
                {
                    AsistenciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hora_Asistencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_Asistencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tipo_Asistencia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asistencias", x => x.AsistenciaId);
                });

            migrationBuilder.CreateTable(
                name: "departamentos",
                columns: table => new
                {
                    DepartamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Departamento = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departamentos", x => x.DepartamentoId);
                });

            migrationBuilder.CreateTable(
                name: "jornadasTrabajos",
                columns: table => new
                {
                    JornadaTrabajoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo_Jornada = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jornadasTrabajos", x => x.JornadaTrabajoId);
                });

            migrationBuilder.CreateTable(
                name: "paises",
                columns: table => new
                {
                    PaisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Pais = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paises", x => x.PaisId);
                });

            migrationBuilder.CreateTable(
                name: "rolPagos",
                columns: table => new
                {
                    RolPagosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Empresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RUC_Empresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Representante_Empresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion_RolPagos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_Inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Fin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado_Rol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rolPagos", x => x.RolPagosId);
                });

            migrationBuilder.CreateTable(
                name: "tiposContratos",
                columns: table => new
                {
                    TipoContratoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Tipo_Contrato = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion_Tipo_Contrato = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tiposContratos", x => x.TipoContratoId);
                });

            migrationBuilder.CreateTable(
                name: "tiposDiscapacidades",
                columns: table => new
                {
                    TipoDiscapacidadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTipoDiscapacidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion_TipoDiscapacidad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tiposDiscapacidades", x => x.TipoDiscapacidadId);
                });

            migrationBuilder.CreateTable(
                name: "tiposPermisos",
                columns: table => new
                {
                    TipoPermisosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Tipo_Permiso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion_Tipo_Permiso = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tiposPermisos", x => x.TipoPermisosId);
                });

            migrationBuilder.CreateTable(
                name: "regiones",
                columns: table => new
                {
                    RegionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_regiones", x => x.RegionId);
                    table.ForeignKey(
                        name: "FK_regiones_paises_PaisId",
                        column: x => x.PaisId,
                        principalTable: "paises",
                        principalColumn: "PaisId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rubros",
                columns: table => new
                {
                    RubrosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Rubro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo_Rubro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mes_Pago_Rubro = table.Column<int>(type: "int", nullable: false),
                    Dias_Gracia_Rubro = table.Column<int>(type: "int", nullable: false),
                    Facturar_Rubro = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RolPagosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rubros", x => x.RubrosId);
                    table.ForeignKey(
                        name: "FK_rubros_rolPagos_RolPagosId",
                        column: x => x.RolPagosId,
                        principalTable: "rolPagos",
                        principalColumn: "RolPagosId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "permisos",
                columns: table => new
                {
                    PermisosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Permiso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_Inicio_Permiso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Fin_Permiso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hora_Inicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hora_Fin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado_Permiso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoPermisosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permisos", x => x.PermisosId);
                    table.ForeignKey(
                        name: "FK_permisos_tiposPermisos_TipoPermisosId",
                        column: x => x.TipoPermisosId,
                        principalTable: "tiposPermisos",
                        principalColumn: "TipoPermisosId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ciudades",
                columns: table => new
                {
                    CiudadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ciudades", x => x.CiudadId);
                    table.ForeignKey(
                        name: "FK_ciudades_regiones_RegionId",
                        column: x => x.RegionId,
                        principalTable: "regiones",
                        principalColumn: "RegionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "empleados",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apellidos_Empleado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombres_Empleado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cedula_Empleado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email_Empleado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Celular_Empleado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profesion_Empleado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nivel_Educacion_Empleado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sexo_Empelado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado_Civil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Banco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo_Cuenta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero_Cuenta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre_CiudadCiudadId = table.Column<int>(type: "int", nullable: false),
                    TipoDiscapacidadId = table.Column<int>(type: "int", nullable: false),
                    JornadaTrabajoId = table.Column<int>(type: "int", nullable: false),
                    PermisosId = table.Column<int>(type: "int", nullable: false),
                    RubrosId = table.Column<int>(type: "int", nullable: false),
                    AsistenciaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empleados", x => x.EmpleadoId);
                    table.ForeignKey(
                        name: "FK_empleados_asistencias_AsistenciaId",
                        column: x => x.AsistenciaId,
                        principalTable: "asistencias",
                        principalColumn: "AsistenciaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_empleados_ciudades_Nombre_CiudadCiudadId",
                        column: x => x.Nombre_CiudadCiudadId,
                        principalTable: "ciudades",
                        principalColumn: "CiudadId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_empleados_jornadasTrabajos_JornadaTrabajoId",
                        column: x => x.JornadaTrabajoId,
                        principalTable: "jornadasTrabajos",
                        principalColumn: "JornadaTrabajoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_empleados_permisos_PermisosId",
                        column: x => x.PermisosId,
                        principalTable: "permisos",
                        principalColumn: "PermisosId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_empleados_rubros_RubrosId",
                        column: x => x.RubrosId,
                        principalTable: "rubros",
                        principalColumn: "RubrosId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_empleados_tiposDiscapacidades_TipoDiscapacidadId",
                        column: x => x.TipoDiscapacidadId,
                        principalTable: "tiposDiscapacidades",
                        principalColumn: "TipoDiscapacidadId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "contratos",
                columns: table => new
                {
                    ContratoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Inicio_Contrato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fin_Contrato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sueldo_Contrato = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TipoContratoId = table.Column<int>(type: "int", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contratos", x => x.ContratoId);
                    table.ForeignKey(
                        name: "FK_contratos_empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "empleados",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contratos_tiposContratos_TipoContratoId",
                        column: x => x.TipoContratoId,
                        principalTable: "tiposContratos",
                        principalColumn: "TipoContratoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "discacidadEmpleados",
                columns: table => new
                {
                    tipoDiscapacidadId = table.Column<int>(type: "int", nullable: false),
                    empleadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_discacidadEmpleados", x => new { x.tipoDiscapacidadId, x.empleadoId });
                    table.ForeignKey(
                        name: "FK_discacidadEmpleados_empleados_empleadoId",
                        column: x => x.empleadoId,
                        principalTable: "empleados",
                        principalColumn: "EmpleadoId");
                    table.ForeignKey(
                        name: "FK_discacidadEmpleados_tiposDiscapacidades_tipoDiscapacidadId",
                        column: x => x.tipoDiscapacidadId,
                        principalTable: "tiposDiscapacidades",
                        principalColumn: "TipoDiscapacidadId");
                });

            migrationBuilder.CreateTable(
                name: "rubrosEmpleados",
                columns: table => new
                {
                    RubrosId = table.Column<int>(type: "int", nullable: false),
                    EmpeladoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rubrosEmpleados", x => new { x.RubrosId, x.EmpeladoId });
                    table.ForeignKey(
                        name: "FK_rubrosEmpleados_empleados_EmpeladoId",
                        column: x => x.EmpeladoId,
                        principalTable: "empleados",
                        principalColumn: "EmpleadoId");
                    table.ForeignKey(
                        name: "FK_rubrosEmpleados_rubros_RubrosId",
                        column: x => x.RubrosId,
                        principalTable: "rubros",
                        principalColumn: "RubrosId");
                });

            migrationBuilder.CreateTable(
                name: "cargos",
                columns: table => new
                {
                    CargoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartamentoId = table.Column<int>(type: "int", nullable: false),
                    ContratoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cargos", x => x.CargoId);
                    table.ForeignKey(
                        name: "FK_cargos_contratos_ContratoId",
                        column: x => x.ContratoId,
                        principalTable: "contratos",
                        principalColumn: "ContratoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cargos_departamentos_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "departamentos",
                        principalColumn: "DepartamentoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cargos_ContratoId",
                table: "cargos",
                column: "ContratoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cargos_DepartamentoId",
                table: "cargos",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_ciudades_RegionId",
                table: "ciudades",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_contratos_EmpleadoId",
                table: "contratos",
                column: "EmpleadoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_contratos_TipoContratoId",
                table: "contratos",
                column: "TipoContratoId");

            migrationBuilder.CreateIndex(
                name: "IX_discacidadEmpleados_empleadoId",
                table: "discacidadEmpleados",
                column: "empleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_empleados_AsistenciaId",
                table: "empleados",
                column: "AsistenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_empleados_JornadaTrabajoId",
                table: "empleados",
                column: "JornadaTrabajoId");

            migrationBuilder.CreateIndex(
                name: "IX_empleados_Nombre_CiudadCiudadId",
                table: "empleados",
                column: "Nombre_CiudadCiudadId");

            migrationBuilder.CreateIndex(
                name: "IX_empleados_PermisosId",
                table: "empleados",
                column: "PermisosId");

            migrationBuilder.CreateIndex(
                name: "IX_empleados_RubrosId",
                table: "empleados",
                column: "RubrosId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_empleados_TipoDiscapacidadId",
                table: "empleados",
                column: "TipoDiscapacidadId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_permisos_TipoPermisosId",
                table: "permisos",
                column: "TipoPermisosId");

            migrationBuilder.CreateIndex(
                name: "IX_regiones_PaisId",
                table: "regiones",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_rubros_RolPagosId",
                table: "rubros",
                column: "RolPagosId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_rubrosEmpleados_EmpeladoId",
                table: "rubrosEmpleados",
                column: "EmpeladoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cargos");

            migrationBuilder.DropTable(
                name: "discacidadEmpleados");

            migrationBuilder.DropTable(
                name: "rubrosEmpleados");

            migrationBuilder.DropTable(
                name: "contratos");

            migrationBuilder.DropTable(
                name: "departamentos");

            migrationBuilder.DropTable(
                name: "empleados");

            migrationBuilder.DropTable(
                name: "tiposContratos");

            migrationBuilder.DropTable(
                name: "asistencias");

            migrationBuilder.DropTable(
                name: "ciudades");

            migrationBuilder.DropTable(
                name: "jornadasTrabajos");

            migrationBuilder.DropTable(
                name: "permisos");

            migrationBuilder.DropTable(
                name: "rubros");

            migrationBuilder.DropTable(
                name: "tiposDiscapacidades");

            migrationBuilder.DropTable(
                name: "regiones");

            migrationBuilder.DropTable(
                name: "tiposPermisos");

            migrationBuilder.DropTable(
                name: "rolPagos");

            migrationBuilder.DropTable(
                name: "paises");
        }
    }
}
