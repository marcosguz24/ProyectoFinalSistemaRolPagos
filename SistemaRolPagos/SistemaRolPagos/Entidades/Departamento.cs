﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRolPagos.Entidades
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }
        public string Nombre_Departamento { get; set; }

        //Propiedad de la relacion 1 - n con Cargo
        public Cargo Nombre_Cargo { get; set; }
        public int CargoId { get; set; }
    }
}
