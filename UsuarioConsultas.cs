using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Clases;
using Ventas.Modelos;

namespace Ventas
{
    internal class UsuarioConsultas
    {
        private ConexionMysql conexionMysql;
        private List<Usuario> mUsuarios;
    public UsuarioConsultas()
        {
            conexionMysql=new ConexionMysql();
            mUsuarios = new List<Usuario>();
        }

        public Usuario? ObtenerUsuarioActual(int idUsuario)
        {
            string query = $"SELECT * FROM USUARIO WHERE IdUsuario = {idUsuario}";
            MySqlCommand mComando = new MySqlCommand(query);
            mComando.Connection = conexionMysql.GetConnection();
            MySqlDataReader mReader;
            try
            {
                mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    var mUsuario = new Usuario();
                    mUsuario.IdUsuario = mReader.GetInt16("IdUsuario");
                    mUsuario.NombreCompleto = mReader.GetString("NombreCompleto");
                    mUsuario.Correo = mReader.GetString("Correo");
                    mUsuario.Contrasenia = mReader.GetString("Contraseña");
                    mUsuario.Rol = mReader.GetString("Rol");

                    mUsuarios.Add(mUsuario);

                }
                mReader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return mUsuarios?.First();
        }
        

        public List<Usuario> getUsuario(string filtro)
        {
            String QUERY = "SELECT * FROM usuario ";
            MySqlCommand mComando = new MySqlCommand(QUERY);
            mComando.Connection = conexionMysql.GetConnection();
            MySqlDataReader mReader;
            try
            {
                if (filtro != "")
                {
                    QUERY += " WHERE " + 
                        "IdUsuario LIKE'%" + filtro + "%' OR" + 
                        "NombreCompleto LIKE '%" + filtro + "%'OR" + 
                        "Correo LIKE '%" + filtro + "%'OR" + 
                        "Contraseñia LIKE '%" + filtro + "%' OR" + 
                        "Rol LIKE'%" + filtro + "%';";

                }
                mReader = mComando.ExecuteReader();
                while (mReader.Read())
                {
                   var mUsuario = new Usuario();
                    mUsuario.IdUsuario = mReader.GetInt16("IdUsuario");
                    mUsuario.NombreCompleto = mReader.GetString("NombreCompleto");
                    mUsuario.Correo = mReader.GetString("Correo");
                    mUsuario.Contrasenia = mReader.GetString("Contraseña");
                    mUsuario.Rol = mReader.GetString("Rol");

                    mUsuarios.Add(mUsuario);


                }
                mReader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return mUsuarios;
        }
        internal  bool agregarUsuario(Usuario usuarioNuevo)
        {
            string INSERT = "INSERT INTO usuario(nombrecompleto,correo,contraseña,rol)VALUES(@nombrecompleto,@correo,@contraseña,@rol);";
            MySqlCommand mCommand = new MySqlCommand(INSERT, conexionMysql.GetConnection());
            mCommand.Parameters.Add(new MySqlParameter("@nombrecompleto",usuarioNuevo.NombreCompleto));
            mCommand.Parameters.Add(new MySqlParameter("@correo", usuarioNuevo.Correo));
            mCommand.Parameters.Add(new MySqlParameter("@contraseña", usuarioNuevo.Contrasenia));
            mCommand.Parameters.Add(new MySqlParameter("@rol", usuarioNuevo.Rol));
            return mCommand.ExecuteNonQuery()>0;

        }

        internal bool eliminarUsuario(Usuario usuarioNuevo)
        {
            string DELETE = "DELETE FROM usuario WHERE idusuario=@idusuario;";
            MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMysql.GetConnection());
          
            mCommand.Parameters.Add(new MySqlParameter("@idusuario", usuarioNuevo.IdUsuario));
            return mCommand.ExecuteNonQuery() > 0;
        }

        internal bool modificarUsuario(Usuario usuarioNuevo)
        {
            string UPDATE = "UPDATE usuario SET " +

                "nombrecompleto=@nombrecompleto, " +
                "correo=@correo, " +
                "contraseña=@contraseña, " +
                "rol=@rol "  +  
                "WHERE idusuario=@idusuario;";
            MySqlCommand mCommand = new MySqlCommand(UPDATE, conexionMysql.GetConnection());
            mCommand.Parameters.Add(new MySqlParameter("@nombrecompleto", usuarioNuevo.NombreCompleto));
            mCommand.Parameters.Add(new MySqlParameter("@correo", usuarioNuevo.Correo));
            mCommand.Parameters.Add(new MySqlParameter("@contraseña", usuarioNuevo.Contrasenia));
            mCommand.Parameters.Add(new MySqlParameter("@rol", usuarioNuevo.Rol));
            mCommand.Parameters.Add(new MySqlParameter("@idusuario", usuarioNuevo.IdUsuario));
            return mCommand.ExecuteNonQuery() > 0;
        }
       
    }
}
