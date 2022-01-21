using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRolPagos.Entidades
{
    public class RolPagos
    {
        public int RolPagosId { get; set; }
        public string Nombre_Empresa { get; set; }
        public string RUC_Empresa { get; set; }
        public string Representante_Empresa { get; set; }
        public string Descripcion_RolPagos { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Fin { get; set; }
        public string Estado_Rol { get; set; }

        //Propiedad relacion con Rubros
        public Rubros Nombre_Rubro { get; set; }
    }
}
