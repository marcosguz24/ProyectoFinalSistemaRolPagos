using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRolPagos.Entidades
{
    public class Cargo
    {
        public int CargoId { get; set; }
        public string Nombre_Cargo { get; set; }

        //Propiedades de la relacion 1- n con Departamento
        public IEnumerable<Departamento> Lista_Departamento { get; set; }

        //Propiedad de la relacion 1 - 1 con Contrato
        public Contrato Nombre_Contrato { get; set; }
        public int ContratoId { get; set; }
    }
}
