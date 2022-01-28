using Microsoft.AspNetCore.Mvc;
using ModeloBD;
using SistemaRolPagos.Entidades;

namespace WebSGRP.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly Repositorio db;

        public EmpleadosController(Repositorio db)
        {
            this.db = db;
        }

        /*=======================================================
         *Recuperar la lista de empleados y enviar hacia la vista
         *=======================================================*/
        public IActionResult Index()
        {
            IEnumerable<Empleado> listaEmpleados = db.empleados;
            return View(listaEmpleados);
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
    }
}
