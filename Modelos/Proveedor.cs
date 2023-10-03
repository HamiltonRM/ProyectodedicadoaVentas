using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Modelos
{
    internal class Proveedor
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Producto { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
       
    }
}
