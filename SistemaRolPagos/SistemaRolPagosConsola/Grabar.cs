using CargaDatos;
using ModeloBD;
using SistemaRolPagos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CargaDatos.DatosIniciales;

namespace SistemaRolPagosConsola
{
    public class Grabar
    {
        public void DatosIniciales()
        {
            DatosIniciales datosIniciales = new DatosIniciales();
            var listas = datosIniciales.Carga();

            /*=============================================================================================
             *                              Extraer del diccionario las listas
             *=============================================================================================*/
            var listaAsistencia         =     (List<Asistencia>)          listas[ListasTipo.Asistencias];
            var listaCargo              =     (List<Cargo>)               listas[ListasTipo.Cargos];
            var listaContrato           =     (List<Contrato>)            listas[ListasTipo.Contratos];
            var listaCiudad             =     (List<Ciudad>)              listas[ListasTipo.Ciudades];
            var listaDepartamento       =     (List<Departamento>)        listas[ListasTipo.Departamentos];
            var listaJornadaTrabajo     =     (List<JornadaTrabajo>)      listas[ListasTipo.JornadaTrabajos];
            var listaPermiso            =     (List<Permisos>)            listas[ListasTipo.Permisos];
            var listaRegion             =     (List<Region>)              listas[ListasTipo.Regiones];
            var listaRolPago            =     (List<RolPagos>)            listas[ListasTipo.RolPagos];
            var listaRubro              =     (List<Rubros>)              listas[ListasTipo.Rubros];
            var listaTipoContrato       =     (List<TipoContrato>)        listas[ListasTipo.TipoContratos];
            var listaTipoDiscapacidad   =     (List<TipoDiscapacidad>)    listas[ListasTipo.TipoDiscapacidad];
            var listaTipoPermiso        =     (List<TipoPermisos>)        listas[ListasTipo.TipoPermisos];

            /*============================================================
             *                              Grabar
             *============================================================*/
            Repositorio repositorio = new Repositorio();
            repositorio.asistencias.AddRange(listaAsistencia);
            repositorio.cargos.AddRange(listaCargo);
            repositorio.contratos.AddRange(listaContrato);
            repositorio.ciudades.AddRange(listaCiudad);
            repositorio.departamentos.AddRange(listaDepartamento);
            repositorio.jornadasTrabajos.AddRange(listaJornadaTrabajo);
            repositorio.permisos.AddRange(listaPermiso);
            repositorio.regiones.AddRange(listaRegion);
            repositorio.rolPagos.AddRange(listaRolPago);
            repositorio.rubros.AddRange(listaRubro);
            repositorio.tiposContratos.AddRange(listaTipoContrato);
            repositorio.tiposDiscapacidades.AddRange(listaTipoDiscapacidad);
            repositorio.tiposPermisos.AddRange(listaTipoPermiso);

            repositorio.SaveChanges();
        }
    }
}
