using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModeloBD.Migrations
{
    public partial class InicioSRP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asistencias",
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
                    table.PrimaryKey("PK_Asistencias", x => x.AsistenciaId);
                });

            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    DepartamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Departamento = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.DepartamentoId);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    EmpresaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Empresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RUC_Empresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Representante_Empresa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.EmpresaId);
                });

            migrationBuilder.CreateTable(
                name: "JornadasTrabajos",
                columns: table => new
                {
                    JornadaTrabajoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo_Jornada = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JornadasTrabajos", x => x.JornadaTrabajoId);
                });

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    PaisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Pais = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.PaisId);
                });

            migrationBuilder.CreateTable(
                name: "RolPagos",
                columns: table => new
                {
                    RolPagosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion_RolPagos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_Inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Fin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado_Rol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rubro_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolPagos", x => x.RolPagosId);
                });

            migrationBuilder.CreateTable(
                name: "TiposContratos",
                columns: table => new
                {
                    TipoContratoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion_Tipo_Contrato = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposContratos", x => x.TipoContratoId);
                });

            migrationBuilder.CreateTable(
                name: "TiposDiscapacidades",
                columns: table => new
                {
                    TipoDiscapacidadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion_TipoDiscapacidad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDiscapacidades", x => x.TipoDiscapacidadId);
                });

            migrationBuilder.CreateTable(
                name: "TiposPermisos",
                columns: table => new
                {
                    TipoPermisosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion_Tipo_Permiso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposPermisos", x => x.TipoPermisosId);
                });

            migrationBuilder.CreateTable(
                name: "Cargos",
                columns: table => new
                {
                    CargoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre_DepartamentoDepartamentoId = table.Column<int>(type: "int", nullable: false),
                    Departamento_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargos", x => x.CargoId);
                    table.ForeignKey(
                        name: "FK_Cargos_Departamentos_Nombre_DepartamentoDepartamentoId",
                        column: x => x.Nombre_DepartamentoDepartamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "DepartamentoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Regiones",
                columns: table => new
                {
                    RegionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre_PaisPaisId = table.Column<int>(type: "int", nullable: false),
                    Pais_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regiones", x => x.RegionId);
                    table.ForeignKey(
                        name: "FK_Regiones_Paises_Nombre_PaisPaisId",
                        column: x => x.Nombre_PaisPaisId,
                        principalTable: "Paises",
                        principalColumn: "PaisId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rubros",
                columns: table => new
                {
                    RubrosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Rubro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo_Rubro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mes_Pago_Rubro = table.Column<int>(type: "int", nullable: false),
                    Dias_Gracia_Rubro = table.Column<int>(type: "int", nullable: false),
                    Facturar_Rubro = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Empleado = table.Column<int>(type: "int", nullable: false),
                    RolPagosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rubros", x => x.RubrosId);
                    table.ForeignKey(
                        name: "FK_Rubros_RolPagos_RolPagosId",
                        column: x => x.RolPagosId,
                        principalTable: "RolPagos",
                        principalColumn: "RolPagosId");
                });

            migrationBuilder.CreateTable(
                name: "Contratos",
                columns: table => new
                {
                    ContratoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Inicio_Contrato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fin_Contrato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sueldo_Contrato = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tipo_ContratoTipoContratoId = table.Column<int>(type: "int", nullable: false),
                    TipoContrato_Id = table.Column<int>(type: "int", nullable: false),
                    Nombre_CargoCargoId = table.Column<int>(type: "int", nullable: false),
                    Cargo_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contratos", x => x.ContratoId);
                    table.ForeignKey(
                        name: "FK_Contratos_Cargos_Nombre_CargoCargoId",
                        column: x => x.Nombre_CargoCargoId,
                        principalTable: "Cargos",
                        principalColumn: "CargoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contratos_TiposContratos_Tipo_ContratoTipoContratoId",
                        column: x => x.Tipo_ContratoTipoContratoId,
                        principalTable: "TiposContratos",
                        principalColumn: "TipoContratoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    CiudadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre_RegionRegionId = table.Column<int>(type: "int", nullable: false),
                    Region_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.CiudadId);
                    table.ForeignKey(
                        name: "FK_Ciudades_Regiones_Nombre_RegionRegionId",
                        column: x => x.Nombre_RegionRegionId,
                        principalTable: "Regiones",
                        principalColumn: "RegionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apellidos_Empleado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombres_Empleado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cedula_Empleado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pasaporte_Empleado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email_Empleado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Celular_Empleado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profesion_Empleado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nivel_Educacion_Empleado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sexo_Empelado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado_Civil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Banco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo_Cuenta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero_Cuenta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre_EmpresaEmpresaId = table.Column<int>(type: "int", nullable: false),
                    Empresa_Id = table.Column<int>(type: "int", nullable: false),
                    ContratoId = table.Column<int>(type: "int", nullable: false),
                    Contrato_Id = table.Column<int>(type: "int", nullable: false),
                    Nombre_CiudadCiudadId = table.Column<int>(type: "int", nullable: false),
                    Ciudad_Id = table.Column<int>(type: "int", nullable: false),
                    Tipo_DiscapacidadTipoDiscapacidadId = table.Column<int>(type: "int", nullable: false),
                    TipoDiscapacidad_Id = table.Column<int>(type: "int", nullable: false),
                    Jornada_TrabajoJornadaTrabajoId = table.Column<int>(type: "int", nullable: false),
                    JornadaTrabajos_Id = table.Column<int>(type: "int", nullable: false),
                    AsistenciaEmpleadosAsistenciaId = table.Column<int>(type: "int", nullable: false),
                    Asistencia_Id = table.Column<int>(type: "int", nullable: false),
                    RubrosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.EmpleadoId);
                    table.ForeignKey(
                        name: "FK_Empleados_Asistencias_AsistenciaEmpleadosAsistenciaId",
                        column: x => x.AsistenciaEmpleadosAsistenciaId,
                        principalTable: "Asistencias",
                        principalColumn: "AsistenciaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_Ciudades_Nombre_CiudadCiudadId",
                        column: x => x.Nombre_CiudadCiudadId,
                        principalTable: "Ciudades",
                        principalColumn: "CiudadId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_Contratos_ContratoId",
                        column: x => x.ContratoId,
                        principalTable: "Contratos",
                        principalColumn: "ContratoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_Empresas_Nombre_EmpresaEmpresaId",
                        column: x => x.Nombre_EmpresaEmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "EmpresaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_JornadasTrabajos_Jornada_TrabajoJornadaTrabajoId",
                        column: x => x.Jornada_TrabajoJornadaTrabajoId,
                        principalTable: "JornadasTrabajos",
                        principalColumn: "JornadaTrabajoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_Rubros_RubrosId",
                        column: x => x.RubrosId,
                        principalTable: "Rubros",
                        principalColumn: "RubrosId");
                    table.ForeignKey(
                        name: "FK_Empleados_TiposDiscapacidades_Tipo_DiscapacidadTipoDiscapacidadId",
                        column: x => x.Tipo_DiscapacidadTipoDiscapacidadId,
                        principalTable: "TiposDiscapacidades",
                        principalColumn: "TipoDiscapacidadId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permisos",
                columns: table => new
                {
                    PermisosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha_Inicio_Permiso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Fin_Permiso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hora_Inicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hora_Fin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado_Permiso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo_PermisosTipoPermisosId = table.Column<int>(type: "int", nullable: false),
                    TipoPermisos_Id = table.Column<int>(type: "int", nullable: false),
                    Nombre_EmpleadoEmpleadoId = table.Column<int>(type: "int", nullable: false),
                    Empleado_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permisos", x => x.PermisosId);
                    table.ForeignKey(
                        name: "FK_Permisos_Empleados_Nombre_EmpleadoEmpleadoId",
                        column: x => x.Nombre_EmpleadoEmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Permisos_TiposPermisos_Tipo_PermisosTipoPermisosId",
                        column: x => x.Tipo_PermisosTipoPermisosId,
                        principalTable: "TiposPermisos",
                        principalColumn: "TipoPermisosId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cargos_Nombre_DepartamentoDepartamentoId",
                table: "Cargos",
                column: "Nombre_DepartamentoDepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudades_Nombre_RegionRegionId",
                table: "Ciudades",
                column: "Nombre_RegionRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_Nombre_CargoCargoId",
                table: "Contratos",
                column: "Nombre_CargoCargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_Tipo_ContratoTipoContratoId",
                table: "Contratos",
                column: "Tipo_ContratoTipoContratoId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_AsistenciaEmpleadosAsistenciaId",
                table: "Empleados",
                column: "AsistenciaEmpleadosAsistenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_ContratoId",
                table: "Empleados",
                column: "ContratoId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_Jornada_TrabajoJornadaTrabajoId",
                table: "Empleados",
                column: "Jornada_TrabajoJornadaTrabajoId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_Nombre_CiudadCiudadId",
                table: "Empleados",
                column: "Nombre_CiudadCiudadId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_Nombre_EmpresaEmpresaId",
                table: "Empleados",
                column: "Nombre_EmpresaEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_RubrosId",
                table: "Empleados",
                column: "RubrosId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_Tipo_DiscapacidadTipoDiscapacidadId",
                table: "Empleados",
                column: "Tipo_DiscapacidadTipoDiscapacidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Permisos_Nombre_EmpleadoEmpleadoId",
                table: "Permisos",
                column: "Nombre_EmpleadoEmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Permisos_Tipo_PermisosTipoPermisosId",
                table: "Permisos",
                column: "Tipo_PermisosTipoPermisosId");

            migrationBuilder.CreateIndex(
                name: "IX_Regiones_Nombre_PaisPaisId",
                table: "Regiones",
                column: "Nombre_PaisPaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Rubros_RolPagosId",
                table: "Rubros",
                column: "RolPagosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Permisos");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "TiposPermisos");

            migrationBuilder.DropTable(
                name: "Asistencias");

            migrationBuilder.DropTable(
                name: "Ciudades");

            migrationBuilder.DropTable(
                name: "Contratos");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "JornadasTrabajos");

            migrationBuilder.DropTable(
                name: "Rubros");

            migrationBuilder.DropTable(
                name: "TiposDiscapacidades");

            migrationBuilder.DropTable(
                name: "Regiones");

            migrationBuilder.DropTable(
                name: "Cargos");

            migrationBuilder.DropTable(
                name: "TiposContratos");

            migrationBuilder.DropTable(
                name: "RolPagos");

            migrationBuilder.DropTable(
                name: "Paises");

            migrationBuilder.DropTable(
                name: "Departamentos");
        }
    }
}
