using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRolPagos.Entidades
{
    public class DiscapacidadEmpleado
    {
        public int tipoDiscapacidadId { get; set; }
        public int empleadoId { get; set; }

        //Relaciones
        public Empleado empleado { get; set; }
        public TipoDiscapacidad tipoDiscapacidad { get; set; }
    }
}
