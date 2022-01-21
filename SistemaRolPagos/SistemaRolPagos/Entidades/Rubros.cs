using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRolPagos.Entidades
{
    public class Rubros
    {
        public int RubrosId { get; set; }
        public string Nombre_Rubro { get; set; }
        public string Tipo_Rubro { get; set; }
        public int Mes_Pago_Rubro { get; set; }
        public int Dias_Gracia_Rubro { get; set; }
        public decimal Facturar_Rubro { get; set; }

        //Propiedad relacion con Empleado
        public Empleado Nombre_Empleado { get; set; }

        //Propiedad relacion con RubrosEmpleados
        public IEnumerable<RubrosEmpleados> RubroEmpleados { get; set; }

        //Propiedad relacion con RolPagos
        public RolPagos Rol_Pagos { get; set; }
        public int RolPagosId { get; set; }
    }
}
