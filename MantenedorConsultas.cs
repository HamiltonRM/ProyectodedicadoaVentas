using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Clases;
using Ventas.Modelos;

namespace Ventas
{
    internal class MantenedorConsultas
    {
        private ConexionMysql conexionMysql;
        private List<Mantenedor> mMantenedores;
        public MantenedorConsultas()
        {
            conexionMysql = new ConexionMysql();
            mMantenedores = new List<Mantenedor>();
        }
        internal bool agregarMantenedor(Mantenedor MantenedorNuevo)
        {
            string INSERT = "INSERT INTO producto(nombre,descripcion)VALUES(@nombre,@descripcion);";
            MySqlCommand mCommand = new MySqlCommand(INSERT, conexionMysql.GetConnection());
            mCommand.Parameters.Add(new MySqlParameter("@nombre", MantenedorNuevo.Nombre));
            mCommand.Parameters.Add(new MySqlParameter("@descripcion", MantenedorNuevo.Descripcion));

            return mCommand.ExecuteNonQuery() > 0;
        }

        internal bool eliminarUsuario(Mantenedor MantenedorNuevo)
        {
            string DELETE = "DELETE FROM producto WHERE codigo=@codigo;";
            MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMysql.GetConnection());

            mCommand.Parameters.Add(new MySqlParameter("@codigo", MantenedorNuevo.Codigo));
            return mCommand.ExecuteNonQuery() > 0;
        }

        internal List<Mantenedor> getMantenedor(string filtro)
        {
            String QUERY = "SELECT * FROM producto ";
            MySqlCommand mComando = new MySqlCommand(QUERY);
            mComando.Connection = conexionMysql.GetConnection();
            MySqlDataReader mReader;
            try
            {
                if (filtro != "")
                {
                    QUERY += " WHERE " +
                        "Codigo LIKE'%" + filtro + "%' OR" +
                        "Nombre LIKE '%" + filtro + "%'OR" +
                        "Descripcion LIKE'%" + filtro + "%';";

                }
                mReader = mComando.ExecuteReader();
                while (mReader.Read())
                {
                    var mMantenedor = new Mantenedor();
                    mMantenedor.Codigo = mReader.GetInt16("Codigo");
                    mMantenedor.Nombre = mReader.GetString("Nombre");
                    mMantenedor.Descripcion = mReader.GetString("Descripcion");


                    mMantenedores.Add(mMantenedor);


                }
                mReader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return mMantenedores;
        }

        internal bool modificarMantenedor(Mantenedor MantenedorNuevo)
        {

            string UPDATE = "UPDATE producto SET " +

                "nombre=@nombre, " +
                "descripcion=@descripcion " +
                "WHERE Codigo=@Codigo;";
            MySqlCommand mCommand = new MySqlCommand(UPDATE, conexionMysql.GetConnection());
            mCommand.Parameters.Add(new MySqlParameter("@nombre", MantenedorNuevo.Nombre));
            mCommand.Parameters.Add(new MySqlParameter("@descripcion", MantenedorNuevo.Descripcion));

            mCommand.Parameters.Add(new MySqlParameter("Codigo", MantenedorNuevo.Codigo));
            return mCommand.ExecuteNonQuery() > 0;
        }
    }
  
   
   
  
  

}
