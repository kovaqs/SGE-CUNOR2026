using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PermisoLaboralListado
    {
        public uint IdPermiso { get; set; }
        public string Empleado { get; set; } = ""; public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public string Motivo { get; set; } = ""; public bool ConGoce { get; set; }
        public string Estado { get; set; } = "";
    }
}
