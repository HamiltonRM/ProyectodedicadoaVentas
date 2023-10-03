using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Modelos
{
    internal class Venta
    {
        public int CorrelativoVenta { get; set; }
        public string Cantidad  { get; set; } = string.Empty;
        public string Monto { get; set; } = string.Empty;
        public string Usuario_IdUsuario { get; set; } = string.Empty;
        public string Producto_Codigo { get; set; } = string.Empty;
        public string Cliente_idCliente { get; set; } = string.Empty;   
    }
}
