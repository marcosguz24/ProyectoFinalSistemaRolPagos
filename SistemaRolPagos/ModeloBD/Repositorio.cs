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
        public DbSet<Empresa> Empresas { get; set; }
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

        //Conexion con la base de datos SQLServer

        override protected void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("SERVER=DESKTOP-JEQTB22; initial catalog = SGRP; trusted_connection = true;");
        }
    }
}
