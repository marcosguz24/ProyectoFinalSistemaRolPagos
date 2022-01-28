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
            Grabar grabar = new Grabar();
            grabar.DatosIniciales();
        }
    }
}