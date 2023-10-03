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
    internal class ClienteConsultas
    {
        private ConexionMysql conexionMysql;
        private List<Cliente> mClientes;
        public ClienteConsultas()
        {
            conexionMysql = new ConexionMysql();
            mClientes = new List<Cliente>();
        }
        public List<Cliente> getCliente(string filtro)
        {
            String QUERY = "SELECT * FROM cliente ";
            MySqlCommand mComando = new MySqlCommand(QUERY);
            mComando.Connection = conexionMysql.GetConnection();
            MySqlDataReader mReader;
            try
            {
                if (filtro != "")
                {
                    QUERY += " WHERE " +
                        "idCliente LIKE'%" + filtro + "%' OR" +
                        "NombreCompleto LIKE '%" + filtro + "%'OR" +
                        "Correo LIKE '%" + filtro + "%'OR" +
                        "Telefono LIKE '%" + filtro + "%' OR" +
                        "Nit LIKE'%" + filtro + "%';";

                }
                mReader = mComando.ExecuteReader();
                while (mReader.Read())
                {
                    var mCliente = new Cliente();
                    mCliente.idCliente = mReader.GetInt16("idCliente");
                    mCliente.Nombre = mReader.GetString("NombreCompleto");
                    mCliente.Correo = mReader.GetString("Correo");
                    mCliente.Telefono = mReader.GetString("Telefono");
                    mCliente.Nit = mReader.GetString("Nit");

                    mClientes.Add(mCliente);


                }
                mReader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return mClientes;
        }
        internal bool agregarCliente(Cliente ClienteNuevo)
        {
            string INSERT = "INSERT INTO cliente(nombrecompleto,correo,telefono,nit)VALUES(@nombrecompleto,@correo,@telefono,@nit);";
            MySqlCommand mCommand = new MySqlCommand(INSERT, conexionMysql.GetConnection());
            mCommand.Parameters.Add(new MySqlParameter("@nombrecompleto", ClienteNuevo.Nombre));
            mCommand.Parameters.Add(new MySqlParameter("@correo", ClienteNuevo.Correo));
            mCommand.Parameters.Add(new MySqlParameter("@telefono", ClienteNuevo.Telefono));
            mCommand.Parameters.Add(new MySqlParameter("@nit", ClienteNuevo.Nit));
            return mCommand.ExecuteNonQuery() > 0;

        }
        internal bool eliminarCliente(Cliente ClienteNuevo)
        {
            string DELETE = "DELETE FROM cliente WHERE idcliente=@idcliente;";
            MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMysql.GetConnection());

            mCommand.Parameters.Add(new MySqlParameter("@idcliente", ClienteNuevo.idCliente));
            return mCommand.ExecuteNonQuery() > 0;
        }
        internal bool modificarCliente(Cliente ClienteNuevo)
        {
            string UPDATE = "UPDATE cliente SET " +

                "nombrecompleto=@nombrecompleto, " +
                "correo=@correo, " +
                "telefono=@telefono, " +
                "nit=@nit " +
                "WHERE idcliente=@idcliente;";
            MySqlCommand mCommand = new MySqlCommand(UPDATE, conexionMysql.GetConnection());
            mCommand.Parameters.Add(new MySqlParameter("@nombrecompleto", ClienteNuevo.Nombre));
            mCommand.Parameters.Add(new MySqlParameter("@correo", ClienteNuevo.Correo));
            mCommand.Parameters.Add(new MySqlParameter("@telefono", ClienteNuevo.Telefono));
            mCommand.Parameters.Add(new MySqlParameter("@nit", ClienteNuevo.Nit));
            mCommand.Parameters.Add(new MySqlParameter("@idcliente", ClienteNuevo.idCliente));
            return mCommand.ExecuteNonQuery() > 0;
        }
    }
}
