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
    public partial class pantallaCliente : Form
    {
        private List<Cliente> mClientes;
        private Cliente ClienteNuevo;

        private ClienteConsultas mClienteConsultas;

        public pantallaCliente()
        {
            InitializeComponent();
            mClientes = new List<Cliente>();
            mClienteConsultas = new ClienteConsultas();
            ClienteNuevo = new Cliente();
            cargarCliente();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cargarCliente(String filtro = "")
        {
            dgvClientes.Rows.Clear();
            dgvClientes.Refresh();
            mClientes.Clear();
            mClientes = mClienteConsultas.getCliente(filtro);
            for (int i = 0; i < mClientes.Count; i++)
            {
                dgvClientes.RowTemplate.Height = 50;
                dgvClientes.Rows.Add(
                    mClientes[i].idCliente,
                    mClientes[i].Nombre,
                    mClientes[i].Correo,
                    mClientes[i].Telefono,
                    mClientes[i].Nit);

            }
        }

        private bool datosCorrectos()
        {

            if (txtNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Nombre");
                return false;
            }
            if (txtCorreo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Correo");
                return false;
            }
            if (txtTelefono.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Telefono");
                return false;
            }
            if (txtNit.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Nit");
            }
            return true;

        }
        private void cargarDatosClientes()
        {
            ClienteNuevo.idCliente = getFolioIfExist();
            ClienteNuevo.Nombre = txtNombre.Text.Trim();
            ClienteNuevo.Correo = txtCorreo.Text.Trim();
            ClienteNuevo.Telefono = txtTelefono.Text.Trim();
            ClienteNuevo.Nit = txtNit.Text.Trim();
        }
        private int getFolioIfExist()
        {
            if (!txtCliente.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtCliente.Text.Trim(), out int idCliente))
                {
                    return idCliente;
                }
                else return -1;
            }
            else return -1;

        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtNit.Text = "";
        }




        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];
            txtCliente.Text = Convert.ToString(fila.Cells["idCliente"].Value);
            txtNombre.Text = Convert.ToString(fila.Cells["NombreCompleto"].Value);
            txtCorreo.Text = Convert.ToString(fila.Cells["Correo"].Value);
            txtTelefono.Text = Convert.ToString(fila.Cells["Telefono"].Value);
            txtNit.Text = Convert.ToString(fila.Cells["Nit"].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }
            cargarDatosClientes();

            if (mClienteConsultas.agregarCliente(ClienteNuevo))
            {
                MessageBox.Show("Cliente agregado");
                cargarCliente();
                LimpiarCampos();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }
            cargarDatosClientes();

            if (mClienteConsultas.modificarCliente(ClienteNuevo))
            {
                MessageBox.Show("Cliente agregado");
                cargarCliente();
                LimpiarCampos();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (getFolioIfExist() == -1)
            {
                return;
            }

            if (MessageBox.Show("¿Desea Eliminar el Cliente?", "Eliminar Cliente",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cargarDatosClientes();
                if (mClienteConsultas.eliminarCliente(ClienteNuevo))
                {
                    MessageBox.Show("Cliente Eliminado");
                    cargarCliente();
                    LimpiarCampos();

                }
            }
        }
        private void BuscarPorIdCliente(int idCliente)
        {
           
            Cliente clienteEncontrado = mClientes.FirstOrDefault(c => c.idCliente == idCliente);

           
            if (clienteEncontrado != null)
            {
                txtCliente.Text = clienteEncontrado.idCliente.ToString();
                txtNombre.Text = clienteEncontrado.Nombre;
                txtCorreo.Text = clienteEncontrado.Correo;
                txtTelefono.Text = clienteEncontrado.Telefono;
                txtNit.Text = clienteEncontrado.Nit;
            }
            else
            {
                
                LimpiarCampos();
                MessageBox.Show("Cliente no encontrado.");
            }
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtbuscar.Text.Trim(), out int idClienteBuscado))
            {
               
                BuscarPorIdCliente(idClienteBuscado);
            }
            else
            {
               
                MessageBox.Show("Ingrese un ID de cliente válido en el campo de búsqueda.");
            }
        }
    }
}