using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.Modelos;

namespace Ventas
{
    public partial class pantallaVenta : Form
    {
        private List<Venta> mVentas;
        private Venta VentaNueva;

        private VentaConsultas mVentaConsultas;

        public pantallaVenta()
        {
            InitializeComponent();
            mVentas = new List<Venta>();
            mVentaConsultas = new VentaConsultas();
            VentaNueva = new Venta();
            cargarVentas();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void cargarVentas(String filtro = "")
        {
            dgvVentas.Rows.Clear();
            dgvVentas.Refresh();
            mVentas.Clear();
            mVentas = mVentaConsultas.getVenta(filtro);
            for (int i = 0; i < mVentas.Count; i++)
            {
                dgvVentas.RowTemplate.Height = 50;
                dgvVentas.Rows.Add(
                    mVentas[i].CorrelativoVenta,
                    mVentas[i].Cantidad,
                    mVentas[i].Monto,
                    mVentas[i].Usuario_IdUsuario,
                    mVentas[i].Producto_Codigo,
                    mVentas[i].Cliente_idCliente);

            }
        }

        private bool datosCorrectos()
        {

            if (txtMonto.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Monto");
                return false;
            }
            if (txtCantidad.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese la Cantidad");
                return false;
            }
            if (txtCliente.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Cliente");
                return false;
            }
            if (txtProducto.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Producto");
            }
            if (txtVendedor.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el vendedor");
            }
            return true;

        }
        private void cargarDatosVentas()
        {
            VentaNueva.CorrelativoVenta = getFolioIfExist();
            VentaNueva.Monto = txtMonto.Text.Trim();
            VentaNueva.Cantidad = txtCantidad.Text.Trim();
            VentaNueva.Producto_Codigo = txtProducto.Text.Trim();
            VentaNueva.Cliente_idCliente = txtCliente.Text.Trim();
            VentaNueva.Usuario_IdUsuario = txtVendedor.Text.Trim();

        }

        private int getFolioIfExist()
        {
            if (!txtCorrelativo.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtCorrelativo.Text.Trim(), out int CorrelativoVenta))
                {
                    return CorrelativoVenta;
                }
                else return -1;
            }
            else return -1;

        }
        private void LimpiarCampos()
        {
            txtCantidad.Text = "";
            txtCliente.Text = "";
            txtCorrelativo.Text = "";
            txtProducto.Text = "";
            txtVendedor.Text = "";
            txtMonto.Text = "";
        }





        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }
            cargarDatosVentas();

            if (mVentaConsultas.agregarVenta(VentaNueva))
            {
                MessageBox.Show("Producto agregado");
                cargarVentas();
                LimpiarCampos();
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (getFolioIfExist() == -1)
            {
                return;
            }

            if (MessageBox.Show("¿Desea Eliminar el Usuario?", "Eliminar usuario",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cargarDatosVentas();
                if (mVentaConsultas.eliminarVenta(VentaNueva))
                {
                    MessageBox.Show("UsuarioEliminardo");
                    cargarVentas();
                    LimpiarCampos();

                }
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }
            cargarDatosVentas();

            if (mVentaConsultas.modificarVenta(VentaNueva))
            {
                MessageBox.Show("Producto agregado");
                cargarVentas();
                LimpiarCampos();
            }
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvVentas.Rows[e.RowIndex];
            txtCorrelativo.Text = Convert.ToString(fila.Cells["CorrelativoVenta"].Value);
            txtMonto.Text = Convert.ToString(fila.Cells["Monto"].Value);
            txtCantidad.Text = Convert.ToString(fila.Cells["Cantidad"].Value);
            txtProducto.Text = Convert.ToString(fila.Cells["Producto_Codigo"].Value);
            txtCliente.Text = Convert.ToString(fila.Cells["Cliente"].Value);
            txtVendedor.Text = Convert.ToString(fila.Cells["Usuario_IdUsuario"].Value);
        }
        private void BuscarPorCorrelativoVenta(int correlativo)
        {
        
            Venta ventaEncontrada = mVentas.FirstOrDefault(v => v.CorrelativoVenta == correlativo);

            
            if (ventaEncontrada != null)
            {
                txtCorrelativo.Text = ventaEncontrada.CorrelativoVenta.ToString();
                txtMonto.Text = ventaEncontrada.Monto;
                txtCantidad.Text = ventaEncontrada.Cantidad;
                txtProducto.Text = ventaEncontrada.Producto_Codigo;
                txtCliente.Text = ventaEncontrada.Cliente_idCliente;
                txtVendedor.Text = ventaEncontrada.Usuario_IdUsuario;
            }
            else
            {
               
                LimpiarCampos();
                MessageBox.Show("Venta no encontrada.");
            }
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
           
            if (int.TryParse(txtbuscar.Text.Trim(), out int correlativoBuscado))
            {
               
                BuscarPorCorrelativoVenta(correlativoBuscado);
            }
            else
            {
               
                MessageBox.Show("Ingrese un correlativo válido en el campo de búsqueda.");
            }
        }
    }
}
