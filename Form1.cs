using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Ventas.Modelos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ventas
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=malu;Uid=root;Pwd=rouham2002;");
        
        public void Datos()
        {
            String email;
            String password;

            email = txtusuario.Text;
            password = txtpassword.Text; ;


            if (ValidarCredenciales(email, password))

            {
                MessageBox.Show("¡Validacion Correcta");


            }
            else
            {
                MessageBox.Show("¡Validacion Incorrecta, Verifique!");
            }

        }
        private bool ValidarCredenciales(String email, String password)
        {
            return email == "Hamilton" && password == "123";
        }



        private void btnIngresar_Click(object sender, EventArgs e)
        {
         connection.Open();
            string consulta ="SELECT * FROM usuario where correo='"+txtusuario.Text+"'and contraseña='"+txtpassword.Text+"'";
            MySqlCommand comando = new MySqlCommand(consulta,connection);
            MySqlDataReader lector;
            lector = comando.ExecuteReader();
            if (lector.HasRows == true)
            {
                MessageBox.Show("Bienvenido");
                lector.Read();
                int idUsuario = lector.GetInt16("IdUsuario");
                Menucs ventana = new Menucs(idUsuario);
                ventana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
            connection.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtusuario.Clear();
            txtpassword.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        }
    }
