using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRolPagos.Entidades
{
    public class RolPagos
    {
        public int RolPagos_Id { get; set; }
        public string Descripcion_RolPagos { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Fin { get; set; }
        public string Estado_Rol { get; set; }

        //Propiedad relacion con Rubros
        public IEnumerable<Rubros> Lista_Rubros { get; set; }
        public int Rubro_Id { get; set; }
    }
}
