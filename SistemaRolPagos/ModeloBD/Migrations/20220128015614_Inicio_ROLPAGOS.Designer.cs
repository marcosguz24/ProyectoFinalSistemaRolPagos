﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModeloBD;

#nullable disable

namespace ModeloBD.Migrations
{
    [DbContext(typeof(Repositorio))]
    [Migration("20220128015614_Inicio_ROLPAGOS")]
    partial class Inicio_ROLPAGOS
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SistemaRolPagos.Entidades.Asistencia", b =>
                {
                    b.Property<int>("AsistenciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AsistenciaId"), 1L, 1);

                    b.Property<DateTime>("Fecha_Asistencia")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hora_Asistencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo_Asistencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AsistenciaId");

                    b.ToTable("asistencias");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.Cargo", b =>
                {
                    b.Property<int>("CargoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CargoId"), 1L, 1);

                    b.Property<int>("ContratoId")
                        .HasColumnType("int");

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre_Cargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CargoId");

                    b.HasIndex("ContratoId")
                        .IsUnique();

                    b.HasIndex("DepartamentoId");

                    b.ToTable("cargos");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.Ciudad", b =>
                {
                    b.Property<int>("CiudadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CiudadId"), 1L, 1);

                    b.Property<string>("Nombre_Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.HasKey("CiudadId");

                    b.HasIndex("RegionId");

                    b.ToTable("ciudades");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.Contrato", b =>
                {
                    b.Property<int>("ContratoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContratoId"), 1L, 1);

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fin_Contrato")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Inicio_Contrato")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Sueldo_Contrato")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TipoContratoId")
                        .HasColumnType("int");

                    b.HasKey("ContratoId");

                    b.HasIndex("EmpleadoId")
                        .IsUnique();

                    b.HasIndex("TipoContratoId");

                    b.ToTable("contratos");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.Departamento", b =>
                {
                    b.Property<int>("DepartamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartamentoId"), 1L, 1);

                    b.Property<string>("Nombre_Departamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartamentoId");

                    b.ToTable("departamentos");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.DiscapacidadEmpleado", b =>
                {
                    b.Property<int>("tipoDiscapacidadId")
                        .HasColumnType("int");

                    b.Property<int>("empleadoId")
                        .HasColumnType("int");

                    b.HasKey("tipoDiscapacidadId", "empleadoId");

                    b.HasIndex("empleadoId");

                    b.ToTable("discacidadEmpleados");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.Empleado", b =>
                {
                    b.Property<int>("EmpleadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpleadoId"), 1L, 1);

                    b.Property<string>("Apellidos_Empleado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AsistenciaId")
                        .HasColumnType("int");

                    b.Property<string>("Banco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula_Empleado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular_Empleado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email_Empleado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado_Civil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JornadaTrabajoId")
                        .HasColumnType("int");

                    b.Property<string>("Nivel_Educacion_Empleado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nombre_CiudadCiudadId")
                        .HasColumnType("int");

                    b.Property<string>("Nombres_Empleado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero_Cuenta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PermisosId")
                        .HasColumnType("int");

                    b.Property<string>("Profesion_Empleado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RubrosId")
                        .HasColumnType("int");

                    b.Property<string>("Sexo_Empelado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoDiscapacidadId")
                        .HasColumnType("int");

                    b.Property<string>("Tipo_Cuenta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpleadoId");

                    b.HasIndex("AsistenciaId");

                    b.HasIndex("JornadaTrabajoId");

                    b.HasIndex("Nombre_CiudadCiudadId");

                    b.HasIndex("PermisosId");

                    b.HasIndex("RubrosId")
                        .IsUnique();

                    b.HasIndex("TipoDiscapacidadId")
                        .IsUnique();

                    b.ToTable("empleados");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.JornadaTrabajo", b =>
                {
                    b.Property<int>("JornadaTrabajoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JornadaTrabajoId"), 1L, 1);

                    b.Property<string>("Tipo_Jornada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JornadaTrabajoId");

                    b.ToTable("jornadasTrabajos");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.Pais", b =>
                {
                    b.Property<int>("PaisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaisId"), 1L, 1);

                    b.Property<string>("Nombre_Pais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaisId");

                    b.ToTable("paises");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.Permisos", b =>
                {
                    b.Property<int>("PermisosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PermisosId"), 1L, 1);

                    b.Property<string>("Estado_Permiso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_Fin_Permiso")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha_Inicio_Permiso")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hora_Fin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hora_Inicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_Permiso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoPermisosId")
                        .HasColumnType("int");

                    b.HasKey("PermisosId");

                    b.HasIndex("TipoPermisosId");

                    b.ToTable("permisos");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.Region", b =>
                {
                    b.Property<int>("RegionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RegionId"), 1L, 1);

                    b.Property<string>("Nombre_Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaisId")
                        .HasColumnType("int");

                    b.HasKey("RegionId");

                    b.HasIndex("PaisId");

                    b.ToTable("regiones");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.RolPagos", b =>
                {
                    b.Property<int>("RolPagosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RolPagosId"), 1L, 1);

                    b.Property<string>("Descripcion_RolPagos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado_Rol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_Fin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha_Inicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre_Empresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RUC_Empresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Representante_Empresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RolPagosId");

                    b.ToTable("rolPagos");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.Rubros", b =>
                {
                    b.Property<int>("RubrosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RubrosId"), 1L, 1);

                    b.Property<int>("Dias_Gracia_Rubro")
                        .HasColumnType("int");

                    b.Property<decimal>("Facturar_Rubro")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Mes_Pago_Rubro")
                        .HasColumnType("int");

                    b.Property<string>("Nombre_Rubro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RolPagosId")
                        .HasColumnType("int");

                    b.Property<string>("Tipo_Rubro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RubrosId");

                    b.HasIndex("RolPagosId")
                        .IsUnique();

                    b.ToTable("rubros");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.RubrosEmpleados", b =>
                {
                    b.Property<int>("RubrosId")
                        .HasColumnType("int");

                    b.Property<int>("EmpeladoId")
                        .HasColumnType("int");

                    b.HasKey("RubrosId", "EmpeladoId");

                    b.HasIndex("EmpeladoId");

                    b.ToTable("rubrosEmpleados");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.TipoContrato", b =>
                {
                    b.Property<int>("TipoContratoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoContratoId"), 1L, 1);

                    b.Property<string>("Descripcion_Tipo_Contrato")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_Tipo_Contrato")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoContratoId");

                    b.ToTable("tiposContratos");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.TipoDiscapacidad", b =>
                {
                    b.Property<int>("TipoDiscapacidadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoDiscapacidadId"), 1L, 1);

                    b.Property<string>("Descripcion_TipoDiscapacidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreTipoDiscapacidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoDiscapacidadId");

                    b.ToTable("tiposDiscapacidades");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.TipoPermisos", b =>
                {
                    b.Property<int>("TipoPermisosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoPermisosId"), 1L, 1);

                    b.Property<string>("Descripcion_Tipo_Permiso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_Tipo_Permiso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoPermisosId");

                    b.ToTable("tiposPermisos");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.Cargo", b =>
                {
                    b.HasOne("SistemaRolPagos.Entidades.Contrato", "Nombre_Contrato")
                        .WithOne("Nombre_Cargo")
                        .HasForeignKey("SistemaRolPagos.Entidades.Cargo", "ContratoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaRolPagos.Entidades.Departamento", "Nombre_Departamento")
                        .WithMany("Lista_Cargos")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nombre_Contrato");

                    b.Navigation("Nombre_Departamento");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.Ciudad", b =>
                {
                    b.HasOne("SistemaRolPagos.Entidades.Region", "Nombre_Region")
                        .WithMany("Lista_Ciudades")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nombre_Region");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.Contrato", b =>
                {
                    b.HasOne("SistemaRolPagos.Entidades.Empleado", "Nombre_Empleado")
                        .WithOne("contrato")
                        .HasForeignKey("SistemaRolPagos.Entidades.Contrato", "EmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaRolPagos.Entidades.TipoContrato", "Tipo_Contrato")
                        .WithMany("Lista_Contrato")
                        .HasForeignKey("TipoContratoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nombre_Empleado");

                    b.Navigation("Tipo_Contrato");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.DiscapacidadEmpleado", b =>
                {
                    b.HasOne("SistemaRolPagos.Entidades.Empleado", "empleado")
                        .WithMany("Discapacidad")
                        .HasForeignKey("empleadoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SistemaRolPagos.Entidades.TipoDiscapacidad", "tipoDiscapacidad")
                        .WithMany("discapacidadEmpleados")
                        .HasForeignKey("tipoDiscapacidadId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("empleado");

                    b.Navigation("tipoDiscapacidad");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.Empleado", b =>
                {
                    b.HasOne("SistemaRolPagos.Entidades.Asistencia", "AsistenciaEmpleados")
                        .WithMany("Lista_Empleados")
                        .HasForeignKey("AsistenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaRolPagos.Entidades.JornadaTrabajo", "Jornada_Trabajo")
                        .WithMany("Nombre_Empleado")
                        .HasForeignKey("JornadaTrabajoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaRolPagos.Entidades.Ciudad", "Nombre_Ciudad")
                        .WithMany()
                        .HasForeignKey("Nombre_CiudadCiudadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaRolPagos.Entidades.Permisos", "Nombre_Permiso")
                        .WithMany("Nombre_Empleado")
                        .HasForeignKey("PermisosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaRolPagos.Entidades.Rubros", "Nombre_Rubros")
                        .WithOne("Nombre_Empleado")
                        .HasForeignKey("SistemaRolPagos.Entidades.Empleado", "RubrosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaRolPagos.Entidades.TipoDiscapacidad", "Nombre_TipoDiscapacidad")
                        .WithOne("Nombre_Empleado")
                        .HasForeignKey("SistemaRolPagos.Entidades.Empleado", "TipoDiscapacidadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AsistenciaEmpleados");

                    b.Navigation("Jornada_Trabajo");

                    b.Navigation("Nombre_Ciudad");

                    b.Navigation("Nombre_Permiso");

                    b.Navigation("Nombre_Rubros");

                    b.Navigation("Nombre_TipoDiscapacidad");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.Permisos", b =>
                {
                    b.HasOne("SistemaRolPagos.Entidades.TipoPermisos", "Tipo_Permisos")
                        .WithMany("Lista_Permisos")
                        .HasForeignKey("TipoPermisosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tipo_Permisos");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.Region", b =>
                {
                    b.HasOne("SistemaRolPagos.Entidades.Pais", "Nombre_Pais")
                        .WithMany("Lista_Regiones")
                        .HasForeignKey("PaisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nombre_Pais");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.Rubros", b =>
                {
                    b.HasOne("SistemaRolPagos.Entidades.RolPagos", "Rol_Pagos")
                        .WithOne("Nombre_Rubro")
                        .HasForeignKey("SistemaRolPagos.Entidades.Rubros", "RolPagosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol_Pagos");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.RubrosEmpleados", b =>
                {
                    b.HasOne("SistemaRolPagos.Entidades.Empleado", "Nombre_Empleado")
                        .WithMany("RubroEmpleado")
                        .HasForeignKey("EmpeladoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SistemaRolPagos.Entidades.Rubros", "Nombre_Rubro")
                        .WithMany("RubroEmpleado")
                        .HasForeignKey("RubrosId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Nombre_Empleado");

                    b.Navigation("Nombre_Rubro");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.Asistencia", b =>
                {
                    b.Navigation("Lista_Empleados");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.Contrato", b =>
                {
                    b.Navigation("Nombre_Cargo")
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.Departamento", b =>
                {
                    b.Navigation("Lista_Cargos");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.Empleado", b =>
                {
                    b.Navigation("Discapacidad");

                    b.Navigation("RubroEmpleado");

                    b.Navigation("contrato")
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.JornadaTrabajo", b =>
                {
                    b.Navigation("Nombre_Empleado");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.Pais", b =>
                {
                    b.Navigation("Lista_Regiones");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.Permisos", b =>
                {
                    b.Navigation("Nombre_Empleado");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.Region", b =>
                {
                    b.Navigation("Lista_Ciudades");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.RolPagos", b =>
                {
                    b.Navigation("Nombre_Rubro")
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.Rubros", b =>
                {
                    b.Navigation("Nombre_Empleado")
                        .IsRequired();

                    b.Navigation("RubroEmpleado");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.TipoContrato", b =>
                {
                    b.Navigation("Lista_Contrato");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.TipoDiscapacidad", b =>
                {
                    b.Navigation("Nombre_Empleado")
                        .IsRequired();

                    b.Navigation("discapacidadEmpleados");
                });

            modelBuilder.Entity("SistemaRolPagos.Entidades.TipoPermisos", b =>
                {
                    b.Navigation("Lista_Permisos");
                });
#pragma warning restore 612, 618
        }
    }
}
