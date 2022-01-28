using SistemaRolPagos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargaDatos
{
    public class DatosIniciales
    {
        public enum ListasTipo
        {
            Asistencias, Cargos, Ciudades,
            Contratos, Departamentos, DiscapacidadEmpleados,
            Empleados, JornadaTrabajos, Pais,
            Permisos, Regiones, RolPagos,
            Rubros, RubrosEmpleados, TipoContratos,
            TipoPermisos, TipoDiscapacidad
        }

        public Dictionary<ListasTipo, object> Carga()
        {
            /*=======================================
             *                  Pais
             *=======================================*/
            #region
            Pais ecuador = new Pais()
            {
                Nombre_Pais = "Ecuador"
            };
            #endregion
            /*=======================================
             *           Lista de Regiones
             *=======================================*/
            #region
            Region sierra = new Region()
            {
                Nombre_Region = "Sierra",
                Nombre_Pais = ecuador
            };
            Region costa = new Region()
            {
                Nombre_Region = "Costa",
                Nombre_Pais = ecuador
            };
            Region amazonia = new Region()
            {
                Nombre_Region = "Amazonía",
                Nombre_Pais = ecuador
            };
            List<Region> listaRegion = new List<Region>()
            {
                costa, sierra, amazonia
            };
            #endregion
            /*=======================================
            *           Lista de Ciudades
            *======================================= */
            #region
            Ciudad guayaquil = new Ciudad()
            {
                Nombre_Ciudad = "Guayaquil",
                Nombre_Region = costa
            };
            Ciudad quito = new Ciudad()
            {
                Nombre_Ciudad = "Quito",
                Nombre_Region = sierra
            };
            Ciudad cuenca = new Ciudad()
            {
                Nombre_Ciudad = "Cuenca",
                Nombre_Region = sierra
            };
            Ciudad moronaSantiago = new Ciudad()
            {
                Nombre_Ciudad = "Morona Santiago",
                Nombre_Region = amazonia
            };
            List<Ciudad> listaCiudades = new List<Ciudad>()
            {
                guayaquil, quito, cuenca, moronaSantiago
            };
            #endregion
            /*=======================================
            *       Lista de Departamentos
            *======================================= */
            #region
            Departamento sistemas = new Departamento()
            {
                Nombre_Departamento = "Sistemas",
            };
            Departamento rrhh = new Departamento()
            {
                Nombre_Departamento = "RRHH"
            };
            Departamento marketing = new Departamento()
            {
                Nombre_Departamento = "Marketing"
            };
            Departamento finanzas = new Departamento()
            {
                Nombre_Departamento = "Finanzas"
            };
            List<Departamento> listaDepartamentos = new List<Departamento>()
            {
                sistemas, rrhh, marketing, finanzas
            };
            #endregion
            /*=======================================
            *       Lista de Cargos
            *======================================= */
            #region
            Cargo analista = new Cargo()
            {
                Nombre_Cargo = "Analista",
                Nombre_Departamento = sistemas
            };
            /*Cargo disenho = new Cargo()
            {
                Nombre_Cargo = "Diseño",
                Nombre_Departamento = sistemas
            };
            Cargo implementacion = new Cargo()
            {
                Nombre_Cargo = "Implementación",
                Nombre_Departamento = sistemas
            };*/
            Cargo testing = new Cargo()
            {
                Nombre_Cargo = "QA",
                Nombre_Departamento = sistemas
            };
            /*
            Cargo mantenimiento = new Cargo()
            {
                Nombre_Cargo = "Mantenimiento",
                Nombre_Departamento = sistemas
            };
            Cargo comercial = new Cargo()
            {
                Nombre_Cargo = "Comercial",
                Nombre_Departamento = marketing
            };
            Cargo publicidad = new Cargo()
            {
                Nombre_Cargo = "Publicidad",
                Nombre_Departamento = marketing
            };
            Cargo formacion = new Cargo()
            {
                Nombre_Cargo = "Formación",
                Nombre_Departamento = rrhh
            };*/
            Cargo contabilidad = new Cargo()
            {
                Nombre_Cargo = "Contabilidad",
                Nombre_Departamento = finanzas
            };/*
            Cargo administracion = new Cargo()
            {
                Nombre_Cargo = "Administración",
                Nombre_Departamento = finanzas
            };*/
            List<Cargo> listaCargos = new List<Cargo>()
            {
                analista, testing, contabilidad /*, disenho, implementacion,  mantenimiento, 
                comercial, publicidad, formacion,  administracion*/
            };
            #endregion
            /*=======================================
            *       Lista de Tipo de Contrato
            *======================================= */
            #region
            /*
            TipoContrato tipoContratoTacito = new TipoContrato()
            {
                Nombre_Tipo_Contrato = "Contrato Tacito",
                Descripcion_Tipo_Contrato = "Acuerdo de palabra"
            };
            TipoContrato tipoContratoPlazoFijo = new TipoContrato()
            {
                Nombre_Tipo_Contrato = "Contrato a Plazo Fijo",
                Descripcion_Tipo_Contrato = "Tiempo limitado"
            };*/
            TipoContrato tipoContratoIndefinido = new TipoContrato()
            {
                Nombre_Tipo_Contrato = "Contrato Indefinido",
                Descripcion_Tipo_Contrato = "Sin fecha de terminación"
            };
            /*
            TipoContrato tipoContratoPrueba = new TipoContrato()
            {
                Nombre_Tipo_Contrato = "Contrato de Prueba",
                Descripcion_Tipo_Contrato = "Trabajo por un tiempo"
            };
            TipoContrato tipoContratoEventual = new TipoContrato() 
            {
                Nombre_Tipo_Contrato = "Contrato Eventual",
                Descripcion_Tipo_Contrato = "Casos fortuitos"
            };
            TipoContrato tipoContratoTemporada = new TipoContrato()
            {
                Nombre_Tipo_Contrato = "Contrato por Temporada",
                Descripcion_Tipo_Contrato = "Ocaciones cíclicas"
            };*/
            TipoContrato tipoContratoOcacional = new TipoContrato()
            {
                Nombre_Tipo_Contrato = "Contrato Ocacional",
                Descripcion_Tipo_Contrato = "Emergencias"
            };
            TipoContrato tipoContratoParcialPermanente = new TipoContrato()
            {
                Nombre_Tipo_Contrato = "Contrato Parcial Permanente",
                Descripcion_Tipo_Contrato = "Menos tiempo"
            };
            List<TipoContrato> listaTipoContrato = new List<TipoContrato>()
            {
                tipoContratoIndefinido,  tipoContratoParcialPermanente, tipoContratoOcacional
                /*tipoContratoTacito, tipoContratoPlazoFijo, 
                tipoContratoPrueba, tipoContratoEventual, tipoContratoTemporada,
                ,*/
            };
            #endregion
            /*=======================================
            *       Lista de Contratos
            *======================================= */
            #region
            //======== Contratos Publicidad ========
            #region
            /*
            Contrato contratoTacitoPublicidad = new Contrato()
            {
                Tipo_Contrato = tipoContratoTacito,
                Nombre_Cargo = publicidad,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal) 300.00
            };
            Contrato contratoPlazoFijoPublicidad = new Contrato()
            {
                Tipo_Contrato = tipoContratoPlazoFijo,
                Nombre_Cargo = publicidad,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)1200.00
            };
            Contrato contratoIndefinidoPublicidad = new Contrato()
            {
                Tipo_Contrato = tipoContratoIndefinido,
                Nombre_Cargo = publicidad,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)1500.00
            };
            Contrato contratoPruebaPublicidad = new Contrato()
            {
                Tipo_Contrato = tipoContratoPrueba,
                Nombre_Cargo = publicidad,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)850.00
            };
            Contrato contratoEventualPublicidad = new Contrato()
            {
                Tipo_Contrato = tipoContratoEventual,
                Nombre_Cargo = publicidad,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)620.00
            };
            Contrato contratoTemporadaPublicidad = new Contrato()
            {
                Tipo_Contrato = tipoContratoTemporada,
                Nombre_Cargo = publicidad,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)300.00
            };
            Contrato contratoOcacionalPublicidad = new Contrato()
            {
                Tipo_Contrato = tipoContratoOcacional,
                Nombre_Cargo = publicidad,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)900.00
            };
            Contrato contratoParcialPermanentePublicidad = new Contrato()
            {
                Tipo_Contrato = tipoContratoParcialPermanente,
                Nombre_Cargo = publicidad,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)1250.00
            };*/
            #endregion
            //======== Contratos Analista ========
            #region
            /*
            Contrato contratoTacitoAnalista = new Contrato()
            {
                Tipo_Contrato = tipoContratoTacito,
                Nombre_Cargo = analista,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)1250.00
            };
            Contrato contratoPlazoFijoAnalista = new Contrato()
            {
                Tipo_Contrato = tipoContratoPlazoFijo,
                Nombre_Cargo = analista,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)1700.00
            };*/
            Contrato contratoIndefinidoAnalista = new Contrato()
            {
                Tipo_Contrato = tipoContratoIndefinido,
                Nombre_Cargo = analista,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)2200.00
            };
            /*
            Contrato contratoPruebaAnalista = new Contrato()
            {
                Tipo_Contrato = tipoContratoPrueba,
                Nombre_Cargo = analista,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)850.00
            };
            Contrato contratoEventualAnalista = new Contrato()
            {
                Tipo_Contrato = tipoContratoEventual,
                Nombre_Cargo = analista,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)720.00
            };
            Contrato contratoTemporadaAnalista = new Contrato()
            {
                Tipo_Contrato = tipoContratoTemporada,
                Nombre_Cargo = analista,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)980.00
            };*/
            Contrato contratoOcacionalAnalista = new Contrato()
            {
                Tipo_Contrato = tipoContratoOcacional,
                Nombre_Cargo = analista,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)900.00
            };
            /*
            Contrato contratoParcialPermanenteAnalista = new Contrato()
            {
                Tipo_Contrato = tipoContratoParcialPermanente,
                Nombre_Cargo = analista,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)2250.00
            };*/
            #endregion
            //======== Contratos Disenho ========
            #region
            /*
            Contrato contratoTacitoDisenho = new Contrato()
            {
                Tipo_Contrato = tipoContratoTacito,
                Nombre_Cargo = disenho,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)500.00
            };
            Contrato contratoPlazoFijoDisenho = new Contrato()
            {
                Tipo_Contrato = tipoContratoPlazoFijo,
                Nombre_Cargo = disenho,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)1120.00
            };
            Contrato contratoIndefinidoDisenho = new Contrato()
            {
                Tipo_Contrato = tipoContratoIndefinido,
                Nombre_Cargo = disenho,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)1500.00
            };
            Contrato contratoPruebadisenho = new Contrato()
            {
                Tipo_Contrato = tipoContratoPrueba,
                Nombre_Cargo = disenho,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)550.00
            };
            Contrato contratoEventualDisenho = new Contrato()
            {
                Tipo_Contrato = tipoContratoEventual,
                Nombre_Cargo = disenho,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)920.00
            };
            Contrato contratoTemporadaDisenho = new Contrato()
            {
                Tipo_Contrato = tipoContratoTemporada,
                Nombre_Cargo = disenho,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)720.00
            };
            Contrato contratoOcacionalDisenho = new Contrato()
            {
                Tipo_Contrato = tipoContratoOcacional,
                Nombre_Cargo = disenho,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)930.00
            };
            Contrato contratoParcialPermanenteDisenho = new Contrato()
            {
                Tipo_Contrato = tipoContratoParcialPermanente,
                Nombre_Cargo = disenho,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)1350.00
            };
            #endregion
            //======== Contratos Implementacion ========
            #region
            Contrato contratoTacitoImplementacion = new Contrato()
            {
                Tipo_Contrato = tipoContratoTacito,
                Nombre_Cargo = implementacion,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)850.00
            };
            Contrato contratoPlazoFijoImplementacion = new Contrato()
            {
                Tipo_Contrato = tipoContratoPlazoFijo,
                Nombre_Cargo = implementacion,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)1400.00
            };
            Contrato contratoIndefinidoImplementacion = new Contrato()
            {
                Tipo_Contrato = tipoContratoIndefinido,
                Nombre_Cargo = implementacion,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)2200.00
            };
            Contrato contratoPruebaImplementacion = new Contrato()
            {
                Tipo_Contrato = tipoContratoPrueba,
                Nombre_Cargo = implementacion,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)850.00
            };
            Contrato contratoEventualImplementacion = new Contrato()
            {
                Tipo_Contrato = tipoContratoEventual,
                Nombre_Cargo = implementacion,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)520.00
            };
            Contrato contratoTemporadaImplementacion = new Contrato()
            {
                Tipo_Contrato = tipoContratoTemporada,
                Nombre_Cargo = implementacion,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)980.00
            };
            Contrato contratoOcacionalImplementacion = new Contrato()
            {
                Tipo_Contrato = tipoContratoOcacional,
                Nombre_Cargo = implementacion,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)900.00
            };
            Contrato contratoParcialPermanenteImplementacion = new Contrato()
            {
                Tipo_Contrato = tipoContratoParcialPermanente,
                Nombre_Cargo = implementacion,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)2250.00
            };*/
            #endregion
            //======== Contratos Testing ========
            #region
            /*
            Contrato contratoTacitoTesting = new Contrato()
            {
                Tipo_Contrato = tipoContratoTacito,
                Nombre_Cargo = testing,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)600.00
            };
            Contrato contratoPlazoFijoTesting = new Contrato()
            {
                Tipo_Contrato = tipoContratoPlazoFijo,
                Nombre_Cargo = testing,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)2200.00
            };
            Contrato contratoIndefinidoTesting = new Contrato()
            {
                Tipo_Contrato = tipoContratoIndefinido,
                Nombre_Cargo = testing,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)2200.00
            };
            Contrato contratoPruebaTesting = new Contrato()
            {
                Tipo_Contrato = tipoContratoPrueba,
                Nombre_Cargo = testing,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)750.00
            };
            Contrato contratoEventualTesting = new Contrato()
            {
                Tipo_Contrato = tipoContratoEventual,
                Nombre_Cargo = testing,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)720.00
            };
            Contrato contratoTemporadaTesting = new Contrato()
            {
                Tipo_Contrato = tipoContratoTemporada,
                Nombre_Cargo = testing,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)800.00
            };
            Contrato contratoOcacionalTesting = new Contrato()
            {
                Tipo_Contrato = tipoContratoOcacional,
                Nombre_Cargo = testing,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)600.00
            };*/
            Contrato contratoParcialPermanenteTesting = new Contrato()
            {
                Tipo_Contrato = tipoContratoParcialPermanente,
                Nombre_Cargo = testing,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)1950.00
            };
            #endregion
            //======== Contratos Mantenimiento ========
            #region
            /*
            Contrato contratoTacitoMantenimiento = new Contrato()
            {
                Tipo_Contrato = tipoContratoTacito,
                Nombre_Cargo = mantenimiento,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)950.00
            };
            Contrato contratoPlazoFijoMantenimiento = new Contrato()
            {
                Tipo_Contrato = tipoContratoPlazoFijo,
                Nombre_Cargo = mantenimiento,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)1700.00
            };
            Contrato contratoIndefinidoMantenimiento = new Contrato()
            {
                Tipo_Contrato = tipoContratoIndefinido,
                Nombre_Cargo = mantenimiento,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)2200.00
            };
            Contrato contratoPruebaMantenimiento = new Contrato()
            {
                Tipo_Contrato = tipoContratoPrueba,
                Nombre_Cargo = mantenimiento,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)850.00
            };
            Contrato contratoEventualMantenimiento = new Contrato()
            {
                Tipo_Contrato = tipoContratoEventual,
                Nombre_Cargo = mantenimiento,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)720.00
            };
            Contrato contratoTemporadaMantenimiento = new Contrato()
            {
                Tipo_Contrato = tipoContratoTemporada,
                Nombre_Cargo = mantenimiento,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)980.00
            };
            Contrato contratoOcacionalMantenimiento = new Contrato()
            {
                Tipo_Contrato = tipoContratoOcacional,
                Nombre_Cargo = mantenimiento,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)900.00
            };
            Contrato contratoParcialPermanenteMantenimiento = new Contrato()
            {
                Tipo_Contrato = tipoContratoParcialPermanente,
                Nombre_Cargo = mantenimiento,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)2250.00
            };*/
            #endregion
            //======== Contratos Comercial ========
            #region
            /*
            Contrato contratoTacitoComercial = new Contrato()
            {
                Tipo_Contrato = tipoContratoTacito,
                Nombre_Cargo = comercial,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)500.00
            };
            Contrato contratoPlazoFijoComercial = new Contrato()
            {
                Tipo_Contrato = tipoContratoPlazoFijo,
                Nombre_Cargo = comercial,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)1120.00
            };
            Contrato contratoIndefinidoComercial = new Contrato()
            {
                Tipo_Contrato = tipoContratoIndefinido,
                Nombre_Cargo = comercial,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)1500.00
            };
            Contrato contratoPruebaComercial = new Contrato()
            {
                Tipo_Contrato = tipoContratoPrueba,
                Nombre_Cargo = comercial,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)550.00
            };
            Contrato contratoEventualComercial = new Contrato()
            {
                Tipo_Contrato = tipoContratoEventual,
                Nombre_Cargo = comercial,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)920.00
            };
            Contrato contratoTemporadaComercial = new Contrato()
            {
                Tipo_Contrato = tipoContratoTemporada,
                Nombre_Cargo = comercial,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)720.00
            };
            Contrato contratoOcacionalComercial = new Contrato()
            {
                Tipo_Contrato = tipoContratoOcacional,
                Nombre_Cargo = comercial,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)930.00
            };
            Contrato contratoParcialPermanenteComercial = new Contrato()
            {
                Tipo_Contrato = tipoContratoParcialPermanente,
                Nombre_Cargo = comercial,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)1350.00
            };*/
            #endregion
            //======== Contratos Formacion ========
            #region
            /*
            Contrato contratoTacitoFormacion = new Contrato()
            {
                Tipo_Contrato = tipoContratoTacito,
                Nombre_Cargo = formacion,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)850.00
            };
            Contrato contratoPlazoFijoFormacion = new Contrato()
            {
                Tipo_Contrato = tipoContratoPlazoFijo,
                Nombre_Cargo = formacion,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)1400.00
            };
            Contrato contratoIndefinidoFormacion = new Contrato()
            {
                Tipo_Contrato = tipoContratoIndefinido,
                Nombre_Cargo = formacion,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)2200.00
            };
            Contrato contratoPruebaFormacion = new Contrato()
            {
                Tipo_Contrato = tipoContratoPrueba,
                Nombre_Cargo = formacion,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)850.00
            };
            Contrato contratoEventualFormacion = new Contrato()
            {
                Tipo_Contrato = tipoContratoEventual,
                Nombre_Cargo = formacion,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)520.00
            };
            Contrato contratoTemporadaFormacion = new Contrato()
            {
                Tipo_Contrato = tipoContratoTemporada,
                Nombre_Cargo = formacion,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)980.00
            };
            Contrato contratoOcacionalFormacion = new Contrato()
            {
                Tipo_Contrato = tipoContratoOcacional,
                Nombre_Cargo = formacion,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)900.00
            };
            Contrato contratoParcialPermanenteFormacion = new Contrato()
            {
                Tipo_Contrato = tipoContratoParcialPermanente,
                Nombre_Cargo = formacion,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)2250.00
            };
            */
            #endregion
            //======== Contratos Contabilidad ========
            #region
            /*
            Contrato contratoTacitoContabilidad = new Contrato()
            {
                Tipo_Contrato = tipoContratoTacito,
                Nombre_Cargo = contabilidad,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)500.00
            };
            Contrato contratoPlazoFijoContabilidad = new Contrato()
            {
                Tipo_Contrato = tipoContratoPlazoFijo,
                Nombre_Cargo = contabilidad,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)1120.00
            };
            Contrato contratoIndefinidoContabilidad = new Contrato()
            {
                Tipo_Contrato = tipoContratoIndefinido,
                Nombre_Cargo = contabilidad,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)1500.00
            };
            Contrato contratoPruebaContabilidad = new Contrato()
            {
                Tipo_Contrato = tipoContratoPrueba,
                Nombre_Cargo = contabilidad,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)550.00
            };
            Contrato contratoEventualContabilidad = new Contrato()
            {
                Tipo_Contrato = tipoContratoEventual,
                Nombre_Cargo = contabilidad,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)920.00
            };
            Contrato contratoTemporadaContabilidad = new Contrato()
            {
                Tipo_Contrato = tipoContratoTemporada,
                Nombre_Cargo = contabilidad,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)720.00
            };*/
            Contrato contratoOcacionalContabilidad = new Contrato()
            {
                Tipo_Contrato = tipoContratoOcacional,
                Nombre_Cargo = contabilidad,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)930.00
            };/*
            Contrato contratoParcialPermanenteContabilidad = new Contrato()
            {
                Tipo_Contrato = tipoContratoParcialPermanente,
                Nombre_Cargo = contabilidad,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)1350.00
            };*/
            #endregion
            //======== Contratos Administracion ========
            #region
            /*
            Contrato contratoTacitoAdministracion = new Contrato()
            {
                Tipo_Contrato = tipoContratoTacito,
                Nombre_Cargo = administracion,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)500.00
            };
            Contrato contratoPlazoFijoadministracion = new Contrato()
            {
                Tipo_Contrato = tipoContratoPlazoFijo,
                Nombre_Cargo = administracion,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)1120.00
            };
            Contrato contratoIndefinidoAdministracion = new Contrato()
            {
                Tipo_Contrato = tipoContratoIndefinido,
                Nombre_Cargo = administracion,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)1500.00
            };
            Contrato contratoPruebaAdministracion = new Contrato()
            {
                Tipo_Contrato = tipoContratoPrueba,
                Nombre_Cargo = administracion,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)550.00
            };
            Contrato contratoEventualAdministracion = new Contrato()
            {
                Tipo_Contrato = tipoContratoEventual,
                Nombre_Cargo = administracion,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)920.00
            };
            Contrato contratoTemporadaAdministracion = new Contrato()
            {
                Tipo_Contrato = tipoContratoTemporada,
                Nombre_Cargo = administracion,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)720.00
            };
            Contrato contratoOcacionalAdministracion = new Contrato()
            {
                Tipo_Contrato = tipoContratoOcacional,
                Nombre_Cargo = administracion,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)930.00
            };
            Contrato contratoParcialPermanenteAdministracion = new Contrato()
            {
                Tipo_Contrato = tipoContratoParcialPermanente,
                Nombre_Cargo = administracion,
                Inicio_Contrato = new DateTime(2020, 5, 15),
                Fin_Contrato = new DateTime(2020, 5, 30),
                Sueldo_Contrato = (decimal)1350.00
            };*/
            #endregion
            List<Contrato> listaContratos = new List<Contrato>()
            {
                //Contrato Tacito
                /*contratoTacitoAdministracion, contratoTacitoAnalista, contratoTacitoComercial, contratoTacitoContabilidad,
                contratoTacitoDisenho, contratoTacitoFormacion, contratoTacitoImplementacion, contratoTacitoMantenimiento,
                contratoTacitoPublicidad, contratoTacitoTesting,*/

                //Contrato plazo Fijo
                /*contratoPlazoFijoadministracion, contratoPlazoFijoAnalista, contratoPlazoFijoComercial, contratoEventualContabilidad,
                contratoEventualDisenho, contratoEventualFormacion, contratoEventualImplementacion, contratoEventualMantenimiento,
                contratoEventualPublicidad, contratoIndefinidoTesting,*/

                //Contrato de Implementacion
                contratoIndefinidoAnalista,/*contratoIndefinidoAdministracion,  contratoIndefinidoComercial, contratoIndefinidoContabilidad,
                contratoIndefinidoDisenho, contratoIndefinidoFormacion, contratoIndefinidoImplementacion, contratoIndefinidoMantenimiento,
                contratoIndefinidoPublicidad, contratoIndefinidoTesting,*/

                //Contrato de Prueba
                /*contratoPruebaAdministracion, contratoPruebaAnalista, contratoPruebaComercial, contratoPruebaContabilidad,
                contratoPruebadisenho, contratoPruebaFormacion, contratoPruebaImplementacion, contratoPruebaMantenimiento,
                contratoPruebaPublicidad, contratoPruebaTesting,*/

                //Contrato Eventual
                /*contratoEventualAdministracion, contratoEventualAnalista, contratoEventualComercial, contratoEventualContabilidad,
                contratoEventualDisenho, contratoEventualFormacion, contratoEventualImplementacion, contratoEventualMantenimiento,
                contratoEventualPublicidad, contratoEventualTesting,*/

                //Contrato Temporada
                /*contratoTemporadaAdministracion, contratoTemporadaAnalista, contratoTemporadaComercial, contratoTemporadaContabilidad,
                contratoTemporadaDisenho, contratoTemporadaFormacion, contratoTemporadaImplementacion, contratoTemporadaMantenimiento,
                contratoTemporadaPublicidad, contratoTemporadaTesting,*/

                //Contrato Ocacional
                contratoOcacionalContabilidad, /*contratoOcacionalAdministracion,  contratoOcacionalComercial, contratoOcacionalAnalista,
                contratoOcacionalDisenho, contratoOcacionalFormacion, contratoOcacionalImplementacion, contratoOcacionalMantenimiento,
                contratoOcacionalPublicidad, contratoOcacionalTesting,*/

                //Contrato Parcial Permanente
                /*contratoParcialPermanenteAdministracion, contratoParcialPermanenteAnalista, contratoParcialPermanenteComercial, contratoParcialPermanenteContabilidad,
                contratoParcialPermanenteDisenho, contratoParcialPermanenteFormacion, contratoParcialPermanenteImplementacion, contratoParcialPermanenteMantenimiento,
                contratoParcialPermanentePublicidad,*/ contratoParcialPermanenteTesting
            };
            #endregion
            /*=======================================
            *       Lista de Tipo de Permisos
            *======================================= */
            #region
            TipoPermisos tipoPermisoMatrimonio = new TipoPermisos()
            {
                Nombre_Tipo_Permiso = "Matrimonio",
                Descripcion_Tipo_Permiso = "Se debe informar con quince días de antelación "
            };
            TipoPermisos tipoPermisoNacimiento = new TipoPermisos()
            {
                Nombre_Tipo_Permiso = "Nacimiento de hijo",
                Descripcion_Tipo_Permiso = "Se tiene 8 semanas"
            };
            TipoPermisos tipoPermisoFallecimiento = new TipoPermisos()
            {
                Nombre_Tipo_Permiso = "Fallecimiento de un familiar",
                Descripcion_Tipo_Permiso = "Se tiene de 2 a 4 días"
            };
            TipoPermisos tipoPermisoEnfermedad = new TipoPermisos()
            {
                Nombre_Tipo_Permiso = "Acidente o enfermedad grave",
                Descripcion_Tipo_Permiso = "Depende de si es por enfermedad común" +
                " o si se provocado por algún asunto dentro de la empresa"
            };
            TipoPermisos tipoPermisoHospitalizacion = new TipoPermisos()
            {
                Nombre_Tipo_Permiso = "Hospitalización o intervención quirúrgica",
                Descripcion_Tipo_Permiso = "Se requiera reposo domiciliario de parientes " +
                "hasta segundo grado de consanguinidad o afinidad"
            };
            TipoPermisos tipoPermisoMudanza = new TipoPermisos()
            {
                Nombre_Tipo_Permiso = "Traslado de domicilio habitual",
                Descripcion_Tipo_Permiso = "Se establece un día libre el permiso por mudanza"
            };
            TipoPermisos tipoPermisoCompromiso = new TipoPermisos()
            {
                Nombre_Tipo_Permiso = "Compromiso inexcusable de carácter público o personal",
                Descripcion_Tipo_Permiso = "En caso de que el empleado reciba algún tipo de indemnización por su labor, " +
                "esta se le desconectará del salario que corresponda."
            };
            TipoPermisos tipoPermisoNacimientoBebePrematuro = new TipoPermisos()
            {
                Nombre_Tipo_Permiso = "Nacimiento prematuro del hijo/a",
                Descripcion_Tipo_Permiso = "En esos supuestos, o debido a cualquier hecho, " +
                "en el que deban permanecer hospitalizados."
            };
            TipoPermisos tipoPermisoAsistenciaExamenes = new TipoPermisos()
            {
                Nombre_Tipo_Permiso = "Asistencia a exámenes",
                Descripcion_Tipo_Permiso = "Se considera parte de los permisos debido a la retribución laboral la ausencia " +
                ".para la presentación de exámenes académicos o profesionales."
            };
            List<TipoPermisos> listaTipoPermisos = new List<TipoPermisos>()
            {
                tipoPermisoMatrimonio, tipoPermisoNacimiento, tipoPermisoFallecimiento, tipoPermisoEnfermedad,
                tipoPermisoHospitalizacion, tipoPermisoMudanza, tipoPermisoCompromiso, tipoPermisoNacimientoBebePrematuro,
                tipoPermisoAsistenciaExamenes
            };
            #endregion
            /*=======================================
            *       Lista de Permisos
            *======================================= */
            #region
            Permisos permisoMatrimonio = new Permisos()
            {
                Nombre_Permiso = "Permiso por matrimonio",
                Tipo_Permisos = tipoPermisoMatrimonio,
                Fecha_Inicio_Permiso = new DateTime(2020, 2, 15),
                Fecha_Fin_Permiso = new DateTime(2020, 3, 1),
                Hora_Inicio = "8:00 am",
                Hora_Fin = "8:00 am",
                Estado_Permiso = "Finalizado"
            };
            Permisos permisoNacimientoHijo = new Permisos()
            {
                Nombre_Permiso = "Permiso por nacimiento de hijo",
                Tipo_Permisos = tipoPermisoNacimiento,
                Fecha_Inicio_Permiso = new DateTime(2021, 10, 15),
                Fecha_Fin_Permiso = new DateTime(2022, 2, 15),
                Hora_Inicio = "11:00 am",
                Hora_Fin = "11:00 am",
                Estado_Permiso = "Vigente"
            };
            Permisos permisoFallecimiento = new Permisos()
            {
                Nombre_Permiso = "Permiso por fallecimiento de hijo y/o familiar",
                Tipo_Permisos = tipoPermisoFallecimiento,
                Fecha_Inicio_Permiso = new DateTime(2022, 1, 15),
                Fecha_Fin_Permiso = new DateTime(2022, 1, 20),
                Hora_Inicio = "14:30 pm",
                Hora_Fin = "14:30 pm",
                Estado_Permiso = "Finalizado"
            };
            Permisos permisoAccidente = new Permisos()
            {
                Nombre_Permiso = "Permiso por accidente o enfermedad grave",
                Tipo_Permisos = tipoPermisoEnfermedad,
                Fecha_Inicio_Permiso = new DateTime(2021, 1, 15),
                Fecha_Fin_Permiso = new DateTime(2022, 4, 15),
                Hora_Inicio = "13:30 pm",
                Hora_Fin = "13:30 pm",
                Estado_Permiso = "Finalizado"
            };
            Permisos permisoHospitalizacion = new Permisos()
            {
                Nombre_Permiso = "Permiso por hospitalización o intervención quirúrgica",
                Tipo_Permisos = tipoPermisoHospitalizacion,
                Fecha_Inicio_Permiso = new DateTime(2022, 1, 15),
                Fecha_Fin_Permiso = new DateTime(2022, 4, 15),
                Hora_Inicio = "13:30 pm",
                Hora_Fin = "13:30 pm",
                Estado_Permiso = "Vigente"
            };
            Permisos permisoMudanza = new Permisos()
            {
                Nombre_Permiso = "Permiso por traslado domiciliario",
                Tipo_Permisos = tipoPermisoMudanza,
                Fecha_Inicio_Permiso = new DateTime(2021, 1, 15),
                Fecha_Fin_Permiso = new DateTime(2021, 1, 16),
                Hora_Inicio = "13:30 pm",
                Hora_Fin = "13:30 pm",
                Estado_Permiso = "Finalizado"
            };
            Permisos permisoCompromiso = new Permisos()
            {
                Nombre_Permiso = "Permiso por Compromiso de carácter público",
                Tipo_Permisos = tipoPermisoCompromiso,
                Fecha_Inicio_Permiso = new DateTime(2021, 1, 15),
                Fecha_Fin_Permiso = new DateTime(2022, 3, 15),
                Hora_Inicio = "13:30 pm",
                Hora_Fin = "13:30 pm",
                Estado_Permiso = "Finalizado"
            };
            Permisos permisoBebePrematuro = new Permisos()
            {
                Nombre_Permiso = "Permiso por nacimiento de bebé prematuro",
                Tipo_Permisos = tipoPermisoNacimientoBebePrematuro,
                Fecha_Inicio_Permiso = new DateTime(2021, 1, 15),
                Fecha_Fin_Permiso = new DateTime(2022, 1, 15),
                Hora_Inicio = "9:00 am",
                Hora_Fin = "18:00 pm",
                Estado_Permiso = "Finalizado"
            };
            Permisos permisoAsistenciaExamanes = new Permisos()
            {
                Nombre_Permiso = "Permiso por asistencia a exámenes",
                Tipo_Permisos = tipoPermisoAsistenciaExamenes,
                Fecha_Inicio_Permiso = new DateTime(2021, 1, 15),
                Fecha_Fin_Permiso = new DateTime(2022, 4, 15),
                Hora_Inicio = "13:30 pm",
                Hora_Fin = "13:30 pm",
                Estado_Permiso = "Finalizado"
            };
            List<Permisos> listaPermisos = new List<Permisos>()
            {
                permisoMatrimonio, permisoNacimientoHijo, permisoFallecimiento,
                permisoAccidente, permisoHospitalizacion, permisoMudanza,
                permisoCompromiso, permisoBebePrematuro, permisoAsistenciaExamanes
            };
            #endregion
            /*=======================================
            *       Lista de Jornada de Trabajo
            *======================================= */
            #region
            JornadaTrabajo ordinaria = new JornadaTrabajo()
            {
                Tipo_Jornada = "Ordinaria"
            };
            JornadaTrabajo nocturna = new JornadaTrabajo()
            {
                Tipo_Jornada = "Nocturna"
            };
            List<JornadaTrabajo> listaJornadoTrabajos = new List<JornadaTrabajo>()
            {
                ordinaria, nocturna
            };
            #endregion
            /*=======================================
            *           Lista de Rubros
            *======================================= */
            #region
            Rubros ingenieriaSistemas = new Rubros()
            {
                Nombre_Rubro = "Ingeniería en Sistemas",
                Tipo_Rubro = "Ingeniegía",
                Mes_Pago_Rubro = 1,
                Dias_Gracia_Rubro = 5,
                Facturar_Rubro = (decimal)2500.00
            };
            Rubros ingenieriaFinanzas = new Rubros()
            {
                Nombre_Rubro = "Ingeniería en Finanzas",
                Tipo_Rubro = "Ingeniegía",
                Mes_Pago_Rubro = 3,
                Dias_Gracia_Rubro = 5,
                Facturar_Rubro = (decimal)2000.00
            };
            Rubros ingenieriaContabilidad = new Rubros()
            {
                Nombre_Rubro = "Ingeniería en Contabilidad",
                Tipo_Rubro = "Ingeniegía",
                Mes_Pago_Rubro = 2,
                Dias_Gracia_Rubro = 5,
                Facturar_Rubro = (decimal)1800.00
            };
            Rubros ingenieriaMarketing = new Rubros()
            {
                Nombre_Rubro = "Ingeniería en Marketing",
                Tipo_Rubro = "Ingeniegía",
                Mes_Pago_Rubro = 3,
                Dias_Gracia_Rubro = 5,
                Facturar_Rubro = (decimal)2000.00
            };
            List<Rubros> listaRubros = new List<Rubros>()
            {
                ingenieriaContabilidad, ingenieriaMarketing,
                ingenieriaFinanzas, ingenieriaSistemas
            };
            #endregion
            /*=======================================
            *           Rol de Pagos
            *======================================= */
            #region
            RolPagos rolRubroIngenieriaSistemas = new RolPagos()
            {
                Nombre_Empresa = "Sonda Ecuador",
                RUC_Empresa = "1782963542001",
                Representante_Empresa = "María Puican",
                Descripcion_RolPagos =  "Pago del mes Enero",
                Fecha_Inicio = new DateTime(2021, 1, 1),
                Fecha_Fin = new DateTime(2021, 1, 5),
                Estado_Rol = "Pagado",
                Nombre_Rubro = ingenieriaSistemas
            };
            RolPagos rolRubroIngenieriaContabilidad = new RolPagos()
            {
                Nombre_Empresa = "Sonda Ecuador",
                RUC_Empresa = "1782963542001",
                Representante_Empresa = "María Puican",
                Descripcion_RolPagos = "Pago del mes Enero",
                Fecha_Inicio = new DateTime(2021, 1, 1),
                Fecha_Fin = new DateTime(2021, 1, 5),
                Estado_Rol = "Pagado",
                Nombre_Rubro = ingenieriaContabilidad
            };
            RolPagos rolRubroIngenieriaFinanzas = new RolPagos()
            {
                Nombre_Empresa = "Sonda Ecuador",
                RUC_Empresa = "1782963542001",
                Representante_Empresa = "María Puican",
                Descripcion_RolPagos = "Pago del mes Enero",
                Fecha_Inicio = new DateTime(2021, 1, 1),
                Fecha_Fin = new DateTime(2021, 1, 5),
                Estado_Rol = "Pagado",
                Nombre_Rubro = ingenieriaFinanzas
            };
            RolPagos rolRubroIngenieriaMarketing = new RolPagos()
            {
                Nombre_Empresa = "Sonda Ecuador",
                RUC_Empresa = "1782963542001",
                Representante_Empresa = "María Puican",
                Descripcion_RolPagos = "Pago del mes Enero",
                Fecha_Inicio = new DateTime(2021, 1, 1),
                Fecha_Fin = new DateTime(2021, 1, 5),
                Estado_Rol = "Pagado",
                Nombre_Rubro = ingenieriaMarketing
            };
            List<RolPagos> listaRolPagos = new List<RolPagos>()
            {
                rolRubroIngenieriaContabilidad, rolRubroIngenieriaFinanzas,
                rolRubroIngenieriaMarketing, rolRubroIngenieriaSistemas
            };
            #endregion
            /*=======================================
            *          Tipo de Discapacidad
            *======================================= */
            #region
            TipoDiscapacidad tipoDiscapacidadAuditiva = new TipoDiscapacidad()
            {
                NombreTipoDiscapacidad = "Auditiva",
                Descripcion_TipoDiscapacidad = "Tipo de discapacidad que se asocia a la falta, disminución o pérdida de escuchar"
            };
            TipoDiscapacidad tipoDiscapacidadFisica = new TipoDiscapacidad()
            {
                NombreTipoDiscapacidad = "Físisca",
                Descripcion_TipoDiscapacidad = "Tipo de discapacidad que que se asocia a cuando falta alguna parte del cuerpo"
            };
            TipoDiscapacidad tipoDiscapacidadIntelectual = new TipoDiscapacidad()
            {
                NombreTipoDiscapacidad = "Intelectual",
                Descripcion_TipoDiscapacidad = "Tipo de discapacidad que se asocia al hecho" +
                " de no tener la capacidad de aprender al mismo nivel que los demas"
            };
            TipoDiscapacidad tipoDiscapacidadLenguaje = new TipoDiscapacidad()
            {
                NombreTipoDiscapacidad = "Lenguaje",
                Descripcion_TipoDiscapacidad = "Tipo de discapacidad que se asocia a la disminución o " +
                "pérdida total de la capacidad de comunicarse verbalmente"
            };
            TipoDiscapacidad tipoDiscapacidadPsicosocial = new TipoDiscapacidad()
            {
                NombreTipoDiscapacidad = "Psicosocial",
                Descripcion_TipoDiscapacidad = "Tipo de discpacidad asocia al transtorno mental"
            };
            TipoDiscapacidad tipoDiscapacidadVisual = new TipoDiscapacidad()
            {
                NombreTipoDiscapacidad = "Visual",
                Descripcion_TipoDiscapacidad = "Tipo de discapacidad de la disminución total o parcial de la vista"
            };
            TipoDiscapacidad tipoDiscapacidadNula = new TipoDiscapacidad()
            {
                NombreTipoDiscapacidad = "Ninguna",
                Descripcion_TipoDiscapacidad = "Sin discapacidad"
            };
            List<TipoDiscapacidad> listaTipoDiscapacidad = new List<TipoDiscapacidad>()
            {
                tipoDiscapacidadAuditiva, tipoDiscapacidadFisica, tipoDiscapacidadIntelectual,
                tipoDiscapacidadLenguaje, tipoDiscapacidadPsicosocial, tipoDiscapacidadVisual, tipoDiscapacidadNula
            };
            #endregion
            /*=======================================
            *               Asistencia
            *======================================= */
            #region
            Asistencia asistenciaOrdinaria = new Asistencia()
            {
                Hora_Asistencia = "9:00 am",
                Fecha_Asistencia = new DateTime(2022, 1, 15),
                Tipo_Asistencia = "Jornada normal de trabajo"
            };
            Asistencia asistenciaNocturna = new Asistencia()
            {
                Hora_Asistencia = "15:00 pm",
                Fecha_Asistencia = new DateTime(2022, 1, 15),
                Tipo_Asistencia = "Jornada normal de trabajo"
            };
            List<Asistencia> listaAsistencia = new List<Asistencia>()
            {
                asistenciaOrdinaria, asistenciaNocturna
            };
            #endregion
            /*=======================================
            *          Lista de Empleados
            *======================================= */
            #region
            Empleado JuanPerez = new Empleado()
            {
                Apellidos_Empleado = "Perez Altamirano",
                Nombres_Empleado = "Juan Fabricio",
                Cedula_Empleado = "0896324715",
                Email_Empleado = "jperez@mail.com",
                Celular_Empleado = "0963258741",
                Profesion_Empleado = "Ingeniero en Sistemas",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = "Casado",
                Estado_Civil = "Soltero",
                Banco = "Pichincha",
                Tipo_Cuenta = "Corriente",
                Numero_Cuenta = "3359628741",
                contrato = contratoParcialPermanenteTesting,
                Nombre_Ciudad = guayaquil,
                Nombre_TipoDiscapacidad = tipoDiscapacidadNula,
                Jornada_Trabajo = ordinaria,
                Nombre_Permiso = permisoMatrimonio,
                Nombre_Rubros = ingenieriaSistemas,
                AsistenciaEmpleados = asistenciaOrdinaria,
            };
            contratoParcialPermanenteTesting.Nombre_Empleado = JuanPerez;

            Empleado PedroGomez = new Empleado()
            {
                Apellidos_Empleado = "Pedro Pablo",
                Nombres_Empleado = "Gomez Heredia",
                Cedula_Empleado = "1785236940",
                Email_Empleado = "pgomez@mail.com",
                Celular_Empleado = "0952368741",
                Profesion_Empleado = "Ingeniero en Finanzas",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = "Masculino",
                Estado_Civil = "Soltero",
                Banco = "Pichincha",
                Tipo_Cuenta = "Corriente",
                Numero_Cuenta = "2258963158",
                contrato = contratoIndefinidoAnalista,
                Nombre_Ciudad = quito,
                Nombre_TipoDiscapacidad = tipoDiscapacidadNula,
                Jornada_Trabajo = ordinaria,
                Nombre_Permiso = permisoMudanza,
                Nombre_Rubros = ingenieriaFinanzas,
                AsistenciaEmpleados = asistenciaOrdinaria
            };
            contratoIndefinidoAnalista.Nombre_Empleado = PedroGomez;

            Empleado KarlaNajarez = new Empleado()
            {
                Apellidos_Empleado = "Karen Yoali",
                Nombres_Empleado = "Najarez Gonzales",
                Cedula_Empleado = "0963258741",
                Email_Empleado = "knajarez@mail.com",
                Celular_Empleado = "09852367410",
                Profesion_Empleado = "Ingeniera en Contabilidad",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = "Femenina",
                Estado_Civil = "Soltera",
                Banco = "Pichincha",
                Tipo_Cuenta = "Corriente",
                Numero_Cuenta = "2247896531",
                contrato = contratoOcacionalContabilidad,
                Nombre_Ciudad = cuenca,
                Nombre_TipoDiscapacidad = tipoDiscapacidadNula,
                Jornada_Trabajo = nocturna,
                Nombre_Permiso = permisoFallecimiento,
                Nombre_Rubros = ingenieriaContabilidad,
                AsistenciaEmpleados = asistenciaNocturna
            };
            contratoOcacionalContabilidad.Nombre_Empleado = KarlaNajarez;

            Empleado IsabellaOlmedo = new Empleado()
            {
                Apellidos_Empleado = "Isabella Patricia",
                Nombres_Empleado = "Olmedo Jimenez",
                Cedula_Empleado = "178523694",
                Email_Empleado = "iolmedo@mail.com",
                Celular_Empleado = "0978523641",
                Profesion_Empleado = "Ingeniera Marketing",
                Nivel_Educacion_Empleado = "Universidad",
                Sexo_Empelado = "Femenino",
                Estado_Civil = "Soltera",
                Banco = "Pichincha",
                Tipo_Cuenta = "Corriente",
                Numero_Cuenta = "2257896314",
                contrato = contratoParcialPermanenteTesting,
                Nombre_Ciudad = moronaSantiago,
                Nombre_TipoDiscapacidad = tipoDiscapacidadNula,
                Jornada_Trabajo = ordinaria,
                Nombre_Permiso = permisoHospitalizacion,
                Nombre_Rubros = ingenieriaMarketing,
                AsistenciaEmpleados = asistenciaOrdinaria
            };
            contratoParcialPermanenteTesting.Nombre_Empleado = IsabellaOlmedo;

            List<Empleado> listaEmpleados = new List<Empleado>()
            {
                JuanPerez, PedroGomez,
                KarlaNajarez, IsabellaOlmedo
            };
            #endregion
            /*=======================================
            *        Discapacidades Empleados
            *======================================= */
            #region
            DiscapacidadEmpleado discapacidadJuan = new DiscapacidadEmpleado()
            {
                empleado = JuanPerez,
                tipoDiscapacidad = tipoDiscapacidadNula
            };
            DiscapacidadEmpleado discapacidadPedro = new DiscapacidadEmpleado()
            {
                empleado = PedroGomez,
                tipoDiscapacidad = tipoDiscapacidadNula
            };
            DiscapacidadEmpleado discapacidadKarla = new DiscapacidadEmpleado()
            {
                empleado = KarlaNajarez,
                tipoDiscapacidad = tipoDiscapacidadNula
            };
            DiscapacidadEmpleado discapacidadIsabella = new DiscapacidadEmpleado()
            {
                empleado = IsabellaOlmedo,
                tipoDiscapacidad = tipoDiscapacidadNula
            };
            #endregion
            /*=======================================
            *           Rubros Empleados
            *======================================= */
            #region
            RubrosEmpleados rubroJuan = new RubrosEmpleados()
            {
                Nombre_Empleado = JuanPerez,
                Nombre_Rubro = ingenieriaSistemas
            };
            RubrosEmpleados rubroPedro = new RubrosEmpleados()
            {
                Nombre_Empleado = PedroGomez,
                Nombre_Rubro = ingenieriaFinanzas
            };
            RubrosEmpleados rubroKarla = new RubrosEmpleados()
            {
                Nombre_Empleado = KarlaNajarez,
                Nombre_Rubro = ingenieriaContabilidad
            };
            RubrosEmpleados rubroIsabella = new RubrosEmpleados()
            {
                Nombre_Empleado = IsabellaOlmedo,
                Nombre_Rubro = ingenieriaMarketing
            };
            #endregion

            /*=======================================================================================
            *                   Diccionario que contiene todas las listas
            *========================================================================================*/
            Dictionary<ListasTipo, object> dictionaryListData = new Dictionary<ListasTipo, object>()
            {
                { ListasTipo.Regiones, listaRegion },
                { ListasTipo.Ciudades, listaCiudades },
                { ListasTipo.Departamentos, listaDepartamentos },
                { ListasTipo.Cargos, listaCargos },
                { ListasTipo.TipoContratos, listaTipoContrato },
                { ListasTipo.Contratos, listaContratos },
                { ListasTipo.TipoPermisos, listaTipoPermisos },
                { ListasTipo.Permisos, listaPermisos },
                { ListasTipo.JornadaTrabajos, listaJornadoTrabajos },
                { ListasTipo.TipoDiscapacidad, listaTipoDiscapacidad },
                { ListasTipo.Rubros, listaRubros },
                { ListasTipo.RolPagos, listaRolPagos },
                { ListasTipo.Asistencias, listaAsistencia },
                { ListasTipo.Empleados, listaEmpleados }
            };

            return dictionaryListData;
        }
    }
}
