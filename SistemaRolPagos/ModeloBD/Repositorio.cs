using Microsoft.EntityFrameworkCore;
using SistemaRolPagos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloBD
{
    public class Repositorio: DbContext
    {
        //Configuracion Entidades
        public DbSet<Asistencia> Asistencias { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<JornadaTrabajo> JornadasTrabajos { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Permisos> Permisos { get; set; }
        public DbSet<Region> Regiones { get; set; }
        public DbSet<RolPagos> RolPagos { get; set; }
        public DbSet<Rubros> Rubros { get; set; }
        public DbSet<TipoContrato> TiposContratos { get; set; }
        public DbSet<TipoDiscapacidad> TiposDiscapacidades { get; set; }
        public DbSet<TipoPermisos> TiposPermisos { get; set; }
        public DbSet<DiscapacidadEmpleado> DiscacidadEmpleados{ get; set; }
        public DbSet<RubrosEmpleados> RubrosEmpleados { get; set; }

        //Modelado
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Relacion uno a muchos de Region a Pais
            modelBuilder.Entity<Region>()
                .HasOne(region => region.Nombre_Pais)
                .WithMany(pais => pais.Lista_Regiones)
                .HasForeignKey(region => region.PaisId);

            //Relacion uno a muchos de Region a Ciudad
            modelBuilder.Entity<Ciudad>()
                .HasOne(ciudad => ciudad.Nombre_Region)
                .WithMany(region => region.Lista_Ciudades)
                .HasForeignKey(ciudad => ciudad.RegionId);

            //Relaicon uno a muchos de Cargo a Departamento
            modelBuilder.Entity<Departamento>()
                .HasOne(departamento => departamento.Nombre_Cargo)
                .WithMany(cargo => cargo.Lista_Departamento)
                .HasForeignKey(departamento => departamento.CargoId);

            //Relacion uno a muchos de Tipo de Contrato a Contrato
            modelBuilder.Entity<Contrato>()
                .HasOne(contrato => contrato.Tipo_Contrato)
                .WithMany(tipoContrato => tipoContrato.Lista_Contrato)
                .HasForeignKey(contrato => contrato.TipoContratoId);

            //Relacion uno a muchos de TipoPermiso a Permiso
            modelBuilder.Entity<Permisos>()
                .HasOne(permiso => permiso.Tipo_Permisos)
                .WithMany(tipoPermiso => tipoPermiso.Lista_Permisos)
                .HasForeignKey(permiso => permiso.TipoPermisosId);

            //Relacion uno a muchos de Permiso a Empleado
            modelBuilder.Entity<Empleado>()
                .HasOne(empleado => empleado.Nombre_Permiso)
                .WithMany(permiso => permiso.Nombre_Empleado)
                .HasForeignKey(empleado => empleado.PermisosId);

            //Realacion uno a uno de Cargo a Contrato
            modelBuilder.Entity<Cargo>()
                .HasOne(cargo => cargo.Nombre_Contrato)
                .WithOne(contrato => contrato.Nombre_Cargo)
                .HasForeignKey<Cargo>(cargo => cargo.ContratoId);

            //Relacion uno a uno de Empleado a Contrato
            modelBuilder.Entity<Contrato>()
                .HasOne(contrato => contrato.Nombre_Empleado)
                .WithOne(empleado => empleado.contrato)
                .HasForeignKey<Contrato>(contrato => contrato.EmpleadoId);

            //Relacion uno a muchos de Empleado a Asistencia
            modelBuilder.Entity<Empleado>()
                .HasOne(empleado => empleado.AsistenciaEmpleados)
                .WithMany(asistencia => asistencia.Lista_Empleados)
                .HasForeignKey(empleado => empleado.AsistenciaId);

            //Relacion uno a muchos de JornadaTrabajo a Empleado
            modelBuilder.Entity<Empleado>()
                .HasOne(empleado => empleado.Jornada_Trabajo)
                .WithMany(jornadaTrabajo => jornadaTrabajo.Nombre_Empleado)
                .HasForeignKey(empleado => empleado.JornadaTrabajoId);

            //Relacion uno a uno de Rubros a RolPago
            modelBuilder.Entity<Rubros>()
                .HasOne(rubro => rubro.Rol_Pagos)
                .WithOne(rolPago => rolPago.Nombre_Rubro)
                .HasForeignKey<Rubros>(rubro => rubro.RolPagosId);

            //Relacion uno a uno de Rubros a Empleado
            modelBuilder.Entity<Empleado>()
                .HasOne(empleado => empleado.Nombre_Rubros)
                .WithOne(rubros => rubros.Nombre_Empleado)
                .HasForeignKey<Empleado>(empleado => empleado.RubrosId);

            //Relacion Rubros - RubosEmpleados - Empleado
            modelBuilder.Entity<RubrosEmpleados>()
                .HasKey(rubrosEmpleados => new { rubrosEmpleados.RubrosId, rubrosEmpleados.EmpeladoId });

            modelBuilder.Entity<RubrosEmpleados>()
                .HasOne(rubrosEmpleados => rubrosEmpleados.Nombre_Rubro)
                .WithMany(rubros => rubros.RubroEmpleados)
                .HasForeignKey(rubrosEmpleados => rubrosEmpleados.RubrosId);

            modelBuilder.Entity<RubrosEmpleados>()
                .HasOne(rubrosEmpleados => rubrosEmpleados.Nombre_Empleado)
                .WithMany(empleado => empleado.Rubros_Empleados)
                .HasForeignKey(rubrosEmpleados => rubrosEmpleados.EmpeladoId);

            //Relacion uno a uno de Empleado a TipoDiscapacidad
            modelBuilder.Entity<Empleado>()
                .HasOne(empleado => empleado.Nombre_TipoDiscapacidad)
                .WithOne(tipoDiscapacidad => tipoDiscapacidad.Nombre_Empleado)
                .HasForeignKey<Empleado>(empleado => empleado.TipoDiscapacidadId);

            //Relacion Empleado - TipoDiscapacidad - DiscapacidadEmpleado
            modelBuilder.Entity<DiscapacidadEmpleado>()
                .HasKey(discapacidadEmpleado => new { discapacidadEmpleado.Discapacidad, discapacidadEmpleado.Nombre_Empleado });

            modelBuilder.Entity<DiscapacidadEmpleado>()
                .HasOne(discapacidadEmpleado => discapacidadEmpleado.Discapacidad)
                .WithMany(tipoDiscapacidad => tipoDiscapacidad.Discapacidades)
                .HasForeignKey(discapacidadEmpleado => discapacidadEmpleado.TipoDiscapacidadId);

            modelBuilder.Entity<DiscapacidadEmpleado>()
                .HasOne(discapacidadEmpleado => discapacidadEmpleado.Nombre_Empleado)
                .WithMany(empleado => empleado.Discapacidades)
                .HasForeignKey(discapacidadEmpleado => discapacidadEmpleado.EmpleadoId);
        }

        //Conexion con la base de datos SQLServer
        override protected void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("SERVER=DESKTOP-JEQTB22; initial catalog = SGRP; trusted_connection = true;");
        }
    }
}
