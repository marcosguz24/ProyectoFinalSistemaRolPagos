using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRolPagos.Entidades
{
    public class Empresa
    {
        public int EmpresaId { get; set; }
        public string Nombre_Empresa { get; set; }
        public string RUC_Empresa { get; set; }
        public string Representante_Empresa { get; set; }
    }
}
