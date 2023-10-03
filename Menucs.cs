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
    public partial class Menucs : Form
    {
        private Usuario? Usuario { get; set; }
        private UsuarioConsultas UsuarioConsultas { get; set; }

        public Menucs(int idUsuario)
        {
            InitializeComponent();
            UsuarioConsultas = new UsuarioConsultas();
            ObtenerUsuarioActual(idUsuario);
            this.StartPosition = FormStartPosition.CenterScreen;
            MostrarOpciones();

        }

        private void MostrarOpciones()
        {
            bool esAdministrador = Usuario?.Rol?.ToUpper() == "ADMINISTRADOR";

            // Menu Usuario
            pictureUsuario.Visible = esAdministrador;
            btnUsuario.Visible = esAdministrador;

            // Menu Proveedor
            pictureProveedor.Visible = esAdministrador;
           btnProveedor.Visible= esAdministrador;
            //Menu Reporte 

            pictureProveedor.Visible = esAdministrador;
            btnProveedor.Visible= esAdministrador;

            //
            pictureReporte.Visible= esAdministrador;
            btnReporte.Visible= esAdministrador;

            //Menu Acerca 
            pictureAcerca.Visible=esAdministrador;
            btnAcerca.Visible= esAdministrador;
        }

        private void ObtenerUsuarioActual(int idUsuario)
        {
            Usuario = UsuarioConsultas.ObtenerUsuarioActual(idUsuario);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PantallaUsuarios ventana = new PantallaUsuarios();
            ventana.Show();


        }

        private void btnMantenedor_Click(object sender, EventArgs e)
        {
            pantallaMantenedor ventana = new pantallaMantenedor();
            ventana.Show();

        }


        private void btnVenta_Click(object sender, EventArgs e)
        {
            pantallaVenta ventana = new pantallaVenta();
            ventana.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            pantallaCliente ventana = new pantallaCliente();
            ventana.Show();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            pantallaCompra ventana = new pantallaCompra();
            ventana.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            pantallaProveedor ventana = new pantallaProveedor();
            ventana.Show();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reporte ventana = new Reporte();
            ventana.Show();
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            Acerca ventana = new Acerca();
            ventana.Show();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
