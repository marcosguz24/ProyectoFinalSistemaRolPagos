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
        public int TipoContrato_Id { get; set; }

        //Propiedad para implementar la relacion 1 - n con Contrato
        public Cargo Nombre_Cargo { get; set; }
        public int Cargo_Id { get; set; }

    }
}
