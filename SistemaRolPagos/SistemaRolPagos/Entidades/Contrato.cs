using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRolPagos.Entidades
{
    public class Contrato
    {
        public int ContratoId { get; set; }
        public DateTime Inicio_Contrato { get; set; }
        public DateTime Fin_Contrato { get; set; }
        public decimal Sueldo_Contrato { get; set; }

        //Propiedad para implementar la relacion 1 - n con TipoContrato
        public TipoContrato Tipo_Contrato { get; set; }
        public int TipoContratoId { get; set; }

        //Propiedad para implementar la relacion 1 - 1 con Cargo
        public Cargo Nombre_Cargo { get; set; }

        //Propiedad para implementar la realacion 1 - 1 con Empleado
        public int EmpleadoId { get; set; }
        public Empleado Nombre_Empleado { get; set; }

    }
}
