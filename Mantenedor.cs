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
    public partial class pantallaMantenedor : Form
    {
        private List<Mantenedor> mMantenedor;
        private Mantenedor MantenedorNuevo;

        private MantenedorConsultas mMantenedorConsultas;
        public pantallaMantenedor()
        {
            InitializeComponent();
            mMantenedor = new List<Mantenedor>();
            mMantenedorConsultas = new MantenedorConsultas();
            MantenedorNuevo = new Mantenedor();
            cargarMantenedores();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void cargarMantenedores(String filtro = "")
        {
            dgvMantenedor.Rows.Clear();
            dgvMantenedor.Refresh();
            mMantenedor.Clear();
            mMantenedor = mMantenedorConsultas.getMantenedor(filtro);
            for (int i = 0; i < mMantenedor.Count; i++)
            {
                dgvMantenedor.RowTemplate.Height = 50;
                dgvMantenedor.Rows.Add(
                    mMantenedor[i].Codigo,
                    mMantenedor[i].Nombre,
                    mMantenedor[i].Descripcion);


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }
            cargarDatosMantenedor();

            if (mMantenedorConsultas.agregarMantenedor(MantenedorNuevo))
            {
                MessageBox.Show("Producto agregado");
                cargarMantenedores();
                LimpiarCampos();
            }
        }
        private bool datosCorrectos()
        {

            if (txtNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Nombre");
                return false;
            }
            if (txtDescripcion.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese la descripcion");
                return false;
            }

            return true;

        }
        private void cargarDatosMantenedor()
        {
            MantenedorNuevo.Codigo = getFolioIfExist();
            MantenedorNuevo.Nombre = txtNombre.Text.Trim();
            MantenedorNuevo.Descripcion = txtDescripcion.Text.Trim();

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
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";

        }



        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }
            cargarDatosMantenedor();

            if (mMantenedorConsultas.modificarMantenedor(MantenedorNuevo))
            {
                MessageBox.Show("Producto agregado");
                cargarMantenedores();
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
                cargarDatosMantenedor();
                if (mMantenedorConsultas.eliminarUsuario(MantenedorNuevo))
                {
                    MessageBox.Show("UsuarioEliminardo");
                    cargarMantenedores();
                    LimpiarCampos();

                }
            }
        }

        private void dgvMantenedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow fila = dgvMantenedor.Rows[e.RowIndex];
            txtCodigo.Text = Convert.ToString(fila.Cells["Codigo"].Value);
            txtNombre.Text = Convert.ToString(fila.Cells["Nombre"].Value);
            txtDescripcion.Text = Convert.ToString(fila.Cells["Descripcion"].Value);



        }

        private void BuscarPorCodigo(int codigo)
        {

            Mantenedor mantenedorEncontrado = mMantenedor.FirstOrDefault(m => m.Codigo == codigo);


            if (mantenedorEncontrado != null)
            {
                txtCodigo.Text = mantenedorEncontrado.Codigo.ToString();
                txtNombre.Text = mantenedorEncontrado.Nombre;
                txtDescripcion.Text = mantenedorEncontrado.Descripcion;
            }
            else
            {

                LimpiarCampos();
                MessageBox.Show("Mantenedor no encontrado.");
            }
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtBuscar.Text.Trim(), out int codigoBuscado))
            {

                BuscarPorCodigo(codigoBuscado);
            }
            else
            {

                MessageBox.Show("Ingrese un código válido en el campo de búsqueda.");
            }
        }
    }
}

