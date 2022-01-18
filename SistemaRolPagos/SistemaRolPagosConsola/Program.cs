using SistemaRolPagos.Entidades;
using System;

namespace SistemaRolPagosConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creacion de un empleado
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

            //Creacion de la empresa
            Empresa SondaEcuador = new Empresa() 
            { 
                Nombre_Empresa = "Sonda Ecuador",
                RUC_Empresa = "1789632540001",
                Representante_Empresa = "María Puican"
            };

            //Creacion del Departamento
            Departamento sistemas = new Departamento()
            {
                Nombre_Departamento = "Departamento de Sistemas"
            };

            //Creacion del Cargo
            Cargo cargoJuan = new Cargo()
            {
                Nombre_Cargo =  "Desarrollador Semi Senior",
            };

            //Creacion del Tipo de Contrato
            TipoContrato contratoIndefinido = new TipoContrato()
            {
                Descripcion_Tipo_Contrato = "Contrato sin plazo fijo establecido para su terminación"
            };

            //Creacion del Contrato
            Contrato contratoJuan = new Contrato()
            {
                Inicio_Contrato = DateTime.Now,       
                Sueldo_Contrato = (decimal) 1500.00
            };

            //Creacion de la Jornada de trabajo
            JornadaTrabajo jornadaDiurna = new JornadaTrabajo()
            {
                Tipo_Jornada = "Diurna"
            };

            //Creacion del Pais
            Pais ecuador = new Pais()
            {
                Nombre_Pais = "Ecuador"
            };

            //Creacion de la region
            Region region = new Region()
            {
                Nombre_Region = "Sierra"
            };

            //Creacion de la ciudad
            Ciudad quito = new Ciudad()
            {
                Nombre_Ciudad = "Quito"
            };

            //Instancia del Cargo
            cargoJuan.Nombre_Departamento = sistemas;

            //Instancia del Contrato
            contratoJuan.Nombre_Cargo = cargoJuan;

            //Instancia de la region y la ciudad
            region.Nombre_Pais = ecuador;
            quito.Nombre_Region = region;

            //Instancia del empleado
            JuanPerez.Nombre_Empresa = SondaEcuador;
            JuanPerez.Nombre_Ciudad = quito;
            JuanPerez.contrato = contratoJuan;
            JuanPerez.Jornada_Trabajo = jornadaDiurna;
        }
    }
}