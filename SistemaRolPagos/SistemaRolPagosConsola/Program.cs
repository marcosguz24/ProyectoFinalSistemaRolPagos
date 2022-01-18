using SistemaRolPagos.Entidades;
using System;

namespace SistemaRolPagosConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado JuanPerez = new Empleado()
            {
                Apellidos_Empleado = "Perez Olarte",
                Nombres_Empleado = "Juan Fabricio",
                Cedula_Empleado = "1785203694",
                Email_Empleado = "jperez@mail.com",
                Celular_Empleado = "0985236147",
                Profesion_Empleado = "Ingeniero en Sistemas",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = "Masculino",
                Estado_Civil = "Soltero",
                Banco = "Pichincha",
                Tipo_Cuenta = "Ahorros",
                Numero_Cuenta = "2200704850"
            };

            Empresa SonDaEcuador = new Empresa() 
            { 
                Nombre_Empresa = "Sonda Ecuador",
                RUC_Empresa = "1789632540001",
                Representante_Empresa = "María Puican"
            };
        }
    }
}