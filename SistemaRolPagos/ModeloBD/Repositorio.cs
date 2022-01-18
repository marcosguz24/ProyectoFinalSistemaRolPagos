using Microsoft.EntityFrameworkCore;
using SistemaRolPagos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloBD
{
    internal class Repositorio: DbContext
    {
        //Configuracion Entidades
        public DbSet<Asistencia> Asistencia { get; set; }
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Contrato> Contrato { get; set; }
        public DbSet<Ciudad> Ciudad { get; set; }
        public DbSet<Departamento> Departamentp { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<JornadaTrabajo> JornadaTrabajo { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Permisos> Permisos { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<RolPagos> RolPagos { get; set; }
        public DbSet<Rubros> Rubros { get; set; }
        public DbSet<TipoContrato> TipoContrato { get; set; }
        public DbSet<TipoDiscapacidad> TipoDiscapacidad { get; set; }
        public DbSet<TipoPermisos> TipoPermisos { get; set; }


    }
}
