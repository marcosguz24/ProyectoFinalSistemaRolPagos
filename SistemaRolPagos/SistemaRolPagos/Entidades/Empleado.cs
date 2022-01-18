using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRolPagos.Entidades
{
    public class Empleado
    {
        public int Empleado_Id { get; set; }
        public string Apellidos_Empleado { get; set; }
        public string Nombres_Empleado { get; set; }
        public string Cedula_Empleado { get; set; }
        public string Pasaporte_Empleado { get; set; }
        public string Email_Empleado { get; set; }
        public string Celular_Empleado { get; set; }
        public string Profesion_Empleado { get; set; }
        public string Nivel_Educacion_Empleado { get; set; }
        public string Sexo_Empelado { get; set; }
        public string Estado_Civil { get; set; }
        public string Banco { get; set; }
        public string Tipo_Cuenta { get; set; }
        public string Numero_Cuenta { get; set; }

        //Propiedad relacion con Empresa
        public Empresa Nombre_Empresa { get; set; }
        public int Empresa_Id { get; set; }

        //Propiedad relacion con Contrato
        public Contrato contrato { get; set; }
        public int Contrato_Id { get; set; }

        //Propiedad relacion con Ciudad
        public Ciudad Nombre_Ciudad { get; set; }
        public int Ciudad_Id { get; set; }

        //Propiedad relacion con TipoDiscapacidad
        public TipoDiscapacidad Tipo_Discapacidad { get; set; }
        public int TipoDiscapacidad_Id { get; set; }

        //Propiedad relacion con JornadaTrabajo
        public JornadaTrabajo Jornada_Trabajo { get; set; }
        public int JornadaTrabajos { get; set; }

    }
}
