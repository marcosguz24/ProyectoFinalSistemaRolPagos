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
        public Repositorio(DbContextOptions<Repositorio> options)
            : base(options)
        {

        }

        //Configuracion Entidades
        public DbSet<Asistencia> asistencias { get; set; }
        public DbSet<Cargo> cargos { get; set; }
        public DbSet<Contrato> contratos { get; set; }
        public DbSet<Ciudad> ciudades { get; set; }
        public DbSet<Departamento> departamentos { get; set; }
        public DbSet<Empleado> empleados { get; set; }
        public DbSet<JornadaTrabajo> jornadasTrabajos { get; set; }
        public DbSet<Pais> paises { get; set; }
        public DbSet<Permisos> permisos { get; set; }
        public DbSet<Region> regiones { get; set; }
        public DbSet<RolPagos> rolPagos { get; set; }
        public DbSet<Rubros> rubros { get; set; }
        public DbSet<TipoContrato> tiposContratos { get; set; }
        public DbSet<TipoDiscapacidad> tiposDiscapacidades { get; set; }
        public DbSet<TipoPermisos> tiposPermisos { get; set; }
        public DbSet<DiscapacidadEmpleado> discacidadEmpleados{ get; set; }
        public DbSet<RubrosEmpleados> rubrosEmpleados { get; set; }

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
            modelBuilder.Entity<Cargo>()
                .HasOne(cargo => cargo.Nombre_Departamento)
                .WithMany(departamento => departamento.Lista_Cargos)
                .HasForeignKey(cargo => cargo.DepartamentoId);

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
                .WithMany(rubros => rubros.RubroEmpleado)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(rubrosEmpleados => rubrosEmpleados.RubrosId);

            modelBuilder.Entity<RubrosEmpleados>()
                .HasOne(rubrosEmpleados => rubrosEmpleados.Nombre_Empleado)
                .WithMany(empleado => empleado.RubroEmpleado)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(rubrosEmpleados => rubrosEmpleados.EmpeladoId);

            //Relacion uno a uno de Empleado a TipoDiscapacidad
            modelBuilder.Entity<Empleado>()
                .HasOne(empleado => empleado.Nombre_TipoDiscapacidad)
                .WithOne(tipoDiscapacidad => tipoDiscapacidad.Nombre_Empleado)
                .HasForeignKey<Empleado>(empleado => empleado.TipoDiscapacidadId);

            //Relacion Empleado - TipoDiscapacidad - DiscapacidadEmpleado         
            modelBuilder.Entity<DiscapacidadEmpleado>()
                .HasOne(discapacidadEmpleado => discapacidadEmpleado.tipoDiscapacidad)
                .WithMany(tipoDiscapacidad => tipoDiscapacidad.discapacidadEmpleados)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(discapacidadEmpleado => discapacidadEmpleado.tipoDiscapacidadId);

            modelBuilder.Entity<DiscapacidadEmpleado>()
                .HasOne(discapacidadEmpleado => discapacidadEmpleado.empleado)
                .WithMany(empleado => empleado.Discapacidad)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(discapacidadEmpleado => discapacidadEmpleado.empleadoId);

            modelBuilder.Entity<DiscapacidadEmpleado>()
                .HasKey(discapacidadEmpleado => new { discapacidadEmpleado.tipoDiscapacidadId, discapacidadEmpleado.empleadoId });
        }

        //Conexion con la base de datos SQLServer
        /*
        override protected void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("SERVER=DESKTOP-JEQTB22; initial catalog = ROLPAGOS; trusted_connection = true;");
        }
        */
    }
}
