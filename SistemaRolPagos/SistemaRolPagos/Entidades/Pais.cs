using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRolPagos.Entidades
{
    public class Pais
    {
        public int PaisId { get; set; }
        public string Nombre_Pais { get; set; }

        //Propiedad para la relacion 1 - n con Region
        public IEnumerable<Region> Lista_Regiones { get; set; }
    }
}
