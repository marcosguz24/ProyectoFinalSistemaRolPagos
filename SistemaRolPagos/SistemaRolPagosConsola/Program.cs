using ModeloBD;
using SistemaRolPagos.Entidades;
using System;

namespace SistemaRolPagosConsola
{
    internal class Program
    {
        public static object Repositorio { get; private set; }

        static void Main(string[] args)
        {
            //Creacion de la empresa
            Empresa SondaEcuador = new Empresa()
            {
                Nombre_Empresa = "Sonda Ecuador",
                RUC_Empresa = "1789632540001",
                Representante_Empresa = "María Puican"
            };

            //Creacion del Pais
            Pais Ecuador = new Pais()
            {
                Nombre_Pais = "Edcuador"
            };

            //Creacion de la Region
            Region Sierra = new Region()
            {
                Nombre_Region = "Sierra",
                Nombre_Pais = Ecuador
            };

            Region Costa = new Region()
            {
                Nombre_Region = "Costa",
                Nombre_Pais = Ecuador
            };

            //Creacion de la Ciudad
            Ciudad Quito = new Ciudad()
            {
                Nombre_Ciudad = "Quito",
                Nombre_Region = Sierra
            };

            Ciudad Guayaquil = new Ciudad()
            {
                Nombre_Ciudad = "Guayquil",
                Nombre_Region = Costa
            };

            //Creacion de los Departamentos
            Departamento Sistemas = new Departamento { Nombre_Departamento = "Sistemas" };
            Departamento Marketing = new Departamento { Nombre_Departamento = "Marketing" };

            //Creacion de los Cargos
            Cargo CargoJuanPerez = new Cargo()
            {
                Nombre_Cargo = "Desarrollador de Software",
                Nombre_Departamento = Sistemas,
            };

            Cargo CargoMariaAlvarado = new Cargo()
            {
                Nombre_Cargo = "Marketing",
                Nombre_Departamento = Marketing
            };

            Cargo CargoEmilianoManzanero = new Cargo()
            {
                Nombre_Cargo = "Marketing",
                Nombre_Departamento = Marketing
            };

            Cargo CargoBlancaToapanta = new Cargo()
            {
                Nombre_Cargo = "QA",
                Nombre_Departamento = Sistemas
            };

            //Creacion del Tipo de Contrato
            TipoContrato Indefinido = new TipoContrato() { Descripcion_Tipo_Contrato = "Contrato Indefinido" };
            TipoContrato Temporal = new TipoContrato() { Descripcion_Tipo_Contrato = "Contrato de 3 meses" };

            //Creacion del Contrato
            Contrato ContratoJuanPerez = new Contrato()
            {
                Inicio_Contrato = new DateTime(2020, 8, 15),
                Fin_Contrato = new DateTime(),
                Tipo_Contrato = Indefinido,
                Nombre_Cargo = CargoJuanPerez

            };

            Contrato ContratoMariaAlvarado = new Contrato()
            {
                Inicio_Contrato = new DateTime(2021, 1, 3),
                Fin_Contrato = new DateTime(2022, 1, 15),
                Tipo_Contrato = Temporal
            };

            Contrato ContratoEmilianoManzanero = new Contrato()
            {
                Inicio_Contrato = new DateTime(2019, 5, 15),
                Fin_Contrato = new DateTime(),
                Tipo_Contrato = Indefinido,
                
            };

            Contrato ContratoBlancaToapanta = new Contrato()
            {
                Inicio_Contrato = new DateTime(2021, 2, 3),
                Fin_Contrato = new DateTime(2021, 8, 15),
                Tipo_Contrato = Temporal
            };

            
            
            //Creacion de la Jornada de Trabajo
            JornadaTrabajo Diurna = new JornadaTrabajo()
            {
                Tipo_Jornada = "Diurna"
            };

            JornadaTrabajo Vespertina = new JornadaTrabajo()
            {
                Tipo_Jornada = "Vespertina"
            };

            //Creacion de un empleado
            Empleado JuanPerez = new Empleado()
            {
                Apellidos_Empleado = "Perez Olarte",
                Nombres_Empleado = "Juan Fabricio",
                Cedula_Empleado = "1785203694",
                Pasaporte_Empleado = "187304875263",
                Email_Empleado = "jperez@mail.com",
                Celular_Empleado = "0985236147",
                Profesion_Empleado = "Ingeniero en Sistemas",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = "Masculino",
                Estado_Civil = "Soltero",
                Banco = "Pichincha",
                Tipo_Cuenta = "Ahorros",
                Numero_Cuenta = "2200704850",
                Nombre_Empresa = SondaEcuador,
                Nombre_Ciudad = Guayaquil,
                contrato = ContratoJuanPerez,
                Tipo_Discapacidad = new TipoDiscapacidad()
                {
                    Descripcion_TipoDiscapacidad = "Discapacidad 1"
                },
                Jornada_Trabajo = Diurna
            };
            /*
            Empleado MariaAlvarado = new Empleado()
            {
                Apellidos_Empleado = "Alvarado Pilatuña",
                Nombres_Empleado = "Maria Fernanda",
                Cedula_Empleado = "0258963147",
                Email_Empleado = "malvarado@mail.com",
                Celular_Empleado = "0987456321",
                Profesion_Empleado = "Ingeniero en Marketing",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = "Femenino",
                Estado_Civil = "Soltera",
                Banco = "Pichincha",
                Tipo_Cuenta = "Corriente",
                Numero_Cuenta = "3389562147",
                Nombre_Empresa = SondaEcuador,
                Nombre_Ciudad = Quito,
                contrato = ContratoMariaAlvarado,
                Tipo_Discapacidad = new TipoDiscapacidad()
                {
                    Descripcion_TipoDiscapacidad = "Discapacidad 1"
                },
                Jornada_Trabajo = Vespertina
            };

            Empleado EmilianoManzanero = new Empleado()
            {
                Apellidos_Empleado = "Manzanero Valdez",
                Nombres_Empleado = "Emiliano Joao",
                Cedula_Empleado = "0879632145",
                Email_Empleado = "emanzanero@mail.com",
                Celular_Empleado = "0963258741",
                Profesion_Empleado = "Ingeniero en Marketing",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = "Masculino",
                Estado_Civil = "Soltero",
                Banco = "Pichincha",
                Tipo_Cuenta = "Ahorros",
                Numero_Cuenta = "2287963140",
                Nombre_Empresa = SondaEcuador,
                Nombre_Ciudad = Guayaquil,
                contrato = ContratoEmilianoManzanero,
                Tipo_Discapacidad = new TipoDiscapacidad()
                {
                    Descripcion_TipoDiscapacidad = "Discapacidad 1"
                },
                Jornada_Trabajo = Diurna
            };

            Empleado BlancaToapanta = new Empleado()
            {
                Apellidos_Empleado = "Toapanta Pibil",
                Nombres_Empleado = "Blanca Irene",
                Cedula_Empleado = "1789654230",
                Email_Empleado = "btoapanta@mail.com",
                Celular_Empleado = "0965823147",
                Profesion_Empleado = "Tecnologa en Sistemas",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = "Femenino",
                Estado_Civil = "Soltera",
                Banco = "Pichincha",
                Tipo_Cuenta = "Ahorros",
                Numero_Cuenta = "2278965413",
                Nombre_Empresa = SondaEcuador,
                Nombre_Ciudad = Quito,
                contrato = ContratoBlancaToapanta,
                Tipo_Discapacidad = new TipoDiscapacidad()
                {
                    Descripcion_TipoDiscapacidad = "Discapacidad 1"
                },
                Jornada_Trabajo = Vespertina
            };*/

            //Creacion de la Asistencia de los empleados
            Asistencia asistencia = new Asistencia()
            {
                Fecha_Asistencia = new DateTime(2020, 8, 8),
                Hora_Asistencia = "8:00 am",
                Tipo_Asistencia = "Jornada Laboral",
                Lista_Empleados = new List<Empleado> { JuanPerez}
            };

            Repositorio repositorio = new Repositorio();
            repositorio.AddRange(new List<Asistencia>() { asistencia});
            repositorio.SaveChanges();
        }
    }
}