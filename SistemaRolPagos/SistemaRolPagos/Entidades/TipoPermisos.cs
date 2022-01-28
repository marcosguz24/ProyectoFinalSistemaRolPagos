using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRolPagos.Entidades
{
    public class TipoPermisos
    {
        public int TipoPermisosId { get; set; }
        public string Nombre_Tipo_Permiso { get; set; }
        public string Descripcion_Tipo_Permiso { get; set; }

        //Propiedad de la relacion 1 - 1 con Permiso
        public IEnumerable<Permisos> Lista_Permisos { get; set; }
    }
}
