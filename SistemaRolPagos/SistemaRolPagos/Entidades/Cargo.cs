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

        //Propiedades relacion con Departamento
        public Departamento Nombre_Departamento { get; set; }
        public int Departamento_Id { get; set; }
    }
}
