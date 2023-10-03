using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.Clases;
using Ventas.Modelos;

namespace Ventas
{
    public partial class PantallaUsuarios : Form
    {
        private List<Usuario> mUsuarios;
        private Usuario UsuarioNuevo;

        private UsuarioConsultas mUsuarioConsultas;

        public PantallaUsuarios()
        {
            InitializeComponent();
            mUsuarios = new List<Usuario>();
            mUsuarioConsultas = new UsuarioConsultas();
            UsuarioNuevo = new Usuario();
            cargarUsuarios();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=malu;Uid=root;Pwd=rouham2002;");

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarUsuarios(String filtro = "")
        {
            dgvUsuarios.Rows.Clear();
            dgvUsuarios.Refresh();
            mUsuarios.Clear();
            mUsuarios = mUsuarioConsultas.getUsuario(filtro);
            for (int i = 0; i < mUsuarios.Count; i++)
            {
                dgvUsuarios.RowTemplate.Height = 50;
                dgvUsuarios.Rows.Add(
                    mUsuarios[i].IdUsuario,
                    mUsuarios[i].NombreCompleto,
                    mUsuarios[i].Correo,
                    mUsuarios[i].Contrasenia,
                    mUsuarios[i].Rol);

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }
            cargarDatosUsuarios();

            if (mUsuarioConsultas.agregarUsuario(UsuarioNuevo))
            {
                MessageBox.Show("Producto agregado");
                cargarUsuarios();
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
            if (txtCorreo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Nombre");
                return false;
            }
            if (txtPassword.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Nombre");
                return false;
            }
            return true;

        }
        private void cargarDatosUsuarios()
        {
            UsuarioNuevo.IdUsuario = getFolioIfExist();
            UsuarioNuevo.NombreCompleto = txtNombre.Text.Trim();
            UsuarioNuevo.Correo = txtCorreo.Text.Trim();
            UsuarioNuevo.Contrasenia = txtPassword.Text.Trim();
            UsuarioNuevo.Rol = txtRol.Text.Trim();
        }

        private int getFolioIfExist()
        {
            if (!txtId.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtId.Text.Trim(), out int IdUsuario))
                {
                    return IdUsuario;
                }
                else return -1;
            }
            else return -1;

        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtPassword.Text = "";
            txtRol.Text = "";
        }

        private void dgvUsuarios_CelContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
            txtId.Text = Convert.ToString(fila.Cells["Folio"].Value);
            txtNombre.Text = Convert.ToString(fila.Cells["Nombre"].Value);
            txtCorreo.Text = Convert.ToString(fila.Cells["Usuarios"].Value);
            txtPassword.Text = Convert.ToString(fila.Cells["Password"].Value);
            txtRol.Text = Convert.ToString(fila.Cells["Puesto"].Value);


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }
            cargarDatosUsuarios();

            if (mUsuarioConsultas.modificarUsuario(UsuarioNuevo))
            {
                MessageBox.Show("Producto agregado");
                cargarUsuarios();
                LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (getFolioIfExist() == -1)
            {
                return;
            }

            if (MessageBox.Show("¿Desea Eliminar el Usuario?", "Eliminar usuario",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cargarDatosUsuarios();
                if (mUsuarioConsultas.eliminarUsuario(UsuarioNuevo))
                {
                    MessageBox.Show("UsuarioEliminardo");
                    cargarUsuarios();
                    LimpiarCampos();

                }
            }
        }
        private void BuscarPorId(int idUsuario)
        {
            // Buscar el usuario por su Id
            Usuario usuarioEncontrado = mUsuarios.FirstOrDefault(u => u.IdUsuario == idUsuario);

            // Si se encuentra el usuario, mostrarlo en las cajas de texto
            if (usuarioEncontrado != null)
            {
                txtId.Text = usuarioEncontrado.IdUsuario.ToString();
                txtNombre.Text = usuarioEncontrado.NombreCompleto;
                txtCorreo.Text = usuarioEncontrado.Correo;
                txtPassword.Text = usuarioEncontrado.Contrasenia;
                txtRol.Text = usuarioEncontrado.Rol;
            }
            else
            {
                // Si no se encuentra el usuario, limpiar las cajas de texto y mostrar un mensaje
                LimpiarCampos();
                MessageBox.Show("Usuario no encontrado.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtener el Id de usuario ingresado en txtBuscar
            if (int.TryParse(txtbuscar.Text.Trim(), out int idUsuarioBuscado))
            {
                // Llamar al método BuscarPorId con el Id de usuario
                BuscarPorId(idUsuarioBuscado);
            }
            else
            {
                // Mostrar un mensaje si el valor ingresado no es un número válido
                MessageBox.Show("Ingrese un número válido en el campo de búsqueda.");
            }
            

        }
    }
}
