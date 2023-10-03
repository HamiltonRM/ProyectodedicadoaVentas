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
    public partial class pantallaCompra : Form
    {
        private List<Compra> mCompras;
        private Compra CompraNueva;

        private CompraConsulta mCompraConsultas;

        public pantallaCompra()
        {
            InitializeComponent();
            mCompras = new List<Compra>();
            mCompraConsultas = new CompraConsulta();
            CompraNueva = new Compra();
            cargarCompras();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cargarCompras(String filtro = "")
        {
            dgvCompras.Rows.Clear();
            dgvCompras.Refresh();
            mCompras.Clear();
            mCompras = mCompraConsultas.getCompra(filtro);
            for (int i = 0; i < mCompras.Count; i++)
            {
                dgvCompras.RowTemplate.Height = 50;
                dgvCompras.Rows.Add(
                    mCompras[i].CorrelativoCompra,
                    mCompras[i].Fecha,
                    mCompras[i].Cantidad,
                    mCompras[i].Proveedor,
                    mCompras[i].Usuario,
                    mCompras[i].Producto);

            }
        }

        private bool datosCorrectos()
        {

            if (txtFecha.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese la fecha");
                return false;
            }
            if (txtProducto.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el producto");
                return false;
            }
            if (txtCantidad.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese la cantidad");
                return false;
            }
            if (txtUsuario.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el usuario");
                return false;
            }
            if (txtProveedor.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el proveedor");
                return false;
            }
            return true;

        }
        private void cargarDatosCompras()
        {
            CompraNueva.CorrelativoCompra = getFolioIfExist();
            CompraNueva.Fecha = txtFecha.Text.Trim();
            CompraNueva.Cantidad = txtCantidad.Text.Trim();
            CompraNueva.Proveedor = txtProveedor.Text.Trim();
            CompraNueva.Usuario = txtUsuario.Text.Trim();
            CompraNueva.Producto = txtProducto.Text.Trim();
        }
        private int getFolioIfExist()
        {
            if (!txtCorrelativo.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtCorrelativo.Text.Trim(), out int CorrelativoCompra))
                {
                    return CorrelativoCompra;
                }
                else return -1;
            }
            else return -1;

        }
        private void LimpiarCampos()
        {
            txtCantidad.Text = "";
            txtFecha.Text = "";
            txtProducto.Text = "";
            txtCantidad.Text = "";
            txtUsuario.Text = "";
            txtProveedor.Text = "";


        }




        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (getFolioIfExist() == -1)
            {
                return;
            }

            if (MessageBox.Show("¿Desea Eliminar la Compra?", "Eliminar compra",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cargarDatosCompras();
                if (mCompraConsultas.eliminarCompra(CompraNueva))
                {
                    MessageBox.Show("Compra Eliminardo");
                    cargarCompras();
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
            cargarDatosCompras();

            if (mCompraConsultas.modificarCompra(CompraNueva))
            {
                MessageBox.Show("Compra agregado");
                cargarCompras();
                LimpiarCampos();
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }
            cargarDatosCompras();

            if (mCompraConsultas.agregarCompra(CompraNueva))
            {
                MessageBox.Show("Compra agregado");
                cargarCompras();
                LimpiarCampos();
            }
        }

        private void dgvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvCompras.Rows[e.RowIndex];
            txtCorrelativo.Text = Convert.ToString(fila.Cells["CorrelativoCompra"].Value);
            txtFecha.Text = Convert.ToString(fila.Cells["Fecha"].Value);
            txtProducto.Text = Convert.ToString(fila.Cells["Cantidad"].Value);
            txtCantidad.Text = Convert.ToString(fila.Cells["Proveedor"].Value);
            txtUsuario.Text = Convert.ToString(fila.Cells["Usuario"].Value);
            txtProveedor.Text = Convert.ToString(fila.Cells["Producto"].Value);

        }
        private void BuscarPorCorrelativoCompra(int correlativo)
        {
            
            Compra compraEncontrada = mCompras.FirstOrDefault(c => c.CorrelativoCompra == correlativo);

           
            if (compraEncontrada != null)
            {
                txtCorrelativo.Text = compraEncontrada.CorrelativoCompra.ToString();
                txtFecha.Text = compraEncontrada.Fecha;
                txtCantidad.Text = compraEncontrada.Cantidad;
                txtProveedor.Text = compraEncontrada.Proveedor;
                txtUsuario.Text = compraEncontrada.Usuario;
                txtProducto.Text = compraEncontrada.Producto;
            }
            else
            {
               
                LimpiarCampos();
                MessageBox.Show("Compra no encontrada.");
            }
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtbuscar.Text.Trim(), out int correlativoBuscado))
            {

                BuscarPorCorrelativoCompra(correlativoBuscado);
            }
            else
            {
                MessageBox.Show("Ingrese un correlativo válido en el campo de búsqueda.");
            }
        }
    }
}
