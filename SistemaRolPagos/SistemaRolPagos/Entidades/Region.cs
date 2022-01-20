using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRolPagos.Entidades
{
    public class Region
    {
        public int RegionId { get; set; }
        public string Nombre_Region { get; set; }

        //Propiedad relacion con Pais
        public Pais Nombre_Pais { get; set; }
        public int Pais_Id { get; set; }
    }
}
