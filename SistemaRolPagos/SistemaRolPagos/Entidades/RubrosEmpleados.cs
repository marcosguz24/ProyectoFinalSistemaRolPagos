using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRolPagos.Entidades
{
    public class RubrosEmpleados
    {
        public int RubrosId { get; set; }
        public int EmpeladoId { get; set; }

        //Relacion
        public Rubros Nombre_Rubro { get; set; }
        public Empleado Nombre_Empleado { get; set; }
    }
}
