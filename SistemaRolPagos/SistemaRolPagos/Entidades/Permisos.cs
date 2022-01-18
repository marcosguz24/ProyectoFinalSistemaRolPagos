using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRolPagos.Entidades
{
    public class Permisos
    {
        public int Permisos_Id { get; set; }
        public DateTime Fecha_Inicio_Permiso { get; set; }
        public DateTime Fecha_Fin_Permiso { get; set; }
        public string Hora_Inicio { get; set; }
        public string Hora_Fin { get; set; }
        public string Estado_Permiso { get; set; }

        //Propiedad relacion con TipoPermiso
        public TipoPermisos Tipo_Permisos { get; set; }
        public int TipoPermisos_Id { get; set; }

        //Propiedad relacion con Empleado
        public Empleado Nombre_Empleado { get; set; }
        public int Empleado_Id { get; set; }
    }
}
