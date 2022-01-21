using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRolPagos.Entidades
{
    public class DiscapacidadEmpleado
    {
        public int TipoDiscapacidadId { get; set; }
        public int EmpleadoId { get; set; }

        //Relaciones
        public Empleado Nombre_Empleado { get; set; }
        public TipoDiscapacidad Discapacidad { get; set; }
    }
}
