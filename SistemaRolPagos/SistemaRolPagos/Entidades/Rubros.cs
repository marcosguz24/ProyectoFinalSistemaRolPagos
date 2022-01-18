using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRolPagos.Entidades
{
    public class Rubros
    {
        public int Rubro_Id { get; set; }
        public string Nombre_Rubro { get; set; }
        public string Tipo_Rubro { get; set; }
        public int Mes_Pago_Rubro { get; set; }
        public int Dias_Gracia_Rubro { get; set; }
        public decimal Facturar_Rubro { get; set; }

        //Propiedad relacion con Empleado
        public IEnumerable<Empleado> Lista_Empleado { get; set; }
        public int Empleado { get; set; }
    }
}
