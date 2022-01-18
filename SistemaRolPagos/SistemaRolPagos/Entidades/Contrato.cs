using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRolPagos.Entidades
{
    public class Contrato
    {
        public int Contrato_Id { get; set; }
        public DateTime Inicio_Contrato { get; set; }
        public DateTime Fin_Contrato { get; set; }
        public decimal Sueldo_Contrato { get; set; }

        //Propiedad relacion con TipoContrato
        //public TipoContrato Tipo_Contrato { get; set; }
        public int TipoContrato_Id { get; set; }

        //Propiedad relacion con Contrato
        public Cargo Nombre_Cargo { get; set; }
        public int Cargo_Id { get; set; }

    }
}
