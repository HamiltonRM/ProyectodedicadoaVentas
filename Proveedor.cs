using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.Modelos;

namespace Ventas
{
    public partial class pantallaProveedor : Form
    {
        private List<Proveedor> mProveedores;
        private Proveedor ProveedorNuevo;

        private ProveedorConsultas mProveedorConsultas;
        public pantallaProveedor()
        {
            InitializeComponent();
            mProveedores = new List<Proveedor>();
            mProveedorConsultas = new ProveedorConsultas();
            ProveedorNuevo = new Proveedor();
            cargarProveedores();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }
            cargarDatosProveedores();

            if (mProveedorConsultas.modificarProveedor(ProveedorNuevo))
            {
                MessageBox.Show("Proveedor agregado");
                cargarProveedores();
                LimpiarCampos();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cargarProveedores(String filtro = "")
        {
            dgvProveedor.Rows.Clear();
            dgvProveedor.Refresh();
            mProveedores.Clear();
            mProveedores = mProveedorConsultas.getProveedor(filtro);
            for (int i = 0; i < mProveedores.Count; i++)
            {
                dgvProveedor.RowTemplate.Height = 50;
                dgvProveedor.Rows.Add(
                    mProveedores[i].Codigo,
                    mProveedores[i].Nombre,
                    mProveedores[i].Producto,
                    mProveedores[i].Telefono);

            }
        }

        private bool datosCorrectos()
        {

            if (txtNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Nombre");
                return false;
            }
            if (txtProducto.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Producto");
                return false;
            }
            if (txtTelefono.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el telefono");
                return false;
            }
            return true;

        }
        private void cargarDatosProveedores()
        {
            ProveedorNuevo.Codigo = getFolioIfExist();
            ProveedorNuevo.Nombre = txtNombre.Text.Trim();
            ProveedorNuevo.Producto = txtProducto.Text.Trim();
            ProveedorNuevo.Telefono = txtTelefono.Text.Trim();

        }
        private int getFolioIfExist()
        {
            if (!txtCodigo.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtCodigo.Text.Trim(), out int Codigo))
                {
                    return Codigo;
                }
                else return -1;
            }
            else return -1;

        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtProducto.Text = "";
            txtTelefono.Text = "";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }
            cargarDatosProveedores();

            if (mProveedorConsultas.agregarProveedor(ProveedorNuevo))
            {
                MessageBox.Show("Proveedor agregado");
                cargarProveedores();
                LimpiarCampos();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (getFolioIfExist() == -1)
            {
                return;
            }

            if (MessageBox.Show("¿Desea Eliminar el Proveedor?", "Eliminar Proveedor",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cargarDatosProveedores();
                if (mProveedorConsultas.eliminarProveedor(ProveedorNuevo))
                {
                    MessageBox.Show("Proveedor Eliminardo");
                    cargarProveedores();
                    LimpiarCampos();

                }
            }
        }

        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvProveedor.Rows[e.RowIndex];
            txtCodigo.Text = Convert.ToString(fila.Cells["Codigo"].Value);
            txtNombre.Text = Convert.ToString(fila.Cells["Nombre"].Value);
            txtProducto.Text = Convert.ToString(fila.Cells["Producto"].Value);
            txtTelefono.Text = Convert.ToString(fila.Cells["Telefono"].Value);

        }
        private void BuscarPorCodigo(int Codigo)
        {
         
            Proveedor proveedorEncontrado = mProveedores.FirstOrDefault(p => p.Codigo == Codigo);

       
            if (proveedorEncontrado != null)
            {
                txtCodigo.Text = proveedorEncontrado.Codigo.ToString();
                txtNombre.Text = proveedorEncontrado.Nombre;
                txtProducto.Text = proveedorEncontrado.Producto;
                txtTelefono.Text = proveedorEncontrado.Telefono;
            }
            else
            {
               
                LimpiarCampos();
                MessageBox.Show("Proveedor no encontrado.");
            }
        }
       




        private void btnbuscar_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(txtbuscar.Text.Trim(), out int CodigoBuscado))
            {
                BuscarPorCodigo(CodigoBuscado);
            }
            else
            {
               
                MessageBox.Show("Ingrese un código válido en el campo de búsqueda.");
            }
        }
    }
}


