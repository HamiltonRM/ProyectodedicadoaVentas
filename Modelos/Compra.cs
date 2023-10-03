using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Modelos
{
    internal class Compra
    {
        public int CorrelativoCompra { get; set; }
        public string Fecha { get; set; } = string.Empty;
        public string Cantidad { get; set; } = string.Empty;
        public string Proveedor { get; set; } = string.Empty;
        public string Usuario { get; set; } = string.Empty;
        public string Producto { get; set; } = string.Empty;
    }
}
