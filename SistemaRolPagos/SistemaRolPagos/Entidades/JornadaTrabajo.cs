using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRolPagos.Entidades
{
    public class JornadaTrabajo
    {
        public int JornadaTrabajo_Id { get; set; }
        public string Tipo_Jornada { get; set; }

        //Propiedad relacion con Empleado
        public Empleado Nombre_Empelado { get; set; }
        public int Empleado_Id { get; set; }
    }
}
